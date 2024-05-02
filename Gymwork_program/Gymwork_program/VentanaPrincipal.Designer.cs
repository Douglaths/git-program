namespace Gymwork_program
{
    partial class VentanaPrincipal
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
            CloseBtn = new Button();
            menuStrip2 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            taxesToolStripMenuItem = new ToolStripMenuItem();
            txtTaxesEdit = new ToolStripTextBox();
            discountToolStripMenuItem = new ToolStripMenuItem();
            txtDiscountEdit = new ToolStripTextBox();
            toolStripMenuItem3 = new ToolStripMenuItem();
            stockToolStripMenuItem = new ToolStripMenuItem();
            reportsToolStripMenuItem = new ToolStripMenuItem();
            rutineToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            txtBillNumber = new TextBox();
            txtWelcomeUser = new TextBox();
            label2 = new Label();
            txtUserCodeSearch = new TextBox();
            label3 = new Label();
            AddProductBtn = new Button();
            PayBtn = new Button();
            txtIDProductSearch = new TextBox();
            label4 = new Label();
            txtQuantity = new TextBox();
            label5 = new Label();
            txtSalesTax = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtTotalPrice = new Label();
            txtDiscount = new TextBox();
            label9 = new Label();
            txtSubtotalPrice = new Label();
            label11 = new Label();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CloseBtn
            // 
            CloseBtn.Location = new Point(790, 403);
            CloseBtn.Name = "CloseBtn";
            CloseBtn.Size = new Size(105, 34);
            CloseBtn.TabIndex = 0;
            CloseBtn.Text = "Close";
            CloseBtn.UseVisualStyleBackColor = true;
            CloseBtn.Click += CloseBtn_Click;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, stockToolStripMenuItem, reportsToolStripMenuItem, rutineToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(907, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(37, 20);
            toolStripMenuItem1.Text = "File";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { taxesToolStripMenuItem, discountToolStripMenuItem });
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(175, 22);
            toolStripMenuItem2.Text = "Taxes and Discount";
            // 
            // taxesToolStripMenuItem
            // 
            taxesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtTaxesEdit });
            taxesToolStripMenuItem.Name = "taxesToolStripMenuItem";
            taxesToolStripMenuItem.Size = new Size(121, 22);
            taxesToolStripMenuItem.Text = "Taxes";
            // 
            // txtTaxesEdit
            // 
            txtTaxesEdit.Name = "txtTaxesEdit";
            txtTaxesEdit.Size = new Size(100, 23);
            txtTaxesEdit.Enter += TaxesAndDiscountChanged;
            txtTaxesEdit.TextChanged += TaxesAndDiscountChanged;
            // 
            // discountToolStripMenuItem
            // 
            discountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { txtDiscountEdit });
            discountToolStripMenuItem.Name = "discountToolStripMenuItem";
            discountToolStripMenuItem.Size = new Size(121, 22);
            discountToolStripMenuItem.Text = "Discount";
            // 
            // txtDiscountEdit
            // 
            txtDiscountEdit.Name = "txtDiscountEdit";
            txtDiscountEdit.Size = new Size(100, 23);
            txtDiscountEdit.Enter += TaxesAndDiscountChanged;
            txtDiscountEdit.TextChanged += TaxesAndDiscountChanged;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(47, 20);
            toolStripMenuItem3.Text = "Users";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // stockToolStripMenuItem
            // 
            stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            stockToolStripMenuItem.Size = new Size(48, 20);
            stockToolStripMenuItem.Text = "Stock";
            stockToolStripMenuItem.Click += stockToolStripMenuItem_Click;
            // 
            // reportsToolStripMenuItem
            // 
            reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            reportsToolStripMenuItem.Size = new Size(59, 20);
            reportsToolStripMenuItem.Text = "Reports";
            // 
            // rutineToolStripMenuItem
            // 
            rutineToolStripMenuItem.Name = "rutineToolStripMenuItem";
            rutineToolStripMenuItem.Size = new Size(53, 20);
            rutineToolStripMenuItem.Text = "Rutine";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bill;
            pictureBox1.Location = new Point(12, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(110, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 34);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 4;
            label1.Text = "Bill Number";
            // 
            // button1
            // 
            button1.Location = new Point(12, 191);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 5;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(150, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(745, 187);
            dataGridView1.TabIndex = 6;
            // 
            // txtBillNumber
            // 
            txtBillNumber.Location = new Point(226, 30);
            txtBillNumber.Name = "txtBillNumber";
            txtBillNumber.ReadOnly = true;
            txtBillNumber.Size = new Size(100, 23);
            txtBillNumber.TabIndex = 7;
            // 
            // txtWelcomeUser
            // 
            txtWelcomeUser.Location = new Point(545, 30);
            txtWelcomeUser.Name = "txtWelcomeUser";
            txtWelcomeUser.ReadOnly = true;
            txtWelcomeUser.Size = new Size(350, 23);
            txtWelcomeUser.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(451, 34);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 8;
            label2.Text = "Welcome, user:";
            // 
            // txtUserCodeSearch
            // 
            txtUserCodeSearch.Location = new Point(12, 162);
            txtUserCodeSearch.Name = "txtUserCodeSearch";
            txtUserCodeSearch.Size = new Size(110, 23);
            txtUserCodeSearch.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 144);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "User Code";
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(468, 308);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(225, 65);
            AddProductBtn.TabIndex = 12;
            AddProductBtn.Text = "Add Product";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // PayBtn
            // 
            PayBtn.Location = new Point(711, 260);
            PayBtn.Name = "PayBtn";
            PayBtn.Size = new Size(185, 113);
            PayBtn.TabIndex = 13;
            PayBtn.Text = "PAY";
            PayBtn.UseVisualStyleBackColor = true;
            PayBtn.Click += PayBtn_Click;
            // 
            // txtIDProductSearch
            // 
            txtIDProductSearch.Location = new Point(468, 279);
            txtIDProductSearch.Name = "txtIDProductSearch";
            txtIDProductSearch.Size = new Size(96, 23);
            txtIDProductSearch.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(468, 261);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 14;
            label4.Text = "ID Product";
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(586, 279);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(107, 23);
            txtQuantity.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 261);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 16;
            label5.Text = "Quantity";
            // 
            // txtSalesTax
            // 
            txtSalesTax.Location = new Point(337, 254);
            txtSalesTax.Name = "txtSalesTax";
            txtSalesTax.ReadOnly = true;
            txtSalesTax.Size = new Size(100, 23);
            txtSalesTax.TabIndex = 19;
            txtSalesTax.TextChanged += txtSalesTax_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(277, 262);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 18;
            label6.Text = "Sales Tax";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 328);
            label7.Name = "label7";
            label7.Size = new Size(88, 45);
            label7.TabIndex = 20;
            label7.Text = "Total";
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.AutoSize = true;
            txtTotalPrice.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotalPrice.Location = new Point(17, 356);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.Size = new Size(202, 86);
            txtTotalPrice.TabIndex = 21;
            txtTotalPrice.Text = "$0.00";
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(337, 287);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.ReadOnly = true;
            txtDiscount.Size = new Size(100, 23);
            txtDiscount.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(277, 291);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 22;
            label9.Text = "Discount";
            // 
            // txtSubtotalPrice
            // 
            txtSubtotalPrice.AutoSize = true;
            txtSubtotalPrice.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSubtotalPrice.Location = new Point(145, 278);
            txtSubtotalPrice.Name = "txtSubtotalPrice";
            txtSubtotalPrice.Size = new Size(109, 47);
            txtSubtotalPrice.TabIndex = 25;
            txtSubtotalPrice.Text = "$0.00";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(150, 262);
            label11.Name = "label11";
            label11.Size = new Size(84, 25);
            label11.TabIndex = 24;
            label11.Text = "SubTotal";
            // 
            // VentanaPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 450);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(txtSubtotalPrice);
            Controls.Add(txtDiscount);
            Controls.Add(label9);
            Controls.Add(txtTotalPrice);
            Controls.Add(txtSalesTax);
            Controls.Add(label6);
            Controls.Add(txtQuantity);
            Controls.Add(label5);
            Controls.Add(txtIDProductSearch);
            Controls.Add(label4);
            Controls.Add(PayBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(txtUserCodeSearch);
            Controls.Add(label3);
            Controls.Add(txtWelcomeUser);
            Controls.Add(label2);
            Controls.Add(txtBillNumber);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(CloseBtn);
            Controls.Add(menuStrip2);
            Name = "VentanaPrincipal";
            Text = "VentanaPrincipal";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CloseBtn;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem stockToolStripMenuItem;
        private ToolStripMenuItem reportsToolStripMenuItem;
        private ToolStripMenuItem rutineToolStripMenuItem;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private TextBox txtBillNumber;
        private TextBox txtWelcomeUser;
        private Label label2;
        private TextBox txtUserCodeSearch;
        private Label label3;
        private Button AddProductBtn;
        private Button PayBtn;
        private TextBox txtIDProductSearch;
        private Label label4;
        private TextBox txtQuantity;
        private Label label5;
        private TextBox txtSalesTax;
        private Label label6;
        private Label label7;
        private Label txtTotalPrice;
        private TextBox txtDiscount;
        private Label label9;
        private Label txtSubtotalPrice;
        private Label label11;
        private ToolStripMenuItem taxesToolStripMenuItem;
        private ToolStripMenuItem discountToolStripMenuItem;
        private ToolStripTextBox txtDiscountEdit;
        private ToolStripTextBox txtTaxesEdit;
    }
}