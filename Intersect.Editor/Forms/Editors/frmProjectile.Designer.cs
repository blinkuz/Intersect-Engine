using DarkUI.Controls;

namespace Intersect.Editor.Forms.Editors
{
    partial class FrmProjectile
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProjectile));
            this.grpProjectiles = new DarkUI.Controls.DarkGroupBox();
            this.btnClearSearch = new DarkUI.Controls.DarkButton();
            this.txtSearch = new DarkUI.Controls.DarkTextBox();
            this.lstProjectiles = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.grpSpawns = new DarkUI.Controls.DarkGroupBox();
            this.picSpawns = new System.Windows.Forms.PictureBox();
            this.grpProperties = new DarkUI.Controls.DarkGroupBox();
            this.lblOnlyRenderWeb = new System.Windows.Forms.Label();
            this.chkStaticProjAnim = new DarkUI.Controls.DarkCheckBox();
            this.chkStaticProj = new DarkUI.Controls.DarkCheckBox();
            this.lblStaticD = new System.Windows.Forms.Label();
            this.nudOnlyRenderD = new DarkUI.Controls.DarkNumericUpDown();
            this.lblStaticY = new System.Windows.Forms.Label();
            this.lblStaticX = new System.Windows.Forms.Label();
            this.nudOnlyRenderY = new DarkUI.Controls.DarkNumericUpDown();
            this.nudOnlyRenderX = new DarkUI.Controls.DarkNumericUpDown();
            this.nudStaticProj = new DarkUI.Controls.DarkNumericUpDown();
            this.chkOneC2Kill = new DarkUI.Controls.DarkCheckBox();
            this.chkOnlyRender = new DarkUI.Controls.DarkCheckBox();
            this.nudHitRadius = new DarkUI.Controls.DarkNumericUpDown();
            this.lblHitRadius = new System.Windows.Forms.Label();
            this.btnAddFolder = new DarkUI.Controls.DarkButton();
            this.lblFolder = new System.Windows.Forms.Label();
            this.cmbFolder = new DarkUI.Controls.DarkComboBox();
            this.cmbSpell = new DarkUI.Controls.DarkComboBox();
            this.nudKnockback = new DarkUI.Controls.DarkNumericUpDown();
            this.nudRange = new DarkUI.Controls.DarkNumericUpDown();
            this.nudAmount = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpawn = new DarkUI.Controls.DarkNumericUpDown();
            this.nudSpeed = new DarkUI.Controls.DarkNumericUpDown();
            this.lblKnockback = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.chkGrapple = new DarkUI.Controls.DarkCheckBox();
            this.lblSpell = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new DarkUI.Controls.DarkTextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblSpawn = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.grpAnimations = new DarkUI.Controls.DarkGroupBox();
            this.cmbAnimation = new DarkUI.Controls.DarkComboBox();
            this.btnRemove = new DarkUI.Controls.DarkButton();
            this.btnAdd = new DarkUI.Controls.DarkButton();
            this.chkRotation = new DarkUI.Controls.DarkCheckBox();
            this.lblAnimation = new System.Windows.Forms.Label();
            this.lstAnimations = new System.Windows.Forms.ListBox();
            this.lblSpawnRange = new System.Windows.Forms.Label();
            this.scrlSpawnRange = new DarkUI.Controls.DarkScrollBar();
            this.grpCollisions = new DarkUI.Controls.DarkGroupBox();
            this.chkPierce = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreInactiveResources = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreZDimensionBlocks = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreMapBlocks = new DarkUI.Controls.DarkCheckBox();
            this.chkIgnoreActiveResources = new DarkUI.Controls.DarkCheckBox();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.grpAmmo = new DarkUI.Controls.DarkGroupBox();
            this.nudConsume = new DarkUI.Controls.DarkNumericUpDown();
            this.cmbItem = new DarkUI.Controls.DarkComboBox();
            this.lblAmmoItem = new System.Windows.Forms.Label();
            this.lblAmmoAmount = new System.Windows.Forms.Label();
            this.btnCancel = new DarkUI.Controls.DarkButton();
            this.btnSave = new DarkUI.Controls.DarkButton();
            this.toolStrip = new DarkUI.Controls.DarkToolStrip();
            this.toolStripItemNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnChronological = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripItemPaste = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripItemUndo = new System.Windows.Forms.ToolStripButton();
            this.grpProjectiles.SuspendLayout();
            this.grpSpawns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSpawns)).BeginInit();
            this.grpProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnlyRenderD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnlyRenderY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnlyRenderX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaticProj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnockback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).BeginInit();
            this.grpAnimations.SuspendLayout();
            this.grpCollisions.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            this.grpAmmo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsume)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProjectiles
            // 
            this.grpProjectiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpProjectiles.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpProjectiles.Controls.Add(this.btnClearSearch);
            this.grpProjectiles.Controls.Add(this.txtSearch);
            this.grpProjectiles.Controls.Add(this.lstProjectiles);
            this.grpProjectiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpProjectiles.Location = new System.Drawing.Point(12, 36);
            this.grpProjectiles.Name = "grpProjectiles";
            this.grpProjectiles.Size = new System.Drawing.Size(203, 654);
            this.grpProjectiles.TabIndex = 15;
            this.grpProjectiles.TabStop = false;
            this.grpProjectiles.Text = "Projectiles";
            // 
            // btnClearSearch
            // 
            this.btnClearSearch.Location = new System.Drawing.Point(179, 18);
            this.btnClearSearch.Name = "btnClearSearch";
            this.btnClearSearch.Padding = new System.Windows.Forms.Padding(5);
            this.btnClearSearch.Size = new System.Drawing.Size(18, 20);
            this.btnClearSearch.TabIndex = 34;
            this.btnClearSearch.Text = "X";
            this.btnClearSearch.Click += new System.EventHandler(this.btnClearSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtSearch.Location = new System.Drawing.Point(6, 18);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(167, 20);
            this.txtSearch.TabIndex = 33;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // lstProjectiles
            // 
            this.lstProjectiles.AllowDrop = true;
            this.lstProjectiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstProjectiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstProjectiles.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstProjectiles.HideSelection = false;
            this.lstProjectiles.ImageIndex = 0;
            this.lstProjectiles.ImageList = this.imageList;
            this.lstProjectiles.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.lstProjectiles.Location = new System.Drawing.Point(6, 44);
            this.lstProjectiles.Name = "lstProjectiles";
            this.lstProjectiles.SelectedImageIndex = 0;
            this.lstProjectiles.Size = new System.Drawing.Size(191, 604);
            this.lstProjectiles.TabIndex = 32;
            this.lstProjectiles.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.lstProjectiles_AfterSelect);
            this.lstProjectiles.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.lstProjectiles_NodeMouseClick);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // grpSpawns
            // 
            this.grpSpawns.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpSpawns.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpSpawns.Controls.Add(this.picSpawns);
            this.grpSpawns.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpSpawns.Location = new System.Drawing.Point(292, 3);
            this.grpSpawns.Name = "grpSpawns";
            this.grpSpawns.Size = new System.Drawing.Size(258, 256);
            this.grpSpawns.TabIndex = 17;
            this.grpSpawns.TabStop = false;
            this.grpSpawns.Text = "Projectile Spawns";
            // 
            // picSpawns
            // 
            this.picSpawns.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSpawns.Location = new System.Drawing.Point(15, 14);
            this.picSpawns.Name = "picSpawns";
            this.picSpawns.Size = new System.Drawing.Size(232, 224);
            this.picSpawns.TabIndex = 17;
            this.picSpawns.TabStop = false;
            this.picSpawns.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSpawns_MouseDown);
            // 
            // grpProperties
            // 
            this.grpProperties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpProperties.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpProperties.Controls.Add(this.lblOnlyRenderWeb);
            this.grpProperties.Controls.Add(this.chkStaticProjAnim);
            this.grpProperties.Controls.Add(this.chkStaticProj);
            this.grpProperties.Controls.Add(this.lblStaticD);
            this.grpProperties.Controls.Add(this.nudOnlyRenderD);
            this.grpProperties.Controls.Add(this.lblStaticY);
            this.grpProperties.Controls.Add(this.lblStaticX);
            this.grpProperties.Controls.Add(this.nudOnlyRenderY);
            this.grpProperties.Controls.Add(this.nudOnlyRenderX);
            this.grpProperties.Controls.Add(this.nudStaticProj);
            this.grpProperties.Controls.Add(this.chkOneC2Kill);
            this.grpProperties.Controls.Add(this.chkOnlyRender);
            this.grpProperties.Controls.Add(this.nudHitRadius);
            this.grpProperties.Controls.Add(this.lblHitRadius);
            this.grpProperties.Controls.Add(this.btnAddFolder);
            this.grpProperties.Controls.Add(this.lblFolder);
            this.grpProperties.Controls.Add(this.cmbFolder);
            this.grpProperties.Controls.Add(this.cmbSpell);
            this.grpProperties.Controls.Add(this.nudKnockback);
            this.grpProperties.Controls.Add(this.nudRange);
            this.grpProperties.Controls.Add(this.nudAmount);
            this.grpProperties.Controls.Add(this.nudSpawn);
            this.grpProperties.Controls.Add(this.nudSpeed);
            this.grpProperties.Controls.Add(this.lblKnockback);
            this.grpProperties.Controls.Add(this.lblAmount);
            this.grpProperties.Controls.Add(this.chkGrapple);
            this.grpProperties.Controls.Add(this.lblSpell);
            this.grpProperties.Controls.Add(this.lblName);
            this.grpProperties.Controls.Add(this.txtName);
            this.grpProperties.Controls.Add(this.lblRange);
            this.grpProperties.Controls.Add(this.lblSpawn);
            this.grpProperties.Controls.Add(this.lblSpeed);
            this.grpProperties.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpProperties.Location = new System.Drawing.Point(3, 3);
            this.grpProperties.Name = "grpProperties";
            this.grpProperties.Size = new System.Drawing.Size(280, 556);
            this.grpProperties.TabIndex = 18;
            this.grpProperties.TabStop = false;
            this.grpProperties.Text = "Properties";
            // 
            // lblOnlyRenderWeb
            // 
            this.lblOnlyRenderWeb.AutoSize = true;
            this.lblOnlyRenderWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOnlyRenderWeb.ForeColor = System.Drawing.Color.White;
            this.lblOnlyRenderWeb.Location = new System.Drawing.Point(84, 417);
            this.lblOnlyRenderWeb.Name = "lblOnlyRenderWeb";
            this.lblOnlyRenderWeb.Size = new System.Drawing.Size(22, 13);
            this.lblOnlyRenderWeb.TabIndex = 68;
            this.lblOnlyRenderWeb.Text = "[?]";
            this.lblOnlyRenderWeb.Visible = false;
            this.lblOnlyRenderWeb.Click += new System.EventHandler(this.lblOnlyRenderWeb_Click);
            // 
            // chkStaticProjAnim
            // 
            this.chkStaticProjAnim.AutoSize = true;
            this.chkStaticProjAnim.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStaticProjAnim.Location = new System.Drawing.Point(6, 352);
            this.chkStaticProjAnim.Name = "chkStaticProjAnim";
            this.chkStaticProjAnim.Size = new System.Drawing.Size(109, 30);
            this.chkStaticProjAnim.TabIndex = 67;
            this.chkStaticProjAnim.Text = "Static Projectiles?\r\n[Client Side Anim]";
            this.chkStaticProjAnim.CheckedChanged += new System.EventHandler(this.chkStaticProjAnim_CheckedChanged);
            // 
            // chkStaticProj
            // 
            this.chkStaticProj.AutoSize = true;
            this.chkStaticProj.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStaticProj.Location = new System.Drawing.Point(6, 286);
            this.chkStaticProj.Name = "chkStaticProj";
            this.chkStaticProj.Size = new System.Drawing.Size(107, 43);
            this.chkStaticProj.TabIndex = 65;
            this.chkStaticProj.Text = "Static Projectiles?\r\n[Anim + Spawn]\r\n(Life Time in ms)";
            this.chkStaticProj.CheckedChanged += new System.EventHandler(this.chkStaticProj_CheckedChanged);
            // 
            // lblStaticD
            // 
            this.lblStaticD.AutoSize = true;
            this.lblStaticD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaticD.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticD.Location = new System.Drawing.Point(6, 511);
            this.lblStaticD.Name = "lblStaticD";
            this.lblStaticD.Size = new System.Drawing.Size(16, 15);
            this.lblStaticD.TabIndex = 64;
            this.lblStaticD.Text = "D";
            this.lblStaticD.Visible = false;
            // 
            // nudOnlyRenderD
            // 
            this.nudOnlyRenderD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOnlyRenderD.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOnlyRenderD.Location = new System.Drawing.Point(26, 508);
            this.nudOnlyRenderD.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.nudOnlyRenderD.Name = "nudOnlyRenderD";
            this.nudOnlyRenderD.Size = new System.Drawing.Size(75, 20);
            this.nudOnlyRenderD.TabIndex = 63;
            this.nudOnlyRenderD.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOnlyRenderD.Visible = false;
            this.nudOnlyRenderD.ValueChanged += new System.EventHandler(this.nudOnlyRenderD_ValueChanged);
            // 
            // lblStaticY
            // 
            this.lblStaticY.AutoSize = true;
            this.lblStaticY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaticY.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticY.Location = new System.Drawing.Point(6, 485);
            this.lblStaticY.Name = "lblStaticY";
            this.lblStaticY.Size = new System.Drawing.Size(15, 15);
            this.lblStaticY.TabIndex = 62;
            this.lblStaticY.Text = "Y";
            this.lblStaticY.Visible = false;
            // 
            // lblStaticX
            // 
            this.lblStaticX.AutoSize = true;
            this.lblStaticX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStaticX.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaticX.Location = new System.Drawing.Point(6, 459);
            this.lblStaticX.Name = "lblStaticX";
            this.lblStaticX.Size = new System.Drawing.Size(15, 15);
            this.lblStaticX.TabIndex = 61;
            this.lblStaticX.Text = "X";
            this.lblStaticX.Visible = false;
            // 
            // nudOnlyRenderY
            // 
            this.nudOnlyRenderY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOnlyRenderY.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOnlyRenderY.Location = new System.Drawing.Point(26, 482);
            this.nudOnlyRenderY.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudOnlyRenderY.Name = "nudOnlyRenderY";
            this.nudOnlyRenderY.Size = new System.Drawing.Size(75, 20);
            this.nudOnlyRenderY.TabIndex = 60;
            this.nudOnlyRenderY.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOnlyRenderY.Visible = false;
            this.nudOnlyRenderY.ValueChanged += new System.EventHandler(this.nudOnlyRenderY_ValueChanged);
            // 
            // nudOnlyRenderX
            // 
            this.nudOnlyRenderX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudOnlyRenderX.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudOnlyRenderX.Location = new System.Drawing.Point(26, 456);
            this.nudOnlyRenderX.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.nudOnlyRenderX.Name = "nudOnlyRenderX";
            this.nudOnlyRenderX.Size = new System.Drawing.Size(75, 20);
            this.nudOnlyRenderX.TabIndex = 59;
            this.nudOnlyRenderX.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudOnlyRenderX.Visible = false;
            this.nudOnlyRenderX.ValueChanged += new System.EventHandler(this.nudOnlyRenderX_ValueChanged);
            // 
            // nudStaticProj
            // 
            this.nudStaticProj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudStaticProj.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudStaticProj.Location = new System.Drawing.Point(135, 298);
            this.nudStaticProj.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudStaticProj.Name = "nudStaticProj";
            this.nudStaticProj.Size = new System.Drawing.Size(66, 20);
            this.nudStaticProj.TabIndex = 57;
            this.nudStaticProj.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudStaticProj.Visible = false;
            this.nudStaticProj.ValueChanged += new System.EventHandler(this.nudStaticProj_ValueChanged);
            // 
            // chkOneC2Kill
            // 
            this.chkOneC2Kill.AutoSize = true;
            this.chkOneC2Kill.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOneC2Kill.Location = new System.Drawing.Point(161, 404);
            this.chkOneC2Kill.Name = "chkOneC2Kill";
            this.chkOneC2Kill.Size = new System.Drawing.Size(80, 43);
            this.chkOneC2Kill.TabIndex = 55;
            this.chkOneC2Kill.Text = "One Collide\r\nto kill Every\r\nProjectile?";
            this.chkOneC2Kill.CheckedChanged += new System.EventHandler(this.chkOneC2Kill_CheckedChanged);
            // 
            // chkOnlyRender
            // 
            this.chkOnlyRender.AutoSize = true;
            this.chkOnlyRender.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOnlyRender.Location = new System.Drawing.Point(6, 404);
            this.chkOnlyRender.Name = "chkOnlyRender";
            this.chkOnlyRender.Size = new System.Drawing.Size(87, 43);
            this.chkOnlyRender.TabIndex = 53;
            this.chkOnlyRender.Text = "Only Render\r\nProjectile\r\nAnimation at:";
            this.chkOnlyRender.CheckedChanged += new System.EventHandler(this.chkOnlyRender_CheckedChanged);
            // 
            // nudHitRadius
            // 
            this.nudHitRadius.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudHitRadius.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudHitRadius.Location = new System.Drawing.Point(135, 189);
            this.nudHitRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHitRadius.Name = "nudHitRadius";
            this.nudHitRadius.Size = new System.Drawing.Size(66, 20);
            this.nudHitRadius.TabIndex = 54;
            this.nudHitRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudHitRadius.ValueChanged += new System.EventHandler(this.nudHitRadius_ValueChanged);
            // 
            // lblHitRadius
            // 
            this.lblHitRadius.AutoSize = true;
            this.lblHitRadius.Location = new System.Drawing.Point(7, 196);
            this.lblHitRadius.Name = "lblHitRadius";
            this.lblHitRadius.Size = new System.Drawing.Size(59, 13);
            this.lblHitRadius.TabIndex = 53;
            this.lblHitRadius.Text = "Hit Radius:";
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(183, 46);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Padding = new System.Windows.Forms.Padding(5);
            this.btnAddFolder.Size = new System.Drawing.Size(18, 21);
            this.btnAddFolder.TabIndex = 52;
            this.btnAddFolder.Text = "+";
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // lblFolder
            // 
            this.lblFolder.AutoSize = true;
            this.lblFolder.Location = new System.Drawing.Point(6, 48);
            this.lblFolder.Name = "lblFolder";
            this.lblFolder.Size = new System.Drawing.Size(39, 13);
            this.lblFolder.TabIndex = 51;
            this.lblFolder.Text = "Folder:";
            // 
            // cmbFolder
            // 
            this.cmbFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbFolder.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbFolder.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbFolder.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbFolder.DrawDropdownHoverOutline = false;
            this.cmbFolder.DrawFocusRectangle = false;
            this.cmbFolder.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbFolder.FormattingEnabled = true;
            this.cmbFolder.Location = new System.Drawing.Point(69, 48);
            this.cmbFolder.Name = "cmbFolder";
            this.cmbFolder.Size = new System.Drawing.Size(108, 21);
            this.cmbFolder.TabIndex = 50;
            this.cmbFolder.Text = null;
            this.cmbFolder.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbFolder.SelectedIndexChanged += new System.EventHandler(this.cmbFolder_SelectedIndexChanged);
            // 
            // cmbSpell
            // 
            this.cmbSpell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbSpell.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbSpell.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbSpell.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbSpell.DrawDropdownHoverOutline = false;
            this.cmbSpell.DrawFocusRectangle = false;
            this.cmbSpell.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSpell.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSpell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSpell.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbSpell.FormattingEnabled = true;
            this.cmbSpell.Location = new System.Drawing.Point(87, 79);
            this.cmbSpell.Name = "cmbSpell";
            this.cmbSpell.Size = new System.Drawing.Size(114, 21);
            this.cmbSpell.TabIndex = 46;
            this.cmbSpell.Text = null;
            this.cmbSpell.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbSpell.SelectedIndexChanged += new System.EventHandler(this.cmbSpell_SelectedIndexChanged);
            // 
            // nudKnockback
            // 
            this.nudKnockback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudKnockback.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudKnockback.Location = new System.Drawing.Point(135, 162);
            this.nudKnockback.Name = "nudKnockback";
            this.nudKnockback.Size = new System.Drawing.Size(66, 20);
            this.nudKnockback.TabIndex = 45;
            this.nudKnockback.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudKnockback.ValueChanged += new System.EventHandler(this.nudKnockback_ValueChanged);
            // 
            // nudRange
            // 
            this.nudRange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudRange.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudRange.Location = new System.Drawing.Point(135, 136);
            this.nudRange.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRange.Name = "nudRange";
            this.nudRange.Size = new System.Drawing.Size(66, 20);
            this.nudRange.TabIndex = 44;
            this.nudRange.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRange.ValueChanged += new System.EventHandler(this.nudRange_ValueChanged);
            // 
            // nudAmount
            // 
            this.nudAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudAmount.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudAmount.Location = new System.Drawing.Point(135, 109);
            this.nudAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.Name = "nudAmount";
            this.nudAmount.Size = new System.Drawing.Size(66, 20);
            this.nudAmount.TabIndex = 43;
            this.nudAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmount.ValueChanged += new System.EventHandler(this.nudAmount_ValueChanged);
            // 
            // nudSpawn
            // 
            this.nudSpawn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpawn.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpawn.Location = new System.Drawing.Point(135, 217);
            this.nudSpawn.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpawn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpawn.Name = "nudSpawn";
            this.nudSpawn.Size = new System.Drawing.Size(66, 20);
            this.nudSpawn.TabIndex = 42;
            this.nudSpawn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpawn.ValueChanged += new System.EventHandler(this.nudSpawnDelay_ValueChanged);
            // 
            // nudSpeed
            // 
            this.nudSpeed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudSpeed.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudSpeed.Location = new System.Drawing.Point(135, 246);
            this.nudSpeed.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.nudSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.Name = "nudSpeed";
            this.nudSpeed.Size = new System.Drawing.Size(66, 20);
            this.nudSpeed.TabIndex = 41;
            this.nudSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSpeed.ValueChanged += new System.EventHandler(this.nudSpeed_ValueChanged);
            // 
            // lblKnockback
            // 
            this.lblKnockback.AutoSize = true;
            this.lblKnockback.Location = new System.Drawing.Point(6, 169);
            this.lblKnockback.Name = "lblKnockback";
            this.lblKnockback.Size = new System.Drawing.Size(65, 13);
            this.lblKnockback.TabIndex = 40;
            this.lblKnockback.Text = "Knockback:";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(6, 116);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(49, 13);
            this.lblAmount.TabIndex = 38;
            this.lblAmount.Text = "Quantity:";
            // 
            // chkGrapple
            // 
            this.chkGrapple.AutoSize = true;
            this.chkGrapple.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkGrapple.Location = new System.Drawing.Point(161, 352);
            this.chkGrapple.Name = "chkGrapple";
            this.chkGrapple.Size = new System.Drawing.Size(57, 30);
            this.chkGrapple.TabIndex = 36;
            this.chkGrapple.Text = "Graple\r\nhook?";
            this.chkGrapple.CheckedChanged += new System.EventHandler(this.chkGrapple_CheckedChanged);
            // 
            // lblSpell
            // 
            this.lblSpell.AutoSize = true;
            this.lblSpell.Location = new System.Drawing.Point(6, 84);
            this.lblSpell.Name = "lblSpell";
            this.lblSpell.Size = new System.Drawing.Size(74, 13);
            this.lblSpell.TabIndex = 24;
            this.lblSpell.Text = "Collision Spell:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 21);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(38, 13);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "Name:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.txtName.Location = new System.Drawing.Point(69, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 20);
            this.txtName.TabIndex = 18;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Location = new System.Drawing.Point(6, 143);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(42, 13);
            this.lblRange.TabIndex = 7;
            this.lblRange.Text = "Range:";
            // 
            // lblSpawn
            // 
            this.lblSpawn.AutoSize = true;
            this.lblSpawn.Location = new System.Drawing.Point(6, 222);
            this.lblSpawn.Name = "lblSpawn";
            this.lblSpawn.Size = new System.Drawing.Size(95, 13);
            this.lblSpawn.TabIndex = 4;
            this.lblSpawn.Text = "Spawn Delay (ms):";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(6, 251);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(63, 13);
            this.lblSpeed.TabIndex = 3;
            this.lblSpeed.Text = "Speed (ms):";
            // 
            // grpAnimations
            // 
            this.grpAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAnimations.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAnimations.Controls.Add(this.cmbAnimation);
            this.grpAnimations.Controls.Add(this.btnRemove);
            this.grpAnimations.Controls.Add(this.btnAdd);
            this.grpAnimations.Controls.Add(this.chkRotation);
            this.grpAnimations.Controls.Add(this.lblAnimation);
            this.grpAnimations.Controls.Add(this.lstAnimations);
            this.grpAnimations.Controls.Add(this.lblSpawnRange);
            this.grpAnimations.Controls.Add(this.scrlSpawnRange);
            this.grpAnimations.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAnimations.Location = new System.Drawing.Point(292, 265);
            this.grpAnimations.Name = "grpAnimations";
            this.grpAnimations.Size = new System.Drawing.Size(258, 294);
            this.grpAnimations.TabIndex = 27;
            this.grpAnimations.TabStop = false;
            this.grpAnimations.Text = "Animations";
            // 
            // cmbAnimation
            // 
            this.cmbAnimation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbAnimation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbAnimation.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbAnimation.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbAnimation.DrawDropdownHoverOutline = false;
            this.cmbAnimation.DrawFocusRectangle = false;
            this.cmbAnimation.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbAnimation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbAnimation.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbAnimation.FormattingEnabled = true;
            this.cmbAnimation.Location = new System.Drawing.Point(71, 170);
            this.cmbAnimation.Name = "cmbAnimation";
            this.cmbAnimation.Size = new System.Drawing.Size(192, 21);
            this.cmbAnimation.TabIndex = 39;
            this.cmbAnimation.Text = null;
            this.cmbAnimation.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbAnimation.SelectedIndexChanged += new System.EventHandler(this.cmbAnimation_SelectedIndexChanged);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(188, 262);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Padding = new System.Windows.Forms.Padding(5);
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 38;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 262);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5);
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // chkRotation
            // 
            this.chkRotation.AutoSize = true;
            this.chkRotation.Location = new System.Drawing.Point(12, 235);
            this.chkRotation.Name = "chkRotation";
            this.chkRotation.Size = new System.Drawing.Size(138, 17);
            this.chkRotation.TabIndex = 36;
            this.chkRotation.Text = "Auto Rotate Animation?";
            this.chkRotation.CheckedChanged += new System.EventHandler(this.chkRotation_CheckedChanged);
            // 
            // lblAnimation
            // 
            this.lblAnimation.AutoSize = true;
            this.lblAnimation.Location = new System.Drawing.Point(9, 170);
            this.lblAnimation.Name = "lblAnimation";
            this.lblAnimation.Size = new System.Drawing.Size(56, 13);
            this.lblAnimation.TabIndex = 31;
            this.lblAnimation.Text = "Animation:";
            // 
            // lstAnimations
            // 
            this.lstAnimations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.lstAnimations.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstAnimations.ForeColor = System.Drawing.Color.Gainsboro;
            this.lstAnimations.FormattingEnabled = true;
            this.lstAnimations.Items.AddRange(new object[] {
            "[Spawn Range: 1 - 1] Animation: None"});
            this.lstAnimations.Location = new System.Drawing.Point(6, 19);
            this.lstAnimations.Name = "lstAnimations";
            this.lstAnimations.Size = new System.Drawing.Size(251, 145);
            this.lstAnimations.TabIndex = 29;
            this.lstAnimations.Click += new System.EventHandler(this.lstAnimations_Click);
            // 
            // lblSpawnRange
            // 
            this.lblSpawnRange.AutoSize = true;
            this.lblSpawnRange.Location = new System.Drawing.Point(9, 199);
            this.lblSpawnRange.Name = "lblSpawnRange";
            this.lblSpawnRange.Size = new System.Drawing.Size(102, 13);
            this.lblSpawnRange.TabIndex = 28;
            this.lblSpawnRange.Text = "Spawn Range: 1 - 1";
            // 
            // scrlSpawnRange
            // 
            this.scrlSpawnRange.Location = new System.Drawing.Point(12, 214);
            this.scrlSpawnRange.Minimum = 1;
            this.scrlSpawnRange.Name = "scrlSpawnRange";
            this.scrlSpawnRange.ScrollOrientation = DarkUI.Controls.DarkScrollOrientation.Horizontal;
            this.scrlSpawnRange.Size = new System.Drawing.Size(251, 17);
            this.scrlSpawnRange.TabIndex = 27;
            this.scrlSpawnRange.Value = 1;
            this.scrlSpawnRange.ValueChanged += new System.EventHandler<DarkUI.Controls.ScrollValueEventArgs>(this.scrlSpawnRange_Scroll);
            // 
            // grpCollisions
            // 
            this.grpCollisions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpCollisions.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpCollisions.Controls.Add(this.chkPierce);
            this.grpCollisions.Controls.Add(this.chkIgnoreInactiveResources);
            this.grpCollisions.Controls.Add(this.chkIgnoreZDimensionBlocks);
            this.grpCollisions.Controls.Add(this.chkIgnoreMapBlocks);
            this.grpCollisions.Controls.Add(this.chkIgnoreActiveResources);
            this.grpCollisions.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpCollisions.Location = new System.Drawing.Point(276, 565);
            this.grpCollisions.Name = "grpCollisions";
            this.grpCollisions.Size = new System.Drawing.Size(274, 83);
            this.grpCollisions.TabIndex = 29;
            this.grpCollisions.TabStop = false;
            this.grpCollisions.Text = "Ignore Collision:";
            // 
            // chkPierce
            // 
            this.chkPierce.AutoSize = true;
            this.chkPierce.Location = new System.Drawing.Point(146, 16);
            this.chkPierce.Name = "chkPierce";
            this.chkPierce.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkPierce.Size = new System.Drawing.Size(96, 17);
            this.chkPierce.TabIndex = 39;
            this.chkPierce.Text = "Pierce Target?";
            this.chkPierce.CheckedChanged += new System.EventHandler(this.chkPierce_CheckedChanged);
            // 
            // chkIgnoreInactiveResources
            // 
            this.chkIgnoreInactiveResources.AutoSize = true;
            this.chkIgnoreInactiveResources.Location = new System.Drawing.Point(146, 39);
            this.chkIgnoreInactiveResources.Name = "chkIgnoreInactiveResources";
            this.chkIgnoreInactiveResources.Size = new System.Drawing.Size(118, 17);
            this.chkIgnoreInactiveResources.TabIndex = 38;
            this.chkIgnoreInactiveResources.Text = "Inactive Resources";
            this.chkIgnoreInactiveResources.CheckedChanged += new System.EventHandler(this.chkIgnoreInactiveResources_CheckedChanged);
            // 
            // chkIgnoreZDimensionBlocks
            // 
            this.chkIgnoreZDimensionBlocks.AutoSize = true;
            this.chkIgnoreZDimensionBlocks.Location = new System.Drawing.Point(6, 62);
            this.chkIgnoreZDimensionBlocks.Name = "chkIgnoreZDimensionBlocks";
            this.chkIgnoreZDimensionBlocks.Size = new System.Drawing.Size(120, 17);
            this.chkIgnoreZDimensionBlocks.TabIndex = 37;
            this.chkIgnoreZDimensionBlocks.Text = "Z-Dimension Blocks";
            this.chkIgnoreZDimensionBlocks.CheckedChanged += new System.EventHandler(this.chkIgnoreZDimensionBlocks_CheckedChanged);
            // 
            // chkIgnoreMapBlocks
            // 
            this.chkIgnoreMapBlocks.AutoSize = true;
            this.chkIgnoreMapBlocks.Location = new System.Drawing.Point(6, 16);
            this.chkIgnoreMapBlocks.Name = "chkIgnoreMapBlocks";
            this.chkIgnoreMapBlocks.Size = new System.Drawing.Size(82, 17);
            this.chkIgnoreMapBlocks.TabIndex = 33;
            this.chkIgnoreMapBlocks.Text = "Map Blocks";
            this.chkIgnoreMapBlocks.CheckedChanged += new System.EventHandler(this.chkIgnoreMapBlocks_CheckedChanged);
            // 
            // chkIgnoreActiveResources
            // 
            this.chkIgnoreActiveResources.AutoSize = true;
            this.chkIgnoreActiveResources.Location = new System.Drawing.Point(6, 39);
            this.chkIgnoreActiveResources.Name = "chkIgnoreActiveResources";
            this.chkIgnoreActiveResources.Size = new System.Drawing.Size(110, 17);
            this.chkIgnoreActiveResources.TabIndex = 36;
            this.chkIgnoreActiveResources.Text = "Active Resources";
            this.chkIgnoreActiveResources.CheckedChanged += new System.EventHandler(this.chkIgnoreActiveResources_CheckedChanged);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.grpAmmo);
            this.pnlContainer.Controls.Add(this.grpCollisions);
            this.pnlContainer.Controls.Add(this.grpProperties);
            this.pnlContainer.Controls.Add(this.grpAnimations);
            this.pnlContainer.Controls.Add(this.grpSpawns);
            this.pnlContainer.Location = new System.Drawing.Point(221, 36);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(553, 654);
            this.pnlContainer.TabIndex = 30;
            this.pnlContainer.Visible = false;
            // 
            // grpAmmo
            // 
            this.grpAmmo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.grpAmmo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.grpAmmo.Controls.Add(this.nudConsume);
            this.grpAmmo.Controls.Add(this.cmbItem);
            this.grpAmmo.Controls.Add(this.lblAmmoItem);
            this.grpAmmo.Controls.Add(this.lblAmmoAmount);
            this.grpAmmo.ForeColor = System.Drawing.Color.Gainsboro;
            this.grpAmmo.Location = new System.Drawing.Point(14, 565);
            this.grpAmmo.Name = "grpAmmo";
            this.grpAmmo.Size = new System.Drawing.Size(207, 83);
            this.grpAmmo.TabIndex = 30;
            this.grpAmmo.TabStop = false;
            this.grpAmmo.Text = "Ammunition Requirements: ";
            // 
            // nudConsume
            // 
            this.nudConsume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.nudConsume.ForeColor = System.Drawing.Color.Gainsboro;
            this.nudConsume.Location = new System.Drawing.Point(83, 53);
            this.nudConsume.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConsume.Name = "nudConsume";
            this.nudConsume.Size = new System.Drawing.Size(108, 20);
            this.nudConsume.TabIndex = 46;
            this.nudConsume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudConsume.ValueChanged += new System.EventHandler(this.nudConsume_ValueChanged);
            // 
            // cmbItem
            // 
            this.cmbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.cmbItem.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.cmbItem.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmbItem.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.cmbItem.DrawDropdownHoverOutline = false;
            this.cmbItem.DrawFocusRectangle = false;
            this.cmbItem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbItem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(83, 19);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(108, 21);
            this.cmbItem.TabIndex = 26;
            this.cmbItem.Text = null;
            this.cmbItem.TextPadding = new System.Windows.Forms.Padding(2);
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // lblAmmoItem
            // 
            this.lblAmmoItem.AutoSize = true;
            this.lblAmmoItem.Location = new System.Drawing.Point(9, 19);
            this.lblAmmoItem.Name = "lblAmmoItem";
            this.lblAmmoItem.Size = new System.Drawing.Size(30, 13);
            this.lblAmmoItem.TabIndex = 25;
            this.lblAmmoItem.Text = "Item:";
            // 
            // lblAmmoAmount
            // 
            this.lblAmmoAmount.AutoSize = true;
            this.lblAmmoAmount.Location = new System.Drawing.Point(9, 53);
            this.lblAmmoAmount.Name = "lblAmmoAmount";
            this.lblAmmoAmount.Size = new System.Drawing.Size(46, 13);
            this.lblAmmoAmount.TabIndex = 9;
            this.lblAmmoAmount.Text = "Amount:";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(485, 704);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(5);
            this.btnCancel.Size = new System.Drawing.Size(250, 27);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(221, 704);
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5);
            this.btnSave.Size = new System.Drawing.Size(250, 27);
            this.btnSave.TabIndex = 31;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripItemNew,
            this.toolStripSeparator1,
            this.toolStripItemDelete,
            this.toolStripSeparator2,
            this.btnChronological,
            this.toolStripSeparator4,
            this.toolStripItemCopy,
            this.toolStripItemPaste,
            this.toolStripSeparator3,
            this.toolStripItemUndo});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStrip.Size = new System.Drawing.Size(786, 25);
            this.toolStrip.TabIndex = 46;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripItemNew
            // 
            this.toolStripItemNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemNew.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemNew.Image")));
            this.toolStripItemNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemNew.Name = "toolStripItemNew";
            this.toolStripItemNew.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemNew.Text = "New";
            this.toolStripItemNew.Click += new System.EventHandler(this.toolStripItemNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemDelete
            // 
            this.toolStripItemDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemDelete.Enabled = false;
            this.toolStripItemDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemDelete.Image")));
            this.toolStripItemDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemDelete.Name = "toolStripItemDelete";
            this.toolStripItemDelete.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemDelete.Text = "Delete";
            this.toolStripItemDelete.Click += new System.EventHandler(this.toolStripItemDelete_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnChronological
            // 
            this.btnChronological.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnChronological.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnChronological.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnChronological.Name = "btnChronological";
            this.btnChronological.Size = new System.Drawing.Size(23, 22);
            this.btnChronological.Text = "Order Chronologically";
            this.btnChronological.Click += new System.EventHandler(this.btnChronological_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator4.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemCopy
            // 
            this.toolStripItemCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemCopy.Enabled = false;
            this.toolStripItemCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemCopy.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemCopy.Image")));
            this.toolStripItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemCopy.Name = "toolStripItemCopy";
            this.toolStripItemCopy.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemCopy.Text = "Copy";
            this.toolStripItemCopy.Click += new System.EventHandler(this.toolStripItemCopy_Click);
            // 
            // toolStripItemPaste
            // 
            this.toolStripItemPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemPaste.Enabled = false;
            this.toolStripItemPaste.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemPaste.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemPaste.Image")));
            this.toolStripItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemPaste.Name = "toolStripItemPaste";
            this.toolStripItemPaste.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemPaste.Text = "Paste";
            this.toolStripItemPaste.Click += new System.EventHandler(this.toolStripItemPaste_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripItemUndo
            // 
            this.toolStripItemUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItemUndo.Enabled = false;
            this.toolStripItemUndo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripItemUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItemUndo.Image")));
            this.toolStripItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItemUndo.Name = "toolStripItemUndo";
            this.toolStripItemUndo.Size = new System.Drawing.Size(23, 22);
            this.toolStripItemUndo.Text = "Undo";
            this.toolStripItemUndo.Click += new System.EventHandler(this.toolStripItemUndo_Click);
            // 
            // FrmProjectile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(786, 743);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpProjectiles);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmProjectile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projectile Editor";
            this.Load += new System.EventHandler(this.frmProjectile_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.form_KeyDown);
            this.grpProjectiles.ResumeLayout(false);
            this.grpProjectiles.PerformLayout();
            this.grpSpawns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSpawns)).EndInit();
            this.grpProperties.ResumeLayout(false);
            this.grpProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnlyRenderD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnlyRenderY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudOnlyRenderX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStaticProj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHitRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKnockback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpawn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSpeed)).EndInit();
            this.grpAnimations.ResumeLayout(false);
            this.grpAnimations.PerformLayout();
            this.grpCollisions.ResumeLayout(false);
            this.grpCollisions.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            this.grpAmmo.ResumeLayout(false);
            this.grpAmmo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudConsume)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DarkGroupBox grpProjectiles;
        private DarkGroupBox grpSpawns;
        public System.Windows.Forms.PictureBox picSpawns;
        private DarkGroupBox grpProperties;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblSpawn;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblName;
        private DarkTextBox txtName;
        private System.Windows.Forms.Label lblSpell;
        private DarkCheckBox chkGrapple;
        private DarkGroupBox grpAnimations;
        private DarkCheckBox chkRotation;
        private System.Windows.Forms.Label lblAnimation;
        private System.Windows.Forms.ListBox lstAnimations;
        private System.Windows.Forms.Label lblSpawnRange;
        private DarkScrollBar scrlSpawnRange;
        private DarkGroupBox grpCollisions;
        private DarkCheckBox chkIgnoreInactiveResources;
        private DarkCheckBox chkIgnoreZDimensionBlocks;
        private DarkCheckBox chkIgnoreMapBlocks;
        private DarkCheckBox chkIgnoreActiveResources;
        private DarkButton btnRemove;
        private DarkButton btnAdd;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel pnlContainer;
        private DarkButton btnSave;
        private DarkButton btnCancel;
        private System.Windows.Forms.Label lblKnockback;
        private DarkToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripItemNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripItemDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        public System.Windows.Forms.ToolStripButton toolStripItemCopy;
        public System.Windows.Forms.ToolStripButton toolStripItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        public System.Windows.Forms.ToolStripButton toolStripItemUndo;
        private DarkGroupBox grpAmmo;
        private System.Windows.Forms.Label lblAmmoAmount;
        private DarkComboBox cmbItem;
        private System.Windows.Forms.Label lblAmmoItem;
        private DarkComboBox cmbAnimation;
        private DarkComboBox cmbSpell;
        private DarkNumericUpDown nudKnockback;
        private DarkNumericUpDown nudRange;
        private DarkNumericUpDown nudAmount;
        private DarkNumericUpDown nudSpawn;
        private DarkNumericUpDown nudSpeed;
        private DarkNumericUpDown nudConsume;
        private DarkButton btnClearSearch;
        private DarkTextBox txtSearch;
        public System.Windows.Forms.TreeView lstProjectiles;
        private DarkButton btnAddFolder;
        private System.Windows.Forms.Label lblFolder;
        private DarkComboBox cmbFolder;
        private System.Windows.Forms.ToolStripButton btnChronological;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ImageList imageList;
    private DarkCheckBox chkPierce;
        private DarkCheckBox chkOnlyRender;
        private DarkNumericUpDown nudHitRadius;
        private System.Windows.Forms.Label lblHitRadius;
        private DarkCheckBox chkOneC2Kill;
        private DarkNumericUpDown nudStaticProj;
        private DarkCheckBox chkStaticProj;
        private DarkCheckBox chkStaticProjAnim;
        private System.Windows.Forms.Label lblStaticD;
        private DarkNumericUpDown nudOnlyRenderD;
        private System.Windows.Forms.Label lblStaticY;
        private System.Windows.Forms.Label lblStaticX;
        private DarkNumericUpDown nudOnlyRenderY;
        private DarkNumericUpDown nudOnlyRenderX;
        private System.Windows.Forms.Label lblOnlyRenderWeb;
    }
}
