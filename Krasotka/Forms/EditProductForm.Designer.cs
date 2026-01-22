namespace Krasotka.Forms
{
    partial class EditProductForm
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
            System.Windows.Forms.Label articleLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label discountProbablyLabel;
            System.Windows.Forms.Label discountActualLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label photoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            this.krasotka_dnDataSet = new Krasotka.krasotka_dnDataSet();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Krasotka.krasotka_dnDataSetTableAdapters.ProductTableAdapter();
            this.tableAdapterManager = new Krasotka.krasotka_dnDataSetTableAdapters.TableAdapterManager();
            this.articleTextBox = new System.Windows.Forms.TextBox();
            this.priceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountProbablyNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.discountActualNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.photoTextBox = new System.Windows.Forms.TextBox();
            this.productNameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productNameTableAdapter = new Krasotka.krasotka_dnDataSetTableAdapters.ProductNameTableAdapter();
            this.productNameComboBox = new System.Windows.Forms.ComboBox();
            this.unitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unitTableAdapter = new Krasotka.krasotka_dnDataSetTableAdapters.UnitTableAdapter();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerTableAdapter = new Krasotka.krasotka_dnDataSetTableAdapters.ManufacturerTableAdapter();
            this.manufacturerComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierTableAdapter = new Krasotka.krasotka_dnDataSetTableAdapters.SupplierTableAdapter();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Krasotka.krasotka_dnDataSetTableAdapters.CategoryTableAdapter();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.ButtonAddPhoto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ButtonSave = new System.Windows.Forms.Button();
            articleLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            discountProbablyLabel = new System.Windows.Forms.Label();
            discountActualLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            photoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.krasotka_dnDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountProbablyNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountActualNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.ButtonSave);
            this.splitContainer1.Panel2.Controls.Add(this.ButtonAddPhoto);
            this.splitContainer1.Panel2.Controls.Add(label4);
            this.splitContainer1.Panel2.Controls.Add(label5);
            this.splitContainer1.Panel2.Controls.Add(label1);
            this.splitContainer1.Panel2.Controls.Add(label2);
            this.splitContainer1.Panel2.Controls.Add(label3);
            this.splitContainer1.Panel2.Controls.Add(this.categoryComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.supplierComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.manufacturerComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.unitComboBox);
            this.splitContainer1.Panel2.Controls.Add(this.productNameComboBox);
            this.splitContainer1.Panel2.Controls.Add(articleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.articleTextBox);
            this.splitContainer1.Panel2.Controls.Add(priceLabel);
            this.splitContainer1.Panel2.Controls.Add(this.priceNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(discountProbablyLabel);
            this.splitContainer1.Panel2.Controls.Add(this.discountProbablyNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(discountActualLabel);
            this.splitContainer1.Panel2.Controls.Add(this.discountActualNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(amountLabel);
            this.splitContainer1.Panel2.Controls.Add(this.amountNumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(descriptionLabel);
            this.splitContainer1.Panel2.Controls.Add(this.descriptionTextBox);
            this.splitContainer1.Panel2.Controls.Add(photoLabel);
            this.splitContainer1.Panel2.Controls.Add(this.photoTextBox);
            this.splitContainer1.Size = new System.Drawing.Size(785, 599);
            // 
            // articleLabel
            // 
            articleLabel.AutoSize = true;
            articleLabel.Location = new System.Drawing.Point(156, 15);
            articleLabel.Name = "articleLabel";
            articleLabel.Size = new System.Drawing.Size(52, 19);
            articleLabel.TabIndex = 0;
            articleLabel.Text = "Article:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(156, 136);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(43, 19);
            priceLabel.TabIndex = 2;
            priceLabel.Text = "Price:";
            // 
            // discountProbablyLabel
            // 
            discountProbablyLabel.AutoSize = true;
            discountProbablyLabel.Location = new System.Drawing.Point(156, 168);
            discountProbablyLabel.Name = "discountProbablyLabel";
            discountProbablyLabel.Size = new System.Drawing.Size(124, 19);
            discountProbablyLabel.TabIndex = 4;
            discountProbablyLabel.Text = "Discount Probably:";
            // 
            // discountActualLabel
            // 
            discountActualLabel.AutoSize = true;
            discountActualLabel.Location = new System.Drawing.Point(156, 313);
            discountActualLabel.Name = "discountActualLabel";
            discountActualLabel.Size = new System.Drawing.Size(107, 19);
            discountActualLabel.TabIndex = 6;
            discountActualLabel.Text = "Discount Actual:";
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Location = new System.Drawing.Point(156, 345);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(60, 19);
            amountLabel.TabIndex = 8;
            amountLabel.Text = "Amount:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(156, 380);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(81, 19);
            descriptionLabel.TabIndex = 10;
            descriptionLabel.Text = "Description:";
            // 
            // photoLabel
            // 
            photoLabel.AutoSize = true;
            photoLabel.Location = new System.Drawing.Point(156, 412);
            photoLabel.Name = "photoLabel";
            photoLabel.Size = new System.Drawing.Size(48, 19);
            photoLabel.TabIndex = 12;
            photoLabel.Text = "Photo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(156, 212);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 19);
            label1.TabIndex = 19;
            label1.Text = "Производитель";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(156, 244);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 19);
            label2.TabIndex = 20;
            label2.Text = "Поставщик";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(156, 279);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(79, 19);
            label3.TabIndex = 21;
            label3.Text = "Категория";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(156, 61);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 19);
            label4.TabIndex = 22;
            label4.Text = "Название";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(156, 93);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(106, 19);
            label5.TabIndex = 23;
            label5.Text = "Ед. измерения";
            // 
            // krasotka_dnDataSet
            // 
            this.krasotka_dnDataSet.DataSetName = "krasotka_dnDataSet";
            this.krasotka_dnDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.krasotka_dnDataSet;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoryTableAdapter = null;
            this.tableAdapterManager.ManufacturerTableAdapter = null;
            this.tableAdapterManager.OrderProductTableAdapter = null;
            this.tableAdapterManager.OrderTableAdapter = null;
            this.tableAdapterManager.PickupPointTableAdapter = null;
            this.tableAdapterManager.ProductNameTableAdapter = null;
            this.tableAdapterManager.ProductTableAdapter = this.productTableAdapter;
            this.tableAdapterManager.RoleTableAdapter = null;
            this.tableAdapterManager.SupplierTableAdapter = null;
            this.tableAdapterManager.UnitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Krasotka.krasotka_dnDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            // 
            // articleTextBox
            // 
            this.articleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Article", true));
            this.articleTextBox.Location = new System.Drawing.Point(305, 12);
            this.articleTextBox.Name = "articleTextBox";
            this.articleTextBox.Size = new System.Drawing.Size(120, 26);
            this.articleTextBox.TabIndex = 1;
            // 
            // priceNumericUpDown
            // 
            this.priceNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Price", true));
            this.priceNumericUpDown.Location = new System.Drawing.Point(305, 136);
            this.priceNumericUpDown.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.priceNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.priceNumericUpDown.Name = "priceNumericUpDown";
            this.priceNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.priceNumericUpDown.TabIndex = 3;
            this.priceNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // discountProbablyNumericUpDown
            // 
            this.discountProbablyNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "DiscountProbably", true));
            this.discountProbablyNumericUpDown.Enabled = false;
            this.discountProbablyNumericUpDown.Location = new System.Drawing.Point(305, 168);
            this.discountProbablyNumericUpDown.Name = "discountProbablyNumericUpDown";
            this.discountProbablyNumericUpDown.ReadOnly = true;
            this.discountProbablyNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.discountProbablyNumericUpDown.TabIndex = 5;
            this.discountProbablyNumericUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // discountActualNumericUpDown
            // 
            this.discountActualNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "DiscountActual", true));
            this.discountActualNumericUpDown.Location = new System.Drawing.Point(305, 313);
            this.discountActualNumericUpDown.Name = "discountActualNumericUpDown";
            this.discountActualNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.discountActualNumericUpDown.TabIndex = 7;
            // 
            // amountNumericUpDown
            // 
            this.amountNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Amount", true));
            this.amountNumericUpDown.Location = new System.Drawing.Point(305, 345);
            this.amountNumericUpDown.Name = "amountNumericUpDown";
            this.amountNumericUpDown.Size = new System.Drawing.Size(120, 26);
            this.amountNumericUpDown.TabIndex = 9;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(305, 377);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(120, 26);
            this.descriptionTextBox.TabIndex = 11;
            // 
            // photoTextBox
            // 
            this.photoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Photo", true));
            this.photoTextBox.Enabled = false;
            this.photoTextBox.Location = new System.Drawing.Point(305, 409);
            this.photoTextBox.Name = "photoTextBox";
            this.photoTextBox.ReadOnly = true;
            this.photoTextBox.Size = new System.Drawing.Size(120, 26);
            this.photoTextBox.TabIndex = 13;
            // 
            // productNameBindingSource
            // 
            this.productNameBindingSource.DataMember = "ProductName";
            this.productNameBindingSource.DataSource = this.krasotka_dnDataSet;
            // 
            // productNameTableAdapter
            // 
            this.productNameTableAdapter.ClearBeforeFill = true;
            // 
            // productNameComboBox
            // 
            this.productNameComboBox.DataSource = this.productNameBindingSource;
            this.productNameComboBox.DisplayMember = "Name";
            this.productNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productNameComboBox.FormattingEnabled = true;
            this.productNameComboBox.Location = new System.Drawing.Point(305, 58);
            this.productNameComboBox.Name = "productNameComboBox";
            this.productNameComboBox.Size = new System.Drawing.Size(300, 27);
            this.productNameComboBox.TabIndex = 14;
            this.productNameComboBox.ValueMember = "Id";
            // 
            // unitBindingSource
            // 
            this.unitBindingSource.DataMember = "Unit";
            this.unitBindingSource.DataSource = this.krasotka_dnDataSet;
            // 
            // unitTableAdapter
            // 
            this.unitTableAdapter.ClearBeforeFill = true;
            // 
            // unitComboBox
            // 
            this.unitComboBox.DataSource = this.unitBindingSource;
            this.unitComboBox.DisplayMember = "Name";
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(305, 91);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(300, 27);
            this.unitComboBox.TabIndex = 15;
            this.unitComboBox.ValueMember = "Id";
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.krasotka_dnDataSet;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerComboBox
            // 
            this.manufacturerComboBox.DataSource = this.manufacturerBindingSource;
            this.manufacturerComboBox.DisplayMember = "Name";
            this.manufacturerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manufacturerComboBox.FormattingEnabled = true;
            this.manufacturerComboBox.Location = new System.Drawing.Point(305, 209);
            this.manufacturerComboBox.Name = "manufacturerComboBox";
            this.manufacturerComboBox.Size = new System.Drawing.Size(300, 27);
            this.manufacturerComboBox.TabIndex = 16;
            this.manufacturerComboBox.ValueMember = "Id";
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataMember = "Supplier";
            this.supplierBindingSource.DataSource = this.krasotka_dnDataSet;
            // 
            // supplierTableAdapter
            // 
            this.supplierTableAdapter.ClearBeforeFill = true;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(305, 247);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(300, 27);
            this.supplierComboBox.TabIndex = 17;
            this.supplierComboBox.ValueMember = "Id";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.krasotka_dnDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(305, 280);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(300, 27);
            this.categoryComboBox.TabIndex = 18;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // ButtonAddPhoto
            // 
            this.ButtonAddPhoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ButtonAddPhoto.Location = new System.Drawing.Point(431, 409);
            this.ButtonAddPhoto.Name = "ButtonAddPhoto";
            this.ButtonAddPhoto.Size = new System.Drawing.Size(174, 26);
            this.ButtonAddPhoto.TabIndex = 24;
            this.ButtonAddPhoto.Text = "Фото";
            this.ButtonAddPhoto.UseVisualStyleBackColor = false;
            this.ButtonAddPhoto.Click += new System.EventHandler(this.ButtonAddPhoto_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(102)))), ((int)(((byte)(0)))));
            this.ButtonSave.Location = new System.Drawing.Point(160, 444);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(445, 32);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // EditProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 599);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditProductForm";
            this.Text = "EditProductForm";
            this.Load += new System.EventHandler(this.EditProductForm_Load);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.krasotka_dnDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountProbablyNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discountActualNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productNameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private krasotka_dnDataSet krasotka_dnDataSet;
        private System.Windows.Forms.BindingSource productBindingSource;
        private krasotka_dnDataSetTableAdapters.ProductTableAdapter productTableAdapter;
        private krasotka_dnDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox articleTextBox;
        private System.Windows.Forms.NumericUpDown priceNumericUpDown;
        private System.Windows.Forms.NumericUpDown discountProbablyNumericUpDown;
        private System.Windows.Forms.NumericUpDown discountActualNumericUpDown;
        private System.Windows.Forms.NumericUpDown amountNumericUpDown;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox photoTextBox;
        private System.Windows.Forms.BindingSource productNameBindingSource;
        private krasotka_dnDataSetTableAdapters.ProductNameTableAdapter productNameTableAdapter;
        private System.Windows.Forms.ComboBox productNameComboBox;
        private System.Windows.Forms.BindingSource unitBindingSource;
        private krasotka_dnDataSetTableAdapters.UnitTableAdapter unitTableAdapter;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private krasotka_dnDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.ComboBox manufacturerComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private krasotka_dnDataSetTableAdapters.SupplierTableAdapter supplierTableAdapter;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private krasotka_dnDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.Button ButtonAddPhoto;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button ButtonSave;
    }
}