namespace L9_SBL_1104822
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modelo, marca, resultados;
            int precio, descuento, disponible, cambio;
            if (!int.TryParse(txt_precio.Text, out int num))
            {
                MessageBox.Show("Debe ingrear un numero");
            }
            else
            {
                if (!int.TryParse(txt_tipoCambioDolar.Text, out int num1))
                {
                    MessageBox.Show("Debe de ingresar numero no letra");
                }
                else
                {
                    MessageBox.Show("Debe de ingresar un numero");
                }
                if (!int.TryParse(txt_descuentoAplicado.Text, out int num2))
                {
                    MessageBox.Show("Debe ingresar un numero");
                }
                else
                {
                    if (!int.TryParse(txt_disponible.Text, out int num3))
                    {
                        MessageBox.Show("Debe de ingresar un numero no letra");
                    }
                    else
                    {
                        precio = Convert.ToInt32(txt_precio.Text);
                        cambio = Convert.ToInt32(txt_tipoCambioDolar.Text);
                        descuento = Convert.ToInt32(txt_descuentoAplicado.Text);
                        disponible = Convert.ToInt32(txt_disponible.Text);

                        lbl_modelo.Text = precio.ToString();
                        lbl_precio.Text = cambio.ToString();
                        lbl_disponible.Text = disponible.ToString();
                        lbl_descuento.Text = descuento.ToString();
                    }
                }
            }
           
               
           

             
        }
    }
}