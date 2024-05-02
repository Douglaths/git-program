namespace Gymwork_program
{
    partial class Stock
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
            pictureBox1 = new PictureBox();
            dataGridView1 = new DataGridView();
            AddProductBtn = new Button();
            ModifyProductBtn = new Button();
            DeleteProductBtn = new Button();
            txtIDProduct = new TextBox();
            txtProduct = new TextBox();
            txtCategory = new TextBox();
            txtPrices = new TextBox();
            txtQuantity = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            CloseBtnV3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventary1;
            pictureBox1.Location = new Point(623, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(165, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(605, 174);
            dataGridView1.TabIndex = 1;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(691, 209);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(75, 23);
            AddProductBtn.TabIndex = 2;
            AddProductBtn.Text = "Add";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // ModifyProductBtn
            // 
            ModifyProductBtn.Location = new Point(691, 239);
            ModifyProductBtn.Name = "ModifyProductBtn";
            ModifyProductBtn.Size = new Size(75, 23);
            ModifyProductBtn.TabIndex = 3;
            ModifyProductBtn.Text = "Modify";
            ModifyProductBtn.UseVisualStyleBackColor = true;
            ModifyProductBtn.Click += ModifyProductBtn_Click;
            // 
            // DeleteProductBtn
            // 
            DeleteProductBtn.Location = new Point(691, 268);
            DeleteProductBtn.Name = "DeleteProductBtn";
            DeleteProductBtn.Size = new Size(75, 23);
            DeleteProductBtn.TabIndex = 4;
            DeleteProductBtn.Text = "Delete";
            DeleteProductBtn.UseVisualStyleBackColor = true;
            DeleteProductBtn.Click += DeleteProductBtn_Click;
            // 
            // txtIDProduct
            // 
            txtIDProduct.Location = new Point(20, 238);
            txtIDProduct.Name = "txtIDProduct";
            txtIDProduct.Size = new Size(100, 23);
            txtIDProduct.TabIndex = 5;
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(146, 238);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(100, 23);
            txtProduct.TabIndex = 6;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(268, 238);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 7;
            // 
            // txtPrices
            // 
            txtPrices.Location = new Point(398, 238);
            txtPrices.Name = "txtPrices";
            txtPrices.Size = new Size(100, 23);
            txtPrices.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(532, 238);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 220);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 10;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 220);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 11;
            label2.Text = "Name of product";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 220);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 12;
            label3.Text = "Category";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 220);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 13;
            label4.Text = "Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(532, 220);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 14;
            label5.Text = "Quantity left";
            // 
            // CloseBtnV3
            // 
            CloseBtnV3.Location = new Point(684, 404);
            CloseBtnV3.Name = "CloseBtnV3";
            CloseBtnV3.Size = new Size(104, 34);
            CloseBtnV3.TabIndex = 15;
            CloseBtnV3.Text = "Exit";
            CloseBtnV3.UseVisualStyleBackColor = true;
            CloseBtnV3.Click += CloseBtnV3_Click;
            // 
            // Stock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CloseBtnV3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrices);
            Controls.Add(txtCategory);
            Controls.Add(txtProduct);
            Controls.Add(txtIDProduct);
            Controls.Add(DeleteProductBtn);
            Controls.Add(ModifyProductBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBox1);
            Name = "Stock";
            Text = "stock";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView dataGridView1;
        private Button AddProductBtn;
        private Button ModifyProductBtn;
        private Button DeleteProductBtn;
        private TextBox txtIDProduct;
        private TextBox txtProduct;
        private TextBox txtCategory;
        private TextBox txtPrices;
        private TextBox txtQuantity;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button CloseBtnV3;
    }
}