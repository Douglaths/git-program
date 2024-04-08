namespace ConexionBD
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
            ConnectionOn = new Button();
            ConnectionOff = new Button();
            SuspendLayout();
            // 
            // ConnectionOn
            // 
            ConnectionOn.Location = new Point(40, 12);
            ConnectionOn.Name = "ConnectionOn";
            ConnectionOn.Size = new Size(191, 96);
            ConnectionOn.TabIndex = 0;
            ConnectionOn.Text = "On";
            ConnectionOn.UseVisualStyleBackColor = true;
            ConnectionOn.Click += ConnectionOn_Click;
            // 
            // ConnectionOff
            // 
            ConnectionOff.Location = new Point(40, 118);
            ConnectionOff.Name = "ConnectionOff";
            ConnectionOff.Size = new Size(191, 96);
            ConnectionOff.TabIndex = 1;
            ConnectionOff.Text = "Off";
            ConnectionOff.UseVisualStyleBackColor = true;
            ConnectionOff.Click += ConnectionOff_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 267);
            Controls.Add(ConnectionOff);
            Controls.Add(ConnectionOn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button ConnectionOn;
        private Button ConnectionOff;
    }
}
