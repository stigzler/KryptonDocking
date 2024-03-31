namespace KryptonDocking
{
    partial class Form1
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonDockableWorkspace1 = new Krypton.Docking.KryptonDockableWorkspace();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.kryptonManager1 = new Krypton.Toolkit.KryptonManager(this.components);
            this.dockingManager = new Krypton.Docking.KryptonDockingManager();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.console = new KryptonDocking.UserControls.Console();
            this.SaveDockingBT = new System.Windows.Forms.ToolStripButton();
            this.LoadWindowsBT = new System.Windows.Forms.ToolStripButton();
            this.ResetDockingBT = new System.Windows.Forms.ToolStripButton();
            this.ViewWindowsStringBT = new System.Windows.Forms.ToolStripButton();
            this.AddTextDocumentBT = new System.Windows.Forms.ToolStripButton();
            this.GetInfoBT = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveDockingBT,
            this.LoadWindowsBT,
            this.ResetDockingBT,
            this.ViewWindowsStringBT,
            this.AddTextDocumentBT,
            this.GetInfoBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(952, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonDockableWorkspace1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Padding = new System.Windows.Forms.Padding(2);
            this.kryptonPanel1.Size = new System.Drawing.Size(952, 293);
            this.kryptonPanel1.TabIndex = 1;
            // 
            // kryptonDockableWorkspace1
            // 
            this.kryptonDockableWorkspace1.ActivePage = null;
            this.kryptonDockableWorkspace1.AutoHiddenHost = false;
            this.kryptonDockableWorkspace1.CompactFlags = ((Krypton.Workspace.CompactFlags)(((Krypton.Workspace.CompactFlags.RemoveEmptyCells | Krypton.Workspace.CompactFlags.RemoveEmptySequences) 
            | Krypton.Workspace.CompactFlags.PromoteLeafs)));
            this.kryptonDockableWorkspace1.ContainerBackStyle = Krypton.Toolkit.PaletteBackStyle.PanelClient;
            this.kryptonDockableWorkspace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonDockableWorkspace1.Location = new System.Drawing.Point(2, 2);
            this.kryptonDockableWorkspace1.Name = "kryptonDockableWorkspace1";
            // 
            // 
            // 
            this.kryptonDockableWorkspace1.Root.UniqueName = "d40fe784de934f13b02da6e6d4309b72";
            this.kryptonDockableWorkspace1.Root.WorkspaceControl = this.kryptonDockableWorkspace1;
            this.kryptonDockableWorkspace1.SeparatorStyle = Krypton.Toolkit.SeparatorStyle.LowProfile;
            this.kryptonDockableWorkspace1.ShowMaximizeButton = false;
            this.kryptonDockableWorkspace1.Size = new System.Drawing.Size(948, 289);
            this.kryptonDockableWorkspace1.SplitterWidth = 5;
            this.kryptonDockableWorkspace1.TabIndex = 1;
            this.kryptonDockableWorkspace1.TabStop = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 612);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(952, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.kryptonPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.console);
            this.splitContainer1.Size = new System.Drawing.Size(952, 587);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 3;
            // 
            // console
            // 
            this.console.Dock = System.Windows.Forms.DockStyle.Fill;
            this.console.Location = new System.Drawing.Point(0, 0);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(952, 290);
            this.console.TabIndex = 2;
            // 
            // SaveDockingBT
            // 
            this.SaveDockingBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveDockingBT.Image = global::KryptonDocking.Properties.Resources.disk;
            this.SaveDockingBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveDockingBT.Name = "SaveDockingBT";
            this.SaveDockingBT.Size = new System.Drawing.Size(23, 22);
            this.SaveDockingBT.Text = "toolStripButton2";
            this.SaveDockingBT.ToolTipText = "Save Docking State";
            this.SaveDockingBT.Click += new System.EventHandler(this.SaveDockingBT_Click);
            // 
            // LoadWindowsBT
            // 
            this.LoadWindowsBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LoadWindowsBT.Image = global::KryptonDocking.Properties.Resources.folder_horizontal_open;
            this.LoadWindowsBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LoadWindowsBT.Name = "LoadWindowsBT";
            this.LoadWindowsBT.Size = new System.Drawing.Size(23, 22);
            this.LoadWindowsBT.Text = "toolStripButton2";
            this.LoadWindowsBT.ToolTipText = "Load Docking State";
            this.LoadWindowsBT.Click += new System.EventHandler(this.LoadWindowsBT_Click);
            // 
            // ResetDockingBT
            // 
            this.ResetDockingBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ResetDockingBT.Image = global::KryptonDocking.Properties.Resources.arrow_circle_315_left;
            this.ResetDockingBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ResetDockingBT.Name = "ResetDockingBT";
            this.ResetDockingBT.Size = new System.Drawing.Size(23, 22);
            this.ResetDockingBT.Text = "toolStripButton1";
            this.ResetDockingBT.ToolTipText = "Reset Docking Persistance";
            this.ResetDockingBT.Click += new System.EventHandler(this.ResetDockingBT_Click);
            // 
            // ViewWindowsStringBT
            // 
            this.ViewWindowsStringBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ViewWindowsStringBT.Image = global::KryptonDocking.Properties.Resources.eye;
            this.ViewWindowsStringBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ViewWindowsStringBT.Name = "ViewWindowsStringBT";
            this.ViewWindowsStringBT.Size = new System.Drawing.Size(23, 22);
            this.ViewWindowsStringBT.Text = "toolStripButton1";
            this.ViewWindowsStringBT.ToolTipText = "Show docking persistence string";
            this.ViewWindowsStringBT.Click += new System.EventHandler(this.ViewWindowsStringBT_Click);
            // 
            // AddTextDocumentBT
            // 
            this.AddTextDocumentBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddTextDocumentBT.Image = global::KryptonDocking.Properties.Resources.plus_button;
            this.AddTextDocumentBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddTextDocumentBT.Name = "AddTextDocumentBT";
            this.AddTextDocumentBT.Size = new System.Drawing.Size(23, 22);
            this.AddTextDocumentBT.Text = "toolStripButton1";
            this.AddTextDocumentBT.ToolTipText = "Add Text Document to Document Group";
            this.AddTextDocumentBT.Click += new System.EventHandler(this.AddTextDocumentBT_Click);
            // 
            // GetInfoBT
            // 
            this.GetInfoBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GetInfoBT.Image = global::KryptonDocking.Properties.Resources.information;
            this.GetInfoBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GetInfoBT.Name = "GetInfoBT";
            this.GetInfoBT.Size = new System.Drawing.Size(23, 22);
            this.GetInfoBT.Text = "toolStripButton1";
            this.GetInfoBT.ToolTipText = "Get full info about present state";
            this.GetInfoBT.Click += new System.EventHandler(this.GetInfoBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 634);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonDockableWorkspace1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ResetDockingBT;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Docking.KryptonDockableWorkspace kryptonDockableWorkspace1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Docking.KryptonDockingManager dockingManager;
        private System.Windows.Forms.ToolStripButton LoadWindowsBT;
        private System.Windows.Forms.ToolStripButton SaveDockingBT;
        private System.Windows.Forms.ToolStripButton ViewWindowsStringBT;
        private UserControls.Console console;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripButton AddTextDocumentBT;
        private System.Windows.Forms.ToolStripButton GetInfoBT;
    }
}

