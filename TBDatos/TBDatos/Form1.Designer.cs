namespace TBDatos
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
            EscribirBtn = new Button();
            LeerBtn = new Button();
            AbrirBtn = new Button();
            GuardarBtn = new Button();
            label1 = new Label();
            txt_direccion = new TextBox();
            rtxt_Contenido = new RichTextBox();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // EscribirBtn
            // 
            EscribirBtn.Location = new Point(12, 191);
            EscribirBtn.Name = "EscribirBtn";
            EscribirBtn.Size = new Size(136, 69);
            EscribirBtn.TabIndex = 0;
            EscribirBtn.Text = "Escribir";
            EscribirBtn.UseVisualStyleBackColor = true;
            EscribirBtn.Click += EscribirBtn_Click;
            // 
            // LeerBtn
            // 
            LeerBtn.Location = new Point(12, 281);
            LeerBtn.Name = "LeerBtn";
            LeerBtn.Size = new Size(136, 69);
            LeerBtn.TabIndex = 1;
            LeerBtn.Text = "Leer";
            LeerBtn.UseVisualStyleBackColor = true;
            LeerBtn.Click += LeerBtn_Click;
            // 
            // AbrirBtn
            // 
            AbrirBtn.Location = new Point(12, 12);
            AbrirBtn.Name = "AbrirBtn";
            AbrirBtn.Size = new Size(136, 69);
            AbrirBtn.TabIndex = 2;
            AbrirBtn.Text = "Abrir";
            AbrirBtn.UseVisualStyleBackColor = true;
            AbrirBtn.Click += AbrirBtn_Click;
            // 
            // GuardarBtn
            // 
            GuardarBtn.Location = new Point(12, 99);
            GuardarBtn.Name = "GuardarBtn";
            GuardarBtn.Size = new Size(136, 69);
            GuardarBtn.TabIndex = 3;
            GuardarBtn.Text = "Guardar";
            GuardarBtn.UseVisualStyleBackColor = true;
            GuardarBtn.Click += GuardarBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(216, 12);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 4;
            label1.Text = "Dirección";
            // 
            // txt_direccion
            // 
            txt_direccion.Location = new Point(216, 36);
            txt_direccion.Name = "txt_direccion";
            txt_direccion.Size = new Size(212, 23);
            txt_direccion.TabIndex = 5;
            // 
            // rtxt_Contenido
            // 
            rtxt_Contenido.Location = new Point(216, 65);
            rtxt_Contenido.Name = "rtxt_Contenido";
            rtxt_Contenido.Size = new Size(212, 285);
            rtxt_Contenido.TabIndex = 6;
            rtxt_Contenido.Text = "";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 351);
            Controls.Add(rtxt_Contenido);
            Controls.Add(txt_direccion);
            Controls.Add(label1);
            Controls.Add(GuardarBtn);
            Controls.Add(AbrirBtn);
            Controls.Add(LeerBtn);
            Controls.Add(EscribirBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button EscribirBtn;
        private Button LeerBtn;
        private Button AbrirBtn;
        private Button GuardarBtn;
        private Label label1;
        private TextBox txt_direccion;
        private RichTextBox rtxt_Contenido;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}
