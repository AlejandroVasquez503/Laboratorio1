namespace gradosyradianes
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
            ValorTerabox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            ResultadoLabel = new Label();
            GradosButton = new Button();
            RadianesButton = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // ValorTerabox
            // 
            ValorTerabox.Location = new Point(304, 185);
            ValorTerabox.Name = "ValorTerabox";
            ValorTerabox.Size = new Size(304, 23);
            ValorTerabox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 119);
            label1.Name = "label1";
            label1.Size = new Size(281, 21);
            label1.TabIndex = 1;
            label1.Text = "Calcular coseno a grados y radianes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(180, 185);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 2;
            label2.Text = "ingresar valor→";
            // 
            // ResultadoLabel
            // 
            ResultadoLabel.AutoSize = true;
            ResultadoLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResultadoLabel.Location = new Point(428, 328);
            ResultadoLabel.Name = "ResultadoLabel";
            ResultadoLabel.Size = new Size(0, 20);
            ResultadoLabel.TabIndex = 4;
            // 
            // GradosButton
            // 
            GradosButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GradosButton.Location = new Point(304, 256);
            GradosButton.Name = "GradosButton";
            GradosButton.Size = new Size(78, 32);
            GradosButton.TabIndex = 5;
            GradosButton.Text = "Grados";
            GradosButton.UseVisualStyleBackColor = true;
            GradosButton.MouseClick += GradosButton_MouseClick;
            // 
            // RadianesButton
            // 
            RadianesButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RadianesButton.Location = new Point(525, 256);
            RadianesButton.Name = "RadianesButton";
            RadianesButton.Size = new Size(83, 32);
            RadianesButton.TabIndex = 6;
            RadianesButton.Text = "Radianes";
            RadianesButton.UseVisualStyleBackColor = true;
            RadianesButton.MouseClick += RadianesButton_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(304, 323);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 7;
            label3.Text = "ingresar valor→";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 531);
            Controls.Add(label3);
            Controls.Add(RadianesButton);
            Controls.Add(GradosButton);
            Controls.Add(ResultadoLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ValorTerabox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ValorTerabox;
        private Label label1;
        private Label label2;
        private Label ResultadoLabel;
        private Button GradosButton;
        private Button RadianesButton;
        private Label label3;
    }
}
