namespace Ejercicio2
{
    partial class FormPrincipal
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
            groupBox1 = new GroupBox();
            tbPrecioBase = new TextBox();
            label3 = new Label();
            tbCUIT = new TextBox();
            label2 = new Label();
            tbNombre = new TextBox();
            label1 = new Label();
            btnCrearImpresion = new Button();
            btnCalcularPrecio = new Button();
            btnAgregarFigura = new Button();
            lsbFiguras = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbPrecioBase);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbCUIT);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(tbNombre);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(278, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos del Cliente";
            // 
            // tbPrecioBase
            // 
            tbPrecioBase.Location = new Point(82, 108);
            tbPrecioBase.Name = "tbPrecioBase";
            tbPrecioBase.Size = new Size(142, 23);
            tbPrecioBase.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 111);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 4;
            label3.Text = "Precio Base:";
            // 
            // tbCUIT
            // 
            tbCUIT.Location = new Point(82, 65);
            tbCUIT.Name = "tbCUIT";
            tbCUIT.Size = new Size(142, 23);
            tbCUIT.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 68);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "CUIT:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(82, 33);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(142, 23);
            tbNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 36);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnCrearImpresion
            // 
            btnCrearImpresion.Location = new Point(13, 192);
            btnCrearImpresion.Name = "btnCrearImpresion";
            btnCrearImpresion.Size = new Size(89, 38);
            btnCrearImpresion.TabIndex = 6;
            btnCrearImpresion.Text = "Crear Impresión";
            btnCrearImpresion.UseVisualStyleBackColor = true;
            btnCrearImpresion.Click += btnCrearImpresion_Click;
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(201, 192);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(89, 38);
            btnCalcularPrecio.TabIndex = 7;
            btnCalcularPrecio.Text = "Calcular precio";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // btnAgregarFigura
            // 
            btnAgregarFigura.Location = new Point(108, 192);
            btnAgregarFigura.Name = "btnAgregarFigura";
            btnAgregarFigura.Size = new Size(89, 38);
            btnAgregarFigura.TabIndex = 8;
            btnAgregarFigura.Text = "Agregar Figura";
            btnAgregarFigura.UseVisualStyleBackColor = true;
            btnAgregarFigura.Click += btnAgregarFigura_Click;
            // 
            // lsbFiguras
            // 
            lsbFiguras.FormattingEnabled = true;
            lsbFiguras.ItemHeight = 15;
            lsbFiguras.Location = new Point(13, 236);
            lsbFiguras.Name = "lsbFiguras";
            lsbFiguras.Size = new Size(277, 139);
            lsbFiguras.TabIndex = 9;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 390);
            Controls.Add(lsbFiguras);
            Controls.Add(btnAgregarFigura);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(btnCrearImpresion);
            Controls.Add(groupBox1);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Impresiones 3D";
            Load += FormPrincipal_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbPrecioBase;
        private Label label3;
        private TextBox tbCUIT;
        private Label label2;
        private TextBox tbNombre;
        private Label label1;
        private Button btnCrearImpresion;
        private Button btnCalcularPrecio;
        private Button btnAgregarFigura;
        private ListBox lsbFiguras;
    }
}
