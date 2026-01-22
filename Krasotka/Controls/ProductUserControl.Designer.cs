namespace Krasotka.Controls
{
    partial class ProductUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.PictureBoxPhoto = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOldPrice = new System.Windows.Forms.Label();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.labelManufacturer = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelPercent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxPhoto
            // 
            this.PictureBoxPhoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PictureBoxPhoto.Location = new System.Drawing.Point(18, 17);
            this.PictureBoxPhoto.Name = "PictureBoxPhoto";
            this.PictureBoxPhoto.Size = new System.Drawing.Size(121, 123);
            this.PictureBoxPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBoxPhoto.TabIndex = 0;
            this.PictureBoxPhoto.TabStop = false;
            this.PictureBoxPhoto.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelOldPrice);
            this.panel1.Controls.Add(this.ButtonRemove);
            this.panel1.Controls.Add(this.labelManufacturer);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.labelPrice);
            this.panel1.Controls.Add(this.labelName);
            this.panel1.Location = new System.Drawing.Point(169, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(350, 125);
            this.panel1.TabIndex = 7;
            // 
            // labelOldPrice
            // 
            this.labelOldPrice.AutoSize = true;
            this.labelOldPrice.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelOldPrice.Location = new System.Drawing.Point(65, 103);
            this.labelOldPrice.Name = "labelOldPrice";
            this.labelOldPrice.Size = new System.Drawing.Size(45, 19);
            this.labelOldPrice.TabIndex = 10;
            this.labelOldPrice.Text = "label1";
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ButtonRemove.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonRemove.Location = new System.Drawing.Point(268, 85);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 32);
            this.ButtonRemove.TabIndex = 9;
            this.ButtonRemove.Text = "Удалить";
            this.ButtonRemove.UseVisualStyleBackColor = false;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // labelManufacturer
            // 
            this.labelManufacturer.AutoSize = true;
            this.labelManufacturer.Location = new System.Drawing.Point(3, 74);
            this.labelManufacturer.Name = "labelManufacturer";
            this.labelManufacturer.Size = new System.Drawing.Size(45, 19);
            this.labelManufacturer.TabIndex = 8;
            this.labelManufacturer.Text = "label4";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(3, 40);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(45, 19);
            this.labelDescription.TabIndex = 7;
            this.labelDescription.Text = "label3";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(3, 104);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(45, 19);
            this.labelPrice.TabIndex = 6;
            this.labelPrice.Text = "label2";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(3, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(45, 19);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "label1";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelPercent);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(538, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(139, 125);
            this.panel2.TabIndex = 8;
            // 
            // labelPercent
            // 
            this.labelPercent.AutoSize = true;
            this.labelPercent.Location = new System.Drawing.Point(58, 74);
            this.labelPercent.Name = "labelPercent";
            this.labelPercent.Size = new System.Drawing.Size(22, 19);
            this.labelPercent.TabIndex = 8;
            this.labelPercent.Text = "%";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(3, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 42);
            this.label5.TabIndex = 7;
            this.label5.Text = "Размер скидки";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PictureBoxPhoto);
            this.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "ProductUserControl";
            this.Size = new System.Drawing.Size(694, 159);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPhoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelManufacturer;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPercent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Label labelOldPrice;
    }
}
