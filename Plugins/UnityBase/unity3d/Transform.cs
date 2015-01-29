﻿using System;
using System.Collections.Generic;
using System.IO;
using SlimDX;

using SB3Utility;

namespace UnityPlugin
{
	public class Transform : ObjChildren<Transform>, IObjChild, Component, LinkedByGameObject, StoresReferences
	{
		public AssetCabinet file { get; set; }
		public int pathID { get; set; }
		public UnityClassID classID1 { get; set; }
		public UnityClassID classID2 { get; set; }

		public dynamic Parent { get; set; }

		public PPtr<GameObject> m_GameObject { get; set; }
		public Quaternion m_LocalRotation { get; set; }
		public Vector3 m_LocalPosition { get; set; }
		public Vector3 m_LocalScale { get; set; }
		//public List<PPtr<Transform>> m_Children { get; protected set; }
		//public PPtr<Transform> m_Father { get; protected set; }

		public Transform(AssetCabinet file, int pathID, UnityClassID classID1, UnityClassID classID2)
		{
			this.file = file;
			this.pathID = pathID;
			this.classID1 = classID1;
			this.classID2 = classID2;
		}

		public Transform(AssetCabinet file) :
			this(file, 0, UnityClassID.Transform, UnityClassID.Transform)
		{
			file.ReplaceSubfile(-1, this, null);
		}

		public void LoadFrom(Stream stream)
		{
			BinaryReader reader = new BinaryReader(stream);
			m_GameObject = new PPtr<GameObject>(stream, file);
			m_LocalRotation = reader.ReadQuaternion();
			m_LocalPosition = reader.ReadVector3();
			m_LocalScale = reader.ReadVector3();

			int numChildren = reader.ReadInt32();
			//m_Children = new List<PPtr<Transform>>(numChildren);
			InitChildren(numChildren);
			for (int i = 0; i < numChildren; i++)
			{
				PPtr<Transform> transPtr = new PPtr<Transform>(stream, file);
				//m_Children.Add(transPtr);
				if (transPtr.instance != null)
				{
					AddChild(transPtr.instance);
				}
			}

			//m_Father = 
				new PPtr<Transform>(stream, file);
		}

		public void WriteTo(Stream stream)
		{
			BinaryWriter writer = new BinaryWriter(stream);
			file.WritePPtr(m_GameObject.asset, false, stream);
			writer.Write(m_LocalRotation);
			writer.Write(m_LocalPosition);
			writer.Write(m_LocalScale);

			writer.Write(/*m_Children.*/Count);
			for (int i = 0; i < /*m_Children.*/Count; i++)
			{
				file.WritePPtr(/*m_Children*/this[i]/*.asset*/, false, stream);
			}

			file.WritePPtr(/*m_Father.asset*/Parent, false, stream);
		}

		public static Matrix WorldTransform(Transform frame)
		{
			Matrix world = Matrix.Identity;
			while (frame != null)
			{
				world = world * Matrix.Scaling(frame.m_LocalScale) * Matrix.RotationQuaternion(frame.m_LocalRotation) * Matrix.Translation(frame.m_LocalPosition);
				frame = frame.Parent;
			}
			return world;
		}
	}
}