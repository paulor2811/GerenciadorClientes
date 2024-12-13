using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorClientes
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            await SendData();
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            await BuscarEndereco();
        }
        public async Task SendData()
        {
            try
            {
                var apiClient = new ApiClient();
                var usuario = new Usuario
                {
                    Nome = textBoxNome.Text,
                    Cep = textBoxCep.Text,
                    Endereco = textBoxEndereco.Text,
                    Bairro = textBoxBairro.Text,
                    Cidade = textBoxCidade.Text,
                    Uf = textBoxUf.Text,
                    Telefone = textBoxTelefone.Text,
                    Email = textBoxEmail.Text
                };

                bool sucesso = await apiClient.InserirUsuarioAsync(usuario);
                if (sucesso)
                {
                    MessageBox.Show("Usuário inserido com sucesso!");
                }
                else
                {
                    MessageBox.Show("Falha ao inserir o usuário.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao enviar dados: " + ex.Message);
                Console.WriteLine("Erro ao enviar dados: " + ex.Message);
            }
        }
        public async Task BuscarEndereco()
        {
            try
            {
                var apiClient = new ApiClient(); 
                string cep = textBoxCep.Text.Replace("-", ""); // Remove possíveis traços
                var endereco = await apiClient.BuscarEnderecoAsync(cep); 
                
                if (endereco != null) { 
                    textBoxEndereco.Text = endereco.Logradouro;
                    textBoxBairro.Text = endereco.Bairro; 
                    textBoxCidade.Text = endereco.Localidade; 
                    textBoxUf.Text = endereco.Uf; 
                } else { 
                    MessageBox.Show("CEP não encontrado."); 
                } 
            } catch (Exception ex) { 
                MessageBox.Show("Erro ao buscar endereço: " + ex.Message); 
                Debug.WriteLine("Erro ao buscar endereço: " + ex.Message); 
            } 
        }
    }
}
