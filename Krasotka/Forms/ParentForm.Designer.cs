namespace Krasotka.Forms
{
    partial class ParentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParentForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ButtonLogout = new System.Windows.Forms.Button();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(153)))));
            this.splitContainer1.Panel1.Controls.Add(this.ButtonLogout);
            this.splitContainer1.Panel1.Controls.Add(this.labelRole);
            this.splitContainer1.Panel1.Controls.Add(this.labelName);
            this.splitContainer1.Panel1.Controls.Add(this.labelTitle);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 428);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // ButtonLogout
            // 
            this.ButtonLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ButtonLogout.Location = new System.Drawing.Point(698, 40);
            this.ButtonLogout.Name = "ButtonLogout";
            this.ButtonLogout.Size = new System.Drawing.Size(75, 34);
            this.ButtonLogout.TabIndex = 4;
            this.ButtonLogout.Text = "Выход";
            this.ButtonLogout.UseVisualStyleBackColor = false;
            this.ButtonLogout.Click += new System.EventHandler(this.ButtonLogout_Click);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(394, 60);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(41, 19);
            this.labelRole.TabIndex = 3;
            this.labelRole.Text = "Роль";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(394, 24);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(37, 19);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(186, 24);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(77, 19);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Заголовок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Krasotka.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ParentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ParentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ParentForm";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ButtonLogout;
    }
}