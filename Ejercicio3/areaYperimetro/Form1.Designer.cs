namespace areaYperimetro
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
            ValorTextBox = new TextBox();
            cuadradoButton = new RadioButton();
            circunferenciaButton = new RadioButton();
            AreaButton = new Button();
            PerimetroButton = new Button();
            cuadroResultado = new Label();
            perimetroResultado = new Label();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // ValorTextBox
            // 
            ValorTextBox.Location = new Point(311, 63);
            ValorTextBox.Name = "ValorTextBox";
            ValorTextBox.Size = new Size(324, 23);
            ValorTextBox.TabIndex = 0;
            // 
            // cuadradoButton
            // 
            cuadradoButton.AutoSize = true;
            cuadradoButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuadradoButton.Location = new Point(319, 130);
            cuadradoButton.Name = "cuadradoButton";
            cuadradoButton.Size = new Size(94, 24);
            cuadradoButton.TabIndex = 1;
            cuadradoButton.TabStop = true;
            cuadradoButton.Text = "Cuadrado";
            cuadradoButton.UseVisualStyleBackColor = true;
            // 
            // circunferenciaButton
            // 
            circunferenciaButton.AutoSize = true;
            circunferenciaButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            circunferenciaButton.Location = new Point(508, 130);
            circunferenciaButton.Name = "circunferenciaButton";
            circunferenciaButton.Size = new Size(127, 24);
            circunferenciaButton.TabIndex = 2;
            circunferenciaButton.TabStop = true;
            circunferenciaButton.Text = "Circunferencia";
            circunferenciaButton.UseVisualStyleBackColor = true;
            // 
            // AreaButton
            // 
            AreaButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AreaButton.Location = new Point(311, 240);
            AreaButton.Name = "AreaButton";
            AreaButton.Size = new Size(102, 35);
            AreaButton.TabIndex = 3;
            AreaButton.Text = "Calcular Área";
            AreaButton.UseVisualStyleBackColor = true;
            AreaButton.Click += AreaButton_Click;
            // 
            // PerimetroButton
            // 
            PerimetroButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PerimetroButton.Location = new Point(497, 240);
            PerimetroButton.Name = "PerimetroButton";
            PerimetroButton.Size = new Size(138, 35);
            PerimetroButton.TabIndex = 4;
            PerimetroButton.Text = "Calcular Perímetro";
            PerimetroButton.UseVisualStyleBackColor = true;
            PerimetroButton.Click += PerimetroButton_Click;
            // 
            // cuadroResultado
            // 
            cuadroResultado.AutoSize = true;
            cuadroResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cuadroResultado.Location = new Point(352, 344);
            cuadroResultado.Name = "cuadroResultado";
            cuadroResultado.Size = new Size(0, 20);
            cuadroResultado.TabIndex = 5;
            // 
            // perimetroResultado
            // 
            perimetroResultado.AutoSize = true;
            perimetroResultado.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            perimetroResultado.Location = new Point(508, 344);
            perimetroResultado.Name = "perimetroResultado";
            perimetroResultado.Size = new Size(0, 20);
            perimetroResultado.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(276, 29);
            label1.Name = "label1";
            label1.Size = new Size(398, 20);
            label1.TabIndex = 7;
            label1.Text = "Calcular el Área o Perimetro de un cuadrado o circunferencia";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(228, 344);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 8;
            label2.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 530);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(perimetroResultado);
            Controls.Add(cuadroResultado);
            Controls.Add(PerimetroButton);
            Controls.Add(AreaButton);
            Controls.Add(circunferenciaButton);
            Controls.Add(cuadradoButton);
            Controls.Add(ValorTextBox);
            Name = "Form1";
            Text = "Calcular Area y Perimetro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ValorTextBox;
        private RadioButton cuadradoButton;
        private RadioButton circunferenciaButton;
        private Button AreaButton;
        private Button PerimetroButton;
        private Label cuadroResultado;
        private Label perimetroResultado;
        private Label label1;
        private Label label2;
    }
}
