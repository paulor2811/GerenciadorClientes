namespace GerenciadorClientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CadastroCliente RegisterClient = new CadastroCliente();
            RegisterClient.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ConsultaCliente ConsultClient = new ConsultaCliente();
            ConsultClient.ShowDialog();
        }
    }
}
