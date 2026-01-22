namespace Krasotka.Forms
{
    partial class ProductForm
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
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ComboBoxDiscount = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RadioButtonFew = new System.Windows.Forms.RadioButton();
            this.RadioButtonMore = new System.Windows.Forms.RadioButton();
            this.ButtonAddProduct = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.labelWhichProducts = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(903, 450);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            this.splitContainer2.Panel1.Controls.Add(this.ButtonAddProduct);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.labelWhichProducts);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer2.Size = new System.Drawing.Size(903, 346);
            this.splitContainer2.SplitterDistance = 120;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ComboBoxDiscount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.TextBoxSearch);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 68);
            this.panel1.TabIndex = 10;
            // 
            // ComboBoxDiscount
            // 
            this.ComboBoxDiscount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDiscount.FormattingEnabled = true;
            this.ComboBoxDiscount.Items.AddRange(new object[] {
            "Все элементы",
            "0-9,99%",
            "10-14,99%",
            "15% и более"});
            this.ComboBoxDiscount.Location = new System.Drawing.Point(332, 17);
            this.ComboBoxDiscount.Name = "ComboBoxDiscount";
            this.ComboBoxDiscount.Size = new System.Drawing.Size(197, 27);
            this.ComboBoxDiscount.TabIndex = 15;
            this.ComboBoxDiscount.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDiscount_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Скидка";
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(663, 14);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(219, 26);
            this.TextBoxSearch.TabIndex = 13;
            this.TextBoxSearch.TextChanged += new System.EventHandler(this.TextBoxSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(596, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RadioButtonFew);
            this.groupBox1.Controls.Add(this.RadioButtonMore);
            this.groupBox1.Location = new System.Drawing.Point(7, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 61);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Сортировка по цене";
            // 
            // RadioButtonFew
            // 
            this.RadioButtonFew.AutoSize = true;
            this.RadioButtonFew.Location = new System.Drawing.Point(93, 25);
            this.RadioButtonFew.Name = "RadioButtonFew";
            this.RadioButtonFew.Size = new System.Drawing.Size(89, 23);
            this.RadioButtonFew.TabIndex = 1;
            this.RadioButtonFew.TabStop = true;
            this.RadioButtonFew.Text = "Меньше";
            this.RadioButtonFew.UseVisualStyleBackColor = true;
            this.RadioButtonFew.CheckedChanged += new System.EventHandler(this.RadioButtonFew_CheckedChanged);
            // 
            // RadioButtonMore
            // 
            this.RadioButtonMore.AutoSize = true;
            this.RadioButtonMore.Checked = true;
            this.RadioButtonMore.Location = new System.Drawing.Point(3, 22);
            this.RadioButtonMore.Name = "RadioButtonMore";
            this.RadioButtonMore.Size = new System.Drawing.Size(84, 23);
            this.RadioButtonMore.TabIndex = 0;
            this.RadioButtonMore.TabStop = true;
            this.RadioButtonMore.Text = "Больше";
            this.RadioButtonMore.UseVisualStyleBackColor = true;
            this.RadioButtonMore.CheckedChanged += new System.EventHandler(this.RadioButtonMore_CheckedChanged);
            // 
            // ButtonAddProduct
            // 
            this.ButtonAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ButtonAddProduct.Location = new System.Drawing.Point(605, 78);
            this.ButtonAddProduct.Name = "ButtonAddProduct";
            this.ButtonAddProduct.Size = new System.Drawing.Size(161, 29);
            this.ButtonAddProduct.TabIndex = 8;
            this.ButtonAddProduct.Text = "Добавить продукт";
            this.ButtonAddProduct.UseVisualStyleBackColor = false;
            this.ButtonAddProduct.Click += new System.EventHandler(this.ButtonAddProduct_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(262, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Отображено товаров:";
            // 
            // labelWhichProducts
            // 
            this.labelWhichProducts.AutoSize = true;
            this.labelWhichProducts.Location = new System.Drawing.Point(423, 85);
            this.labelWhichProducts.Name = "labelWhichProducts";
            this.labelWhichProducts.Size = new System.Drawing.Size(111, 19);
            this.labelWhichProducts.TabIndex = 6;
            this.labelWhichProducts.Text = "кол-во товаров";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(903, 222);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 450);
            this.MaximizeBox = false;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProductForm_FormClosed);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonAddProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelWhichProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ComboBoxDiscount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RadioButtonFew;
        private System.Windows.Forms.RadioButton RadioButtonMore;
    }
}