namespace POOpractica1
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
            Btn_Llamar = new Button();
            SuspendLayout();
            // 
            // Btn_Llamar
            // 
            Btn_Llamar.Location = new Point(613, 245);
            Btn_Llamar.Name = "Btn_Llamar";
            Btn_Llamar.Size = new Size(179, 63);
            Btn_Llamar.TabIndex = 0;
            Btn_Llamar.Text = "Send Message";
            Btn_Llamar.UseVisualStyleBackColor = true;
            Btn_Llamar.Click += Btn_Llamar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 332);
            Controls.Add(Btn_Llamar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Btn_Llamar;
    }
}
