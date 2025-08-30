namespace TuanDepTraiVai
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boderColor = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangle = new System.Windows.Forms.ToolStripMenuItem();
            this.line = new System.Windows.Forms.ToolStripMenuItem();
            this.pic = new System.Windows.Forms.PictureBox();
            this.xoa = new System.Windows.Forms.ToolStripMenuItem();
            this.eLLIPESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boderColor,
            this.rectangle,
            this.line,
            this.eLLIPESToolStripMenuItem,
            this.xoa});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // boderColor
            // 
            this.boderColor.Name = "boderColor";
            this.boderColor.Size = new System.Drawing.Size(224, 26);
            this.boderColor.Text = "Boder Color";
            this.boderColor.Click += new System.EventHandler(this.boderColorToolStripMenuItem_Click);
            // 
            // rectangle
            // 
            this.rectangle.Name = "rectangle";
            this.rectangle.Size = new System.Drawing.Size(224, 26);
            this.rectangle.Text = "Rectangle";
            this.rectangle.Click += new System.EventHandler(this.rectangle_Click);
            // 
            // line
            // 
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(224, 26);
            this.line.Text = "Line";
            this.line.Click += new System.EventHandler(this.line_Click);
            // 
            // pic
            // 
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 28);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(800, 422);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // xoa
            // 
            this.xoa.Name = "xoa";
            this.xoa.Size = new System.Drawing.Size(224, 26);
            this.xoa.Text = "Xoa";
            this.xoa.Click += new System.EventHandler(this.xoa_Click);
            // 
            // eLLIPESToolStripMenuItem
            // 
            this.eLLIPESToolStripMenuItem.Name = "eLLIPESToolStripMenuItem";
            this.eLLIPESToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.eLLIPESToolStripMenuItem.Text = "ELLIPES";
            this.eLLIPESToolStripMenuItem.Click += new System.EventHandler(this.eLLIPESToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boderColor;
        private System.Windows.Forms.ToolStripMenuItem line;
        private System.Windows.Forms.ToolStripMenuItem rectangle;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.ToolStripMenuItem xoa;
        private System.Windows.Forms.ToolStripMenuItem eLLIPESToolStripMenuItem;
    }
}

