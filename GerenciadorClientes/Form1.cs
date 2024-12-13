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

        private void button3_Click(object sender, EventArgs e)
        {
            AlterarCadastro AltRegister = new AlterarCadastro();
            AltRegister.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeletarCadastro Del = new DeletarCadastro();
            Del.ShowDialog();
        }
    }
}
