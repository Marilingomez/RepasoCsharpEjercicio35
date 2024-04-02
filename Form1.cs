namespace RepasoCsharpEjercicio35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mostrar_Click(object sender, EventArgs e)
        {
            string fechatexto = textfecha.Text;
            DateTime fecha;

            if (DateTime.TryParse(fechatexto, out fecha))
            {

                MessageBox.Show("la fecha ingresada es " + fechatexto);
            }
            else
            {

                MessageBox.Show("Por favor, ingrese una fecha válida en el formato dd/mm/yyyy.");
            }
        }
    }
}
