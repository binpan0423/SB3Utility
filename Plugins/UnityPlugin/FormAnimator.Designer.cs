﻿namespace UnityPlugin
{
	partial class FormAnimator
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			CustomDispose();

			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.toolTip1 = new System.Windows.Forms.ToolTip();
			this.buttonObjectTreeRefresh = new System.Windows.Forms.Button();
			this.buttonObjectTreeExpand = new System.Windows.Forms.Button();
			this.label19 = new System.Windows.Forms.Label();
			this.comboBoxMeshRendererMesh = new System.Windows.Forms.ComboBox();
			this.buttonMeshNormals = new System.Windows.Forms.Button();
			this.label8 = new System.Windows.Forms.Label();
			this.checkBoxMorphFbxOptionEmbedMedia = new System.Windows.Forms.CheckBox();
			this.checkBoxMorphFbxOptionOneBlendshape = new System.Windows.Forms.CheckBox();
			this.buttonMorphExport = new System.Windows.Forms.Button();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControlLists = new System.Windows.Forms.TabControl();
			this.tabPageObject = new System.Windows.Forms.TabPage();
			this.treeViewObjectTree = new System.Windows.Forms.TreeView();
			this.panelObjectTreeBottom = new System.Windows.Forms.Panel();
			this.buttonObjectTreeCollapse = new System.Windows.Forms.Button();
			this.tabPageMesh = new System.Windows.Forms.TabPage();
			this.splitContainerMesh = new System.Windows.Forms.SplitContainer();
			this.listViewMesh = new System.Windows.Forms.ListView();
			this.meshlistHeaderNames = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.meshListHeaderType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainerMeshCrossRef = new System.Windows.Forms.SplitContainer();
			this.listViewMeshMaterial = new System.Windows.Forms.ListView();
			this.listViewMeshMaterialHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label68 = new System.Windows.Forms.Label();
			this.listViewMeshTexture = new System.Windows.Forms.ListView();
			this.listViewMeshTextureHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label70 = new System.Windows.Forms.Label();
			this.tabPageMorph = new System.Windows.Forms.TabPage();
			this.label44 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.treeViewMorphKeyframes = new System.Windows.Forms.TreeView();
			this.label57 = new System.Windows.Forms.Label();
			this.tabPageMaterial = new System.Windows.Forms.TabPage();
			this.splitContainerMaterial = new System.Windows.Forms.SplitContainer();
			this.listViewMaterial = new System.Windows.Forms.ListView();
			this.materiallistHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainerMaterialCrossRef = new System.Windows.Forms.SplitContainer();
			this.listViewMaterialMesh = new System.Windows.Forms.ListView();
			this.listViewMaterialMeshHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label71 = new System.Windows.Forms.Label();
			this.listViewMaterialTexture = new System.Windows.Forms.ListView();
			this.listViewMaterialTextureHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label72 = new System.Windows.Forms.Label();
			this.tabPageTexture = new System.Windows.Forms.TabPage();
			this.splitContainerTexture = new System.Windows.Forms.SplitContainer();
			this.listViewTexture = new System.Windows.Forms.ListView();
			this.texturelistHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.splitContainerTextureCrossRef = new System.Windows.Forms.SplitContainer();
			this.listViewTextureMesh = new System.Windows.Forms.ListView();
			this.listViewTextureMeshHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label73 = new System.Windows.Forms.Label();
			this.listViewTextureMaterial = new System.Windows.Forms.ListView();
			this.listViewTextureMaterialHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label74 = new System.Windows.Forms.Label();
			this.tabControlViews = new System.Windows.Forms.TabControl();
			this.tabPageFrameView = new System.Windows.Forms.TabPage();
			this.label38 = new System.Windows.Forms.Label();
			this.buttonFrameUnique = new System.Windows.Forms.Button();
			this.buttonFrameAddBone = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.buttonFrameMatrixApply = new System.Windows.Forms.Button();
			this.checkBoxFrameMatrixUpdate = new System.Windows.Forms.CheckBox();
			this.numericFrameMatrixRatio = new System.Windows.Forms.NumericUpDown();
			this.label5 = new System.Windows.Forms.Label();
			this.numericFrameMatrixNumber = new System.Windows.Forms.NumericUpDown();
			this.label6 = new System.Windows.Forms.Label();
			this.buttonFrameMatrixPaste = new System.Windows.Forms.Button();
			this.buttonFrameMatrixCopy = new System.Windows.Forms.Button();
			this.buttonFrameMatrixGrow = new System.Windows.Forms.Button();
			this.buttonFrameMatrixShrink = new System.Windows.Forms.Button();
			this.buttonFrameMatrixIdentity = new System.Windows.Forms.Button();
			this.buttonFrameMatrixInverse = new System.Windows.Forms.Button();
			this.buttonFrameMatrixCombined = new System.Windows.Forms.Button();
			this.tabControlFrameMatrix = new System.Windows.Forms.TabControl();
			this.tabPageFrameSRT = new System.Windows.Forms.TabPage();
			this.tabPageFrameMatrix = new System.Windows.Forms.TabPage();
			this.buttonFrameMoveUp = new System.Windows.Forms.Button();
			this.buttonFrameRemove = new System.Windows.Forms.Button();
			this.buttonFrameMoveDown = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tabPageBoneView = new System.Windows.Forms.TabPage();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.numericBoneMatrixRatio = new System.Windows.Forms.NumericUpDown();
			this.label9 = new System.Windows.Forms.Label();
			this.numericBoneMatrixNumber = new System.Windows.Forms.NumericUpDown();
			this.label12 = new System.Windows.Forms.Label();
			this.buttonBoneMatrixPaste = new System.Windows.Forms.Button();
			this.buttonBoneMatrixCopy = new System.Windows.Forms.Button();
			this.buttonBoneMatrixGrow = new System.Windows.Forms.Button();
			this.buttonBoneMatrixShrink = new System.Windows.Forms.Button();
			this.buttonBoneMatrixIdentity = new System.Windows.Forms.Button();
			this.buttonBoneMatrixInverse = new System.Windows.Forms.Button();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.buttonBoneMatrixApply = new System.Windows.Forms.Button();
			this.checkBoxBoneMatrixUpdate = new System.Windows.Forms.CheckBox();
			this.tabControlBoneMatrix = new System.Windows.Forms.TabControl();
			this.tabPageBoneSRT = new System.Windows.Forms.TabPage();
			this.tabPageBoneMatrix = new System.Windows.Forms.TabPage();
			this.buttonBoneRemove = new System.Windows.Forms.Button();
			this.buttonBoneGotoFrame = new System.Windows.Forms.Button();
			this.label25 = new System.Windows.Forms.Label();
			this.tabPageMeshView = new System.Windows.Forms.TabPage();
			this.comboBoxRendererRootBone = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.checkBoxRendererEnabled = new System.Windows.Forms.CheckBox();
			this.label27 = new System.Windows.Forms.Label();
			this.checkBoxMeshNewSkin = new System.Windows.Forms.CheckBox();
			this.buttonSkinnedMeshRendererAttributes = new System.Windows.Forms.Button();
			this.buttonMeshMinBones = new System.Windows.Forms.Button();
			this.buttonMeshGotoFrame = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label28 = new System.Windows.Forms.Label();
			this.comboBoxMeshExportFormat = new System.Windows.Forms.ComboBox();
			this.buttonMeshExport = new System.Windows.Forms.Button();
			this.panelMeshExportOptionsDefault = new System.Windows.Forms.Panel();
			this.panelMeshExportOptionsDirectX = new System.Windows.Forms.Panel();
			this.numericMeshExportDirectXTicksPerSecond = new System.Windows.Forms.NumericUpDown();
			this.numericMeshExportDirectXKeyframeLength = new System.Windows.Forms.NumericUpDown();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.panelMeshExportOptionsCollada = new System.Windows.Forms.Panel();
			this.checkBoxMeshExportColladaAllFrames = new System.Windows.Forms.CheckBox();
			this.panelMeshExportOptionsMqo = new System.Windows.Forms.Panel();
			this.checkBoxMeshExportMqoSortMeshes = new System.Windows.Forms.CheckBox();
			this.checkBoxMeshExportMqoSingleFile = new System.Windows.Forms.CheckBox();
			this.checkBoxMeshExportMqoWorldCoords = new System.Windows.Forms.CheckBox();
			this.panelMeshExportOptionsFbx = new System.Windows.Forms.Panel();
			this.checkBoxMeshExportFbxLinearInterpolation = new System.Windows.Forms.CheckBox();
			this.checkBoxMeshExportNoMesh = new System.Windows.Forms.CheckBox();
			this.checkBoxMeshExportAllBones = new System.Windows.Forms.CheckBox();
			this.checkBoxMeshExportFbxSkins = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.checkBoxMeshExportFbxAllFrames = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonMeshRemove = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label24 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.buttonMeshRestPose = new System.Windows.Forms.Button();
			this.label15 = new System.Windows.Forms.Label();
			this.buttonMeshSnapBorders = new System.Windows.Forms.Button();
			this.dataGridViewMesh = new System.Windows.Forms.DataGridView();
			this.ColumnSubmeshVerts = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSubmeshFaces = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnSubmeshMaterial = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Topology = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.buttonMeshSubmeshRemove = new System.Windows.Forms.Button();
			this.checkBoxMeshMultiPass = new System.Windows.Forms.CheckBox();
			this.tabPageMorphView = new System.Windows.Forms.TabPage();
			this.label45 = new System.Windows.Forms.Label();
			this.label42 = new System.Windows.Forms.Label();
			this.checkBoxMorphTangents = new System.Windows.Forms.CheckBox();
			this.checkBoxMorphNormals = new System.Windows.Forms.CheckBox();
			this.label40 = new System.Windows.Forms.Label();
			this.buttonMorphDeleteRef = new System.Windows.Forms.Button();
			this.buttonMorphRefDown = new System.Windows.Forms.Button();
			this.buttonMorphRefUp = new System.Windows.Forms.Button();
			this.label39 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.groupBox8 = new System.Windows.Forms.GroupBox();
			this.label46 = new System.Windows.Forms.Label();
			this.comboBoxMorphExportFormat = new System.Windows.Forms.ComboBox();
			this.label43 = new System.Windows.Forms.Label();
			this.label41 = new System.Windows.Forms.Label();
			this.groupBox11 = new System.Windows.Forms.GroupBox();
			this.checkBoxMorphEndKeyframe = new System.Windows.Forms.CheckBox();
			this.checkBoxMorphStartKeyframe = new System.Windows.Forms.CheckBox();
			this.trackBarMorphFactor = new System.Windows.Forms.TrackBar();
			this.tabPageMaterialView = new System.Windows.Forms.TabPage();
			this.labelMatTex4 = new System.Windows.Forms.Label();
			this.labelMatTex3 = new System.Windows.Forms.Label();
			this.labelMatTex2 = new System.Windows.Forms.Label();
			this.labelMatTex1 = new System.Windows.Forms.Label();
			this.labelExtra = new System.Windows.Forms.Label();
			this.labelOutline = new System.Windows.Forms.Label();
			this.labelRimPower = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.comboBoxMatShaderKeywords = new System.Windows.Forms.ComboBox();
			this.label29 = new System.Windows.Forms.Label();
			this.comboBoxMatTex4 = new System.Windows.Forms.ComboBox();
			this.comboBoxMatTex3 = new System.Windows.Forms.ComboBox();
			this.comboBoxMatTex2 = new System.Windows.Forms.ComboBox();
			this.comboBoxMatTex1 = new System.Windows.Forms.ComboBox();
			this.buttonMaterialRemove = new System.Windows.Forms.Button();
			this.buttonMaterialCopy = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.labelShininess = new System.Windows.Forms.Label();
			this.labelShadow = new System.Windows.Forms.Label();
			this.labelOutlineColour = new System.Windows.Forms.Label();
			this.labelRim = new System.Windows.Forms.Label();
			this.labelEmissive = new System.Windows.Forms.Label();
			this.labelSpecular = new System.Windows.Forms.Label();
			this.labelAmbient = new System.Windows.Forms.Label();
			this.labelDiffuse = new System.Windows.Forms.Label();
			this.tabPageTextureView = new System.Windows.Forms.TabPage();
			this.label37 = new System.Windows.Forms.Label();
			this.label36 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.label32 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.checkBoxTextureMipMap = new System.Windows.Forms.CheckBox();
			this.labelTextureFormat = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.buttonTextureAdd = new System.Windows.Forms.Button();
			this.panelTexturePic = new System.Windows.Forms.Panel();
			this.pictureBoxTexture = new System.Windows.Forms.PictureBox();
			this.label3 = new System.Windows.Forms.Label();
			this.buttonTextureExport = new System.Windows.Forms.Button();
			this.buttonTextureReplace = new System.Windows.Forms.Button();
			this.buttonTextureRemove = new System.Windows.Forms.Button();
			this.dataGridViewFrameSRT = new SB3Utility.DataGridViewEditor();
			this.dataGridViewFrameMatrix = new SB3Utility.DataGridViewEditor();
			this.textBoxFrameName = new SB3Utility.EditTextBox();
			this.dataGridViewBoneSRT = new SB3Utility.DataGridViewEditor();
			this.dataGridViewBoneMatrix = new SB3Utility.DataGridViewEditor();
			this.textBoxBoneName = new SB3Utility.EditTextBox();
			this.textBoxKeyframeRange = new SB3Utility.EditTextBox();
			this.editTextBoxMeshRootBone = new SB3Utility.EditTextBox();
			this.editTextBoxMeshName = new SB3Utility.EditTextBox();
			this.textBoxRendererName = new SB3Utility.EditTextBox();
			this.editTextBoxMorphKeyframeHash = new SB3Utility.EditTextBox();
			this.editTextBoxMorphWeightRange = new SB3Utility.EditTextBox();
			this.editTextBoxMorphFrameCount = new SB3Utility.EditTextBox();
			this.textBoxMorphFrameIndex = new SB3Utility.EditTextBox();
			this.editTextBoxMorphKeyframe = new SB3Utility.EditTextBox();
			this.editTextBoxMatShader = new SB3Utility.EditTextBox();
			this.textBoxMatExtra = new SB3Utility.EditTextBox();
			this.textBoxMatShadowA = new SB3Utility.EditTextBox();
			this.textBoxMatShadowB = new SB3Utility.EditTextBox();
			this.textBoxMatShadowG = new SB3Utility.EditTextBox();
			this.textBoxMatShadowR = new SB3Utility.EditTextBox();
			this.textBoxMatOutlineA = new SB3Utility.EditTextBox();
			this.textBoxMatOutlineB = new SB3Utility.EditTextBox();
			this.textBoxMatOutlineG = new SB3Utility.EditTextBox();
			this.textBoxMatOutlineR = new SB3Utility.EditTextBox();
			this.textBoxMatRimA = new SB3Utility.EditTextBox();
			this.textBoxMatRimB = new SB3Utility.EditTextBox();
			this.textBoxMatRimG = new SB3Utility.EditTextBox();
			this.textBoxMatRimR = new SB3Utility.EditTextBox();
			this.textBoxMatOutline = new SB3Utility.EditTextBox();
			this.textBoxMatRimPower = new SB3Utility.EditTextBox();
			this.textBoxMatSpecularPower = new SB3Utility.EditTextBox();
			this.textBoxMatEmissiveA = new SB3Utility.EditTextBox();
			this.textBoxMatEmissiveB = new SB3Utility.EditTextBox();
			this.textBoxMatEmissiveG = new SB3Utility.EditTextBox();
			this.textBoxMatEmissiveR = new SB3Utility.EditTextBox();
			this.textBoxMatSpecularA = new SB3Utility.EditTextBox();
			this.textBoxMatSpecularB = new SB3Utility.EditTextBox();
			this.textBoxMatSpecularG = new SB3Utility.EditTextBox();
			this.textBoxMatSpecularR = new SB3Utility.EditTextBox();
			this.textBoxMatAmbientA = new SB3Utility.EditTextBox();
			this.textBoxMatAmbientB = new SB3Utility.EditTextBox();
			this.textBoxMatAmbientG = new SB3Utility.EditTextBox();
			this.textBoxMatAmbientR = new SB3Utility.EditTextBox();
			this.textBoxMatDiffuseA = new SB3Utility.EditTextBox();
			this.textBoxMatDiffuseB = new SB3Utility.EditTextBox();
			this.textBoxMatDiffuseG = new SB3Utility.EditTextBox();
			this.textBoxMatDiffuseR = new SB3Utility.EditTextBox();
			this.textBoxMatName = new SB3Utility.EditTextBox();
			this.editTextBoxTexDimension = new SB3Utility.EditTextBox();
			this.editTextBoxTexLightMap = new SB3Utility.EditTextBox();
			this.editTextBoxTexColorSpace = new SB3Utility.EditTextBox();
			this.editTextBoxTexWrapMode = new SB3Utility.EditTextBox();
			this.editTextBoxTexAniso = new SB3Utility.EditTextBox();
			this.editTextBoxTexMipBias = new SB3Utility.EditTextBox();
			this.editTextBoxTexFilterMode = new SB3Utility.EditTextBox();
			this.editTextBoxTexImageCount = new SB3Utility.EditTextBox();
			this.textBoxTexSize = new SB3Utility.EditTextBox();
			this.textBoxTexName = new SB3Utility.EditTextBox();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControlLists.SuspendLayout();
			this.tabPageObject.SuspendLayout();
			this.panelObjectTreeBottom.SuspendLayout();
			this.tabPageMesh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMesh)).BeginInit();
			this.splitContainerMesh.Panel1.SuspendLayout();
			this.splitContainerMesh.Panel2.SuspendLayout();
			this.splitContainerMesh.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMeshCrossRef)).BeginInit();
			this.splitContainerMeshCrossRef.Panel1.SuspendLayout();
			this.splitContainerMeshCrossRef.Panel2.SuspendLayout();
			this.splitContainerMeshCrossRef.SuspendLayout();
			this.tabPageMorph.SuspendLayout();
			this.panel1.SuspendLayout();
			this.tabPageMaterial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterial)).BeginInit();
			this.splitContainerMaterial.Panel1.SuspendLayout();
			this.splitContainerMaterial.Panel2.SuspendLayout();
			this.splitContainerMaterial.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterialCrossRef)).BeginInit();
			this.splitContainerMaterialCrossRef.Panel1.SuspendLayout();
			this.splitContainerMaterialCrossRef.Panel2.SuspendLayout();
			this.splitContainerMaterialCrossRef.SuspendLayout();
			this.tabPageTexture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerTexture)).BeginInit();
			this.splitContainerTexture.Panel1.SuspendLayout();
			this.splitContainerTexture.Panel2.SuspendLayout();
			this.splitContainerTexture.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerTextureCrossRef)).BeginInit();
			this.splitContainerTextureCrossRef.Panel1.SuspendLayout();
			this.splitContainerTextureCrossRef.Panel2.SuspendLayout();
			this.splitContainerTextureCrossRef.SuspendLayout();
			this.tabControlViews.SuspendLayout();
			this.tabPageFrameView.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericFrameMatrixRatio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericFrameMatrixNumber)).BeginInit();
			this.tabControlFrameMatrix.SuspendLayout();
			this.tabPageFrameSRT.SuspendLayout();
			this.tabPageFrameMatrix.SuspendLayout();
			this.tabPageBoneView.SuspendLayout();
			this.groupBox4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBoneMatrixRatio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBoneMatrixNumber)).BeginInit();
			this.groupBox6.SuspendLayout();
			this.tabControlBoneMatrix.SuspendLayout();
			this.tabPageBoneSRT.SuspendLayout();
			this.tabPageBoneMatrix.SuspendLayout();
			this.tabPageMeshView.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.panelMeshExportOptionsDirectX.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMeshExportDirectXTicksPerSecond)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMeshExportDirectXKeyframeLength)).BeginInit();
			this.panelMeshExportOptionsCollada.SuspendLayout();
			this.panelMeshExportOptionsMqo.SuspendLayout();
			this.panelMeshExportOptionsFbx.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesh)).BeginInit();
			this.tabPageMorphView.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox8.SuspendLayout();
			this.groupBox11.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.trackBarMorphFactor)).BeginInit();
			this.tabPageMaterialView.SuspendLayout();
			this.tabPageTextureView.SuspendLayout();
			this.panelTexturePic.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTexture)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrameSRT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrameMatrix)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoneSRT)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoneMatrix)).BeginInit();
			this.SuspendLayout();
			// 
			// buttonObjectTreeRefresh
			// 
			this.buttonObjectTreeRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonObjectTreeRefresh.Location = new System.Drawing.Point(169, 6);
			this.buttonObjectTreeRefresh.Name = "buttonObjectTreeRefresh";
			this.buttonObjectTreeRefresh.Size = new System.Drawing.Size(75, 23);
			this.buttonObjectTreeRefresh.TabIndex = 16;
			this.buttonObjectTreeRefresh.Text = "Refresh";
			this.toolTip1.SetToolTip(this.buttonObjectTreeRefresh, "Updates the Object Tree after running custom scripts");
			this.buttonObjectTreeRefresh.UseVisualStyleBackColor = true;
			this.buttonObjectTreeRefresh.Click += new System.EventHandler(this.buttonObjectTreeRefresh_Click);
			// 
			// buttonObjectTreeExpand
			// 
			this.buttonObjectTreeExpand.Location = new System.Drawing.Point(0, 6);
			this.buttonObjectTreeExpand.Name = "buttonObjectTreeExpand";
			this.buttonObjectTreeExpand.Size = new System.Drawing.Size(75, 23);
			this.buttonObjectTreeExpand.TabIndex = 12;
			this.buttonObjectTreeExpand.Text = "Expand All";
			this.toolTip1.SetToolTip(this.buttonObjectTreeExpand, "All except Bone nodes");
			this.buttonObjectTreeExpand.UseVisualStyleBackColor = true;
			this.buttonObjectTreeExpand.Click += new System.EventHandler(this.buttonObjectTreeExpand_Click);
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(-2, 42);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(69, 13);
			this.label19.TabIndex = 262;
			this.label19.Text = "PathID Mesh";
			this.toolTip1.SetToolTip(this.label19, "Bones will taken from Mesh");
			// 
			// comboBoxMeshRendererMesh
			// 
			this.comboBoxMeshRendererMesh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMeshRendererMesh.DropDownWidth = 216;
			this.comboBoxMeshRendererMesh.Location = new System.Drawing.Point(0, 58);
			this.comboBoxMeshRendererMesh.Name = "comboBoxMeshRendererMesh";
			this.comboBoxMeshRendererMesh.Size = new System.Drawing.Size(139, 21);
			this.comboBoxMeshRendererMesh.TabIndex = 10;
			this.toolTip1.SetToolTip(this.comboBoxMeshRendererMesh, "Bones will taken from Mesh");
			this.comboBoxMeshRendererMesh.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeshRendererMesh_SelectedIndexChanged);
			// 
			// buttonMeshNormals
			// 
			this.buttonMeshNormals.Location = new System.Drawing.Point(90, 216);
			this.buttonMeshNormals.Name = "buttonMeshNormals";
			this.buttonMeshNormals.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshNormals.TabIndex = 45;
			this.buttonMeshNormals.Text = "Normals...";
			this.toolTip1.SetToolTip(this.buttonMeshNormals, "and Tangents");
			this.buttonMeshNormals.UseVisualStyleBackColor = true;
			this.buttonMeshNormals.Click += new System.EventHandler(this.buttonMeshNormals_Click);
			// 
			// label8
			// 
			this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(3, 184);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(55, 13);
			this.label8.TabIndex = 125;
			this.label8.Text = "Multi-Pass";
			this.toolTip1.SetToolTip(this.label8, "Exceeding Materials will be used for SubMesh[0] in additional rendering passes.");
			// 
			// checkBoxMorphFbxOptionEmbedMedia
			// 
			this.checkBoxMorphFbxOptionEmbedMedia.AutoSize = true;
			this.checkBoxMorphFbxOptionEmbedMedia.Enabled = false;
			this.checkBoxMorphFbxOptionEmbedMedia.Location = new System.Drawing.Point(119, 15);
			this.checkBoxMorphFbxOptionEmbedMedia.Name = "checkBoxMorphFbxOptionEmbedMedia";
			this.checkBoxMorphFbxOptionEmbedMedia.Size = new System.Drawing.Size(91, 17);
			this.checkBoxMorphFbxOptionEmbedMedia.TabIndex = 66;
			this.checkBoxMorphFbxOptionEmbedMedia.Text = "Embed Media";
			this.toolTip1.SetToolTip(this.checkBoxMorphFbxOptionEmbedMedia, "Textures are stored inside the output file.");
			this.checkBoxMorphFbxOptionEmbedMedia.UseVisualStyleBackColor = true;
			// 
			// checkBoxMorphFbxOptionOneBlendshape
			// 
			this.checkBoxMorphFbxOptionOneBlendshape.AutoSize = true;
			this.checkBoxMorphFbxOptionOneBlendshape.Checked = true;
			this.checkBoxMorphFbxOptionOneBlendshape.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMorphFbxOptionOneBlendshape.Location = new System.Drawing.Point(6, 15);
			this.checkBoxMorphFbxOptionOneBlendshape.Name = "checkBoxMorphFbxOptionOneBlendshape";
			this.checkBoxMorphFbxOptionOneBlendshape.Size = new System.Drawing.Size(107, 17);
			this.checkBoxMorphFbxOptionOneBlendshape.TabIndex = 64;
			this.checkBoxMorphFbxOptionOneBlendshape.Text = "One BlendShape";
			this.toolTip1.SetToolTip(this.checkBoxMorphFbxOptionOneBlendshape, "If checked, all morph keyframes appear as channels in one common BlendShape.\r\nIf " +
        "unchecked, each morph keyframe will appear as channel in it\'s own BlendShape.");
			this.checkBoxMorphFbxOptionOneBlendshape.UseVisualStyleBackColor = true;
			// 
			// buttonMorphExport
			// 
			this.buttonMorphExport.Location = new System.Drawing.Point(169, 17);
			this.buttonMorphExport.Name = "buttonMorphExport";
			this.buttonMorphExport.Size = new System.Drawing.Size(69, 23);
			this.buttonMorphExport.TabIndex = 70;
			this.buttonMorphExport.Text = "Export";
			this.toolTip1.SetToolTip(this.buttonMorphExport, "Fbx exports include Morph Clips\r\nfrom all selected Meshes");
			this.buttonMorphExport.UseVisualStyleBackColor = true;
			this.buttonMorphExport.Click += new System.EventHandler(this.buttonMorphClipExport_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControlLists);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControlViews);
			this.splitContainer1.Size = new System.Drawing.Size(520, 535);
			this.splitContainer1.SplitterDistance = 256;
			this.splitContainer1.TabIndex = 117;
			this.splitContainer1.TabStop = false;
			// 
			// tabControlLists
			// 
			this.tabControlLists.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControlLists.Controls.Add(this.tabPageObject);
			this.tabControlLists.Controls.Add(this.tabPageMesh);
			this.tabControlLists.Controls.Add(this.tabPageMorph);
			this.tabControlLists.Controls.Add(this.tabPageMaterial);
			this.tabControlLists.Controls.Add(this.tabPageTexture);
			this.tabControlLists.Location = new System.Drawing.Point(0, 0);
			this.tabControlLists.Name = "tabControlLists";
			this.tabControlLists.SelectedIndex = 0;
			this.tabControlLists.Size = new System.Drawing.Size(255, 535);
			this.tabControlLists.TabIndex = 119;
			// 
			// tabPageObject
			// 
			this.tabPageObject.Controls.Add(this.treeViewObjectTree);
			this.tabPageObject.Controls.Add(this.panelObjectTreeBottom);
			this.tabPageObject.Location = new System.Drawing.Point(4, 22);
			this.tabPageObject.Name = "tabPageObject";
			this.tabPageObject.Size = new System.Drawing.Size(247, 509);
			this.tabPageObject.TabIndex = 2;
			this.tabPageObject.Text = "Object Tree";
			this.tabPageObject.UseVisualStyleBackColor = true;
			// 
			// treeViewObjectTree
			// 
			this.treeViewObjectTree.AllowDrop = true;
			this.treeViewObjectTree.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewObjectTree.HideSelection = false;
			this.treeViewObjectTree.Location = new System.Drawing.Point(0, 0);
			this.treeViewObjectTree.Name = "treeViewObjectTree";
			this.treeViewObjectTree.Size = new System.Drawing.Size(247, 474);
			this.treeViewObjectTree.TabIndex = 1;
			this.treeViewObjectTree.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.treeViewObjectTree_DrawNode);
			this.treeViewObjectTree.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewObjectTree_ItemDrag);
			this.treeViewObjectTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewObjectTree_AfterSelect);
			this.treeViewObjectTree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewObjectTree_NodeMouseClick);
			this.treeViewObjectTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewObjectTree_DragDrop);
			this.treeViewObjectTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewObjectTree_DragEnter);
			this.treeViewObjectTree.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewObjectTree_DragOver);
			this.treeViewObjectTree.DragLeave += new System.EventHandler(this.treeViewObjectTree_DragLeave);
			// 
			// panelObjectTreeBottom
			// 
			this.panelObjectTreeBottom.Controls.Add(this.buttonObjectTreeRefresh);
			this.panelObjectTreeBottom.Controls.Add(this.buttonObjectTreeCollapse);
			this.panelObjectTreeBottom.Controls.Add(this.buttonObjectTreeExpand);
			this.panelObjectTreeBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelObjectTreeBottom.Location = new System.Drawing.Point(0, 474);
			this.panelObjectTreeBottom.Name = "panelObjectTreeBottom";
			this.panelObjectTreeBottom.Size = new System.Drawing.Size(247, 35);
			this.panelObjectTreeBottom.TabIndex = 10;
			// 
			// buttonObjectTreeCollapse
			// 
			this.buttonObjectTreeCollapse.Location = new System.Drawing.Point(81, 6);
			this.buttonObjectTreeCollapse.Name = "buttonObjectTreeCollapse";
			this.buttonObjectTreeCollapse.Size = new System.Drawing.Size(75, 23);
			this.buttonObjectTreeCollapse.TabIndex = 14;
			this.buttonObjectTreeCollapse.Text = "Collapse All";
			this.buttonObjectTreeCollapse.UseVisualStyleBackColor = true;
			this.buttonObjectTreeCollapse.Click += new System.EventHandler(this.buttonObjectTreeCollapse_Click);
			// 
			// tabPageMesh
			// 
			this.tabPageMesh.Controls.Add(this.splitContainerMesh);
			this.tabPageMesh.Location = new System.Drawing.Point(4, 22);
			this.tabPageMesh.Name = "tabPageMesh";
			this.tabPageMesh.Size = new System.Drawing.Size(247, 509);
			this.tabPageMesh.TabIndex = 0;
			this.tabPageMesh.Text = "Mesh";
			this.tabPageMesh.UseVisualStyleBackColor = true;
			// 
			// splitContainerMesh
			// 
			this.splitContainerMesh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMesh.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMesh.Name = "splitContainerMesh";
			this.splitContainerMesh.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMesh.Panel1
			// 
			this.splitContainerMesh.Panel1.Controls.Add(this.listViewMesh);
			// 
			// splitContainerMesh.Panel2
			// 
			this.splitContainerMesh.Panel2.Controls.Add(this.splitContainerMeshCrossRef);
			this.splitContainerMesh.Size = new System.Drawing.Size(247, 509);
			this.splitContainerMesh.SplitterDistance = 287;
			this.splitContainerMesh.TabIndex = 3;
			this.splitContainerMesh.TabStop = false;
			// 
			// listViewMesh
			// 
			this.listViewMesh.AutoArrange = false;
			this.listViewMesh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.meshlistHeaderNames,
            this.meshListHeaderType});
			this.listViewMesh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMesh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.listViewMesh.HideSelection = false;
			this.listViewMesh.LabelWrap = false;
			this.listViewMesh.Location = new System.Drawing.Point(0, 0);
			this.listViewMesh.Name = "listViewMesh";
			this.listViewMesh.Size = new System.Drawing.Size(247, 287);
			this.listViewMesh.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewMesh.TabIndex = 1;
			this.listViewMesh.UseCompatibleStateImageBehavior = false;
			this.listViewMesh.View = System.Windows.Forms.View.Details;
			this.listViewMesh.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMesh_ItemSelectionChanged);
			// 
			// meshlistHeaderNames
			// 
			this.meshlistHeaderNames.Text = "Name";
			this.meshlistHeaderNames.Width = 157;
			// 
			// meshListHeaderType
			// 
			this.meshListHeaderType.Text = "Type";
			this.meshListHeaderType.Width = 47;
			// 
			// splitContainerMeshCrossRef
			// 
			this.splitContainerMeshCrossRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMeshCrossRef.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMeshCrossRef.Name = "splitContainerMeshCrossRef";
			this.splitContainerMeshCrossRef.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMeshCrossRef.Panel1
			// 
			this.splitContainerMeshCrossRef.Panel1.Controls.Add(this.listViewMeshMaterial);
			this.splitContainerMeshCrossRef.Panel1.Controls.Add(this.label68);
			// 
			// splitContainerMeshCrossRef.Panel2
			// 
			this.splitContainerMeshCrossRef.Panel2.Controls.Add(this.listViewMeshTexture);
			this.splitContainerMeshCrossRef.Panel2.Controls.Add(this.label70);
			this.splitContainerMeshCrossRef.Size = new System.Drawing.Size(247, 218);
			this.splitContainerMeshCrossRef.SplitterDistance = 103;
			this.splitContainerMeshCrossRef.TabIndex = 2;
			this.splitContainerMeshCrossRef.TabStop = false;
			// 
			// listViewMeshMaterial
			// 
			this.listViewMeshMaterial.AutoArrange = false;
			this.listViewMeshMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewMeshMaterialHeader});
			this.listViewMeshMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMeshMaterial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewMeshMaterial.HideSelection = false;
			this.listViewMeshMaterial.LabelWrap = false;
			this.listViewMeshMaterial.Location = new System.Drawing.Point(0, 13);
			this.listViewMeshMaterial.Name = "listViewMeshMaterial";
			this.listViewMeshMaterial.Size = new System.Drawing.Size(247, 90);
			this.listViewMeshMaterial.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewMeshMaterial.TabIndex = 2;
			this.listViewMeshMaterial.UseCompatibleStateImageBehavior = false;
			this.listViewMeshMaterial.View = System.Windows.Forms.View.Details;
			this.listViewMeshMaterial.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMeshMaterial_ItemSelectionChanged);
			this.listViewMeshMaterial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewMeshMaterial_KeyUp);
			// 
			// label68
			// 
			this.label68.AutoSize = true;
			this.label68.Dock = System.Windows.Forms.DockStyle.Top;
			this.label68.Location = new System.Drawing.Point(0, 0);
			this.label68.Name = "label68";
			this.label68.Size = new System.Drawing.Size(77, 13);
			this.label68.TabIndex = 0;
			this.label68.Text = "Materials Used";
			// 
			// listViewMeshTexture
			// 
			this.listViewMeshTexture.AutoArrange = false;
			this.listViewMeshTexture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewMeshTextureHeader});
			this.listViewMeshTexture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMeshTexture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewMeshTexture.HideSelection = false;
			this.listViewMeshTexture.LabelWrap = false;
			this.listViewMeshTexture.Location = new System.Drawing.Point(0, 13);
			this.listViewMeshTexture.Name = "listViewMeshTexture";
			this.listViewMeshTexture.Size = new System.Drawing.Size(247, 98);
			this.listViewMeshTexture.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewMeshTexture.TabIndex = 3;
			this.listViewMeshTexture.UseCompatibleStateImageBehavior = false;
			this.listViewMeshTexture.View = System.Windows.Forms.View.Details;
			this.listViewMeshTexture.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMeshTexture_ItemSelectionChanged);
			this.listViewMeshTexture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewMeshTexture_KeyUp);
			// 
			// label70
			// 
			this.label70.AutoSize = true;
			this.label70.Dock = System.Windows.Forms.DockStyle.Top;
			this.label70.Location = new System.Drawing.Point(0, 0);
			this.label70.Name = "label70";
			this.label70.Size = new System.Drawing.Size(76, 13);
			this.label70.TabIndex = 1;
			this.label70.Text = "Textures Used";
			// 
			// tabPageMorph
			// 
			this.tabPageMorph.Controls.Add(this.label44);
			this.tabPageMorph.Controls.Add(this.panel1);
			this.tabPageMorph.Controls.Add(this.label57);
			this.tabPageMorph.Location = new System.Drawing.Point(4, 22);
			this.tabPageMorph.Name = "tabPageMorph";
			this.tabPageMorph.Size = new System.Drawing.Size(247, 509);
			this.tabPageMorph.TabIndex = 4;
			this.tabPageMorph.Text = "Morph";
			this.tabPageMorph.UseVisualStyleBackColor = true;
			// 
			// label44
			// 
			this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label44.AutoSize = true;
			this.label44.Location = new System.Drawing.Point(3, 493);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(164, 13);
			this.label44.TabIndex = 84;
			this.label44.Text = "Drop imported Morph Clips above";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.treeViewMorphKeyframes);
			this.panel1.Location = new System.Drawing.Point(0, 26);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(247, 464);
			this.panel1.TabIndex = 83;
			// 
			// treeViewMorphKeyframes
			// 
			this.treeViewMorphKeyframes.AllowDrop = true;
			this.treeViewMorphKeyframes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.treeViewMorphKeyframes.HideSelection = false;
			this.treeViewMorphKeyframes.Location = new System.Drawing.Point(0, 0);
			this.treeViewMorphKeyframes.Name = "treeViewMorphKeyframes";
			this.treeViewMorphKeyframes.Size = new System.Drawing.Size(247, 464);
			this.treeViewMorphKeyframes.TabIndex = 81;
			this.treeViewMorphKeyframes.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewMorphKeyframes_ItemDrag);
			this.treeViewMorphKeyframes.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMorphKeyframe_AfterSelect);
			this.treeViewMorphKeyframes.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewMorphKeyframes_DragDrop);
			this.treeViewMorphKeyframes.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewMorphKeyframes_DragEnter);
			this.treeViewMorphKeyframes.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewMorphKeyframes_DragOver);
			// 
			// label57
			// 
			this.label57.AutoSize = true;
			this.label57.Location = new System.Drawing.Point(0, 10);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(128, 13);
			this.label57.TabIndex = 82;
			this.label57.Text = "Morph Clips [Mesh Name]";
			// 
			// tabPageMaterial
			// 
			this.tabPageMaterial.Controls.Add(this.splitContainerMaterial);
			this.tabPageMaterial.Location = new System.Drawing.Point(4, 22);
			this.tabPageMaterial.Name = "tabPageMaterial";
			this.tabPageMaterial.Size = new System.Drawing.Size(247, 509);
			this.tabPageMaterial.TabIndex = 1;
			this.tabPageMaterial.Text = "Material";
			this.tabPageMaterial.UseVisualStyleBackColor = true;
			// 
			// splitContainerMaterial
			// 
			this.splitContainerMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMaterial.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMaterial.Name = "splitContainerMaterial";
			this.splitContainerMaterial.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMaterial.Panel1
			// 
			this.splitContainerMaterial.Panel1.Controls.Add(this.listViewMaterial);
			// 
			// splitContainerMaterial.Panel2
			// 
			this.splitContainerMaterial.Panel2.Controls.Add(this.splitContainerMaterialCrossRef);
			this.splitContainerMaterial.Size = new System.Drawing.Size(247, 509);
			this.splitContainerMaterial.SplitterDistance = 288;
			this.splitContainerMaterial.TabIndex = 4;
			this.splitContainerMaterial.TabStop = false;
			// 
			// listViewMaterial
			// 
			this.listViewMaterial.AutoArrange = false;
			this.listViewMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.materiallistHeader});
			this.listViewMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMaterial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewMaterial.HideSelection = false;
			this.listViewMaterial.LabelWrap = false;
			this.listViewMaterial.Location = new System.Drawing.Point(0, 0);
			this.listViewMaterial.Name = "listViewMaterial";
			this.listViewMaterial.Size = new System.Drawing.Size(247, 288);
			this.listViewMaterial.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewMaterial.TabIndex = 1;
			this.listViewMaterial.UseCompatibleStateImageBehavior = false;
			this.listViewMaterial.View = System.Windows.Forms.View.Details;
			this.listViewMaterial.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMaterial_ItemSelectionChanged);
			// 
			// splitContainerMaterialCrossRef
			// 
			this.splitContainerMaterialCrossRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerMaterialCrossRef.Location = new System.Drawing.Point(0, 0);
			this.splitContainerMaterialCrossRef.Name = "splitContainerMaterialCrossRef";
			this.splitContainerMaterialCrossRef.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerMaterialCrossRef.Panel1
			// 
			this.splitContainerMaterialCrossRef.Panel1.Controls.Add(this.listViewMaterialMesh);
			this.splitContainerMaterialCrossRef.Panel1.Controls.Add(this.label71);
			// 
			// splitContainerMaterialCrossRef.Panel2
			// 
			this.splitContainerMaterialCrossRef.Panel2.Controls.Add(this.listViewMaterialTexture);
			this.splitContainerMaterialCrossRef.Panel2.Controls.Add(this.label72);
			this.splitContainerMaterialCrossRef.Size = new System.Drawing.Size(247, 217);
			this.splitContainerMaterialCrossRef.SplitterDistance = 103;
			this.splitContainerMaterialCrossRef.TabIndex = 2;
			this.splitContainerMaterialCrossRef.TabStop = false;
			// 
			// listViewMaterialMesh
			// 
			this.listViewMaterialMesh.AutoArrange = false;
			this.listViewMaterialMesh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewMaterialMeshHeader});
			this.listViewMaterialMesh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMaterialMesh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewMaterialMesh.HideSelection = false;
			this.listViewMaterialMesh.LabelWrap = false;
			this.listViewMaterialMesh.Location = new System.Drawing.Point(0, 13);
			this.listViewMaterialMesh.Name = "listViewMaterialMesh";
			this.listViewMaterialMesh.Size = new System.Drawing.Size(247, 90);
			this.listViewMaterialMesh.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewMaterialMesh.TabIndex = 2;
			this.listViewMaterialMesh.UseCompatibleStateImageBehavior = false;
			this.listViewMaterialMesh.View = System.Windows.Forms.View.Details;
			this.listViewMaterialMesh.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMaterialMesh_ItemSelectionChanged);
			this.listViewMaterialMesh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewMaterialMesh_KeyUp);
			// 
			// label71
			// 
			this.label71.AutoSize = true;
			this.label71.Dock = System.Windows.Forms.DockStyle.Top;
			this.label71.Location = new System.Drawing.Point(0, 0);
			this.label71.Name = "label71";
			this.label71.Size = new System.Drawing.Size(84, 13);
			this.label71.TabIndex = 1;
			this.label71.Text = "Used In Meshes";
			// 
			// listViewMaterialTexture
			// 
			this.listViewMaterialTexture.AutoArrange = false;
			this.listViewMaterialTexture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewMaterialTextureHeader});
			this.listViewMaterialTexture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewMaterialTexture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewMaterialTexture.HideSelection = false;
			this.listViewMaterialTexture.LabelWrap = false;
			this.listViewMaterialTexture.Location = new System.Drawing.Point(0, 13);
			this.listViewMaterialTexture.Name = "listViewMaterialTexture";
			this.listViewMaterialTexture.Size = new System.Drawing.Size(247, 97);
			this.listViewMaterialTexture.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewMaterialTexture.TabIndex = 3;
			this.listViewMaterialTexture.UseCompatibleStateImageBehavior = false;
			this.listViewMaterialTexture.View = System.Windows.Forms.View.Details;
			this.listViewMaterialTexture.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewMaterialTexture_ItemSelectionChanged);
			this.listViewMaterialTexture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewMaterialTexture_KeyUp);
			// 
			// label72
			// 
			this.label72.AutoSize = true;
			this.label72.Dock = System.Windows.Forms.DockStyle.Top;
			this.label72.Location = new System.Drawing.Point(0, 0);
			this.label72.Name = "label72";
			this.label72.Size = new System.Drawing.Size(76, 13);
			this.label72.TabIndex = 1;
			this.label72.Text = "Textures Used";
			// 
			// tabPageTexture
			// 
			this.tabPageTexture.Controls.Add(this.splitContainerTexture);
			this.tabPageTexture.Location = new System.Drawing.Point(4, 22);
			this.tabPageTexture.Name = "tabPageTexture";
			this.tabPageTexture.Size = new System.Drawing.Size(247, 509);
			this.tabPageTexture.TabIndex = 3;
			this.tabPageTexture.Text = "Texture";
			this.tabPageTexture.UseVisualStyleBackColor = true;
			// 
			// splitContainerTexture
			// 
			this.splitContainerTexture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerTexture.Location = new System.Drawing.Point(0, 0);
			this.splitContainerTexture.Name = "splitContainerTexture";
			this.splitContainerTexture.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerTexture.Panel1
			// 
			this.splitContainerTexture.Panel1.Controls.Add(this.listViewTexture);
			// 
			// splitContainerTexture.Panel2
			// 
			this.splitContainerTexture.Panel2.Controls.Add(this.splitContainerTextureCrossRef);
			this.splitContainerTexture.Size = new System.Drawing.Size(247, 509);
			this.splitContainerTexture.SplitterDistance = 288;
			this.splitContainerTexture.TabIndex = 3;
			this.splitContainerTexture.TabStop = false;
			// 
			// listViewTexture
			// 
			this.listViewTexture.AutoArrange = false;
			this.listViewTexture.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.texturelistHeader});
			this.listViewTexture.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewTexture.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTexture.HideSelection = false;
			this.listViewTexture.LabelWrap = false;
			this.listViewTexture.Location = new System.Drawing.Point(0, 0);
			this.listViewTexture.Name = "listViewTexture";
			this.listViewTexture.Size = new System.Drawing.Size(247, 288);
			this.listViewTexture.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewTexture.TabIndex = 1;
			this.listViewTexture.UseCompatibleStateImageBehavior = false;
			this.listViewTexture.View = System.Windows.Forms.View.Details;
			this.listViewTexture.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewTexture_ItemSelectionChanged);
			this.listViewTexture.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewTexture_KeyUp);
			// 
			// splitContainerTextureCrossRef
			// 
			this.splitContainerTextureCrossRef.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainerTextureCrossRef.Location = new System.Drawing.Point(0, 0);
			this.splitContainerTextureCrossRef.Name = "splitContainerTextureCrossRef";
			this.splitContainerTextureCrossRef.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainerTextureCrossRef.Panel1
			// 
			this.splitContainerTextureCrossRef.Panel1.Controls.Add(this.listViewTextureMesh);
			this.splitContainerTextureCrossRef.Panel1.Controls.Add(this.label73);
			// 
			// splitContainerTextureCrossRef.Panel2
			// 
			this.splitContainerTextureCrossRef.Panel2.Controls.Add(this.listViewTextureMaterial);
			this.splitContainerTextureCrossRef.Panel2.Controls.Add(this.label74);
			this.splitContainerTextureCrossRef.Size = new System.Drawing.Size(247, 217);
			this.splitContainerTextureCrossRef.SplitterDistance = 103;
			this.splitContainerTextureCrossRef.TabIndex = 2;
			this.splitContainerTextureCrossRef.TabStop = false;
			// 
			// listViewTextureMesh
			// 
			this.listViewTextureMesh.AutoArrange = false;
			this.listViewTextureMesh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewTextureMeshHeader});
			this.listViewTextureMesh.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewTextureMesh.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTextureMesh.HideSelection = false;
			this.listViewTextureMesh.LabelWrap = false;
			this.listViewTextureMesh.Location = new System.Drawing.Point(0, 13);
			this.listViewTextureMesh.Name = "listViewTextureMesh";
			this.listViewTextureMesh.Size = new System.Drawing.Size(247, 90);
			this.listViewTextureMesh.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewTextureMesh.TabIndex = 2;
			this.listViewTextureMesh.UseCompatibleStateImageBehavior = false;
			this.listViewTextureMesh.View = System.Windows.Forms.View.Details;
			this.listViewTextureMesh.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewTextureMesh_ItemSelectionChanged);
			this.listViewTextureMesh.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewTextureMesh_KeyUp);
			// 
			// label73
			// 
			this.label73.AutoSize = true;
			this.label73.Dock = System.Windows.Forms.DockStyle.Top;
			this.label73.Location = new System.Drawing.Point(0, 0);
			this.label73.Name = "label73";
			this.label73.Size = new System.Drawing.Size(84, 13);
			this.label73.TabIndex = 1;
			this.label73.Text = "Used In Meshes";
			// 
			// listViewTextureMaterial
			// 
			this.listViewTextureMaterial.AutoArrange = false;
			this.listViewTextureMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewTextureMaterialHeader});
			this.listViewTextureMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listViewTextureMaterial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.listViewTextureMaterial.HideSelection = false;
			this.listViewTextureMaterial.LabelWrap = false;
			this.listViewTextureMaterial.Location = new System.Drawing.Point(0, 13);
			this.listViewTextureMaterial.Name = "listViewTextureMaterial";
			this.listViewTextureMaterial.Size = new System.Drawing.Size(247, 97);
			this.listViewTextureMaterial.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.listViewTextureMaterial.TabIndex = 3;
			this.listViewTextureMaterial.UseCompatibleStateImageBehavior = false;
			this.listViewTextureMaterial.View = System.Windows.Forms.View.Details;
			this.listViewTextureMaterial.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewTextureMaterial_ItemSelectionChanged);
			this.listViewTextureMaterial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.listViewTextureMaterial_KeyUp);
			// 
			// label74
			// 
			this.label74.AutoSize = true;
			this.label74.Dock = System.Windows.Forms.DockStyle.Top;
			this.label74.Location = new System.Drawing.Point(0, 0);
			this.label74.Name = "label74";
			this.label74.Size = new System.Drawing.Size(89, 13);
			this.label74.TabIndex = 1;
			this.label74.Text = "Used In Materials";
			// 
			// tabControlViews
			// 
			this.tabControlViews.Controls.Add(this.tabPageFrameView);
			this.tabControlViews.Controls.Add(this.tabPageBoneView);
			this.tabControlViews.Controls.Add(this.tabPageMeshView);
			this.tabControlViews.Controls.Add(this.tabPageMorphView);
			this.tabControlViews.Controls.Add(this.tabPageMaterialView);
			this.tabControlViews.Controls.Add(this.tabPageTextureView);
			this.tabControlViews.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlViews.Location = new System.Drawing.Point(0, 0);
			this.tabControlViews.Name = "tabControlViews";
			this.tabControlViews.SelectedIndex = 0;
			this.tabControlViews.Size = new System.Drawing.Size(260, 535);
			this.tabControlViews.TabIndex = 133;
			// 
			// tabPageFrameView
			// 
			this.tabPageFrameView.Controls.Add(this.label38);
			this.tabPageFrameView.Controls.Add(this.buttonFrameUnique);
			this.tabPageFrameView.Controls.Add(this.buttonFrameAddBone);
			this.tabPageFrameView.Controls.Add(this.groupBox3);
			this.tabPageFrameView.Controls.Add(this.tabControlFrameMatrix);
			this.tabPageFrameView.Controls.Add(this.buttonFrameMoveUp);
			this.tabPageFrameView.Controls.Add(this.buttonFrameRemove);
			this.tabPageFrameView.Controls.Add(this.buttonFrameMoveDown);
			this.tabPageFrameView.Controls.Add(this.label4);
			this.tabPageFrameView.Controls.Add(this.textBoxFrameName);
			this.tabPageFrameView.Location = new System.Drawing.Point(4, 22);
			this.tabPageFrameView.Name = "tabPageFrameView";
			this.tabPageFrameView.Size = new System.Drawing.Size(252, 509);
			this.tabPageFrameView.TabIndex = 2;
			this.tabPageFrameView.Text = "Frame";
			this.tabPageFrameView.UseVisualStyleBackColor = true;
			// 
			// label38
			// 
			this.label38.AutoSize = true;
			this.label38.Location = new System.Drawing.Point(93, 4);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(156, 13);
			this.label38.TabIndex = 86;
			this.label38.Text = "Rename Mesh Transforms only!";
			// 
			// buttonFrameUnique
			// 
			this.buttonFrameUnique.Enabled = false;
			this.buttonFrameUnique.Location = new System.Drawing.Point(88, 60);
			this.buttonFrameUnique.Name = "buttonFrameUnique";
			this.buttonFrameUnique.Size = new System.Drawing.Size(75, 23);
			this.buttonFrameUnique.TabIndex = 12;
			this.buttonFrameUnique.Text = "Unique";
			this.buttonFrameUnique.UseVisualStyleBackColor = true;
			this.buttonFrameUnique.Click += new System.EventHandler(this.buttonFrameUnique_Click);
			// 
			// buttonFrameAddBone
			// 
			this.buttonFrameAddBone.Location = new System.Drawing.Point(88, 93);
			this.buttonFrameAddBone.Name = "buttonFrameAddBone";
			this.buttonFrameAddBone.Size = new System.Drawing.Size(162, 23);
			this.buttonFrameAddBone.TabIndex = 18;
			this.buttonFrameAddBone.Text = "Add Bone to Selected Meshes";
			this.buttonFrameAddBone.UseVisualStyleBackColor = true;
			this.buttonFrameAddBone.Click += new System.EventHandler(this.buttonFrameAddBone_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.groupBox5);
			this.groupBox3.Controls.Add(this.numericFrameMatrixRatio);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.numericFrameMatrixNumber);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixPaste);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixCopy);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixGrow);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixShrink);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixIdentity);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixInverse);
			this.groupBox3.Controls.Add(this.buttonFrameMatrixCombined);
			this.groupBox3.Location = new System.Drawing.Point(0, 246);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(253, 149);
			this.groupBox3.TabIndex = 60;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Matrix Operations";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.buttonFrameMatrixApply);
			this.groupBox5.Controls.Add(this.checkBoxFrameMatrixUpdate);
			this.groupBox5.Location = new System.Drawing.Point(6, 105);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(238, 38);
			this.groupBox5.TabIndex = 100;
			this.groupBox5.TabStop = false;
			// 
			// buttonFrameMatrixApply
			// 
			this.buttonFrameMatrixApply.Location = new System.Drawing.Point(120, 10);
			this.buttonFrameMatrixApply.Name = "buttonFrameMatrixApply";
			this.buttonFrameMatrixApply.Size = new System.Drawing.Size(112, 23);
			this.buttonFrameMatrixApply.TabIndex = 114;
			this.buttonFrameMatrixApply.Text = "Apply Changes";
			this.buttonFrameMatrixApply.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixApply.Click += new System.EventHandler(this.buttonFrameMatrixApply_Click);
			// 
			// checkBoxFrameMatrixUpdate
			// 
			this.checkBoxFrameMatrixUpdate.AutoSize = true;
			this.checkBoxFrameMatrixUpdate.Location = new System.Drawing.Point(6, 13);
			this.checkBoxFrameMatrixUpdate.Name = "checkBoxFrameMatrixUpdate";
			this.checkBoxFrameMatrixUpdate.Size = new System.Drawing.Size(94, 17);
			this.checkBoxFrameMatrixUpdate.TabIndex = 112;
			this.checkBoxFrameMatrixUpdate.Text = "Update Bones";
			this.checkBoxFrameMatrixUpdate.UseVisualStyleBackColor = true;
			// 
			// numericFrameMatrixRatio
			// 
			this.numericFrameMatrixRatio.DecimalPlaces = 2;
			this.numericFrameMatrixRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericFrameMatrixRatio.Location = new System.Drawing.Point(36, 52);
			this.numericFrameMatrixRatio.Name = "numericFrameMatrixRatio";
			this.numericFrameMatrixRatio.Size = new System.Drawing.Size(56, 20);
			this.numericFrameMatrixRatio.TabIndex = 68;
			this.numericFrameMatrixRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 55);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(32, 13);
			this.label5.TabIndex = 178;
			this.label5.Text = "Ratio";
			// 
			// numericFrameMatrixNumber
			// 
			this.numericFrameMatrixNumber.Location = new System.Drawing.Point(50, 83);
			this.numericFrameMatrixNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericFrameMatrixNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericFrameMatrixNumber.Name = "numericFrameMatrixNumber";
			this.numericFrameMatrixNumber.Size = new System.Drawing.Size(42, 20);
			this.numericFrameMatrixNumber.TabIndex = 74;
			this.numericFrameMatrixNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 87);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(45, 13);
			this.label6.TabIndex = 176;
			this.label6.Text = "Matrix #";
			// 
			// buttonFrameMatrixPaste
			// 
			this.buttonFrameMatrixPaste.Location = new System.Drawing.Point(179, 81);
			this.buttonFrameMatrixPaste.Name = "buttonFrameMatrixPaste";
			this.buttonFrameMatrixPaste.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixPaste.TabIndex = 78;
			this.buttonFrameMatrixPaste.Text = "Paste";
			this.buttonFrameMatrixPaste.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixPaste.Click += new System.EventHandler(this.buttonFrameMatrixPaste_Click);
			// 
			// buttonFrameMatrixCopy
			// 
			this.buttonFrameMatrixCopy.Location = new System.Drawing.Point(102, 81);
			this.buttonFrameMatrixCopy.Name = "buttonFrameMatrixCopy";
			this.buttonFrameMatrixCopy.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixCopy.TabIndex = 76;
			this.buttonFrameMatrixCopy.Text = "Copy";
			this.buttonFrameMatrixCopy.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixCopy.Click += new System.EventHandler(this.buttonFrameMatrixCopy_Click);
			// 
			// buttonFrameMatrixGrow
			// 
			this.buttonFrameMatrixGrow.Location = new System.Drawing.Point(102, 51);
			this.buttonFrameMatrixGrow.Name = "buttonFrameMatrixGrow";
			this.buttonFrameMatrixGrow.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixGrow.TabIndex = 70;
			this.buttonFrameMatrixGrow.Text = "Grow";
			this.buttonFrameMatrixGrow.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixGrow.Click += new System.EventHandler(this.buttonFrameMatrixGrow_Click);
			// 
			// buttonFrameMatrixShrink
			// 
			this.buttonFrameMatrixShrink.Location = new System.Drawing.Point(179, 51);
			this.buttonFrameMatrixShrink.Name = "buttonFrameMatrixShrink";
			this.buttonFrameMatrixShrink.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixShrink.TabIndex = 72;
			this.buttonFrameMatrixShrink.Text = "Shrink";
			this.buttonFrameMatrixShrink.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixShrink.Click += new System.EventHandler(this.buttonFrameMatrixShrink_Click);
			// 
			// buttonFrameMatrixIdentity
			// 
			this.buttonFrameMatrixIdentity.Location = new System.Drawing.Point(25, 19);
			this.buttonFrameMatrixIdentity.Name = "buttonFrameMatrixIdentity";
			this.buttonFrameMatrixIdentity.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixIdentity.TabIndex = 62;
			this.buttonFrameMatrixIdentity.Text = "Identity";
			this.buttonFrameMatrixIdentity.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixIdentity.Click += new System.EventHandler(this.buttonFrameMatrixIdentity_Click);
			// 
			// buttonFrameMatrixInverse
			// 
			this.buttonFrameMatrixInverse.Location = new System.Drawing.Point(179, 19);
			this.buttonFrameMatrixInverse.Name = "buttonFrameMatrixInverse";
			this.buttonFrameMatrixInverse.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixInverse.TabIndex = 66;
			this.buttonFrameMatrixInverse.Text = "Inverse";
			this.buttonFrameMatrixInverse.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixInverse.Click += new System.EventHandler(this.buttonFrameMatrixInverse_Click);
			// 
			// buttonFrameMatrixCombined
			// 
			this.buttonFrameMatrixCombined.Location = new System.Drawing.Point(102, 19);
			this.buttonFrameMatrixCombined.Name = "buttonFrameMatrixCombined";
			this.buttonFrameMatrixCombined.Size = new System.Drawing.Size(66, 23);
			this.buttonFrameMatrixCombined.TabIndex = 64;
			this.buttonFrameMatrixCombined.Text = "Combined";
			this.buttonFrameMatrixCombined.UseVisualStyleBackColor = true;
			this.buttonFrameMatrixCombined.Click += new System.EventHandler(this.buttonFrameMatrixCombined_Click);
			// 
			// tabControlFrameMatrix
			// 
			this.tabControlFrameMatrix.Controls.Add(this.tabPageFrameSRT);
			this.tabControlFrameMatrix.Controls.Add(this.tabPageFrameMatrix);
			this.tabControlFrameMatrix.Location = new System.Drawing.Point(0, 128);
			this.tabControlFrameMatrix.Name = "tabControlFrameMatrix";
			this.tabControlFrameMatrix.SelectedIndex = 0;
			this.tabControlFrameMatrix.Size = new System.Drawing.Size(253, 112);
			this.tabControlFrameMatrix.TabIndex = 40;
			// 
			// tabPageFrameSRT
			// 
			this.tabPageFrameSRT.Controls.Add(this.dataGridViewFrameSRT);
			this.tabPageFrameSRT.Location = new System.Drawing.Point(4, 22);
			this.tabPageFrameSRT.Name = "tabPageFrameSRT";
			this.tabPageFrameSRT.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFrameSRT.Size = new System.Drawing.Size(245, 86);
			this.tabPageFrameSRT.TabIndex = 1;
			this.tabPageFrameSRT.Text = "SRT";
			this.tabPageFrameSRT.UseVisualStyleBackColor = true;
			// 
			// tabPageFrameMatrix
			// 
			this.tabPageFrameMatrix.Controls.Add(this.dataGridViewFrameMatrix);
			this.tabPageFrameMatrix.Location = new System.Drawing.Point(4, 22);
			this.tabPageFrameMatrix.Name = "tabPageFrameMatrix";
			this.tabPageFrameMatrix.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageFrameMatrix.Size = new System.Drawing.Size(245, 86);
			this.tabPageFrameMatrix.TabIndex = 0;
			this.tabPageFrameMatrix.Text = "Matrix";
			this.tabPageFrameMatrix.UseVisualStyleBackColor = true;
			// 
			// buttonFrameMoveUp
			// 
			this.buttonFrameMoveUp.Location = new System.Drawing.Point(2, 60);
			this.buttonFrameMoveUp.Name = "buttonFrameMoveUp";
			this.buttonFrameMoveUp.Size = new System.Drawing.Size(75, 23);
			this.buttonFrameMoveUp.TabIndex = 10;
			this.buttonFrameMoveUp.Text = "Move Up";
			this.buttonFrameMoveUp.UseVisualStyleBackColor = true;
			this.buttonFrameMoveUp.Click += new System.EventHandler(this.buttonFrameMoveUp_Click);
			// 
			// buttonFrameRemove
			// 
			this.buttonFrameRemove.Location = new System.Drawing.Point(175, 60);
			this.buttonFrameRemove.Name = "buttonFrameRemove";
			this.buttonFrameRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonFrameRemove.TabIndex = 14;
			this.buttonFrameRemove.Text = "Remove";
			this.buttonFrameRemove.UseVisualStyleBackColor = true;
			this.buttonFrameRemove.Click += new System.EventHandler(this.buttonFrameRemove_Click);
			// 
			// buttonFrameMoveDown
			// 
			this.buttonFrameMoveDown.Location = new System.Drawing.Point(2, 93);
			this.buttonFrameMoveDown.Name = "buttonFrameMoveDown";
			this.buttonFrameMoveDown.Size = new System.Drawing.Size(75, 23);
			this.buttonFrameMoveDown.TabIndex = 16;
			this.buttonFrameMoveDown.Text = "Move Down";
			this.buttonFrameMoveDown.UseVisualStyleBackColor = true;
			this.buttonFrameMoveDown.Click += new System.EventHandler(this.buttonFrameMoveDown_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(-2, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(85, 13);
			this.label4.TabIndex = 85;
			this.label4.Text = "Transform Name";
			// 
			// tabPageBoneView
			// 
			this.tabPageBoneView.Controls.Add(this.groupBox4);
			this.tabPageBoneView.Controls.Add(this.tabControlBoneMatrix);
			this.tabPageBoneView.Controls.Add(this.buttonBoneRemove);
			this.tabPageBoneView.Controls.Add(this.buttonBoneGotoFrame);
			this.tabPageBoneView.Controls.Add(this.label25);
			this.tabPageBoneView.Controls.Add(this.textBoxBoneName);
			this.tabPageBoneView.Location = new System.Drawing.Point(4, 22);
			this.tabPageBoneView.Name = "tabPageBoneView";
			this.tabPageBoneView.Size = new System.Drawing.Size(252, 509);
			this.tabPageBoneView.TabIndex = 8;
			this.tabPageBoneView.Text = "Bone";
			this.tabPageBoneView.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.numericBoneMatrixRatio);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.numericBoneMatrixNumber);
			this.groupBox4.Controls.Add(this.label12);
			this.groupBox4.Controls.Add(this.buttonBoneMatrixPaste);
			this.groupBox4.Controls.Add(this.buttonBoneMatrixCopy);
			this.groupBox4.Controls.Add(this.buttonBoneMatrixGrow);
			this.groupBox4.Controls.Add(this.buttonBoneMatrixShrink);
			this.groupBox4.Controls.Add(this.buttonBoneMatrixIdentity);
			this.groupBox4.Controls.Add(this.buttonBoneMatrixInverse);
			this.groupBox4.Controls.Add(this.groupBox6);
			this.groupBox4.Location = new System.Drawing.Point(0, 200);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(253, 149);
			this.groupBox4.TabIndex = 60;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Matrix Operations";
			// 
			// numericBoneMatrixRatio
			// 
			this.numericBoneMatrixRatio.DecimalPlaces = 2;
			this.numericBoneMatrixRatio.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
			this.numericBoneMatrixRatio.Location = new System.Drawing.Point(36, 52);
			this.numericBoneMatrixRatio.Name = "numericBoneMatrixRatio";
			this.numericBoneMatrixRatio.Size = new System.Drawing.Size(56, 20);
			this.numericBoneMatrixRatio.TabIndex = 66;
			this.numericBoneMatrixRatio.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(3, 55);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(32, 13);
			this.label9.TabIndex = 178;
			this.label9.Text = "Ratio";
			// 
			// numericBoneMatrixNumber
			// 
			this.numericBoneMatrixNumber.Location = new System.Drawing.Point(50, 83);
			this.numericBoneMatrixNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.numericBoneMatrixNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericBoneMatrixNumber.Name = "numericBoneMatrixNumber";
			this.numericBoneMatrixNumber.Size = new System.Drawing.Size(42, 20);
			this.numericBoneMatrixNumber.TabIndex = 72;
			this.numericBoneMatrixNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(3, 87);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(45, 13);
			this.label12.TabIndex = 176;
			this.label12.Text = "Matrix #";
			// 
			// buttonBoneMatrixPaste
			// 
			this.buttonBoneMatrixPaste.Location = new System.Drawing.Point(179, 81);
			this.buttonBoneMatrixPaste.Name = "buttonBoneMatrixPaste";
			this.buttonBoneMatrixPaste.Size = new System.Drawing.Size(66, 23);
			this.buttonBoneMatrixPaste.TabIndex = 76;
			this.buttonBoneMatrixPaste.Text = "Paste";
			this.buttonBoneMatrixPaste.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixPaste.Click += new System.EventHandler(this.buttonBoneMatrixPaste_Click);
			// 
			// buttonBoneMatrixCopy
			// 
			this.buttonBoneMatrixCopy.Location = new System.Drawing.Point(102, 81);
			this.buttonBoneMatrixCopy.Name = "buttonBoneMatrixCopy";
			this.buttonBoneMatrixCopy.Size = new System.Drawing.Size(66, 23);
			this.buttonBoneMatrixCopy.TabIndex = 74;
			this.buttonBoneMatrixCopy.Text = "Copy";
			this.buttonBoneMatrixCopy.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixCopy.Click += new System.EventHandler(this.buttonBoneMatrixCopy_Click);
			// 
			// buttonBoneMatrixGrow
			// 
			this.buttonBoneMatrixGrow.Location = new System.Drawing.Point(102, 51);
			this.buttonBoneMatrixGrow.Name = "buttonBoneMatrixGrow";
			this.buttonBoneMatrixGrow.Size = new System.Drawing.Size(66, 23);
			this.buttonBoneMatrixGrow.TabIndex = 68;
			this.buttonBoneMatrixGrow.Text = "Grow";
			this.buttonBoneMatrixGrow.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixGrow.Click += new System.EventHandler(this.buttonBoneMatrixGrow_Click);
			// 
			// buttonBoneMatrixShrink
			// 
			this.buttonBoneMatrixShrink.Location = new System.Drawing.Point(179, 51);
			this.buttonBoneMatrixShrink.Name = "buttonBoneMatrixShrink";
			this.buttonBoneMatrixShrink.Size = new System.Drawing.Size(66, 23);
			this.buttonBoneMatrixShrink.TabIndex = 70;
			this.buttonBoneMatrixShrink.Text = "Shrink";
			this.buttonBoneMatrixShrink.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixShrink.Click += new System.EventHandler(this.buttonBoneMatrixShrink_Click);
			// 
			// buttonBoneMatrixIdentity
			// 
			this.buttonBoneMatrixIdentity.Location = new System.Drawing.Point(102, 19);
			this.buttonBoneMatrixIdentity.Name = "buttonBoneMatrixIdentity";
			this.buttonBoneMatrixIdentity.Size = new System.Drawing.Size(66, 23);
			this.buttonBoneMatrixIdentity.TabIndex = 62;
			this.buttonBoneMatrixIdentity.Text = "Identity";
			this.buttonBoneMatrixIdentity.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixIdentity.Click += new System.EventHandler(this.buttonBoneMatrixIdentity_Click);
			// 
			// buttonBoneMatrixInverse
			// 
			this.buttonBoneMatrixInverse.Location = new System.Drawing.Point(179, 19);
			this.buttonBoneMatrixInverse.Name = "buttonBoneMatrixInverse";
			this.buttonBoneMatrixInverse.Size = new System.Drawing.Size(66, 23);
			this.buttonBoneMatrixInverse.TabIndex = 64;
			this.buttonBoneMatrixInverse.Text = "Inverse";
			this.buttonBoneMatrixInverse.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixInverse.Click += new System.EventHandler(this.buttonBoneMatrixInverse_Click);
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.buttonBoneMatrixApply);
			this.groupBox6.Controls.Add(this.checkBoxBoneMatrixUpdate);
			this.groupBox6.Location = new System.Drawing.Point(6, 105);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(238, 38);
			this.groupBox6.TabIndex = 80;
			this.groupBox6.TabStop = false;
			// 
			// buttonBoneMatrixApply
			// 
			this.buttonBoneMatrixApply.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.buttonBoneMatrixApply.Location = new System.Drawing.Point(141, 10);
			this.buttonBoneMatrixApply.Name = "buttonBoneMatrixApply";
			this.buttonBoneMatrixApply.Size = new System.Drawing.Size(91, 23);
			this.buttonBoneMatrixApply.TabIndex = 84;
			this.buttonBoneMatrixApply.Text = "Apply Changes";
			this.buttonBoneMatrixApply.UseVisualStyleBackColor = true;
			this.buttonBoneMatrixApply.Click += new System.EventHandler(this.buttonBoneMatrixApply_Click);
			// 
			// checkBoxBoneMatrixUpdate
			// 
			this.checkBoxBoneMatrixUpdate.AutoSize = true;
			this.checkBoxBoneMatrixUpdate.Location = new System.Drawing.Point(5, 13);
			this.checkBoxBoneMatrixUpdate.Name = "checkBoxBoneMatrixUpdate";
			this.checkBoxBoneMatrixUpdate.Size = new System.Drawing.Size(135, 17);
			this.checkBoxBoneMatrixUpdate.TabIndex = 82;
			this.checkBoxBoneMatrixUpdate.Text = "Update Bones && Frame";
			this.checkBoxBoneMatrixUpdate.UseVisualStyleBackColor = true;
			// 
			// tabControlBoneMatrix
			// 
			this.tabControlBoneMatrix.Controls.Add(this.tabPageBoneSRT);
			this.tabControlBoneMatrix.Controls.Add(this.tabPageBoneMatrix);
			this.tabControlBoneMatrix.Location = new System.Drawing.Point(0, 84);
			this.tabControlBoneMatrix.Name = "tabControlBoneMatrix";
			this.tabControlBoneMatrix.SelectedIndex = 0;
			this.tabControlBoneMatrix.Size = new System.Drawing.Size(253, 112);
			this.tabControlBoneMatrix.TabIndex = 40;
			// 
			// tabPageBoneSRT
			// 
			this.tabPageBoneSRT.Controls.Add(this.dataGridViewBoneSRT);
			this.tabPageBoneSRT.Location = new System.Drawing.Point(4, 22);
			this.tabPageBoneSRT.Name = "tabPageBoneSRT";
			this.tabPageBoneSRT.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBoneSRT.Size = new System.Drawing.Size(245, 86);
			this.tabPageBoneSRT.TabIndex = 1;
			this.tabPageBoneSRT.Text = "SRT";
			this.tabPageBoneSRT.UseVisualStyleBackColor = true;
			// 
			// tabPageBoneMatrix
			// 
			this.tabPageBoneMatrix.Controls.Add(this.dataGridViewBoneMatrix);
			this.tabPageBoneMatrix.Location = new System.Drawing.Point(4, 22);
			this.tabPageBoneMatrix.Name = "tabPageBoneMatrix";
			this.tabPageBoneMatrix.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageBoneMatrix.Size = new System.Drawing.Size(245, 86);
			this.tabPageBoneMatrix.TabIndex = 0;
			this.tabPageBoneMatrix.Text = "Matrix";
			this.tabPageBoneMatrix.UseVisualStyleBackColor = true;
			// 
			// buttonBoneRemove
			// 
			this.buttonBoneRemove.Location = new System.Drawing.Point(89, 49);
			this.buttonBoneRemove.Name = "buttonBoneRemove";
			this.buttonBoneRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonBoneRemove.TabIndex = 22;
			this.buttonBoneRemove.Text = "Remove";
			this.buttonBoneRemove.UseVisualStyleBackColor = true;
			this.buttonBoneRemove.Click += new System.EventHandler(this.buttonBoneRemove_Click);
			// 
			// buttonBoneGotoFrame
			// 
			this.buttonBoneGotoFrame.Location = new System.Drawing.Point(2, 49);
			this.buttonBoneGotoFrame.Name = "buttonBoneGotoFrame";
			this.buttonBoneGotoFrame.Size = new System.Drawing.Size(75, 23);
			this.buttonBoneGotoFrame.TabIndex = 20;
			this.buttonBoneGotoFrame.Text = "Goto Frame";
			this.buttonBoneGotoFrame.UseVisualStyleBackColor = true;
			this.buttonBoneGotoFrame.Click += new System.EventHandler(this.buttonBoneGotoFrame_Click);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(-2, 5);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(82, 13);
			this.label25.TabIndex = 106;
			this.label25.Text = "Bone Transform";
			// 
			// tabPageMeshView
			// 
			this.tabPageMeshView.Controls.Add(this.comboBoxRendererRootBone);
			this.tabPageMeshView.Controls.Add(this.label16);
			this.tabPageMeshView.Controls.Add(this.label19);
			this.tabPageMeshView.Controls.Add(this.checkBoxRendererEnabled);
			this.tabPageMeshView.Controls.Add(this.comboBoxMeshRendererMesh);
			this.tabPageMeshView.Controls.Add(this.label27);
			this.tabPageMeshView.Controls.Add(this.checkBoxMeshNewSkin);
			this.tabPageMeshView.Controls.Add(this.buttonMeshNormals);
			this.tabPageMeshView.Controls.Add(this.buttonSkinnedMeshRendererAttributes);
			this.tabPageMeshView.Controls.Add(this.buttonMeshMinBones);
			this.tabPageMeshView.Controls.Add(this.buttonMeshGotoFrame);
			this.tabPageMeshView.Controls.Add(this.groupBox2);
			this.tabPageMeshView.Controls.Add(this.label1);
			this.tabPageMeshView.Controls.Add(this.buttonMeshRemove);
			this.tabPageMeshView.Controls.Add(this.groupBox1);
			this.tabPageMeshView.Controls.Add(this.textBoxRendererName);
			this.tabPageMeshView.Location = new System.Drawing.Point(4, 22);
			this.tabPageMeshView.Name = "tabPageMeshView";
			this.tabPageMeshView.Size = new System.Drawing.Size(252, 509);
			this.tabPageMeshView.TabIndex = 0;
			this.tabPageMeshView.Text = "Mesh";
			this.tabPageMeshView.UseVisualStyleBackColor = true;
			// 
			// comboBoxRendererRootBone
			// 
			this.comboBoxRendererRootBone.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxRendererRootBone.DropDownWidth = 160;
			this.comboBoxRendererRootBone.Location = new System.Drawing.Point(145, 58);
			this.comboBoxRendererRootBone.Name = "comboBoxRendererRootBone";
			this.comboBoxRendererRootBone.Size = new System.Drawing.Size(104, 21);
			this.comboBoxRendererRootBone.TabIndex = 14;
			this.comboBoxRendererRootBone.SelectedIndexChanged += new System.EventHandler(this.comboBoxRendererRootBone_SelectedIndexChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(143, 42);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(58, 13);
			this.label16.TabIndex = 263;
			this.label16.Text = "Root Bone";
			// 
			// checkBoxRendererEnabled
			// 
			this.checkBoxRendererEnabled.AutoCheck = false;
			this.checkBoxRendererEnabled.AutoSize = true;
			this.checkBoxRendererEnabled.Enabled = false;
			this.checkBoxRendererEnabled.Location = new System.Drawing.Point(218, 23);
			this.checkBoxRendererEnabled.Name = "checkBoxRendererEnabled";
			this.checkBoxRendererEnabled.Size = new System.Drawing.Size(15, 14);
			this.checkBoxRendererEnabled.TabIndex = 5;
			this.checkBoxRendererEnabled.TabStop = false;
			this.checkBoxRendererEnabled.UseVisualStyleBackColor = true;
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(201, 4);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(46, 13);
			this.label27.TabIndex = 157;
			this.label27.Text = "Enabled";
			// 
			// checkBoxMeshNewSkin
			// 
			this.checkBoxMeshNewSkin.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxMeshNewSkin.Enabled = false;
			this.checkBoxMeshNewSkin.Location = new System.Drawing.Point(174, 216);
			this.checkBoxMeshNewSkin.Name = "checkBoxMeshNewSkin";
			this.checkBoxMeshNewSkin.Size = new System.Drawing.Size(73, 23);
			this.checkBoxMeshNewSkin.TabIndex = 50;
			this.checkBoxMeshNewSkin.Text = "New Skin";
			this.checkBoxMeshNewSkin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxMeshNewSkin.UseVisualStyleBackColor = true;
			// 
			// buttonSkinnedMeshRendererAttributes
			// 
			this.buttonSkinnedMeshRendererAttributes.Location = new System.Drawing.Point(5, 216);
			this.buttonSkinnedMeshRendererAttributes.Name = "buttonSkinnedMeshRendererAttributes";
			this.buttonSkinnedMeshRendererAttributes.Size = new System.Drawing.Size(73, 23);
			this.buttonSkinnedMeshRendererAttributes.TabIndex = 42;
			this.buttonSkinnedMeshRendererAttributes.Text = "Attributes";
			this.buttonSkinnedMeshRendererAttributes.UseVisualStyleBackColor = true;
			this.buttonSkinnedMeshRendererAttributes.Click += new System.EventHandler(this.buttonSkinnedMeshRendererAttributes_Click);
			// 
			// buttonMeshMinBones
			// 
			this.buttonMeshMinBones.Enabled = false;
			this.buttonMeshMinBones.Location = new System.Drawing.Point(174, 187);
			this.buttonMeshMinBones.Name = "buttonMeshMinBones";
			this.buttonMeshMinBones.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshMinBones.TabIndex = 40;
			this.buttonMeshMinBones.Text = "Min Bones";
			this.buttonMeshMinBones.UseVisualStyleBackColor = true;
			// 
			// buttonMeshGotoFrame
			// 
			this.buttonMeshGotoFrame.Location = new System.Drawing.Point(5, 187);
			this.buttonMeshGotoFrame.Name = "buttonMeshGotoFrame";
			this.buttonMeshGotoFrame.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshGotoFrame.TabIndex = 30;
			this.buttonMeshGotoFrame.Text = "Goto Frame";
			this.buttonMeshGotoFrame.UseVisualStyleBackColor = true;
			this.buttonMeshGotoFrame.Click += new System.EventHandler(this.buttonMeshGotoFrame_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label28);
			this.groupBox2.Controls.Add(this.comboBoxMeshExportFormat);
			this.groupBox2.Controls.Add(this.buttonMeshExport);
			this.groupBox2.Controls.Add(this.panelMeshExportOptionsDefault);
			this.groupBox2.Controls.Add(this.panelMeshExportOptionsDirectX);
			this.groupBox2.Controls.Add(this.panelMeshExportOptionsCollada);
			this.groupBox2.Controls.Add(this.panelMeshExportOptionsMqo);
			this.groupBox2.Controls.Add(this.panelMeshExportOptionsFbx);
			this.groupBox2.Location = new System.Drawing.Point(0, 85);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(253, 90);
			this.groupBox2.TabIndex = 20;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Export Options";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(2, 19);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(39, 13);
			this.label28.TabIndex = 131;
			this.label28.Text = "Format";
			// 
			// comboBoxMeshExportFormat
			// 
			this.comboBoxMeshExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMeshExportFormat.Location = new System.Drawing.Point(42, 15);
			this.comboBoxMeshExportFormat.Name = "comboBoxMeshExportFormat";
			this.comboBoxMeshExportFormat.Size = new System.Drawing.Size(126, 21);
			this.comboBoxMeshExportFormat.TabIndex = 22;
			this.comboBoxMeshExportFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxMeshExportFormat_SelectedIndexChanged);
			// 
			// buttonMeshExport
			// 
			this.buttonMeshExport.Location = new System.Drawing.Point(175, 14);
			this.buttonMeshExport.Name = "buttonMeshExport";
			this.buttonMeshExport.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshExport.TabIndex = 24;
			this.buttonMeshExport.Text = "Export";
			this.buttonMeshExport.UseVisualStyleBackColor = true;
			this.buttonMeshExport.Click += new System.EventHandler(this.buttonMeshExport_Click);
			// 
			// panelMeshExportOptionsDefault
			// 
			this.panelMeshExportOptionsDefault.Location = new System.Drawing.Point(3, 40);
			this.panelMeshExportOptionsDefault.Name = "panelMeshExportOptionsDefault";
			this.panelMeshExportOptionsDefault.Size = new System.Drawing.Size(246, 47);
			this.panelMeshExportOptionsDefault.TabIndex = 26;
			// 
			// panelMeshExportOptionsDirectX
			// 
			this.panelMeshExportOptionsDirectX.Controls.Add(this.numericMeshExportDirectXTicksPerSecond);
			this.panelMeshExportOptionsDirectX.Controls.Add(this.numericMeshExportDirectXKeyframeLength);
			this.panelMeshExportOptionsDirectX.Controls.Add(this.label35);
			this.panelMeshExportOptionsDirectX.Controls.Add(this.label34);
			this.panelMeshExportOptionsDirectX.Location = new System.Drawing.Point(3, 40);
			this.panelMeshExportOptionsDirectX.Name = "panelMeshExportOptionsDirectX";
			this.panelMeshExportOptionsDirectX.Size = new System.Drawing.Size(246, 47);
			this.panelMeshExportOptionsDirectX.TabIndex = 200;
			// 
			// numericMeshExportDirectXTicksPerSecond
			// 
			this.numericMeshExportDirectXTicksPerSecond.Location = new System.Drawing.Point(60, 1);
			this.numericMeshExportDirectXTicksPerSecond.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericMeshExportDirectXTicksPerSecond.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMeshExportDirectXTicksPerSecond.Name = "numericMeshExportDirectXTicksPerSecond";
			this.numericMeshExportDirectXTicksPerSecond.Size = new System.Drawing.Size(45, 20);
			this.numericMeshExportDirectXTicksPerSecond.TabIndex = 202;
			this.numericMeshExportDirectXTicksPerSecond.TabStop = false;
			this.numericMeshExportDirectXTicksPerSecond.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// numericMeshExportDirectXKeyframeLength
			// 
			this.numericMeshExportDirectXKeyframeLength.Location = new System.Drawing.Point(199, 1);
			this.numericMeshExportDirectXKeyframeLength.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
			this.numericMeshExportDirectXKeyframeLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.numericMeshExportDirectXKeyframeLength.Name = "numericMeshExportDirectXKeyframeLength";
			this.numericMeshExportDirectXKeyframeLength.Size = new System.Drawing.Size(45, 20);
			this.numericMeshExportDirectXKeyframeLength.TabIndex = 202;
			this.numericMeshExportDirectXKeyframeLength.TabStop = false;
			this.numericMeshExportDirectXKeyframeLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(110, 5);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(87, 13);
			this.label35.TabIndex = 99;
			this.label35.Text = "Keyframe Length";
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(1, 5);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(57, 13);
			this.label34.TabIndex = 98;
			this.label34.Text = "Ticks/Sec";
			// 
			// panelMeshExportOptionsCollada
			// 
			this.panelMeshExportOptionsCollada.Controls.Add(this.checkBoxMeshExportColladaAllFrames);
			this.panelMeshExportOptionsCollada.Location = new System.Drawing.Point(3, 40);
			this.panelMeshExportOptionsCollada.Name = "panelMeshExportOptionsCollada";
			this.panelMeshExportOptionsCollada.Size = new System.Drawing.Size(246, 47);
			this.panelMeshExportOptionsCollada.TabIndex = 220;
			// 
			// checkBoxMeshExportColladaAllFrames
			// 
			this.checkBoxMeshExportColladaAllFrames.AutoSize = true;
			this.checkBoxMeshExportColladaAllFrames.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportColladaAllFrames.Location = new System.Drawing.Point(37, 2);
			this.checkBoxMeshExportColladaAllFrames.Name = "checkBoxMeshExportColladaAllFrames";
			this.checkBoxMeshExportColladaAllFrames.Size = new System.Drawing.Size(74, 17);
			this.checkBoxMeshExportColladaAllFrames.TabIndex = 222;
			this.checkBoxMeshExportColladaAllFrames.TabStop = false;
			this.checkBoxMeshExportColladaAllFrames.Text = "All Frames";
			this.checkBoxMeshExportColladaAllFrames.UseVisualStyleBackColor = true;
			// 
			// panelMeshExportOptionsMqo
			// 
			this.panelMeshExportOptionsMqo.Controls.Add(this.checkBoxMeshExportMqoSortMeshes);
			this.panelMeshExportOptionsMqo.Controls.Add(this.checkBoxMeshExportMqoSingleFile);
			this.panelMeshExportOptionsMqo.Controls.Add(this.checkBoxMeshExportMqoWorldCoords);
			this.panelMeshExportOptionsMqo.Location = new System.Drawing.Point(3, 40);
			this.panelMeshExportOptionsMqo.Name = "panelMeshExportOptionsMqo";
			this.panelMeshExportOptionsMqo.Size = new System.Drawing.Size(246, 47);
			this.panelMeshExportOptionsMqo.TabIndex = 240;
			// 
			// checkBoxMeshExportMqoSortMeshes
			// 
			this.checkBoxMeshExportMqoSortMeshes.AutoSize = true;
			this.checkBoxMeshExportMqoSortMeshes.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportMqoSortMeshes.Location = new System.Drawing.Point(187, 25);
			this.checkBoxMeshExportMqoSortMeshes.Name = "checkBoxMeshExportMqoSortMeshes";
			this.checkBoxMeshExportMqoSortMeshes.Size = new System.Drawing.Size(57, 17);
			this.checkBoxMeshExportMqoSortMeshes.TabIndex = 246;
			this.checkBoxMeshExportMqoSortMeshes.TabStop = false;
			this.checkBoxMeshExportMqoSortMeshes.Text = "Sorted";
			this.checkBoxMeshExportMqoSortMeshes.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeshExportMqoSingleFile
			// 
			this.checkBoxMeshExportMqoSingleFile.AutoSize = true;
			this.checkBoxMeshExportMqoSingleFile.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportMqoSingleFile.Checked = true;
			this.checkBoxMeshExportMqoSingleFile.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMeshExportMqoSingleFile.Location = new System.Drawing.Point(37, 2);
			this.checkBoxMeshExportMqoSingleFile.Name = "checkBoxMeshExportMqoSingleFile";
			this.checkBoxMeshExportMqoSingleFile.Size = new System.Drawing.Size(79, 17);
			this.checkBoxMeshExportMqoSingleFile.TabIndex = 242;
			this.checkBoxMeshExportMqoSingleFile.TabStop = false;
			this.checkBoxMeshExportMqoSingleFile.Text = "Single Mqo";
			this.checkBoxMeshExportMqoSingleFile.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeshExportMqoWorldCoords
			// 
			this.checkBoxMeshExportMqoWorldCoords.AutoSize = true;
			this.checkBoxMeshExportMqoWorldCoords.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportMqoWorldCoords.Location = new System.Drawing.Point(131, 2);
			this.checkBoxMeshExportMqoWorldCoords.Name = "checkBoxMeshExportMqoWorldCoords";
			this.checkBoxMeshExportMqoWorldCoords.Size = new System.Drawing.Size(113, 17);
			this.checkBoxMeshExportMqoWorldCoords.TabIndex = 244;
			this.checkBoxMeshExportMqoWorldCoords.TabStop = false;
			this.checkBoxMeshExportMqoWorldCoords.Text = "World Coordinates";
			this.checkBoxMeshExportMqoWorldCoords.UseVisualStyleBackColor = true;
			// 
			// panelMeshExportOptionsFbx
			// 
			this.panelMeshExportOptionsFbx.Controls.Add(this.checkBoxMeshExportFbxLinearInterpolation);
			this.panelMeshExportOptionsFbx.Controls.Add(this.checkBoxMeshExportNoMesh);
			this.panelMeshExportOptionsFbx.Controls.Add(this.checkBoxMeshExportAllBones);
			this.panelMeshExportOptionsFbx.Controls.Add(this.checkBoxMeshExportFbxSkins);
			this.panelMeshExportOptionsFbx.Controls.Add(this.label13);
			this.panelMeshExportOptionsFbx.Controls.Add(this.textBoxKeyframeRange);
			this.panelMeshExportOptionsFbx.Controls.Add(this.checkBoxMeshExportFbxAllFrames);
			this.panelMeshExportOptionsFbx.Location = new System.Drawing.Point(3, 40);
			this.panelMeshExportOptionsFbx.Name = "panelMeshExportOptionsFbx";
			this.panelMeshExportOptionsFbx.Size = new System.Drawing.Size(246, 47);
			this.panelMeshExportOptionsFbx.TabIndex = 260;
			// 
			// checkBoxMeshExportFbxLinearInterpolation
			// 
			this.checkBoxMeshExportFbxLinearInterpolation.AutoSize = true;
			this.checkBoxMeshExportFbxLinearInterpolation.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportFbxLinearInterpolation.Checked = true;
			this.checkBoxMeshExportFbxLinearInterpolation.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMeshExportFbxLinearInterpolation.Enabled = false;
			this.checkBoxMeshExportFbxLinearInterpolation.Location = new System.Drawing.Point(185, 25);
			this.checkBoxMeshExportFbxLinearInterpolation.Name = "checkBoxMeshExportFbxLinearInterpolation";
			this.checkBoxMeshExportFbxLinearInterpolation.Size = new System.Drawing.Size(55, 17);
			this.checkBoxMeshExportFbxLinearInterpolation.TabIndex = 273;
			this.checkBoxMeshExportFbxLinearInterpolation.TabStop = false;
			this.checkBoxMeshExportFbxLinearInterpolation.Text = "Linear";
			this.checkBoxMeshExportFbxLinearInterpolation.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeshExportNoMesh
			// 
			this.checkBoxMeshExportNoMesh.AutoSize = true;
			this.checkBoxMeshExportNoMesh.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportNoMesh.Location = new System.Drawing.Point(-2, 25);
			this.checkBoxMeshExportNoMesh.Name = "checkBoxMeshExportNoMesh";
			this.checkBoxMeshExportNoMesh.Size = new System.Drawing.Size(69, 17);
			this.checkBoxMeshExportNoMesh.TabIndex = 272;
			this.checkBoxMeshExportNoMesh.TabStop = false;
			this.checkBoxMeshExportNoMesh.Text = "No Mesh";
			this.checkBoxMeshExportNoMesh.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeshExportAllBones
			// 
			this.checkBoxMeshExportAllBones.AutoSize = true;
			this.checkBoxMeshExportAllBones.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportAllBones.Checked = true;
			this.checkBoxMeshExportAllBones.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMeshExportAllBones.Location = new System.Drawing.Point(149, 2);
			this.checkBoxMeshExportAllBones.Name = "checkBoxMeshExportAllBones";
			this.checkBoxMeshExportAllBones.Size = new System.Drawing.Size(70, 17);
			this.checkBoxMeshExportAllBones.TabIndex = 266;
			this.checkBoxMeshExportAllBones.TabStop = false;
			this.checkBoxMeshExportAllBones.Text = "All Bones";
			this.checkBoxMeshExportAllBones.UseVisualStyleBackColor = true;
			// 
			// checkBoxMeshExportFbxSkins
			// 
			this.checkBoxMeshExportFbxSkins.AutoSize = true;
			this.checkBoxMeshExportFbxSkins.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportFbxSkins.Checked = true;
			this.checkBoxMeshExportFbxSkins.CheckState = System.Windows.Forms.CheckState.Checked;
			this.checkBoxMeshExportFbxSkins.Location = new System.Drawing.Point(84, 2);
			this.checkBoxMeshExportFbxSkins.Name = "checkBoxMeshExportFbxSkins";
			this.checkBoxMeshExportFbxSkins.Size = new System.Drawing.Size(52, 17);
			this.checkBoxMeshExportFbxSkins.TabIndex = 264;
			this.checkBoxMeshExportFbxSkins.TabStop = false;
			this.checkBoxMeshExportFbxSkins.Text = "Skins";
			this.checkBoxMeshExportFbxSkins.UseVisualStyleBackColor = true;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(75, 26);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(56, 13);
			this.label13.TabIndex = 268;
			this.label13.Text = "Keyframes";
			// 
			// checkBoxMeshExportFbxAllFrames
			// 
			this.checkBoxMeshExportFbxAllFrames.AutoSize = true;
			this.checkBoxMeshExportFbxAllFrames.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxMeshExportFbxAllFrames.Location = new System.Drawing.Point(-2, 2);
			this.checkBoxMeshExportFbxAllFrames.Name = "checkBoxMeshExportFbxAllFrames";
			this.checkBoxMeshExportFbxAllFrames.Size = new System.Drawing.Size(74, 17);
			this.checkBoxMeshExportFbxAllFrames.TabIndex = 262;
			this.checkBoxMeshExportFbxAllFrames.TabStop = false;
			this.checkBoxMeshExportFbxAllFrames.Text = "All Frames";
			this.checkBoxMeshExportFbxAllFrames.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-2, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(82, 13);
			this.label1.TabIndex = 123;
			this.label1.Text = "Renderer Name";
			// 
			// buttonMeshRemove
			// 
			this.buttonMeshRemove.Location = new System.Drawing.Point(90, 187);
			this.buttonMeshRemove.Name = "buttonMeshRemove";
			this.buttonMeshRemove.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshRemove.TabIndex = 35;
			this.buttonMeshRemove.Text = "Remove";
			this.buttonMeshRemove.UseVisualStyleBackColor = true;
			this.buttonMeshRemove.Click += new System.EventHandler(this.buttonMeshRemove_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label24);
			this.groupBox1.Controls.Add(this.editTextBoxMeshRootBone);
			this.groupBox1.Controls.Add(this.label26);
			this.groupBox1.Controls.Add(this.buttonMeshRestPose);
			this.groupBox1.Controls.Add(this.editTextBoxMeshName);
			this.groupBox1.Controls.Add(this.label15);
			this.groupBox1.Controls.Add(this.buttonMeshSnapBorders);
			this.groupBox1.Controls.Add(this.dataGridViewMesh);
			this.groupBox1.Controls.Add(this.buttonMeshSubmeshRemove);
			this.groupBox1.Controls.Add(this.checkBoxMeshMultiPass);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Location = new System.Drawing.Point(0, 250);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(253, 238);
			this.groupBox1.TabIndex = 140;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Mesh";
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(146, 15);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(92, 13);
			this.label24.TabIndex = 264;
			this.label24.Text = "Root Bone (Hash)";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(1, 16);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(64, 13);
			this.label26.TabIndex = 155;
			this.label26.Text = "Mesh Name";
			// 
			// buttonMeshRestPose
			// 
			this.buttonMeshRestPose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonMeshRestPose.Enabled = false;
			this.buttonMeshRestPose.Location = new System.Drawing.Point(175, 207);
			this.buttonMeshRestPose.Name = "buttonMeshRestPose";
			this.buttonMeshRestPose.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshRestPose.TabIndex = 168;
			this.buttonMeshRestPose.Text = "Rest Pose";
			this.buttonMeshRestPose.UseVisualStyleBackColor = true;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(1, 54);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(62, 13);
			this.label15.TabIndex = 153;
			this.label15.Text = "Submeshes";
			// 
			// buttonMeshSnapBorders
			// 
			this.buttonMeshSnapBorders.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonMeshSnapBorders.Enabled = false;
			this.buttonMeshSnapBorders.Location = new System.Drawing.Point(85, 207);
			this.buttonMeshSnapBorders.Name = "buttonMeshSnapBorders";
			this.buttonMeshSnapBorders.Size = new System.Drawing.Size(84, 23);
			this.buttonMeshSnapBorders.TabIndex = 164;
			this.buttonMeshSnapBorders.Text = "Snap Borders";
			this.buttonMeshSnapBorders.UseVisualStyleBackColor = true;
			// 
			// dataGridViewMesh
			// 
			this.dataGridViewMesh.AllowUserToAddRows = false;
			this.dataGridViewMesh.AllowUserToDeleteRows = false;
			this.dataGridViewMesh.AllowUserToResizeRows = false;
			this.dataGridViewMesh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewMesh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewMesh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSubmeshVerts,
            this.ColumnSubmeshFaces,
            this.ColumnSubmeshMaterial,
            this.Topology});
			this.dataGridViewMesh.Location = new System.Drawing.Point(3, 70);
			this.dataGridViewMesh.Name = "dataGridViewMesh";
			this.dataGridViewMesh.RowHeadersVisible = false;
			this.dataGridViewMesh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dataGridViewMesh.Size = new System.Drawing.Size(246, 108);
			this.dataGridViewMesh.TabIndex = 158;
			this.dataGridViewMesh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMesh_CellClick);
			this.dataGridViewMesh.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewMesh_EditingControlShowing);
			this.dataGridViewMesh.SelectionChanged += new System.EventHandler(this.dataGridViewMesh_SelectionChanged);
			this.dataGridViewMesh.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewMesh_KeyDown);
			// 
			// ColumnSubmeshVerts
			// 
			this.ColumnSubmeshVerts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.ColumnSubmeshVerts.HeaderText = "Verts";
			this.ColumnSubmeshVerts.MinimumWidth = 40;
			this.ColumnSubmeshVerts.Name = "ColumnSubmeshVerts";
			this.ColumnSubmeshVerts.ReadOnly = true;
			this.ColumnSubmeshVerts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnSubmeshVerts.Width = 40;
			// 
			// ColumnSubmeshFaces
			// 
			this.ColumnSubmeshFaces.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
			this.ColumnSubmeshFaces.HeaderText = "Faces";
			this.ColumnSubmeshFaces.MinimumWidth = 40;
			this.ColumnSubmeshFaces.Name = "ColumnSubmeshFaces";
			this.ColumnSubmeshFaces.ReadOnly = true;
			this.ColumnSubmeshFaces.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			this.ColumnSubmeshFaces.Width = 42;
			// 
			// ColumnSubmeshMaterial
			// 
			this.ColumnSubmeshMaterial.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ColumnSubmeshMaterial.DropDownWidth = 200;
			this.ColumnSubmeshMaterial.FillWeight = 500F;
			this.ColumnSubmeshMaterial.HeaderText = "PathID Material";
			this.ColumnSubmeshMaterial.Name = "ColumnSubmeshMaterial";
			// 
			// Topology
			// 
			this.Topology.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Topology.FillWeight = 5F;
			this.Topology.HeaderText = "Topology";
			this.Topology.Name = "Topology";
			this.Topology.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			// 
			// buttonMeshSubmeshRemove
			// 
			this.buttonMeshSubmeshRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.buttonMeshSubmeshRemove.Location = new System.Drawing.Point(5, 207);
			this.buttonMeshSubmeshRemove.Name = "buttonMeshSubmeshRemove";
			this.buttonMeshSubmeshRemove.Size = new System.Drawing.Size(73, 23);
			this.buttonMeshSubmeshRemove.TabIndex = 162;
			this.buttonMeshSubmeshRemove.TabStop = false;
			this.buttonMeshSubmeshRemove.Text = "Remove";
			this.buttonMeshSubmeshRemove.UseVisualStyleBackColor = true;
			this.buttonMeshSubmeshRemove.Click += new System.EventHandler(this.buttonMeshSubmeshRemove_Click);
			// 
			// checkBoxMeshMultiPass
			// 
			this.checkBoxMeshMultiPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.checkBoxMeshMultiPass.AutoCheck = false;
			this.checkBoxMeshMultiPass.AutoSize = true;
			this.checkBoxMeshMultiPass.Enabled = false;
			this.checkBoxMeshMultiPass.Location = new System.Drawing.Point(60, 184);
			this.checkBoxMeshMultiPass.Name = "checkBoxMeshMultiPass";
			this.checkBoxMeshMultiPass.Size = new System.Drawing.Size(15, 14);
			this.checkBoxMeshMultiPass.TabIndex = 160;
			this.checkBoxMeshMultiPass.TabStop = false;
			this.checkBoxMeshMultiPass.UseVisualStyleBackColor = true;
			// 
			// tabPageMorphView
			// 
			this.tabPageMorphView.Controls.Add(this.label45);
			this.tabPageMorphView.Controls.Add(this.label42);
			this.tabPageMorphView.Controls.Add(this.checkBoxMorphTangents);
			this.tabPageMorphView.Controls.Add(this.checkBoxMorphNormals);
			this.tabPageMorphView.Controls.Add(this.label40);
			this.tabPageMorphView.Controls.Add(this.buttonMorphDeleteRef);
			this.tabPageMorphView.Controls.Add(this.buttonMorphRefDown);
			this.tabPageMorphView.Controls.Add(this.buttonMorphRefUp);
			this.tabPageMorphView.Controls.Add(this.label39);
			this.tabPageMorphView.Controls.Add(this.groupBox7);
			this.tabPageMorphView.Controls.Add(this.label41);
			this.tabPageMorphView.Controls.Add(this.groupBox11);
			this.tabPageMorphView.Controls.Add(this.editTextBoxMorphKeyframeHash);
			this.tabPageMorphView.Controls.Add(this.editTextBoxMorphWeightRange);
			this.tabPageMorphView.Controls.Add(this.editTextBoxMorphFrameCount);
			this.tabPageMorphView.Controls.Add(this.textBoxMorphFrameIndex);
			this.tabPageMorphView.Controls.Add(this.editTextBoxMorphKeyframe);
			this.tabPageMorphView.Location = new System.Drawing.Point(4, 22);
			this.tabPageMorphView.Name = "tabPageMorphView";
			this.tabPageMorphView.Size = new System.Drawing.Size(252, 509);
			this.tabPageMorphView.TabIndex = 9;
			this.tabPageMorphView.Text = "Morph";
			this.tabPageMorphView.UseVisualStyleBackColor = true;
			// 
			// label45
			// 
			this.label45.AutoSize = true;
			this.label45.Location = new System.Drawing.Point(179, 6);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(32, 13);
			this.label45.TabIndex = 152;
			this.label45.Text = "Hash";
			// 
			// label42
			// 
			this.label42.AutoSize = true;
			this.label42.Location = new System.Drawing.Point(159, 83);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(41, 13);
			this.label42.TabIndex = 150;
			this.label42.Text = "Weight";
			// 
			// checkBoxMorphTangents
			// 
			this.checkBoxMorphTangents.AutoSize = true;
			this.checkBoxMorphTangents.Enabled = false;
			this.checkBoxMorphTangents.Location = new System.Drawing.Point(71, 82);
			this.checkBoxMorphTangents.Name = "checkBoxMorphTangents";
			this.checkBoxMorphTangents.Size = new System.Drawing.Size(71, 17);
			this.checkBoxMorphTangents.TabIndex = 148;
			this.checkBoxMorphTangents.Text = "Tangents";
			this.checkBoxMorphTangents.UseVisualStyleBackColor = true;
			this.checkBoxMorphTangents.CheckedChanged += new System.EventHandler(this.checkBoxMorphTangents_CheckedChanged);
			// 
			// checkBoxMorphNormals
			// 
			this.checkBoxMorphNormals.AutoSize = true;
			this.checkBoxMorphNormals.Enabled = false;
			this.checkBoxMorphNormals.Location = new System.Drawing.Point(1, 82);
			this.checkBoxMorphNormals.Name = "checkBoxMorphNormals";
			this.checkBoxMorphNormals.Size = new System.Drawing.Size(64, 17);
			this.checkBoxMorphNormals.TabIndex = 147;
			this.checkBoxMorphNormals.Text = "Normals";
			this.checkBoxMorphNormals.UseVisualStyleBackColor = true;
			this.checkBoxMorphNormals.CheckedChanged += new System.EventHandler(this.checkBoxMorphNormals_CheckedChanged);
			// 
			// label40
			// 
			this.label40.AutoSize = true;
			this.label40.Location = new System.Drawing.Point(115, 54);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(67, 13);
			this.label40.TabIndex = 146;
			this.label40.Text = "Frame Count";
			// 
			// buttonMorphDeleteRef
			// 
			this.buttonMorphDeleteRef.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonMorphDeleteRef.Enabled = false;
			this.buttonMorphDeleteRef.Location = new System.Drawing.Point(98, 147);
			this.buttonMorphDeleteRef.Name = "buttonMorphDeleteRef";
			this.buttonMorphDeleteRef.Size = new System.Drawing.Size(75, 23);
			this.buttonMorphDeleteRef.TabIndex = 36;
			this.buttonMorphDeleteRef.Text = "Delete";
			this.buttonMorphDeleteRef.UseVisualStyleBackColor = true;
			// 
			// buttonMorphRefDown
			// 
			this.buttonMorphRefDown.Enabled = false;
			this.buttonMorphRefDown.Location = new System.Drawing.Point(5, 147);
			this.buttonMorphRefDown.Name = "buttonMorphRefDown";
			this.buttonMorphRefDown.Size = new System.Drawing.Size(75, 23);
			this.buttonMorphRefDown.TabIndex = 32;
			this.buttonMorphRefDown.Text = "Down";
			this.buttonMorphRefDown.UseVisualStyleBackColor = true;
			// 
			// buttonMorphRefUp
			// 
			this.buttonMorphRefUp.Enabled = false;
			this.buttonMorphRefUp.Location = new System.Drawing.Point(5, 118);
			this.buttonMorphRefUp.Name = "buttonMorphRefUp";
			this.buttonMorphRefUp.Size = new System.Drawing.Size(75, 23);
			this.buttonMorphRefUp.TabIndex = 30;
			this.buttonMorphRefUp.Text = "Up";
			this.buttonMorphRefUp.UseVisualStyleBackColor = true;
			// 
			// label39
			// 
			this.label39.AutoSize = true;
			this.label39.Location = new System.Drawing.Point(-2, 54);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(65, 13);
			this.label39.TabIndex = 129;
			this.label39.Text = "Frame Index";
			// 
			// groupBox7
			// 
			this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox7.Controls.Add(this.groupBox8);
			this.groupBox7.Controls.Add(this.comboBoxMorphExportFormat);
			this.groupBox7.Controls.Add(this.buttonMorphExport);
			this.groupBox7.Controls.Add(this.label43);
			this.groupBox7.Location = new System.Drawing.Point(5, 282);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(244, 123);
			this.groupBox7.TabIndex = 60;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Export Clip Options";
			// 
			// groupBox8
			// 
			this.groupBox8.Controls.Add(this.label46);
			this.groupBox8.Controls.Add(this.checkBoxMorphFbxOptionEmbedMedia);
			this.groupBox8.Controls.Add(this.checkBoxMorphFbxOptionOneBlendshape);
			this.groupBox8.Location = new System.Drawing.Point(7, 46);
			this.groupBox8.Name = "groupBox8";
			this.groupBox8.Size = new System.Drawing.Size(231, 70);
			this.groupBox8.TabIndex = 143;
			this.groupBox8.TabStop = false;
			this.groupBox8.Text = "Fbx Options";
			// 
			// label46
			// 
			this.label46.AutoSize = true;
			this.label46.Location = new System.Drawing.Point(7, 39);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(179, 26);
			this.label46.TabIndex = 67;
			this.label46.Text = "Fbx exports include Morph Clips from\r\nall selected Meshes of this Animator";
			// 
			// comboBoxMorphExportFormat
			// 
			this.comboBoxMorphExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMorphExportFormat.FormattingEnabled = true;
			this.comboBoxMorphExportFormat.Location = new System.Drawing.Point(42, 19);
			this.comboBoxMorphExportFormat.Name = "comboBoxMorphExportFormat";
			this.comboBoxMorphExportFormat.Size = new System.Drawing.Size(121, 21);
			this.comboBoxMorphExportFormat.TabIndex = 62;
			// 
			// label43
			// 
			this.label43.AutoSize = true;
			this.label43.Location = new System.Drawing.Point(3, 22);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(39, 13);
			this.label43.TabIndex = 125;
			this.label43.Text = "Format";
			// 
			// label41
			// 
			this.label41.AutoSize = true;
			this.label41.Location = new System.Drawing.Point(-2, 6);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(141, 13);
			this.label41.TabIndex = 138;
			this.label41.Text = "Morph Clip . Keyframe Name";
			// 
			// groupBox11
			// 
			this.groupBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox11.Controls.Add(this.checkBoxMorphEndKeyframe);
			this.groupBox11.Controls.Add(this.checkBoxMorphStartKeyframe);
			this.groupBox11.Controls.Add(this.trackBarMorphFactor);
			this.groupBox11.Location = new System.Drawing.Point(5, 184);
			this.groupBox11.Name = "groupBox11";
			this.groupBox11.Size = new System.Drawing.Size(244, 77);
			this.groupBox11.TabIndex = 50;
			this.groupBox11.TabStop = false;
			this.groupBox11.Text = "Morph Keyrame Preview";
			// 
			// checkBoxMorphEndKeyframe
			// 
			this.checkBoxMorphEndKeyframe.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxMorphEndKeyframe.Location = new System.Drawing.Point(123, 21);
			this.checkBoxMorphEndKeyframe.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxMorphEndKeyframe.Name = "checkBoxMorphEndKeyframe";
			this.checkBoxMorphEndKeyframe.Size = new System.Drawing.Size(118, 23);
			this.checkBoxMorphEndKeyframe.TabIndex = 136;
			this.checkBoxMorphEndKeyframe.Text = "End";
			this.checkBoxMorphEndKeyframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxMorphEndKeyframe.UseVisualStyleBackColor = true;
			this.checkBoxMorphEndKeyframe.Click += new System.EventHandler(this.checkBoxStartEndKeyframe_Click);
			// 
			// checkBoxMorphStartKeyframe
			// 
			this.checkBoxMorphStartKeyframe.Appearance = System.Windows.Forms.Appearance.Button;
			this.checkBoxMorphStartKeyframe.Location = new System.Drawing.Point(3, 21);
			this.checkBoxMorphStartKeyframe.Margin = new System.Windows.Forms.Padding(0);
			this.checkBoxMorphStartKeyframe.Name = "checkBoxMorphStartKeyframe";
			this.checkBoxMorphStartKeyframe.Size = new System.Drawing.Size(118, 23);
			this.checkBoxMorphStartKeyframe.TabIndex = 135;
			this.checkBoxMorphStartKeyframe.Text = "Start";
			this.checkBoxMorphStartKeyframe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.checkBoxMorphStartKeyframe.UseVisualStyleBackColor = true;
			this.checkBoxMorphStartKeyframe.Click += new System.EventHandler(this.checkBoxStartEndKeyframe_Click);
			// 
			// trackBarMorphFactor
			// 
			this.trackBarMorphFactor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.trackBarMorphFactor.AutoSize = false;
			this.trackBarMorphFactor.Location = new System.Drawing.Point(6, 53);
			this.trackBarMorphFactor.Maximum = 25;
			this.trackBarMorphFactor.Name = "trackBarMorphFactor";
			this.trackBarMorphFactor.Size = new System.Drawing.Size(232, 18);
			this.trackBarMorphFactor.TabIndex = 52;
			this.trackBarMorphFactor.TickStyle = System.Windows.Forms.TickStyle.None;
			this.trackBarMorphFactor.ValueChanged += new System.EventHandler(this.trackBarMorphFactor_ValueChanged);
			// 
			// tabPageMaterialView
			// 
			this.tabPageMaterialView.Controls.Add(this.editTextBoxMatShader);
			this.tabPageMaterialView.Controls.Add(this.labelMatTex4);
			this.tabPageMaterialView.Controls.Add(this.labelMatTex3);
			this.tabPageMaterialView.Controls.Add(this.labelMatTex2);
			this.tabPageMaterialView.Controls.Add(this.labelMatTex1);
			this.tabPageMaterialView.Controls.Add(this.labelExtra);
			this.tabPageMaterialView.Controls.Add(this.labelOutline);
			this.tabPageMaterialView.Controls.Add(this.labelRimPower);
			this.tabPageMaterialView.Controls.Add(this.label30);
			this.tabPageMaterialView.Controls.Add(this.comboBoxMatShaderKeywords);
			this.tabPageMaterialView.Controls.Add(this.label29);
			this.tabPageMaterialView.Controls.Add(this.comboBoxMatTex4);
			this.tabPageMaterialView.Controls.Add(this.comboBoxMatTex3);
			this.tabPageMaterialView.Controls.Add(this.comboBoxMatTex2);
			this.tabPageMaterialView.Controls.Add(this.comboBoxMatTex1);
			this.tabPageMaterialView.Controls.Add(this.buttonMaterialRemove);
			this.tabPageMaterialView.Controls.Add(this.buttonMaterialCopy);
			this.tabPageMaterialView.Controls.Add(this.label17);
			this.tabPageMaterialView.Controls.Add(this.label23);
			this.tabPageMaterialView.Controls.Add(this.label11);
			this.tabPageMaterialView.Controls.Add(this.label10);
			this.tabPageMaterialView.Controls.Add(this.label7);
			this.tabPageMaterialView.Controls.Add(this.label2);
			this.tabPageMaterialView.Controls.Add(this.labelShininess);
			this.tabPageMaterialView.Controls.Add(this.labelShadow);
			this.tabPageMaterialView.Controls.Add(this.labelOutlineColour);
			this.tabPageMaterialView.Controls.Add(this.labelRim);
			this.tabPageMaterialView.Controls.Add(this.labelEmissive);
			this.tabPageMaterialView.Controls.Add(this.labelSpecular);
			this.tabPageMaterialView.Controls.Add(this.labelAmbient);
			this.tabPageMaterialView.Controls.Add(this.labelDiffuse);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatExtra);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatShadowA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatShadowB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatShadowG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatShadowR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatOutlineA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatOutlineB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatOutlineG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatOutlineR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatRimA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatRimB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatRimG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatRimR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatOutline);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatRimPower);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatSpecularPower);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatEmissiveA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatEmissiveB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatEmissiveG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatEmissiveR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatSpecularA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatSpecularB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatSpecularG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatSpecularR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatAmbientA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatAmbientB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatAmbientG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatAmbientR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatDiffuseA);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatDiffuseB);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatDiffuseG);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatDiffuseR);
			this.tabPageMaterialView.Controls.Add(this.textBoxMatName);
			this.tabPageMaterialView.Location = new System.Drawing.Point(4, 22);
			this.tabPageMaterialView.Name = "tabPageMaterialView";
			this.tabPageMaterialView.Size = new System.Drawing.Size(252, 509);
			this.tabPageMaterialView.TabIndex = 1;
			this.tabPageMaterialView.Text = "Material";
			this.tabPageMaterialView.UseVisualStyleBackColor = true;
			// 
			// labelMatTex4
			// 
			this.labelMatTex4.AutoSize = true;
			this.labelMatTex4.Location = new System.Drawing.Point(5, 177);
			this.labelMatTex4.Name = "labelMatTex4";
			this.labelMatTex4.Size = new System.Drawing.Size(13, 13);
			this.labelMatTex4.TabIndex = 16;
			this.labelMatTex4.Text = "_";
			// 
			// labelMatTex3
			// 
			this.labelMatTex3.AutoSize = true;
			this.labelMatTex3.Location = new System.Drawing.Point(5, 154);
			this.labelMatTex3.Name = "labelMatTex3";
			this.labelMatTex3.Size = new System.Drawing.Size(41, 13);
			this.labelMatTex3.TabIndex = 14;
			this.labelMatTex3.Text = "_Ramp";
			// 
			// labelMatTex2
			// 
			this.labelMatTex2.AutoSize = true;
			this.labelMatTex2.Location = new System.Drawing.Point(5, 131);
			this.labelMatTex2.Name = "labelMatTex2";
			this.labelMatTex2.Size = new System.Drawing.Size(61, 13);
			this.labelMatTex2.TabIndex = 12;
			this.labelMatTex2.Text = "_BumpMap";
			// 
			// labelMatTex1
			// 
			this.labelMatTex1.AutoSize = true;
			this.labelMatTex1.Location = new System.Drawing.Point(5, 108);
			this.labelMatTex1.Name = "labelMatTex1";
			this.labelMatTex1.Size = new System.Drawing.Size(54, 13);
			this.labelMatTex1.TabIndex = 10;
			this.labelMatTex1.Text = "_MainTex";
			// 
			// labelExtra
			// 
			this.labelExtra.AutoSize = true;
			this.labelExtra.Location = new System.Drawing.Point(197, 389);
			this.labelExtra.Name = "labelExtra";
			this.labelExtra.Size = new System.Drawing.Size(13, 13);
			this.labelExtra.TabIndex = 60;
			this.labelExtra.Text = "_";
			// 
			// labelOutline
			// 
			this.labelOutline.AutoSize = true;
			this.labelOutline.Location = new System.Drawing.Point(132, 390);
			this.labelOutline.Name = "labelOutline";
			this.labelOutline.Size = new System.Drawing.Size(40, 13);
			this.labelOutline.TabIndex = 60;
			this.labelOutline.Text = "Outline";
			// 
			// labelRimPower
			// 
			this.labelRimPower.AutoSize = true;
			this.labelRimPower.Location = new System.Drawing.Point(67, 389);
			this.labelRimPower.Name = "labelRimPower";
			this.labelRimPower.Size = new System.Drawing.Size(58, 13);
			this.labelRimPower.TabIndex = 60;
			this.labelRimPower.Text = "Rim Power";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(154, 47);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(90, 13);
			this.label30.TabIndex = 5;
			this.label30.Text = "Shader Keywords";
			// 
			// comboBoxMatShaderKeywords
			// 
			this.comboBoxMatShaderKeywords.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMatShaderKeywords.Location = new System.Drawing.Point(157, 61);
			this.comboBoxMatShaderKeywords.Name = "comboBoxMatShaderKeywords";
			this.comboBoxMatShaderKeywords.Size = new System.Drawing.Size(92, 21);
			this.comboBoxMatShaderKeywords.Sorted = true;
			this.comboBoxMatShaderKeywords.TabIndex = 6;
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(-2, 47);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(69, 13);
			this.label29.TabIndex = 3;
			this.label29.Text = "Shader Used";
			// 
			// comboBoxMatTex4
			// 
			this.comboBoxMatTex4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMatTex4.Location = new System.Drawing.Point(93, 172);
			this.comboBoxMatTex4.Name = "comboBoxMatTex4";
			this.comboBoxMatTex4.Size = new System.Drawing.Size(157, 21);
			this.comboBoxMatTex4.Sorted = true;
			this.comboBoxMatTex4.TabIndex = 16;
			// 
			// comboBoxMatTex3
			// 
			this.comboBoxMatTex3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMatTex3.Location = new System.Drawing.Point(93, 149);
			this.comboBoxMatTex3.Name = "comboBoxMatTex3";
			this.comboBoxMatTex3.Size = new System.Drawing.Size(157, 21);
			this.comboBoxMatTex3.Sorted = true;
			this.comboBoxMatTex3.TabIndex = 14;
			// 
			// comboBoxMatTex2
			// 
			this.comboBoxMatTex2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMatTex2.Location = new System.Drawing.Point(93, 126);
			this.comboBoxMatTex2.Name = "comboBoxMatTex2";
			this.comboBoxMatTex2.Size = new System.Drawing.Size(157, 21);
			this.comboBoxMatTex2.Sorted = true;
			this.comboBoxMatTex2.TabIndex = 12;
			// 
			// comboBoxMatTex1
			// 
			this.comboBoxMatTex1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxMatTex1.Location = new System.Drawing.Point(93, 103);
			this.comboBoxMatTex1.Name = "comboBoxMatTex1";
			this.comboBoxMatTex1.Size = new System.Drawing.Size(157, 21);
			this.comboBoxMatTex1.Sorted = true;
			this.comboBoxMatTex1.TabIndex = 10;
			// 
			// buttonMaterialRemove
			// 
			this.buttonMaterialRemove.Location = new System.Drawing.Point(2, 432);
			this.buttonMaterialRemove.Name = "buttonMaterialRemove";
			this.buttonMaterialRemove.Size = new System.Drawing.Size(75, 23);
			this.buttonMaterialRemove.TabIndex = 80;
			this.buttonMaterialRemove.Text = "Remove";
			this.buttonMaterialRemove.UseVisualStyleBackColor = true;
			this.buttonMaterialRemove.Click += new System.EventHandler(this.buttonMaterialRemove_Click);
			// 
			// buttonMaterialCopy
			// 
			this.buttonMaterialCopy.Location = new System.Drawing.Point(89, 432);
			this.buttonMaterialCopy.Name = "buttonMaterialCopy";
			this.buttonMaterialCopy.Size = new System.Drawing.Size(75, 23);
			this.buttonMaterialCopy.TabIndex = 82;
			this.buttonMaterialCopy.Text = "Copy->New";
			this.buttonMaterialCopy.UseVisualStyleBackColor = true;
			this.buttonMaterialCopy.Click += new System.EventHandler(this.buttonMaterialCopy_Click);
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(-2, 4);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(35, 13);
			this.label17.TabIndex = 1;
			this.label17.Text = "Name";
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(-3, 89);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(76, 13);
			this.label23.TabIndex = 9;
			this.label23.Text = "Textures Used";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(219, 202);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(14, 13);
			this.label11.TabIndex = 20;
			this.label11.Text = "A";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(169, 202);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(14, 13);
			this.label10.TabIndex = 20;
			this.label10.Text = "B";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(119, 202);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(15, 13);
			this.label7.TabIndex = 20;
			this.label7.Text = "G";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(69, 202);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(15, 13);
			this.label2.TabIndex = 20;
			this.label2.Text = "R";
			// 
			// labelShininess
			// 
			this.labelShininess.AutoSize = true;
			this.labelShininess.Location = new System.Drawing.Point(2, 389);
			this.labelShininess.Name = "labelShininess";
			this.labelShininess.Size = new System.Drawing.Size(52, 13);
			this.labelShininess.TabIndex = 60;
			this.labelShininess.Text = "Shininess";
			// 
			// labelShadow
			// 
			this.labelShadow.AutoSize = true;
			this.labelShadow.Location = new System.Drawing.Point(0, 362);
			this.labelShadow.Name = "labelShadow";
			this.labelShadow.Size = new System.Drawing.Size(46, 13);
			this.labelShadow.TabIndex = 21;
			this.labelShadow.Text = "Shadow";
			// 
			// labelOutlineColour
			// 
			this.labelOutlineColour.AutoSize = true;
			this.labelOutlineColour.Location = new System.Drawing.Point(0, 338);
			this.labelOutlineColour.Name = "labelOutlineColour";
			this.labelOutlineColour.Size = new System.Drawing.Size(40, 13);
			this.labelOutlineColour.TabIndex = 21;
			this.labelOutlineColour.Text = "Outline";
			// 
			// labelRim
			// 
			this.labelRim.AutoSize = true;
			this.labelRim.Location = new System.Drawing.Point(0, 314);
			this.labelRim.Name = "labelRim";
			this.labelRim.Size = new System.Drawing.Size(25, 13);
			this.labelRim.TabIndex = 21;
			this.labelRim.Text = "Rim";
			// 
			// labelEmissive
			// 
			this.labelEmissive.AutoSize = true;
			this.labelEmissive.Location = new System.Drawing.Point(0, 291);
			this.labelEmissive.Name = "labelEmissive";
			this.labelEmissive.Size = new System.Drawing.Size(48, 13);
			this.labelEmissive.TabIndex = 21;
			this.labelEmissive.Text = "Emissive";
			// 
			// labelSpecular
			// 
			this.labelSpecular.AutoSize = true;
			this.labelSpecular.Location = new System.Drawing.Point(0, 268);
			this.labelSpecular.Name = "labelSpecular";
			this.labelSpecular.Size = new System.Drawing.Size(49, 13);
			this.labelSpecular.TabIndex = 21;
			this.labelSpecular.Text = "Specular";
			// 
			// labelAmbient
			// 
			this.labelAmbient.AutoSize = true;
			this.labelAmbient.Location = new System.Drawing.Point(0, 243);
			this.labelAmbient.Name = "labelAmbient";
			this.labelAmbient.Size = new System.Drawing.Size(45, 13);
			this.labelAmbient.TabIndex = 21;
			this.labelAmbient.Text = "Ambient";
			// 
			// labelDiffuse
			// 
			this.labelDiffuse.AutoSize = true;
			this.labelDiffuse.Location = new System.Drawing.Point(0, 219);
			this.labelDiffuse.Name = "labelDiffuse";
			this.labelDiffuse.Size = new System.Drawing.Size(40, 13);
			this.labelDiffuse.TabIndex = 21;
			this.labelDiffuse.Text = "Diffuse";
			// 
			// tabPageTextureView
			// 
			this.tabPageTextureView.Controls.Add(this.label37);
			this.tabPageTextureView.Controls.Add(this.label36);
			this.tabPageTextureView.Controls.Add(this.label33);
			this.tabPageTextureView.Controls.Add(this.label32);
			this.tabPageTextureView.Controls.Add(this.label31);
			this.tabPageTextureView.Controls.Add(this.label22);
			this.tabPageTextureView.Controls.Add(this.label21);
			this.tabPageTextureView.Controls.Add(this.label20);
			this.tabPageTextureView.Controls.Add(this.label18);
			this.tabPageTextureView.Controls.Add(this.checkBoxTextureMipMap);
			this.tabPageTextureView.Controls.Add(this.labelTextureFormat);
			this.tabPageTextureView.Controls.Add(this.label14);
			this.tabPageTextureView.Controls.Add(this.buttonTextureAdd);
			this.tabPageTextureView.Controls.Add(this.panelTexturePic);
			this.tabPageTextureView.Controls.Add(this.label3);
			this.tabPageTextureView.Controls.Add(this.buttonTextureExport);
			this.tabPageTextureView.Controls.Add(this.buttonTextureReplace);
			this.tabPageTextureView.Controls.Add(this.buttonTextureRemove);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexDimension);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexLightMap);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexColorSpace);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexWrapMode);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexAniso);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexMipBias);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexFilterMode);
			this.tabPageTextureView.Controls.Add(this.editTextBoxTexImageCount);
			this.tabPageTextureView.Controls.Add(this.textBoxTexSize);
			this.tabPageTextureView.Controls.Add(this.textBoxTexName);
			this.tabPageTextureView.Location = new System.Drawing.Point(4, 22);
			this.tabPageTextureView.Name = "tabPageTextureView";
			this.tabPageTextureView.Size = new System.Drawing.Size(252, 509);
			this.tabPageTextureView.TabIndex = 3;
			this.tabPageTextureView.Text = "Texture";
			this.tabPageTextureView.UseVisualStyleBackColor = true;
			// 
			// label37
			// 
			this.label37.AutoSize = true;
			this.label37.Location = new System.Drawing.Point(170, 62);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(56, 13);
			this.label37.TabIndex = 57;
			this.label37.Text = "Dimension";
			// 
			// label36
			// 
			this.label36.AutoSize = true;
			this.label36.Location = new System.Drawing.Point(175, 115);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(51, 13);
			this.label36.TabIndex = 55;
			this.label36.Text = "LightMap";
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(84, 115);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(62, 13);
			this.label33.TabIndex = 53;
			this.label33.Text = "ColorSpace";
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(193, 142);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(33, 13);
			this.label32.TabIndex = 51;
			this.label32.Text = "Wrap";
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(134, 142);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(33, 13);
			this.label31.TabIndex = 49;
			this.label31.Text = "Aniso";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(58, 142);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(44, 13);
			this.label22.TabIndex = 47;
			this.label22.Text = "MipBias";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(0, 142);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(29, 13);
			this.label21.TabIndex = 45;
			this.label21.Text = "Filter";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(3, 115);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(52, 13);
			this.label20.TabIndex = 3;
			this.label20.Text = "ImgCount";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(170, 88);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(45, 13);
			this.label18.TabIndex = 43;
			this.label18.Text = "MipMap";
			// 
			// checkBoxTextureMipMap
			// 
			this.checkBoxTextureMipMap.AutoSize = true;
			this.checkBoxTextureMipMap.CheckAlign = System.Drawing.ContentAlignment.BottomRight;
			this.checkBoxTextureMipMap.Location = new System.Drawing.Point(230, 88);
			this.checkBoxTextureMipMap.Name = "checkBoxTextureMipMap";
			this.checkBoxTextureMipMap.Size = new System.Drawing.Size(15, 14);
			this.checkBoxTextureMipMap.TabIndex = 42;
			this.checkBoxTextureMipMap.TabStop = false;
			this.checkBoxTextureMipMap.UseVisualStyleBackColor = true;
			this.checkBoxTextureMipMap.CheckedChanged += new System.EventHandler(this.checkBoxTextureMipMap_CheckedChanged);
			// 
			// labelTextureFormat
			// 
			this.labelTextureFormat.AutoSize = true;
			this.labelTextureFormat.Location = new System.Drawing.Point(182, 42);
			this.labelTextureFormat.Name = "labelTextureFormat";
			this.labelTextureFormat.Size = new System.Drawing.Size(39, 13);
			this.labelTextureFormat.TabIndex = 40;
			this.labelTextureFormat.Text = "Format";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(167, 4);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(57, 13);
			this.label14.TabIndex = 39;
			this.label14.Text = "Resolution";
			// 
			// buttonTextureAdd
			// 
			this.buttonTextureAdd.Location = new System.Drawing.Point(2, 83);
			this.buttonTextureAdd.Name = "buttonTextureAdd";
			this.buttonTextureAdd.Size = new System.Drawing.Size(75, 23);
			this.buttonTextureAdd.TabIndex = 30;
			this.buttonTextureAdd.Text = "Add Image";
			this.buttonTextureAdd.UseVisualStyleBackColor = true;
			this.buttonTextureAdd.Click += new System.EventHandler(this.buttonTextureAdd_Click);
			// 
			// panelTexturePic
			// 
			this.panelTexturePic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelTexturePic.Controls.Add(this.pictureBoxTexture);
			this.panelTexturePic.Location = new System.Drawing.Point(0, 165);
			this.panelTexturePic.Name = "panelTexturePic";
			this.panelTexturePic.Size = new System.Drawing.Size(252, 331);
			this.panelTexturePic.TabIndex = 38;
			// 
			// pictureBoxTexture
			// 
			this.pictureBoxTexture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBoxTexture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxTexture.Location = new System.Drawing.Point(0, 0);
			this.pictureBoxTexture.Name = "pictureBoxTexture";
			this.pictureBoxTexture.Size = new System.Drawing.Size(252, 252);
			this.pictureBoxTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBoxTexture.TabIndex = 1;
			this.pictureBoxTexture.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-3, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Name";
			// 
			// buttonTextureExport
			// 
			this.buttonTextureExport.Location = new System.Drawing.Point(2, 49);
			this.buttonTextureExport.Name = "buttonTextureExport";
			this.buttonTextureExport.Size = new System.Drawing.Size(75, 22);
			this.buttonTextureExport.TabIndex = 16;
			this.buttonTextureExport.Text = "Export";
			this.buttonTextureExport.UseVisualStyleBackColor = true;
			this.buttonTextureExport.Click += new System.EventHandler(this.buttonTextureExport_Click);
			// 
			// buttonTextureReplace
			// 
			this.buttonTextureReplace.Location = new System.Drawing.Point(89, 83);
			this.buttonTextureReplace.Name = "buttonTextureReplace";
			this.buttonTextureReplace.Size = new System.Drawing.Size(75, 23);
			this.buttonTextureReplace.TabIndex = 36;
			this.buttonTextureReplace.Text = "Replace";
			this.buttonTextureReplace.UseVisualStyleBackColor = true;
			this.buttonTextureReplace.Click += new System.EventHandler(this.buttonTextureReplace_Click);
			// 
			// buttonTextureRemove
			// 
			this.buttonTextureRemove.Location = new System.Drawing.Point(89, 49);
			this.buttonTextureRemove.Name = "buttonTextureRemove";
			this.buttonTextureRemove.Size = new System.Drawing.Size(75, 22);
			this.buttonTextureRemove.TabIndex = 20;
			this.buttonTextureRemove.Text = "Remove";
			this.buttonTextureRemove.UseVisualStyleBackColor = true;
			this.buttonTextureRemove.Click += new System.EventHandler(this.buttonTextureRemove_Click);
			// 
			// dataGridViewFrameSRT
			// 
			this.dataGridViewFrameSRT.AllowUserToAddRows = false;
			this.dataGridViewFrameSRT.AllowUserToDeleteRows = false;
			this.dataGridViewFrameSRT.AllowUserToResizeColumns = false;
			this.dataGridViewFrameSRT.AllowUserToResizeRows = false;
			this.dataGridViewFrameSRT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewFrameSRT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewFrameSRT.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridViewFrameSRT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewFrameSRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFrameSRT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFrameSRT.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewFrameSRT.Name = "dataGridViewFrameSRT";
			this.dataGridViewFrameSRT.RowHeadersVisible = false;
			this.dataGridViewFrameSRT.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewFrameSRT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewFrameSRT.ShowRowIndex = false;
			this.dataGridViewFrameSRT.Size = new System.Drawing.Size(239, 80);
			this.dataGridViewFrameSRT.TabIndex = 144;
			this.dataGridViewFrameSRT.TabStop = false;
			this.dataGridViewFrameSRT.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSRT_CellValueChanged);
			// 
			// dataGridViewFrameMatrix
			// 
			this.dataGridViewFrameMatrix.AllowUserToAddRows = false;
			this.dataGridViewFrameMatrix.AllowUserToDeleteRows = false;
			this.dataGridViewFrameMatrix.AllowUserToResizeColumns = false;
			this.dataGridViewFrameMatrix.AllowUserToResizeRows = false;
			this.dataGridViewFrameMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewFrameMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewFrameMatrix.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridViewFrameMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewFrameMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFrameMatrix.ColumnHeadersVisible = false;
			this.dataGridViewFrameMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFrameMatrix.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewFrameMatrix.Name = "dataGridViewFrameMatrix";
			this.dataGridViewFrameMatrix.RowHeadersVisible = false;
			this.dataGridViewFrameMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewFrameMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewFrameMatrix.ShowRowIndex = false;
			this.dataGridViewFrameMatrix.Size = new System.Drawing.Size(239, 80);
			this.dataGridViewFrameMatrix.TabIndex = 145;
			this.dataGridViewFrameMatrix.TabStop = false;
			this.dataGridViewFrameMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_CellValueChanged);
			// 
			// textBoxFrameName
			// 
			this.textBoxFrameName.Location = new System.Drawing.Point(0, 19);
			this.textBoxFrameName.Name = "textBoxFrameName";
			this.textBoxFrameName.Size = new System.Drawing.Size(249, 20);
			this.textBoxFrameName.TabIndex = 1;
			this.toolTip1.SetToolTip(this.textBoxFrameName, "Rename Mesh Transforms only!\r\nDont rename any part of the Skeleton!");
			// 
			// dataGridViewBoneSRT
			// 
			this.dataGridViewBoneSRT.AllowUserToAddRows = false;
			this.dataGridViewBoneSRT.AllowUserToDeleteRows = false;
			this.dataGridViewBoneSRT.AllowUserToResizeColumns = false;
			this.dataGridViewBoneSRT.AllowUserToResizeRows = false;
			this.dataGridViewBoneSRT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewBoneSRT.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewBoneSRT.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridViewBoneSRT.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewBoneSRT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBoneSRT.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewBoneSRT.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewBoneSRT.Name = "dataGridViewBoneSRT";
			this.dataGridViewBoneSRT.RowHeadersVisible = false;
			this.dataGridViewBoneSRT.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewBoneSRT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewBoneSRT.ShowRowIndex = false;
			this.dataGridViewBoneSRT.Size = new System.Drawing.Size(239, 80);
			this.dataGridViewBoneSRT.TabIndex = 42;
			this.dataGridViewBoneSRT.TabStop = false;
			this.dataGridViewBoneSRT.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSRT_CellValueChanged);
			// 
			// dataGridViewBoneMatrix
			// 
			this.dataGridViewBoneMatrix.AllowUserToAddRows = false;
			this.dataGridViewBoneMatrix.AllowUserToDeleteRows = false;
			this.dataGridViewBoneMatrix.AllowUserToResizeColumns = false;
			this.dataGridViewBoneMatrix.AllowUserToResizeRows = false;
			this.dataGridViewBoneMatrix.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewBoneMatrix.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.dataGridViewBoneMatrix.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
			this.dataGridViewBoneMatrix.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridViewBoneMatrix.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewBoneMatrix.ColumnHeadersVisible = false;
			this.dataGridViewBoneMatrix.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewBoneMatrix.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewBoneMatrix.Name = "dataGridViewBoneMatrix";
			this.dataGridViewBoneMatrix.RowHeadersVisible = false;
			this.dataGridViewBoneMatrix.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dataGridViewBoneMatrix.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridViewBoneMatrix.ShowRowIndex = false;
			this.dataGridViewBoneMatrix.Size = new System.Drawing.Size(239, 80);
			this.dataGridViewBoneMatrix.TabIndex = 44;
			this.dataGridViewBoneMatrix.TabStop = false;
			this.dataGridViewBoneMatrix.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMatrix_CellValueChanged);
			// 
			// textBoxBoneName
			// 
			this.textBoxBoneName.Location = new System.Drawing.Point(0, 19);
			this.textBoxBoneName.Name = "textBoxBoneName";
			this.textBoxBoneName.ReadOnly = true;
			this.textBoxBoneName.Size = new System.Drawing.Size(251, 20);
			this.textBoxBoneName.TabIndex = 1;
			// 
			// textBoxKeyframeRange
			// 
			this.textBoxKeyframeRange.Enabled = false;
			this.textBoxKeyframeRange.Location = new System.Drawing.Point(133, 23);
			this.textBoxKeyframeRange.MaxLength = 10;
			this.textBoxKeyframeRange.Name = "textBoxKeyframeRange";
			this.textBoxKeyframeRange.Size = new System.Drawing.Size(45, 20);
			this.textBoxKeyframeRange.TabIndex = 268;
			this.textBoxKeyframeRange.TabStop = false;
			this.textBoxKeyframeRange.Text = "-1-0";
			// 
			// editTextBoxMeshRootBone
			// 
			this.editTextBoxMeshRootBone.Enabled = false;
			this.editTextBoxMeshRootBone.Location = new System.Drawing.Point(148, 31);
			this.editTextBoxMeshRootBone.Name = "editTextBoxMeshRootBone";
			this.editTextBoxMeshRootBone.Size = new System.Drawing.Size(100, 20);
			this.editTextBoxMeshRootBone.TabIndex = 156;
			// 
			// editTextBoxMeshName
			// 
			this.editTextBoxMeshName.BackColor = System.Drawing.SystemColors.Window;
			this.editTextBoxMeshName.Location = new System.Drawing.Point(3, 31);
			this.editTextBoxMeshName.Name = "editTextBoxMeshName";
			this.editTextBoxMeshName.Size = new System.Drawing.Size(139, 20);
			this.editTextBoxMeshName.TabIndex = 154;
			// 
			// textBoxRendererName
			// 
			this.textBoxRendererName.Location = new System.Drawing.Point(0, 19);
			this.textBoxRendererName.Name = "textBoxRendererName";
			this.textBoxRendererName.ReadOnly = true;
			this.textBoxRendererName.Size = new System.Drawing.Size(200, 20);
			this.textBoxRendererName.TabIndex = 1;
			// 
			// editTextBoxMorphKeyframeHash
			// 
			this.editTextBoxMorphKeyframeHash.Location = new System.Drawing.Point(182, 22);
			this.editTextBoxMorphKeyframeHash.Name = "editTextBoxMorphKeyframeHash";
			this.editTextBoxMorphKeyframeHash.ReadOnly = true;
			this.editTextBoxMorphKeyframeHash.Size = new System.Drawing.Size(65, 20);
			this.editTextBoxMorphKeyframeHash.TabIndex = 151;
			// 
			// editTextBoxMorphWeightRange
			// 
			this.editTextBoxMorphWeightRange.Location = new System.Drawing.Point(204, 80);
			this.editTextBoxMorphWeightRange.Name = "editTextBoxMorphWeightRange";
			this.editTextBoxMorphWeightRange.ReadOnly = true;
			this.editTextBoxMorphWeightRange.Size = new System.Drawing.Size(43, 20);
			this.editTextBoxMorphWeightRange.TabIndex = 149;
			this.editTextBoxMorphWeightRange.AfterEditTextChanged += new System.EventHandler(this.editTextBoxMorphWeightRange_AfterEditTextChanged);
			// 
			// editTextBoxMorphFrameCount
			// 
			this.editTextBoxMorphFrameCount.Location = new System.Drawing.Point(186, 51);
			this.editTextBoxMorphFrameCount.Name = "editTextBoxMorphFrameCount";
			this.editTextBoxMorphFrameCount.Size = new System.Drawing.Size(36, 20);
			this.editTextBoxMorphFrameCount.TabIndex = 14;
			this.editTextBoxMorphFrameCount.AfterEditTextChanged += new System.EventHandler(this.editTextBoxMorphFrameIndexCount_AfterEditTextChanged);
			// 
			// textBoxMorphFrameIndex
			// 
			this.textBoxMorphFrameIndex.Location = new System.Drawing.Point(67, 51);
			this.textBoxMorphFrameIndex.Name = "textBoxMorphFrameIndex";
			this.textBoxMorphFrameIndex.Size = new System.Drawing.Size(36, 20);
			this.textBoxMorphFrameIndex.TabIndex = 12;
			this.textBoxMorphFrameIndex.AfterEditTextChanged += new System.EventHandler(this.editTextBoxMorphFrameIndexCount_AfterEditTextChanged);
			// 
			// editTextBoxMorphKeyframe
			// 
			this.editTextBoxMorphKeyframe.Location = new System.Drawing.Point(1, 22);
			this.editTextBoxMorphKeyframe.Name = "editTextBoxMorphKeyframe";
			this.editTextBoxMorphKeyframe.Size = new System.Drawing.Size(175, 20);
			this.editTextBoxMorphKeyframe.TabIndex = 10;
			this.editTextBoxMorphKeyframe.AfterEditTextChanged += new System.EventHandler(this.editTextBoxMorphKeyframe_AfterEditTextChanged);
			// 
			// editTextBoxMatShader
			// 
			this.editTextBoxMatShader.Enabled = false;
			this.editTextBoxMatShader.Location = new System.Drawing.Point(1, 61);
			this.editTextBoxMatShader.Name = "editTextBoxMatShader";
			this.editTextBoxMatShader.Size = new System.Drawing.Size(150, 20);
			this.editTextBoxMatShader.TabIndex = 4;
			// 
			// textBoxMatExtra
			// 
			this.textBoxMatExtra.Location = new System.Drawing.Point(200, 405);
			this.textBoxMatExtra.Name = "textBoxMatExtra";
			this.textBoxMatExtra.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatExtra.TabIndex = 64;
			// 
			// textBoxMatShadowA
			// 
			this.textBoxMatShadowA.Location = new System.Drawing.Point(201, 359);
			this.textBoxMatShadowA.Name = "textBoxMatShadowA";
			this.textBoxMatShadowA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatShadowA.TabIndex = 49;
			// 
			// textBoxMatShadowB
			// 
			this.textBoxMatShadowB.Location = new System.Drawing.Point(151, 359);
			this.textBoxMatShadowB.Name = "textBoxMatShadowB";
			this.textBoxMatShadowB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatShadowB.TabIndex = 48;
			// 
			// textBoxMatShadowG
			// 
			this.textBoxMatShadowG.Location = new System.Drawing.Point(101, 359);
			this.textBoxMatShadowG.Name = "textBoxMatShadowG";
			this.textBoxMatShadowG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatShadowG.TabIndex = 47;
			// 
			// textBoxMatShadowR
			// 
			this.textBoxMatShadowR.Location = new System.Drawing.Point(51, 359);
			this.textBoxMatShadowR.Name = "textBoxMatShadowR";
			this.textBoxMatShadowR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatShadowR.TabIndex = 46;
			// 
			// textBoxMatOutlineA
			// 
			this.textBoxMatOutlineA.Location = new System.Drawing.Point(201, 335);
			this.textBoxMatOutlineA.Name = "textBoxMatOutlineA";
			this.textBoxMatOutlineA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatOutlineA.TabIndex = 45;
			// 
			// textBoxMatOutlineB
			// 
			this.textBoxMatOutlineB.Location = new System.Drawing.Point(151, 335);
			this.textBoxMatOutlineB.Name = "textBoxMatOutlineB";
			this.textBoxMatOutlineB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatOutlineB.TabIndex = 44;
			// 
			// textBoxMatOutlineG
			// 
			this.textBoxMatOutlineG.Location = new System.Drawing.Point(101, 335);
			this.textBoxMatOutlineG.Name = "textBoxMatOutlineG";
			this.textBoxMatOutlineG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatOutlineG.TabIndex = 43;
			// 
			// textBoxMatOutlineR
			// 
			this.textBoxMatOutlineR.Location = new System.Drawing.Point(51, 335);
			this.textBoxMatOutlineR.Name = "textBoxMatOutlineR";
			this.textBoxMatOutlineR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatOutlineR.TabIndex = 42;
			// 
			// textBoxMatRimA
			// 
			this.textBoxMatRimA.Location = new System.Drawing.Point(201, 311);
			this.textBoxMatRimA.Name = "textBoxMatRimA";
			this.textBoxMatRimA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatRimA.TabIndex = 41;
			// 
			// textBoxMatRimB
			// 
			this.textBoxMatRimB.Location = new System.Drawing.Point(151, 311);
			this.textBoxMatRimB.Name = "textBoxMatRimB";
			this.textBoxMatRimB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatRimB.TabIndex = 40;
			// 
			// textBoxMatRimG
			// 
			this.textBoxMatRimG.Location = new System.Drawing.Point(101, 311);
			this.textBoxMatRimG.Name = "textBoxMatRimG";
			this.textBoxMatRimG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatRimG.TabIndex = 39;
			// 
			// textBoxMatRimR
			// 
			this.textBoxMatRimR.Location = new System.Drawing.Point(51, 311);
			this.textBoxMatRimR.Name = "textBoxMatRimR";
			this.textBoxMatRimR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatRimR.TabIndex = 38;
			// 
			// textBoxMatOutline
			// 
			this.textBoxMatOutline.Location = new System.Drawing.Point(135, 406);
			this.textBoxMatOutline.Name = "textBoxMatOutline";
			this.textBoxMatOutline.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatOutline.TabIndex = 62;
			// 
			// textBoxMatRimPower
			// 
			this.textBoxMatRimPower.Location = new System.Drawing.Point(70, 405);
			this.textBoxMatRimPower.Name = "textBoxMatRimPower";
			this.textBoxMatRimPower.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatRimPower.TabIndex = 61;
			// 
			// textBoxMatSpecularPower
			// 
			this.textBoxMatSpecularPower.Location = new System.Drawing.Point(5, 405);
			this.textBoxMatSpecularPower.Name = "textBoxMatSpecularPower";
			this.textBoxMatSpecularPower.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatSpecularPower.TabIndex = 60;
			// 
			// textBoxMatEmissiveA
			// 
			this.textBoxMatEmissiveA.Location = new System.Drawing.Point(201, 288);
			this.textBoxMatEmissiveA.Name = "textBoxMatEmissiveA";
			this.textBoxMatEmissiveA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatEmissiveA.TabIndex = 37;
			// 
			// textBoxMatEmissiveB
			// 
			this.textBoxMatEmissiveB.Location = new System.Drawing.Point(151, 288);
			this.textBoxMatEmissiveB.Name = "textBoxMatEmissiveB";
			this.textBoxMatEmissiveB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatEmissiveB.TabIndex = 36;
			// 
			// textBoxMatEmissiveG
			// 
			this.textBoxMatEmissiveG.Location = new System.Drawing.Point(101, 288);
			this.textBoxMatEmissiveG.Name = "textBoxMatEmissiveG";
			this.textBoxMatEmissiveG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatEmissiveG.TabIndex = 35;
			// 
			// textBoxMatEmissiveR
			// 
			this.textBoxMatEmissiveR.Location = new System.Drawing.Point(51, 288);
			this.textBoxMatEmissiveR.Name = "textBoxMatEmissiveR";
			this.textBoxMatEmissiveR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatEmissiveR.TabIndex = 34;
			// 
			// textBoxMatSpecularA
			// 
			this.textBoxMatSpecularA.Location = new System.Drawing.Point(201, 264);
			this.textBoxMatSpecularA.Name = "textBoxMatSpecularA";
			this.textBoxMatSpecularA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatSpecularA.TabIndex = 33;
			// 
			// textBoxMatSpecularB
			// 
			this.textBoxMatSpecularB.Location = new System.Drawing.Point(151, 264);
			this.textBoxMatSpecularB.Name = "textBoxMatSpecularB";
			this.textBoxMatSpecularB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatSpecularB.TabIndex = 32;
			// 
			// textBoxMatSpecularG
			// 
			this.textBoxMatSpecularG.Location = new System.Drawing.Point(101, 264);
			this.textBoxMatSpecularG.Name = "textBoxMatSpecularG";
			this.textBoxMatSpecularG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatSpecularG.TabIndex = 31;
			// 
			// textBoxMatSpecularR
			// 
			this.textBoxMatSpecularR.Location = new System.Drawing.Point(51, 264);
			this.textBoxMatSpecularR.Name = "textBoxMatSpecularR";
			this.textBoxMatSpecularR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatSpecularR.TabIndex = 30;
			// 
			// textBoxMatAmbientA
			// 
			this.textBoxMatAmbientA.Location = new System.Drawing.Point(201, 240);
			this.textBoxMatAmbientA.Name = "textBoxMatAmbientA";
			this.textBoxMatAmbientA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatAmbientA.TabIndex = 29;
			// 
			// textBoxMatAmbientB
			// 
			this.textBoxMatAmbientB.Location = new System.Drawing.Point(151, 240);
			this.textBoxMatAmbientB.Name = "textBoxMatAmbientB";
			this.textBoxMatAmbientB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatAmbientB.TabIndex = 28;
			// 
			// textBoxMatAmbientG
			// 
			this.textBoxMatAmbientG.Location = new System.Drawing.Point(101, 240);
			this.textBoxMatAmbientG.Name = "textBoxMatAmbientG";
			this.textBoxMatAmbientG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatAmbientG.TabIndex = 27;
			// 
			// textBoxMatAmbientR
			// 
			this.textBoxMatAmbientR.Location = new System.Drawing.Point(51, 240);
			this.textBoxMatAmbientR.Name = "textBoxMatAmbientR";
			this.textBoxMatAmbientR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatAmbientR.TabIndex = 26;
			// 
			// textBoxMatDiffuseA
			// 
			this.textBoxMatDiffuseA.Location = new System.Drawing.Point(201, 216);
			this.textBoxMatDiffuseA.Name = "textBoxMatDiffuseA";
			this.textBoxMatDiffuseA.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatDiffuseA.TabIndex = 25;
			// 
			// textBoxMatDiffuseB
			// 
			this.textBoxMatDiffuseB.Location = new System.Drawing.Point(151, 216);
			this.textBoxMatDiffuseB.Name = "textBoxMatDiffuseB";
			this.textBoxMatDiffuseB.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatDiffuseB.TabIndex = 24;
			// 
			// textBoxMatDiffuseG
			// 
			this.textBoxMatDiffuseG.Location = new System.Drawing.Point(101, 216);
			this.textBoxMatDiffuseG.Name = "textBoxMatDiffuseG";
			this.textBoxMatDiffuseG.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatDiffuseG.TabIndex = 23;
			// 
			// textBoxMatDiffuseR
			// 
			this.textBoxMatDiffuseR.Location = new System.Drawing.Point(51, 216);
			this.textBoxMatDiffuseR.Name = "textBoxMatDiffuseR";
			this.textBoxMatDiffuseR.Size = new System.Drawing.Size(49, 20);
			this.textBoxMatDiffuseR.TabIndex = 22;
			// 
			// textBoxMatName
			// 
			this.textBoxMatName.Location = new System.Drawing.Point(0, 19);
			this.textBoxMatName.Name = "textBoxMatName";
			this.textBoxMatName.Size = new System.Drawing.Size(250, 20);
			this.textBoxMatName.TabIndex = 2;
			// 
			// editTextBoxTexDimension
			// 
			this.editTextBoxTexDimension.Location = new System.Drawing.Point(229, 59);
			this.editTextBoxTexDimension.Name = "editTextBoxTexDimension";
			this.editTextBoxTexDimension.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexDimension.TabIndex = 56;
			this.editTextBoxTexDimension.Text = "2";
			this.editTextBoxTexDimension.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexLightMap
			// 
			this.editTextBoxTexLightMap.Location = new System.Drawing.Point(229, 112);
			this.editTextBoxTexLightMap.Name = "editTextBoxTexLightMap";
			this.editTextBoxTexLightMap.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexLightMap.TabIndex = 54;
			this.editTextBoxTexLightMap.Text = "1";
			this.editTextBoxTexLightMap.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexColorSpace
			// 
			this.editTextBoxTexColorSpace.Location = new System.Drawing.Point(149, 112);
			this.editTextBoxTexColorSpace.Name = "editTextBoxTexColorSpace";
			this.editTextBoxTexColorSpace.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexColorSpace.TabIndex = 52;
			this.editTextBoxTexColorSpace.Text = "1";
			this.editTextBoxTexColorSpace.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexWrapMode
			// 
			this.editTextBoxTexWrapMode.Location = new System.Drawing.Point(229, 139);
			this.editTextBoxTexWrapMode.Name = "editTextBoxTexWrapMode";
			this.editTextBoxTexWrapMode.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexWrapMode.TabIndex = 50;
			this.editTextBoxTexWrapMode.Text = "1";
			this.editTextBoxTexWrapMode.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexAniso
			// 
			this.editTextBoxTexAniso.Location = new System.Drawing.Point(170, 139);
			this.editTextBoxTexAniso.Name = "editTextBoxTexAniso";
			this.editTextBoxTexAniso.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexAniso.TabIndex = 48;
			this.editTextBoxTexAniso.Text = "0";
			this.editTextBoxTexAniso.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexMipBias
			// 
			this.editTextBoxTexMipBias.Location = new System.Drawing.Point(105, 139);
			this.editTextBoxTexMipBias.Name = "editTextBoxTexMipBias";
			this.editTextBoxTexMipBias.Size = new System.Drawing.Size(23, 20);
			this.editTextBoxTexMipBias.TabIndex = 46;
			this.editTextBoxTexMipBias.Text = "0";
			this.editTextBoxTexMipBias.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexFilterMode
			// 
			this.editTextBoxTexFilterMode.Location = new System.Drawing.Point(32, 139);
			this.editTextBoxTexFilterMode.Name = "editTextBoxTexFilterMode";
			this.editTextBoxTexFilterMode.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexFilterMode.TabIndex = 44;
			this.editTextBoxTexFilterMode.Text = "1";
			this.editTextBoxTexFilterMode.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// editTextBoxTexImageCount
			// 
			this.editTextBoxTexImageCount.Location = new System.Drawing.Point(58, 112);
			this.editTextBoxTexImageCount.Name = "editTextBoxTexImageCount";
			this.editTextBoxTexImageCount.Size = new System.Drawing.Size(19, 20);
			this.editTextBoxTexImageCount.TabIndex = 2;
			this.editTextBoxTexImageCount.Text = "1";
			this.editTextBoxTexImageCount.AfterEditTextChanged += new System.EventHandler(this.editTextBoxTexAttributes_AfterEditTextChanged);
			// 
			// textBoxTexSize
			// 
			this.textBoxTexSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTexSize.Location = new System.Drawing.Point(170, 19);
			this.textBoxTexSize.Name = "textBoxTexSize";
			this.textBoxTexSize.ReadOnly = true;
			this.textBoxTexSize.Size = new System.Drawing.Size(80, 20);
			this.textBoxTexSize.TabIndex = 37;
			this.textBoxTexSize.TabStop = false;
			// 
			// textBoxTexName
			// 
			this.textBoxTexName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.textBoxTexName.Location = new System.Drawing.Point(0, 19);
			this.textBoxTexName.Name = "textBoxTexName";
			this.textBoxTexName.Size = new System.Drawing.Size(164, 20);
			this.textBoxTexName.TabIndex = 5;
			// 
			// FormAnimator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(520, 535);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "FormAnimator";
			this.Text = "FormAnimator";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControlLists.ResumeLayout(false);
			this.tabPageObject.ResumeLayout(false);
			this.panelObjectTreeBottom.ResumeLayout(false);
			this.tabPageMesh.ResumeLayout(false);
			this.splitContainerMesh.Panel1.ResumeLayout(false);
			this.splitContainerMesh.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMesh)).EndInit();
			this.splitContainerMesh.ResumeLayout(false);
			this.splitContainerMeshCrossRef.Panel1.ResumeLayout(false);
			this.splitContainerMeshCrossRef.Panel1.PerformLayout();
			this.splitContainerMeshCrossRef.Panel2.ResumeLayout(false);
			this.splitContainerMeshCrossRef.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMeshCrossRef)).EndInit();
			this.splitContainerMeshCrossRef.ResumeLayout(false);
			this.tabPageMorph.ResumeLayout(false);
			this.tabPageMorph.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.tabPageMaterial.ResumeLayout(false);
			this.splitContainerMaterial.Panel1.ResumeLayout(false);
			this.splitContainerMaterial.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterial)).EndInit();
			this.splitContainerMaterial.ResumeLayout(false);
			this.splitContainerMaterialCrossRef.Panel1.ResumeLayout(false);
			this.splitContainerMaterialCrossRef.Panel1.PerformLayout();
			this.splitContainerMaterialCrossRef.Panel2.ResumeLayout(false);
			this.splitContainerMaterialCrossRef.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerMaterialCrossRef)).EndInit();
			this.splitContainerMaterialCrossRef.ResumeLayout(false);
			this.tabPageTexture.ResumeLayout(false);
			this.splitContainerTexture.Panel1.ResumeLayout(false);
			this.splitContainerTexture.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainerTexture)).EndInit();
			this.splitContainerTexture.ResumeLayout(false);
			this.splitContainerTextureCrossRef.Panel1.ResumeLayout(false);
			this.splitContainerTextureCrossRef.Panel1.PerformLayout();
			this.splitContainerTextureCrossRef.Panel2.ResumeLayout(false);
			this.splitContainerTextureCrossRef.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainerTextureCrossRef)).EndInit();
			this.splitContainerTextureCrossRef.ResumeLayout(false);
			this.tabControlViews.ResumeLayout(false);
			this.tabPageFrameView.ResumeLayout(false);
			this.tabPageFrameView.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericFrameMatrixRatio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericFrameMatrixNumber)).EndInit();
			this.tabControlFrameMatrix.ResumeLayout(false);
			this.tabPageFrameSRT.ResumeLayout(false);
			this.tabPageFrameMatrix.ResumeLayout(false);
			this.tabPageBoneView.ResumeLayout(false);
			this.tabPageBoneView.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericBoneMatrixRatio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericBoneMatrixNumber)).EndInit();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tabControlBoneMatrix.ResumeLayout(false);
			this.tabPageBoneSRT.ResumeLayout(false);
			this.tabPageBoneMatrix.ResumeLayout(false);
			this.tabPageMeshView.ResumeLayout(false);
			this.tabPageMeshView.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.panelMeshExportOptionsDirectX.ResumeLayout(false);
			this.panelMeshExportOptionsDirectX.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericMeshExportDirectXTicksPerSecond)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericMeshExportDirectXKeyframeLength)).EndInit();
			this.panelMeshExportOptionsCollada.ResumeLayout(false);
			this.panelMeshExportOptionsCollada.PerformLayout();
			this.panelMeshExportOptionsMqo.ResumeLayout(false);
			this.panelMeshExportOptionsMqo.PerformLayout();
			this.panelMeshExportOptionsFbx.ResumeLayout(false);
			this.panelMeshExportOptionsFbx.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewMesh)).EndInit();
			this.tabPageMorphView.ResumeLayout(false);
			this.tabPageMorphView.PerformLayout();
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox8.ResumeLayout(false);
			this.groupBox8.PerformLayout();
			this.groupBox11.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.trackBarMorphFactor)).EndInit();
			this.tabPageMaterialView.ResumeLayout(false);
			this.tabPageMaterialView.PerformLayout();
			this.tabPageTextureView.ResumeLayout(false);
			this.tabPageTextureView.PerformLayout();
			this.panelTexturePic.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxTexture)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrameSRT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFrameMatrix)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoneSRT)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewBoneMatrix)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		public System.Windows.Forms.TabControl tabControlLists;
		private System.Windows.Forms.TabPage tabPageObject;
		public System.Windows.Forms.TreeView treeViewObjectTree;
		private System.Windows.Forms.Panel panelObjectTreeBottom;
		private System.Windows.Forms.Button buttonObjectTreeRefresh;
		private System.Windows.Forms.Button buttonObjectTreeCollapse;
		private System.Windows.Forms.Button buttonObjectTreeExpand;
		private System.Windows.Forms.TabPage tabPageMesh;
		private System.Windows.Forms.SplitContainer splitContainerMesh;
		public System.Windows.Forms.ListView listViewMesh;
		private System.Windows.Forms.ColumnHeader meshlistHeaderNames;
		private System.Windows.Forms.SplitContainer splitContainerMeshCrossRef;
		private System.Windows.Forms.ListView listViewMeshMaterial;
		private System.Windows.Forms.ColumnHeader listViewMeshMaterialHeader;
		private System.Windows.Forms.Label label68;
		private System.Windows.Forms.ListView listViewMeshTexture;
		private System.Windows.Forms.ColumnHeader listViewMeshTextureHeader;
		private System.Windows.Forms.Label label70;
		private System.Windows.Forms.TabPage tabPageMaterial;
		private System.Windows.Forms.SplitContainer splitContainerMaterial;
		private System.Windows.Forms.ListView listViewMaterial;
		private System.Windows.Forms.ColumnHeader materiallistHeader;
		private System.Windows.Forms.SplitContainer splitContainerMaterialCrossRef;
		private System.Windows.Forms.ListView listViewMaterialMesh;
		private System.Windows.Forms.ColumnHeader listViewMaterialMeshHeader;
		private System.Windows.Forms.Label label71;
		private System.Windows.Forms.ListView listViewMaterialTexture;
		private System.Windows.Forms.ColumnHeader listViewMaterialTextureHeader;
		private System.Windows.Forms.Label label72;
		private System.Windows.Forms.TabPage tabPageTexture;
		private System.Windows.Forms.SplitContainer splitContainerTexture;
		private System.Windows.Forms.ListView listViewTexture;
		private System.Windows.Forms.ColumnHeader texturelistHeader;
		private System.Windows.Forms.SplitContainer splitContainerTextureCrossRef;
		private System.Windows.Forms.ListView listViewTextureMesh;
		private System.Windows.Forms.ColumnHeader listViewTextureMeshHeader;
		private System.Windows.Forms.Label label73;
		private System.Windows.Forms.ListView listViewTextureMaterial;
		private System.Windows.Forms.ColumnHeader listViewTextureMaterialHeader;
		private System.Windows.Forms.Label label74;
		public System.Windows.Forms.TabControl tabControlViews;
		private System.Windows.Forms.TabPage tabPageFrameView;
		private System.Windows.Forms.Button buttonFrameAddBone;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button buttonFrameMatrixApply;
		private System.Windows.Forms.CheckBox checkBoxFrameMatrixUpdate;
		private System.Windows.Forms.NumericUpDown numericFrameMatrixRatio;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numericFrameMatrixNumber;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button buttonFrameMatrixPaste;
		private System.Windows.Forms.Button buttonFrameMatrixCopy;
		private System.Windows.Forms.Button buttonFrameMatrixGrow;
		private System.Windows.Forms.Button buttonFrameMatrixShrink;
		private System.Windows.Forms.Button buttonFrameMatrixIdentity;
		private System.Windows.Forms.Button buttonFrameMatrixInverse;
		private System.Windows.Forms.Button buttonFrameMatrixCombined;
		private System.Windows.Forms.TabControl tabControlFrameMatrix;
		private System.Windows.Forms.TabPage tabPageFrameSRT;
		private SB3Utility.DataGridViewEditor dataGridViewFrameSRT;
		private System.Windows.Forms.TabPage tabPageFrameMatrix;
		private SB3Utility.DataGridViewEditor dataGridViewFrameMatrix;
		private System.Windows.Forms.Button buttonFrameMoveUp;
		private System.Windows.Forms.Button buttonFrameRemove;
		private System.Windows.Forms.Button buttonFrameMoveDown;
		private System.Windows.Forms.Label label4;
		private SB3Utility.EditTextBox textBoxFrameName;
		private System.Windows.Forms.TabPage tabPageBoneView;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.NumericUpDown numericBoneMatrixRatio;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.NumericUpDown numericBoneMatrixNumber;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button buttonBoneMatrixPaste;
		private System.Windows.Forms.Button buttonBoneMatrixCopy;
		private System.Windows.Forms.Button buttonBoneMatrixGrow;
		private System.Windows.Forms.Button buttonBoneMatrixShrink;
		private System.Windows.Forms.Button buttonBoneMatrixIdentity;
		private System.Windows.Forms.Button buttonBoneMatrixInverse;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button buttonBoneMatrixApply;
		private System.Windows.Forms.CheckBox checkBoxBoneMatrixUpdate;
		private System.Windows.Forms.TabControl tabControlBoneMatrix;
		private System.Windows.Forms.TabPage tabPageBoneSRT;
		private SB3Utility.DataGridViewEditor dataGridViewBoneSRT;
		private System.Windows.Forms.TabPage tabPageBoneMatrix;
		private SB3Utility.DataGridViewEditor dataGridViewBoneMatrix;
		private System.Windows.Forms.Button buttonBoneRemove;
		private System.Windows.Forms.Button buttonBoneGotoFrame;
		private System.Windows.Forms.Label label25;
		private SB3Utility.EditTextBox textBoxBoneName;
		private System.Windows.Forms.TabPage tabPageMeshView;
		private System.Windows.Forms.Button buttonMeshRestPose;
		private System.Windows.Forms.CheckBox checkBoxMeshNewSkin;
		private System.Windows.Forms.Button buttonMeshNormals;
		private System.Windows.Forms.Button buttonSkinnedMeshRendererAttributes;
		private System.Windows.Forms.Button buttonMeshMinBones;
		private System.Windows.Forms.Button buttonMeshGotoFrame;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.ComboBox comboBoxMeshExportFormat;
		private System.Windows.Forms.Button buttonMeshExport;
		private System.Windows.Forms.Panel panelMeshExportOptionsDefault;
		private System.Windows.Forms.Panel panelMeshExportOptionsDirectX;
		private System.Windows.Forms.NumericUpDown numericMeshExportDirectXTicksPerSecond;
		private System.Windows.Forms.NumericUpDown numericMeshExportDirectXKeyframeLength;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Panel panelMeshExportOptionsCollada;
		private System.Windows.Forms.CheckBox checkBoxMeshExportColladaAllFrames;
		private System.Windows.Forms.Panel panelMeshExportOptionsMqo;
		private System.Windows.Forms.CheckBox checkBoxMeshExportMqoSortMeshes;
		private System.Windows.Forms.CheckBox checkBoxMeshExportMqoSingleFile;
		private System.Windows.Forms.CheckBox checkBoxMeshExportMqoWorldCoords;
		private System.Windows.Forms.Panel panelMeshExportOptionsFbx;
		private System.Windows.Forms.CheckBox checkBoxMeshExportFbxLinearInterpolation;
		private System.Windows.Forms.CheckBox checkBoxMeshExportNoMesh;
		private System.Windows.Forms.CheckBox checkBoxMeshExportAllBones;
		private System.Windows.Forms.CheckBox checkBoxMeshExportFbxSkins;
		private System.Windows.Forms.Label label13;
		public SB3Utility.EditTextBox textBoxKeyframeRange;
		private System.Windows.Forms.CheckBox checkBoxMeshExportFbxAllFrames;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonMeshRemove;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonMeshSnapBorders;
		public System.Windows.Forms.DataGridView dataGridViewMesh;
		private System.Windows.Forms.Button buttonMeshSubmeshRemove;
		public SB3Utility.EditTextBox textBoxRendererName;
		private System.Windows.Forms.TabPage tabPageMaterialView;
		private System.Windows.Forms.ComboBox comboBoxMatTex4;
		private System.Windows.Forms.ComboBox comboBoxMatTex3;
		private System.Windows.Forms.ComboBox comboBoxMatTex2;
		private System.Windows.Forms.ComboBox comboBoxMatTex1;
		private System.Windows.Forms.Button buttonMaterialRemove;
		private System.Windows.Forms.Button buttonMaterialCopy;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labelEmissive;
		private System.Windows.Forms.Label labelShininess;
		private System.Windows.Forms.Label labelSpecular;
		private System.Windows.Forms.Label labelAmbient;
		private System.Windows.Forms.Label labelDiffuse;
		private SB3Utility.EditTextBox textBoxMatSpecularPower;
		private SB3Utility.EditTextBox textBoxMatEmissiveA;
		private SB3Utility.EditTextBox textBoxMatEmissiveB;
		private SB3Utility.EditTextBox textBoxMatEmissiveG;
		private SB3Utility.EditTextBox textBoxMatEmissiveR;
		private SB3Utility.EditTextBox textBoxMatSpecularA;
		private SB3Utility.EditTextBox textBoxMatSpecularB;
		private SB3Utility.EditTextBox textBoxMatSpecularG;
		private SB3Utility.EditTextBox textBoxMatSpecularR;
		private SB3Utility.EditTextBox textBoxMatAmbientA;
		private SB3Utility.EditTextBox textBoxMatAmbientB;
		private SB3Utility.EditTextBox textBoxMatAmbientG;
		private SB3Utility.EditTextBox textBoxMatAmbientR;
		private SB3Utility.EditTextBox textBoxMatDiffuseA;
		private SB3Utility.EditTextBox textBoxMatDiffuseB;
		private SB3Utility.EditTextBox textBoxMatDiffuseG;
		private SB3Utility.EditTextBox textBoxMatDiffuseR;
		private SB3Utility.EditTextBox textBoxMatName;
		private System.Windows.Forms.TabPage tabPageTextureView;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Button buttonTextureAdd;
		private System.Windows.Forms.Panel panelTexturePic;
		private System.Windows.Forms.PictureBox pictureBoxTexture;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button buttonTextureExport;
		private System.Windows.Forms.Button buttonTextureReplace;
		private System.Windows.Forms.Button buttonTextureRemove;
		private SB3Utility.EditTextBox textBoxTexSize;
		private SB3Utility.EditTextBox textBoxTexName;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label26;
		public SB3Utility.EditTextBox editTextBoxMeshName;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.ComboBox comboBoxMatShaderKeywords;
		private System.Windows.Forms.Label labelOutline;
		private SB3Utility.EditTextBox textBoxMatOutline;
		private System.Windows.Forms.Label labelRimPower;
		private SB3Utility.EditTextBox textBoxMatRimPower;
		private System.Windows.Forms.Label labelShadow;
		private System.Windows.Forms.Label labelOutlineColour;
		private System.Windows.Forms.Label labelRim;
		private SB3Utility.EditTextBox textBoxMatShadowA;
		private SB3Utility.EditTextBox textBoxMatShadowB;
		private SB3Utility.EditTextBox textBoxMatShadowG;
		private SB3Utility.EditTextBox textBoxMatShadowR;
		private SB3Utility.EditTextBox textBoxMatOutlineA;
		private SB3Utility.EditTextBox textBoxMatOutlineB;
		private SB3Utility.EditTextBox textBoxMatOutlineG;
		private SB3Utility.EditTextBox textBoxMatOutlineR;
		private SB3Utility.EditTextBox textBoxMatRimA;
		private SB3Utility.EditTextBox textBoxMatRimB;
		private SB3Utility.EditTextBox textBoxMatRimG;
		private SB3Utility.EditTextBox textBoxMatRimR;
		private System.Windows.Forms.Label labelExtra;
		private SB3Utility.EditTextBox textBoxMatExtra;
		private System.Windows.Forms.Label labelMatTex4;
		private System.Windows.Forms.Label labelMatTex3;
		private System.Windows.Forms.Label labelMatTex2;
		private System.Windows.Forms.Label labelMatTex1;
		private SB3Utility.EditTextBox editTextBoxMatShader;
		private System.Windows.Forms.ColumnHeader meshListHeaderType;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox checkBoxRendererEnabled;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.CheckBox checkBoxTextureMipMap;
		private System.Windows.Forms.Label labelTextureFormat;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.ComboBox comboBoxMeshRendererMesh;
		private System.Windows.Forms.Label label20;
		private SB3Utility.EditTextBox editTextBoxTexImageCount;
		private System.Windows.Forms.Label label21;
		private SB3Utility.EditTextBox editTextBoxTexFilterMode;
		private System.Windows.Forms.Label label22;
		private SB3Utility.EditTextBox editTextBoxTexMipBias;
		private System.Windows.Forms.Label label32;
		private SB3Utility.EditTextBox editTextBoxTexWrapMode;
		private System.Windows.Forms.Label label31;
		private SB3Utility.EditTextBox editTextBoxTexAniso;
		private System.Windows.Forms.Label label33;
		private SB3Utility.EditTextBox editTextBoxTexColorSpace;
		private System.Windows.Forms.Label label36;
		private SB3Utility.EditTextBox editTextBoxTexLightMap;
		private System.Windows.Forms.Label label37;
		private SB3Utility.EditTextBox editTextBoxTexDimension;
		private SB3Utility.EditTextBox editTextBoxMeshRootBone;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubmeshVerts;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubmeshFaces;
		private System.Windows.Forms.DataGridViewComboBoxColumn ColumnSubmeshMaterial;
		private System.Windows.Forms.DataGridViewTextBoxColumn Topology;
		private System.Windows.Forms.ComboBox comboBoxRendererRootBone;
		private System.Windows.Forms.CheckBox checkBoxMeshMultiPass;
		private System.Windows.Forms.Button buttonFrameUnique;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.TabPage tabPageMorphView;
		private System.Windows.Forms.TabPage tabPageMorph;
		public System.Windows.Forms.TreeView treeViewMorphKeyframes;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttonMorphRefDown;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Button buttonMorphRefUp;
		private System.Windows.Forms.Button buttonMorphDeleteRef;
		private SB3Utility.EditTextBox textBoxMorphFrameIndex;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox checkBoxMorphFbxOptionEmbedMedia;
		private System.Windows.Forms.CheckBox checkBoxMorphFbxOptionOneBlendshape;
		private System.Windows.Forms.ComboBox comboBoxMorphExportFormat;
		private System.Windows.Forms.Button buttonMorphExport;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label41;
		private SB3Utility.EditTextBox editTextBoxMorphKeyframe;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.TrackBar trackBarMorphFactor;
		private System.Windows.Forms.Label label40;
		private SB3Utility.EditTextBox editTextBoxMorphFrameCount;
		private System.Windows.Forms.CheckBox checkBoxMorphTangents;
		private System.Windows.Forms.CheckBox checkBoxMorphNormals;
		private System.Windows.Forms.Label label42;
		private SB3Utility.EditTextBox editTextBoxMorphWeightRange;
		private System.Windows.Forms.CheckBox checkBoxMorphEndKeyframe;
		private System.Windows.Forms.CheckBox checkBoxMorphStartKeyframe;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.Label label45;
		private SB3Utility.EditTextBox editTextBoxMorphKeyframeHash;
		private System.Windows.Forms.Label label46;
	}
}