namespace EditCinima
{
    partial class EditCine
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Scene");
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.CineMenu = new System.Windows.Forms.MenuStrip();
            this.graphToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graphToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savePayLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.SceneTree = new System.Windows.Forms.TreeView();
            this.PropGrid = new System.Windows.Forms.PropertyGrid();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Visual = new StarEngine.App.StarControl();
            this.UI2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BStopGame = new System.Windows.Forms.Button();
            this.BRunGame = new System.Windows.Forms.Button();
            this.UpdateTick = new System.Windows.Forms.Timer(this.components);
            this.SceneTreeMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SMRename = new System.Windows.Forms.ToolStripMenuItem();
            this.SMDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SMNewScript = new System.Windows.Forms.ToolStripMenuItem();
            this.SMLoadScript = new System.Windows.Forms.ToolStripMenuItem();
            this.BrowseFile = new System.Windows.Forms.OpenFileDialog();
            this.EditMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.moveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loadPayloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.CineMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.UI2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SceneTreeMenu.SuspendLayout();
            this.EditMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1284, 616);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer4
            // 
            this.splitContainer4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.CineMenu);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer5);
            this.splitContainer4.Size = new System.Drawing.Size(268, 616);
            this.splitContainer4.SplitterDistance = 42;
            this.splitContainer4.TabIndex = 0;
            // 
            // CineMenu
            // 
            this.CineMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem});
            this.CineMenu.Location = new System.Drawing.Point(0, 0);
            this.CineMenu.Name = "CineMenu";
            this.CineMenu.Size = new System.Drawing.Size(264, 24);
            this.CineMenu.TabIndex = 0;
            this.CineMenu.Text = "menuStrip1";
            // 
            // graphToolStripMenuItem
            // 
            this.graphToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.graphToolStripMenuItem1,
            this.newSceneToolStripMenuItem,
            this.loadSceneToolStripMenuItem,
            this.saveSceneToolStripMenuItem,
            this.savePayLoadToolStripMenuItem,
            this.loadPayloadToolStripMenuItem});
            this.graphToolStripMenuItem.Name = "graphToolStripMenuItem";
            this.graphToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.graphToolStripMenuItem.Text = "Cine";
            // 
            // graphToolStripMenuItem1
            // 
            this.graphToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newSpriteToolStripMenuItem});
            this.graphToolStripMenuItem1.Name = "graphToolStripMenuItem1";
            this.graphToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.graphToolStripMenuItem1.Text = "Graph";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newToolStripMenuItem.Text = "New Node";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.CineGraphNewNode);
            // 
            // newSpriteToolStripMenuItem
            // 
            this.newSpriteToolStripMenuItem.Name = "newSpriteToolStripMenuItem";
            this.newSpriteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.newSpriteToolStripMenuItem.Text = "New Sprite";
            this.newSpriteToolStripMenuItem.Click += new System.EventHandler(this.CineGraphNewSprite);
            // 
            // newSceneToolStripMenuItem
            // 
            this.newSceneToolStripMenuItem.Name = "newSceneToolStripMenuItem";
            this.newSceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSceneToolStripMenuItem.Text = "New Scene";
            this.newSceneToolStripMenuItem.Click += new System.EventHandler(this.newSceneToolStripMenuItem_Click);
            // 
            // loadSceneToolStripMenuItem
            // 
            this.loadSceneToolStripMenuItem.Name = "loadSceneToolStripMenuItem";
            this.loadSceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadSceneToolStripMenuItem.Text = "Load Scene";
            this.loadSceneToolStripMenuItem.Click += new System.EventHandler(this.loadSceneToolStripMenuItem_Click);
            // 
            // saveSceneToolStripMenuItem
            // 
            this.saveSceneToolStripMenuItem.Name = "saveSceneToolStripMenuItem";
            this.saveSceneToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveSceneToolStripMenuItem.Text = "Save Scene";
            // 
            // savePayLoadToolStripMenuItem
            // 
            this.savePayLoadToolStripMenuItem.Name = "savePayLoadToolStripMenuItem";
            this.savePayLoadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.savePayLoadToolStripMenuItem.Text = "Save PayLoad";
            this.savePayLoadToolStripMenuItem.Click += new System.EventHandler(this.savePayLoadToolStripMenuItem_Click);
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.SceneTree);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.PropGrid);
            this.splitContainer5.Size = new System.Drawing.Size(268, 570);
            this.splitContainer5.SplitterDistance = 270;
            this.splitContainer5.TabIndex = 0;
            // 
            // SceneTree
            // 
            this.SceneTree.AllowDrop = true;
            this.SceneTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SceneTree.LabelEdit = true;
            this.SceneTree.Location = new System.Drawing.Point(0, 0);
            this.SceneTree.Name = "SceneTree";
            treeNode1.Name = "SceneRoot";
            treeNode1.Text = "Scene";
            this.SceneTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.SceneTree.Size = new System.Drawing.Size(264, 266);
            this.SceneTree.TabIndex = 1;
            this.SceneTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.SceneTree_BeforeLabelEdit);
            this.SceneTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.SceneTree_AfterLabelEdit);
            this.SceneTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.SceneTree_AfterSelect);
            this.SceneTree.Click += new System.EventHandler(this.SceneTree_Click);
            this.SceneTree.DragDrop += new System.Windows.Forms.DragEventHandler(this.SceneTree_DragDrop);
            this.SceneTree.DragEnter += new System.Windows.Forms.DragEventHandler(this.SceneTree_DragEnter);
            // 
            // PropGrid
            // 
            this.PropGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropGrid.Location = new System.Drawing.Point(0, 0);
            this.PropGrid.Name = "PropGrid";
            this.PropGrid.Size = new System.Drawing.Size(264, 292);
            this.PropGrid.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.Visual);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.UI2);
            this.splitContainer2.Size = new System.Drawing.Size(1012, 616);
            this.splitContainer2.SplitterDistance = 330;
            this.splitContainer2.TabIndex = 0;
            // 
            // Visual
            // 
            this.Visual.BackColor = System.Drawing.Color.Black;
            this.Visual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Visual.Location = new System.Drawing.Point(0, 0);
            this.Visual.Name = "Visual";
            this.Visual.Size = new System.Drawing.Size(1008, 326);
            this.Visual.TabIndex = 0;
            this.Visual.VSync = false;
            this.Visual.Load += new System.EventHandler(this.starControl1_Load);
            this.Visual.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Visual_Scroll);
            this.Visual.Paint += new System.Windows.Forms.PaintEventHandler(this.Visual_Paint_1);
            this.Visual.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Visual_MouseDown);
            this.Visual.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Visual_MouseMove);
            this.Visual.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Visual_MouseUp);
            this.Visual.Resize += new System.EventHandler(this.Visual_Resize_1);
            // 
            // UI2
            // 
            this.UI2.Controls.Add(this.tabPage1);
            this.UI2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UI2.Location = new System.Drawing.Point(0, 0);
            this.UI2.Name = "UI2";
            this.UI2.SelectedIndex = 0;
            this.UI2.Size = new System.Drawing.Size(1008, 278);
            this.UI2.TabIndex = 0;
            this.UI2.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI2_DragEnter);
            this.UI2.DragOver += new System.Windows.Forms.DragEventHandler(this.UI2_DragOver);
            this.UI2.DoubleClick += new System.EventHandler(this.UI2_DoubleClick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BStopGame);
            this.tabPage1.Controls.Add(this.BRunGame);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1000, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BStopGame
            // 
            this.BStopGame.Enabled = false;
            this.BStopGame.Location = new System.Drawing.Point(127, 7);
            this.BStopGame.Name = "BStopGame";
            this.BStopGame.Size = new System.Drawing.Size(114, 23);
            this.BStopGame.TabIndex = 1;
            this.BStopGame.Text = "Stop Game";
            this.BStopGame.UseVisualStyleBackColor = true;
            this.BStopGame.Click += new System.EventHandler(this.BStopGame_Click);
            // 
            // BRunGame
            // 
            this.BRunGame.Location = new System.Drawing.Point(7, 7);
            this.BRunGame.Name = "BRunGame";
            this.BRunGame.Size = new System.Drawing.Size(114, 23);
            this.BRunGame.TabIndex = 0;
            this.BRunGame.Text = "Run Game";
            this.BRunGame.UseVisualStyleBackColor = true;
            this.BRunGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // UpdateTick
            // 
            this.UpdateTick.Interval = 40;
            this.UpdateTick.Tick += new System.EventHandler(this.UpdateTick_Tick);
            // 
            // SceneTreeMenu
            // 
            this.SceneTreeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SMRename,
            this.SMDelete,
            this.toolStripSeparator1,
            this.SMNewScript,
            this.SMLoadScript});
            this.SceneTreeMenu.Name = "SceneTreeMenu";
            this.SceneTreeMenu.Size = new System.Drawing.Size(134, 98);
            this.SceneTreeMenu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.SceneTreeMenu_ItemClicked);
            // 
            // SMRename
            // 
            this.SMRename.Name = "SMRename";
            this.SMRename.Size = new System.Drawing.Size(133, 22);
            this.SMRename.Text = "Rename";
            // 
            // SMDelete
            // 
            this.SMDelete.Name = "SMDelete";
            this.SMDelete.Size = new System.Drawing.Size(133, 22);
            this.SMDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
            // 
            // SMNewScript
            // 
            this.SMNewScript.Name = "SMNewScript";
            this.SMNewScript.Size = new System.Drawing.Size(133, 22);
            this.SMNewScript.Text = "New Script";
            this.SMNewScript.Click += new System.EventHandler(this.SMNewScript_Click);
            // 
            // SMLoadScript
            // 
            this.SMLoadScript.Name = "SMLoadScript";
            this.SMLoadScript.Size = new System.Drawing.Size(133, 22);
            this.SMLoadScript.Text = "Load Script";
            this.SMLoadScript.Click += new System.EventHandler(this.SMLoadScript_Click);
            // 
            // BrowseFile
            // 
            this.BrowseFile.DefaultExt = "cs";
            // 
            // EditMenu
            // 
            this.EditMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moveToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.scaleToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1});
            this.EditMenu.Name = "EditMenu";
            this.EditMenu.Size = new System.Drawing.Size(127, 98);
            // 
            // moveToolStripMenuItem
            // 
            this.moveToolStripMenuItem.Name = "moveToolStripMenuItem";
            this.moveToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.moveToolStripMenuItem.Text = "Move";
            this.moveToolStripMenuItem.Click += new System.EventHandler(this.moveToolStripMenuItem_Click);
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.rotateToolStripMenuItem.Text = "Rotate";
            this.rotateToolStripMenuItem.Click += new System.EventHandler(this.rotateToolStripMenuItem_Click);
            // 
            // scaleToolStripMenuItem
            // 
            this.scaleToolStripMenuItem.Name = "scaleToolStripMenuItem";
            this.scaleToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.scaleToolStripMenuItem.Text = "Scale";
            this.scaleToolStripMenuItem.Click += new System.EventHandler(this.scaleToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(123, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.toolStripMenuItem1.Text = "Add Light";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // loadPayloadToolStripMenuItem
            // 
            this.loadPayloadToolStripMenuItem.Name = "loadPayloadToolStripMenuItem";
            this.loadPayloadToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadPayloadToolStripMenuItem.Text = "Load Payload";
            this.loadPayloadToolStripMenuItem.Click += new System.EventHandler(this.loadPayloadToolStripMenuItem_Click);
            // 
            // EditCine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 616);
            this.Controls.Add(this.splitContainer1);
            this.MainMenuStrip = this.CineMenu;
            this.Name = "EditCine";
            this.Text = "Cine";
            this.Load += new System.EventHandler(this.EditCine_Load);
            this.Resize += new System.EventHandler(this.EditCine_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.CineMenu.ResumeLayout(false);
            this.CineMenu.PerformLayout();
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.UI2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.SceneTreeMenu.ResumeLayout(false);
            this.EditMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Timer UpdateTick;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.MenuStrip CineMenu;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graphToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSpriteToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.PropertyGrid PropGrid;
        private StarEngine.App.StarControl Visual;
        private System.Windows.Forms.ContextMenuStrip SceneTreeMenu;
        private System.Windows.Forms.ToolStripMenuItem SMRename;
        private System.Windows.Forms.ToolStripMenuItem SMDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SMNewScript;
        private System.Windows.Forms.ToolStripMenuItem SMLoadScript;
        private System.Windows.Forms.OpenFileDialog BrowseFile;
        private System.Windows.Forms.TabControl UI2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TreeView SceneTree;
        private System.Windows.Forms.Button BStopGame;
        private System.Windows.Forms.Button BRunGame;
        private System.Windows.Forms.ContextMenuStrip EditMenu;
        private System.Windows.Forms.ToolStripMenuItem moveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSceneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savePayLoadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadPayloadToolStripMenuItem;
    }
}

