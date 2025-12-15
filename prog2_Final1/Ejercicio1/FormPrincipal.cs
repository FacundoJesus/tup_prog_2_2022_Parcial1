using Ejercicio1.Models;
using System.Collections;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio1
{
    public partial class FormPrincipal : Form
    {
        private ArrayList menuesDisponibles = new ArrayList();
        public FormPrincipal()
        {
            InitializeComponent();

            menuesDisponibles.Add(new ItemMenu(1, "Pizza Napolitana") { Precio = 14300 });
            menuesDisponibles.Add(new ItemMenu(2, "Pizza Parmesana") { Precio = 15300 });
            menuesDisponibles.Add(new ItemMenu(3, "Pizza Con Rúcula") { Precio = 20000 });
            menuesDisponibles.Add(new ItemMenu(4, "Pizza Margarita") { Precio = 18000 });
            menuesDisponibles.Add(new ItemMenu(5, "Pizza Carnívora") { Precio = 16500 });

            foreach (ItemMenu item in menuesDisponibles)
            {
                comboBox1.Items.Add(item);
            }
            //comboBox1.Items.AddRange(menuesDisponibles.ToArray());
        }

        Rotiseria rotiseria = new Rotiseria();

        Pedido nuevoPedido;

        private void FormPrincipal_Load(object sender, EventArgs e){}

        private void btnTomarPedido_Click(object sender, EventArgs e)
        {
            FormTomarPedido formPedido = new FormTomarPedido();
            if (formPedido.ShowDialog() == DialogResult.OK)
            {
                string cliente = formPedido.tbNombre.Text;
                if (formPedido.cbEnvio.Checked)
                {
                    if (formPedido.tbDistEnKm.Text != "")
                    {
                        double distEnKm = Convert.ToDouble(formPedido.tbDistEnKm.Text);

                        nuevoPedido = new Delivery(rotiseria.TotalDePedidos, cliente, distEnKm);

                    }
                   
                }
                else
                {
                    nuevoPedido = new Pedido(rotiseria.TotalDePedidos, cliente);
                }

                rotiseria.AgregarPedido(nuevoPedido);

                formPedido.Dispose();

            }
            else
            {
                MessageBox.Show("Pedido cancelado", "Operacion cancelada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarMenu_Click(object sender, EventArgs e)
        { 
            if (comboBox1.SelectedItem != null)
            {
                int cantidad = Convert.ToInt32(tbCantidad.Text);
                ItemMenu itemMenuSelected = comboBox1.SelectedItem as ItemMenu;

                nuevoPedido.AgregarItem(itemMenuSelected, cantidad);

                for (int n = 0; n < cantidad; n++)
                    lsbPedido.Items.Add(itemMenuSelected.ToString());

                #region Limpio Campos
                comboBox1.SelectedIndex = -1;
                btnCerrarPedido.Enabled = true;
                tbCantidad.Clear();
                #endregion
            }
            else
            {
                MessageBox.Show("Debes seleccionar un item del ComboBox", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCerrarPedido_Click(object sender, EventArgs e)
        {
          
            MessageBox.Show($"Precio a pagar: {nuevoPedido.Precio():c2}");


            //mostrar pedidos ordenados por número
            rotiseria.Ordenar();
            for (int n = 0; n < rotiseria.TotalDePedidos; n++)
            {
                Pedido pedido = rotiseria.VerPedido(n);
                lsbListaPedidos.Items.Add(pedido);
            }
            lsbPedido.Items.Clear();
            
        }
    }
    
}
