namespace Ejercicio1
{
    partial class FormTomarPedido
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
            label1 = new Label();
            tbNombre = new TextBox();
            cbEnvio = new CheckBox();
            label2 = new Label();
            tbDistEnKm = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre del Cliente:";
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(131, 6);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(190, 23);
            tbNombre.TabIndex = 1;
            // 
            // cbEnvio
            // 
            cbEnvio.AutoSize = true;
            cbEnvio.Location = new Point(12, 58);
            cbEnvio.Name = "cbEnvio";
            cbEnvio.Size = new Size(85, 19);
            cbEnvio.TabIndex = 2;
            cbEnvio.Text = "Con Envío?";
            cbEnvio.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(131, 58);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "Distancia en Km:";
            // 
            // tbDistEnKm
            // 
            tbDistEnKm.Location = new Point(232, 55);
            tbDistEnKm.Name = "tbDistEnKm";
            tbDistEnKm.Size = new Size(89, 23);
            tbDistEnKm.TabIndex = 4;
            // 
            // btnAceptar
            // 
            btnAceptar.DialogResult = DialogResult.OK;
            btnAceptar.Location = new Point(12, 113);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 5;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.DialogResult = DialogResult.Cancel;
            btnCancelar.Location = new Point(246, 113);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormTomarPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(333, 151);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(tbDistEnKm);
            Controls.Add(label2);
            Controls.Add(cbEnvio);
            Controls.Add(tbNombre);
            Controls.Add(label1);
            Name = "FormTomarPedido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tomar Pedido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public TextBox tbNombre;
        public CheckBox cbEnvio;
        private Label label2;
        public TextBox tbDistEnKm;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}