using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorClientes
{
    public partial class DeletarCadastro : Form
    {
        public DeletarCadastro()
        {
            InitializeComponent();
        }

        private void DeletarCadastro_Load(object sender, EventArgs e)
        {
        }

       

        private async void buttonID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int userId))
            {
                var apiClient = new ApiClient();
                bool sucesso = await apiClient.DeletarUsuarioPorIDAsync(userId);

                if (sucesso)
                {
                    MessageBox.Show("Usuário deletado com sucesso.");
                }
                else
                {
                    MessageBox.Show("Erro ao deletar usuário.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um ID válido.");
            }
        }
    }
}
