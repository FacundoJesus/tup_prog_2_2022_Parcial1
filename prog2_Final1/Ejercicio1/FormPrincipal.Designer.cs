
namespace Ejercicio1
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
            btnTomarPedido = new Button();
            comboBox1 = new ComboBox();
            btnAgregarMenu = new Button();
            label1 = new Label();
            tbCantidad = new TextBox();
            lsbListaPedidos = new ListBox();
            btnCerrarPedido = new Button();
            lsbPedido = new ListBox();
            SuspendLayout();
            // 
            // btnTomarPedido
            // 
            btnTomarPedido.Location = new Point(12, 12);
            btnTomarPedido.Name = "btnTomarPedido";
            btnTomarPedido.Size = new Size(272, 54);
            btnTomarPedido.TabIndex = 0;
            btnTomarPedido.Text = "Tomar Pedido";
            btnTomarPedido.UseVisualStyleBackColor = true;
            btnTomarPedido.Click += btnTomarPedido_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(184, 23);
            comboBox1.TabIndex = 1;
            // 
            // btnAgregarMenu
            // 
            btnAgregarMenu.Location = new Point(215, 72);
            btnAgregarMenu.Name = "btnAgregarMenu";
            btnAgregarMenu.Size = new Size(69, 54);
            btnAgregarMenu.TabIndex = 2;
            btnAgregarMenu.Text = "Agregar Menu";
            btnAgregarMenu.UseVisualStyleBackColor = true;
            btnAgregarMenu.Click += btnAgregarMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 138);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 3;
            label1.Text = "Cantidad:";
            // 
            // tbCantidad
            // 
            tbCantidad.Location = new Point(76, 135);
            tbCantidad.Name = "tbCantidad";
            tbCantidad.Size = new Size(100, 23);
            tbCantidad.TabIndex = 4;
            // 
            // lsbListaPedidos
            // 
            lsbListaPedidos.FormattingEnabled = true;
            lsbListaPedidos.ItemHeight = 15;
            lsbListaPedidos.Location = new Point(12, 319);
            lsbListaPedidos.Name = "lsbListaPedidos";
            lsbListaPedidos.Size = new Size(272, 109);
            lsbListaPedidos.TabIndex = 5;
            // 
            // btnCerrarPedido
            // 
            btnCerrarPedido.Location = new Point(12, 284);
            btnCerrarPedido.Name = "btnCerrarPedido";
            btnCerrarPedido.Size = new Size(272, 29);
            btnCerrarPedido.TabIndex = 6;
            btnCerrarPedido.Text = "Cerrar Pedido";
            btnCerrarPedido.UseVisualStyleBackColor = true;
            btnCerrarPedido.Click += btnCerrarPedido_Click;
            // 
            // lsbPedido
            // 
            lsbPedido.FormattingEnabled = true;
            lsbPedido.ItemHeight = 15;
            lsbPedido.Location = new Point(12, 169);
            lsbPedido.Name = "lsbPedido";
            lsbPedido.Size = new Size(272, 109);
            lsbPedido.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.Disable;
            ClientSize = new Size(300, 441);
            Controls.Add(lsbPedido);
            Controls.Add(btnCerrarPedido);
            Controls.Add(lsbListaPedidos);
            Controls.Add(tbCantidad);
            Controls.Add(label1);
            Controls.Add(btnAgregarMenu);
            Controls.Add(comboBox1);
            Controls.Add(btnTomarPedido);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rotisería";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Button btnTomarPedido;
        private ComboBox comboBox1;
        private Button btnAgregarMenu;
        private Label label1;
        private TextBox tbCantidad;
        private ListBox lsbListaPedidos;
        private Button btnCerrarPedido;
        private ListBox lsbPedido;
    }
}
