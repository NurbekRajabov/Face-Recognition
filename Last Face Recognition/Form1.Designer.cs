namespace Last_Face_Recognition
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbDetectedFace0 = new System.Windows.Forms.PictureBox();
            this.pbDetectedFace1 = new System.Windows.Forms.PictureBox();
            this.btnSave_Click = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtRecognizedFace0 = new System.Windows.Forms.TextBox();
            this.txtRecognizedFace1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(984, 530);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pbDetectedFace0
            // 
            this.pbDetectedFace0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDetectedFace0.Location = new System.Drawing.Point(1038, 42);
            this.pbDetectedFace0.Name = "pbDetectedFace0";
            this.pbDetectedFace0.Size = new System.Drawing.Size(135, 158);
            this.pbDetectedFace0.TabIndex = 1;
            this.pbDetectedFace0.TabStop = false;
            // 
            // pbDetectedFace1
            // 
            this.pbDetectedFace1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDetectedFace1.Location = new System.Drawing.Point(1038, 312);
            this.pbDetectedFace1.Name = "pbDetectedFace1";
            this.pbDetectedFace1.Size = new System.Drawing.Size(135, 158);
            this.pbDetectedFace1.TabIndex = 2;
            this.pbDetectedFace1.TabStop = false;
            // 
            // btnSave_Click
            // 
            this.btnSave_Click.Location = new System.Drawing.Point(1038, 239);
            this.btnSave_Click.Name = "btnSave_Click";
            this.btnSave_Click.Size = new System.Drawing.Size(135, 37);
            this.btnSave_Click.TabIndex = 3;
            this.btnSave_Click.Text = "Save the face";
            this.btnSave_Click.UseVisualStyleBackColor = true;
            this.btnSave_Click.Click += new System.EventHandler(this.btnSave_Click_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1038, 504);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 4;
            this.button2.Text = "Save the face";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openCameraToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1254, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openCameraToolStripMenuItem
            // 
            this.openCameraToolStripMenuItem.Name = "openCameraToolStripMenuItem";
            this.openCameraToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.openCameraToolStripMenuItem.Text = "Open Camera";
            this.openCameraToolStripMenuItem.Click += new System.EventHandler(this.openCameraToolStripMenuItem_Click);
            // 
            // txtRecognizedFace0
            // 
            this.txtRecognizedFace0.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecognizedFace0.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecognizedFace0.Enabled = false;
            this.txtRecognizedFace0.Location = new System.Drawing.Point(1038, 206);
            this.txtRecognizedFace0.Name = "txtRecognizedFace0";
            this.txtRecognizedFace0.Size = new System.Drawing.Size(135, 15);
            this.txtRecognizedFace0.TabIndex = 6;
            // 
            // txtRecognizedFace1
            // 
            this.txtRecognizedFace1.BackColor = System.Drawing.SystemColors.Control;
            this.txtRecognizedFace1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRecognizedFace1.Enabled = false;
            this.txtRecognizedFace1.Location = new System.Drawing.Point(1038, 476);
            this.txtRecognizedFace1.Name = "txtRecognizedFace1";
            this.txtRecognizedFace1.Size = new System.Drawing.Size(135, 15);
            this.txtRecognizedFace1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1254, 677);
            this.Controls.Add(this.txtRecognizedFace1);
            this.Controls.Add(this.txtRecognizedFace0);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave_Click);
            this.Controls.Add(this.pbDetectedFace1);
            this.Controls.Add(this.pbDetectedFace0);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDetectedFace1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbDetectedFace0;
        private System.Windows.Forms.PictureBox pbDetectedFace1;
        private System.Windows.Forms.Button btnSave_Click;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openCameraToolStripMenuItem;
        private System.Windows.Forms.TextBox txtRecognizedFace0;
        private System.Windows.Forms.TextBox txtRecognizedFace1;
    }
}

