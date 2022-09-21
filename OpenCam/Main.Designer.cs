namespace Test
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.original = new Emgu.CV.UI.ImageBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.srtsrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srrrToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.original)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // original
            // 
            this.original.Dock = System.Windows.Forms.DockStyle.Fill;
            this.original.Location = new System.Drawing.Point(0, 39);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(1441, 683);
            this.original.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.original.TabIndex = 2;
            this.original.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.startToolStripMenuItem,
            this.toolStripComboBox1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1441, 39);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem1,
            this.srtsrToolStripMenuItem,
            this.srrrToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(54, 33);
            this.openToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem1
            // 
            this.openToolStripMenuItem1.Name = "openToolStripMenuItem1";
            this.openToolStripMenuItem1.Size = new System.Drawing.Size(151, 34);
            this.openToolStripMenuItem1.Text = "stest";
            // 
            // srtsrToolStripMenuItem
            // 
            this.srtsrToolStripMenuItem.Name = "srtsrToolStripMenuItem";
            this.srtsrToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.srtsrToolStripMenuItem.Text = "srtsr";
            // 
            // srrrToolStripMenuItem
            // 
            this.srrrToolStripMenuItem.Name = "srrrToolStripMenuItem";
            this.srrrToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.srrrToolStripMenuItem.Text = "srrr";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(64, 33);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.runToolStripMenuItem.Text = "run";
            this.runToolStripMenuItem.Click += new System.EventHandler(this.runToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.stopToolStripMenuItem.Text = "stop";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripComboBox1
            // 
            this.toolStripComboBox1.Name = "toolStripComboBox1";
            this.toolStripComboBox1.Size = new System.Drawing.Size(427, 33);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 722);
            this.Controls.Add(this.original);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "ct";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.original)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox original;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem1;
        private ToolStripMenuItem startToolStripMenuItem;
        private ToolStripComboBox toolStripComboBox1;
        private ToolStripMenuItem srtsrToolStripMenuItem;
        private ToolStripMenuItem srrrToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem stopToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
    }
}