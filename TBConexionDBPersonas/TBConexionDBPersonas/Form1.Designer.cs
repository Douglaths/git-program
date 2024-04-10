namespace TBConexionDBPersonas
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
            CountryBoxTxt = new TextBox();
            dataGridViewTable = new DataGridView();
            AddBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            NameTxt = new TextBox();
            AgeTxt = new TextBox();
            CountryTxt = new TextBox();
            NIDTxt = new TextBox();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            NametoUpdate = new Label();
            NametoUpdateBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).BeginInit();
            SuspendLayout();
            // 
            // ConnectBtn
            // 
            ConnectBtn.Location = new Point(31, 23);
            ConnectBtn.Name = "ConnectBtn";
            ConnectBtn.Size = new Size(171, 60);
            ConnectBtn.TabIndex = 0;
            ConnectBtn.Text = "Connect";
            ConnectBtn.UseVisualStyleBackColor = true;
            ConnectBtn.Click += ConnectBtn_Click;
            // 
            // DisconnectBtn
            // 
            DisconnectBtn.Location = new Point(31, 107);
            DisconnectBtn.Name = "DisconnectBtn";
            DisconnectBtn.Size = new Size(171, 60);
            DisconnectBtn.TabIndex = 1;
            DisconnectBtn.Text = "Disconnect";
            DisconnectBtn.UseVisualStyleBackColor = true;
            DisconnectBtn.Click += DisconnectBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.Location = new Point(31, 193);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(171, 60);
            SearchBtn.TabIndex = 2;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 265);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 3;
            label1.Text = "Name Country";
            // 
            // CountryBoxTxt
            // 
            CountryBoxTxt.Location = new Point(223, 283);
            CountryBoxTxt.Name = "CountryBoxTxt";
            CountryBoxTxt.Size = new Size(171, 23);
            CountryBoxTxt.TabIndex = 4;
            // 
            // dataGridViewTable
            // 
            dataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable.Location = new Point(217, 23);
            dataGridViewTable.Name = "dataGridViewTable";
            dataGridViewTable.Size = new Size(640, 230);
            dataGridViewTable.TabIndex = 5;
            // 
            // AddBtn
            // 
            AddBtn.Location = new Point(31, 282);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(171, 60);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 327);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 7;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 327);
            label3.Name = "label3";
            label3.Size = new Size(28, 15);
            label3.TabIndex = 8;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(501, 327);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(645, 327);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 10;
            label5.Text = "NID";
            // 
            // NameTxt
            // 
            NameTxt.Location = new Point(223, 345);
            NameTxt.Name = "NameTxt";
            NameTxt.Size = new Size(100, 23);
            NameTxt.TabIndex = 11;
            // 
            // AgeTxt
            // 
            AgeTxt.Location = new Point(362, 345);
            AgeTxt.Name = "AgeTxt";
            AgeTxt.Size = new Size(100, 23);
            AgeTxt.TabIndex = 12;
            // 
            // CountryTxt
            // 
            CountryTxt.Location = new Point(501, 345);
            CountryTxt.Name = "CountryTxt";
            CountryTxt.Size = new Size(100, 23);
            CountryTxt.TabIndex = 13;
            // 
            // NIDTxt
            // 
            NIDTxt.Location = new Point(645, 345);
            NIDTxt.Name = "NIDTxt";
            NIDTxt.Size = new Size(100, 23);
            NIDTxt.TabIndex = 14;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(31, 369);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(171, 60);
            UpdateBtn.TabIndex = 15;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(31, 454);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(171, 59);
            DeleteBtn.TabIndex = 16;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // NametoUpdate
            // 
            NametoUpdate.AutoSize = true;
            NametoUpdate.Location = new Point(501, 264);
            NametoUpdate.Name = "NametoUpdate";
            NametoUpdate.Size = new Size(120, 15);
            NametoUpdate.TabIndex = 17;
            NametoUpdate.Text = "Old Name to UPDATE";
            // 
            // NametoUpdateBox
            // 
            NametoUpdateBox.Location = new Point(501, 282);
            NametoUpdateBox.Name = "NametoUpdateBox";
            NametoUpdateBox.Size = new Size(100, 23);
            NametoUpdateBox.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 526);
            Controls.Add(NametoUpdateBox);
            Controls.Add(NametoUpdate);
            Controls.Add(DeleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(NIDTxt);
            Controls.Add(CountryTxt);
            Controls.Add(AgeTxt);
            Controls.Add(NameTxt);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AddBtn);
            Controls.Add(dataGridViewTable);
            Controls.Add(CountryBoxTxt);
            Controls.Add(label1);
            Controls.Add(SearchBtn);
            Controls.Add(DisconnectBtn);
            Controls.Add(ConnectBtn);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ConnectBtn;
        private Button DisconnectBtn;
        private Button SearchBtn;
        private Label label1;
        private TextBox CountryBoxTxt;
        private DataGridView dataGridViewTable;
        private Button AddBtn;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NameTxt;
        private TextBox AgeTxt;
        private TextBox CountryTxt;
        private TextBox NIDTxt;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Label NametoUpdate;
        private TextBox NametoUpdateBox;
    }
}
