namespace postgreSQL
{
    partial class Form1
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
            ConnectBtn = new Button();
            DisconnectBtn = new Button();
            SearchBtn = new Button();
            label1 = new Label();
            NameSearchTxt = new TextBox();
            dataGridViewTB = new DataGridView();
            AddBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            visa = new Label();
            txt_Nid = new TextBox();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtCountry = new TextBox();
            txtID = new TextBox();
            txtVisa = new TextBox();
            DeleteBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTB).BeginInit();
            SuspendLayout();
            // 
            // ConnectBtn
            // 
            ConnectBtn.Location = new Point(12, 12);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(140, 62);
            ConnectBtn.TabIndex = 0;
            ConnectBtn.Text = "Connect";
            ConnectBtn.UseVisualStyleBackColor = true;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // DisconnectBtn
            // 
            DisconnectBtn.Location = new Point(12, 80);
            DisconnectBtn.Name = "DisconnectBtn";
            DisconnectBtn.Size = new Size(140, 62);
            DisconnectBtn.TabIndex = 1;
            DisconnectBtn.Text = "Disconnect";
            DisconnectBtn.UseVisualStyleBackColor = true;
            DisconnectBtn.Click += DisconnectBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(12, 148);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(140, 62);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 225);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // NameSearchTxt
            // 
            NameSearchTxt.ForeColor = SystemColors.InactiveCaption;
            NameSearchTxt.Location = new Point(12, 243);
            NameSearchTxt.Name = "NameSearchTxt";
            NameSearchTxt.Size = new Size(140, 23);
            NameSearchTxt.TabIndex = 4;
            // 
            // dataGridViewTB
            // 
            dataGridViewTB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTB.Location = new Point(168, 12);
            dataGridViewTB.Name = "dataGridViewTB";
            dataGridViewTB.Size = new Size(595, 254);
            dataGridViewTB.TabIndex = 5;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(12, 275);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(140, 28);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 272);
            label2.Name = "label2";
            label2.Size = new Size(26, 15);
            label2.TabIndex = 7;
            label2.Text = "Nid";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(271, 272);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 8;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(370, 272);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 9;
            label4.Text = "LastName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(465, 272);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 10;
            label5.Text = "Country";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(551, 272);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 11;
            label6.Text = "ID";
            // 
            // visa
            // 
            visa.AutoSize = true;
            visa.Location = new Point(651, 272);
            visa.Name = "visa";
            visa.Size = new Size(28, 15);
            visa.TabIndex = 12;
            visa.Text = "Visa";
            // 
            // txt_Nid
            // 
            txt_Nid.Location = new Point(168, 290);
            txt_Nid.Name = "txt_Nid";
            txt_Nid.Size = new Size(82, 23);
            txt_Nid.TabIndex = 13;
            // 
            // txtName
            // 
            txtName.Location = new Point(271, 290);
            txtName.Name = "txtName";
            txtName.Size = new Size(80, 23);
            txtName.TabIndex = 14;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(370, 290);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(78, 23);
            txtLastName.TabIndex = 15;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(465, 290);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(68, 23);
            txtCountry.TabIndex = 16;
            // 
            // txtID
            // 
            txtID.Location = new Point(551, 290);
            txtID.Name = "txtID";
            txtID.Size = new Size(81, 23);
            txtID.TabIndex = 17;
            // 
            // txtVisa
            // 
            txtVisa.Location = new Point(651, 290);
            txtVisa.Name = "txtVisa";
            txtVisa.Size = new Size(90, 23);
            txtVisa.TabIndex = 18;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(12, 309);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(140, 28);
            DeleteBtn.TabIndex = 19;
            DeleteBtn.Text = "DELETE";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 349);
            Controls.Add(DeleteBtn);
            Controls.Add(txtVisa);
            Controls.Add(txtID);
            Controls.Add(txtCountry);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(txt_Nid);
            Controls.Add(visa);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddBtn);
            Controls.Add(dataGridViewTB);
            Controls.Add(NameSearchTxt);
            Controls.Add(label1);
            Controls.Add(SearchBtn);
            Controls.Add(DisconnectBtn);
            Controls.Add(ConnectBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnectBtn;
        private Button DisconnectBtn;
        private Button SearchBtn;
        private Label label1;
        private TextBox NameSearchTxt;
        private DataGridView dataGridViewTB;
        private Button AddBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label visa;
        private TextBox txt_Nid;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtCountry;
        private TextBox txtID;
        private TextBox txtVisa;
        private Button DeleteBtn;
    }
}
