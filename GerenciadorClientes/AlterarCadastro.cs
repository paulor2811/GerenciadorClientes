using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorClientes
{
    public partial class AlterarCadastro : Form
    {
        private string userTelefone; // Armazenar o telefone do usuário encontrado

        public AlterarCadastro()
        {
            InitializeComponent();
            this.textBoxtel = new MaskedTextBox();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Lógica para quando o texto da `textBox1` muda (se necessário)
        }

        private async void buttonSearchID_Click_1(object sender, EventArgs e)
        {
            var telefone = textBoxtel.Text;
            Console.WriteLine("Buscando usuário com telefone: " + telefone);
            var apiClient = new ApiClient();
            var usuario = await apiClient.BuscarUsuarioPorTelefoneAsync(telefone);
            if (usuario != null)
            {
                Console.WriteLine("Usuário encontrado: " + usuario.Nome);
                userTelefone = usuario.Telefone;
                textBoxNome.Text = usuario.Nome;
                textBoxCEP.Text = usuario.Cep;
                textBoxEndereco.Text = usuario.Endereco;
                textBoxBairro.Text = usuario.Bairro;
                textBoxCidade.Text = usuario.Cidade;
                textBoxUF.Text = usuario.Uf;
                textBoxTelefone.Text = usuario.Telefone; // Armazenar o telefone do usuário encontrado
                textBoxemail.Text = usuario.Email;
            }
            else
            {
                Console.WriteLine("Usuário não encontrado.");
                MessageBox.Show("Usuário não encontrado.");
            }
        }

        private async void buttonSave_Click(object sender, EventArgs e)
        {
            var usuario = new Usuario
            {
                Nome = textBoxNome.Text,
                Cep = textBoxCEP.Text,
                Endereco = textBoxEndereco.Text,
                Bairro = textBoxBairro.Text,
                Cidade = textBoxCidade.Text,
                Uf = textBoxUF.Text,
                Telefone = textBoxTelefone.Text,
                Email = textBoxemail.Text // Inclui o campo de email
            };

            var apiClient = new ApiClient();
            bool sucesso = await apiClient.AtualizarUsuarioPorTelefoneAsync(userTelefone, usuario);

            if (sucesso)
            {
                MessageBox.Show("Usuário atualizado com sucesso.");
            }
            else
            {
                MessageBox.Show("Erro ao atualizar usuário.");
            }
        }
    }
}
