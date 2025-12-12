using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e) { }

        Impresion3D impresion3D;

        private void ActualizarFiguras()
        {
            lsbFiguras.Items.Clear();
            impresion3D.Ordenar();
            for (int i = 0; i< impresion3D.CantidadFiguras; i++) 
            {
                lsbFiguras.Items.Add(impresion3D.VerFigura(i).Descripcion);
            }
            
        }

        private void btnCrearImpresion_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            long cuit = Convert.ToInt64(tbCUIT.Text);

            double precioBase = Convert.ToDouble(tbPrecioBase.Text);

            impresion3D = new Impresion3D(precioBase, nombre, cuit);

            MessageBox.Show("Impresión iniciada!");

            #region Bloqueo Campos
            tbNombre.Enabled = false;
            tbCUIT.Enabled = false;
            tbPrecioBase.Enabled = false;
            #endregion
        }

        private void btnAgregarFigura_Click(object sender, EventArgs e)
        {
            FormFigura formFigura = new FormFigura();
            if (formFigura.ShowDialog() == DialogResult.OK)
            {
                double alto = Convert.ToDouble(formFigura.tbAlto.Text);

                Figura figura = null;
                if (formFigura.rbCilindro.Checked)
                {
                    double radio = Convert.ToDouble(formFigura.tbLargoRadio.Text);
                    figura = new Cilindro(radio, alto);
                }
                else
                if (formFigura.rbPrisma.Checked)
                {
                    double largo = Convert.ToDouble(formFigura.tbLargoRadio.Text);
                    double ancho = Convert.ToDouble(formFigura.tbAncho.Text);

                    figura = new Prisma(largo, ancho, alto);
                }

                if (figura != null)
                {
                    impresion3D.AgregarFigura(figura);
                    MessageBox.Show("Figura Agregada!");
                }

                #region Limpio Campos
                formFigura.tbLargoRadio.Clear();
                formFigura.tbAlto.Clear();
                #endregion

            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            lsbFiguras.Items.Add("Nombre: " + impresion3D.ToString());
            ActualizarFiguras();
            lsbFiguras.Items.Add($"Tiempo: {impresion3D.Tiempo()} segundos");
            lsbFiguras.Items.Add($"Precio Total: {impresion3D.PrecioEstimado():c2}");
        }
    }
}
