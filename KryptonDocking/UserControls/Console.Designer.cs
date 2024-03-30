namespace KryptonDocking.UserControls
{
    partial class Console
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ClearScreenBT = new System.Windows.Forms.ToolStripButton();
            this.WordWrapBT = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearScreenBT,
            this.WordWrapBT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(371, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ClearScreenBT
            // 
            this.ClearScreenBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ClearScreenBT.Image = global::KryptonDocking.Properties.Resources.eraser;
            this.ClearScreenBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ClearScreenBT.Name = "ClearScreenBT";
            this.ClearScreenBT.Size = new System.Drawing.Size(23, 22);
            this.ClearScreenBT.Text = "toolStripButton1";
            this.ClearScreenBT.Click += new System.EventHandler(this.ClearScreenBT_Click);
            // 
            // WordWrapBT
            // 
            this.WordWrapBT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.WordWrapBT.Image = global::KryptonDocking.Properties.Resources.arrow_return_180;
            this.WordWrapBT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.WordWrapBT.Name = "WordWrapBT";
            this.WordWrapBT.Size = new System.Drawing.Size(23, 22);
            this.WordWrapBT.Text = "toolStripButton1";
            this.WordWrapBT.Click += new System.EventHandler(this.WordWrapBT_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(371, 380);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Console";
            this.Size = new System.Drawing.Size(371, 405);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ClearScreenBT;
        private System.Windows.Forms.ToolStripButton WordWrapBT;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
