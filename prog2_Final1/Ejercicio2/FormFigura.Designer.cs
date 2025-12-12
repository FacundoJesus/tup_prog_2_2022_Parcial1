namespace Ejercicio2
{
    partial class FormFigura
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
            rbCilindro = new RadioButton();
            rbPrisma = new RadioButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbLargoRadio = new TextBox();
            tbAncho = new TextBox();
            tbAlto = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // rbCilindro
            // 
            rbCilindro.AutoSize = true;
            rbCilindro.Location = new Point(12, 12);
            rbCilindro.Name = "rbCilindro";
            rbCilindro.Size = new Size(67, 19);
            rbCilindro.TabIndex = 0;
            rbCilindro.TabStop = true;
            rbCilindro.Text = "Cilindro";
            rbCilindro.UseVisualStyleBackColor = true;
            // 
            // rbPrisma
            // 
            rbPrisma.AutoSize = true;
            rbPrisma.Location = new Point(12, 50);
            rbPrisma.Name = "rbPrisma";
            rbPrisma.Size = new Size(61, 19);
            rbPrisma.TabIndex = 1;
            rbPrisma.TabStop = true;
            rbPrisma.Text = "Prisma";
            rbPrisma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 14);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Largo/Radio:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(163, 45);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Ancho:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(176, 79);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Alto:";
            // 
            // tbLargoRadio
            // 
            tbLargoRadio.Location = new Point(214, 11);
            tbLargoRadio.Name = "tbLargoRadio";
            tbLargoRadio.Size = new Size(100, 23);
            tbLargoRadio.TabIndex = 5;
            // 
            // tbAncho
            // 
            tbAncho.Location = new Point(214, 42);
            tbAncho.Name = "tbAncho";
            tbAncho.Size = new Size(100, 23);
            tbAncho.TabIndex = 6;
            // 
            // tbAlto
            // 
            tbAlto.Location = new Point(214, 71);
            tbAlto.Name = "tbAlto";
            tbAlto.Size = new Size(100, 23);
            tbAlto.TabIndex = 7;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Location = new Point(12, 131);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.DialogResult = DialogResult.Cancel;
            button2.Location = new Point(239, 131);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            // 
            // TipoFigura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 166);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbAlto);
            Controls.Add(tbAncho);
            Controls.Add(tbLargoRadio);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rbPrisma);
            Controls.Add(rbCilindro);
            Name = "TipoFigura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tipo de Figura";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton radioButton1;
        private Label label1;
        private Label label2;
        public RadioButton rbCilindro;
        public RadioButton rbPrisma;
        private Label label3;
        public TextBox tbLargoRadio;
        public TextBox tbAncho;
        public TextBox tbAlto;
        private Button button1;
        private Button button2;
    }
}