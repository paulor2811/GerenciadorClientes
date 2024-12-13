using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GerenciadorClientes
{
    public partial class ConsultaCliente : Form
    {
        private const int PageSize = 10; // Número de registros por página
        private int currentPage = 1;
        private List<Usuario> usuarios;
        private List<Usuario> usuariosFiltrados;

        public ConsultaCliente()
        {
            InitializeComponent();
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            ConfigureDataGridView();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Desativa redimensionamento
            this.MaximizeBox = false; // Remove o botão de maximizar
        }

        private async void ConsultaCliente_Load(object sender, EventArgs e)
        {
            // Chama o método para buscar usuários e preencher o DataGridView
            await CarregarUsuariosAsync();
            FiltrarUsuarios();
            MostrarPagina(currentPage);
        }

        private void ConfigureDataGridView()
        {
            // Configura o DataGridView para permitir o redimensionamento das colunas
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToResizeColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Adiciona algumas colunas
            dataGridView1.Columns.Add("Nome", "Nome");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Telefone", "Telefone");
            dataGridView1.Columns.Add("CEP", "CEP");
            dataGridView1.Columns.Add("Endereco", "Endereco");
            dataGridView1.Columns.Add("Bairro", "Bairro");
            dataGridView1.Columns.Add("Cidade", "Cidade");
            dataGridView1.Columns.Add("UF", "UF");

            // Ajusta o redimensionamento automático das colunas
            dataGridView1.AutoResizeColumns();
        }

        private async Task CarregarUsuariosAsync()
        {
            try
            {
                var apiClient = new ApiClient();
                usuarios = await apiClient.BuscarUsuariosAsync();

                if (usuarios == null)
                {
                    MessageBox.Show("Erro ao carregar usuários.");
                }
                else
                {
                    usuariosFiltrados = new List<Usuario>(usuarios); // Inicializa usuários filtrados
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
                Console.WriteLine("Erro ao carregar usuários: " + ex.Message);
            }
        }

        private void FiltrarUsuarios()
        {
            string filtro = textBox1.Text.ToLower();
            string filtroTipo = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(filtro) || string.IsNullOrEmpty(filtroTipo))
            {
                usuariosFiltrados = new List<Usuario>(usuarios);
            }
            else
            {
                if (filtroTipo == "Nome")
                {
                    usuariosFiltrados = usuarios.Where(u => u.Nome.ToLower().Contains(filtro)).ToList();
                }
                else if (filtroTipo == "Telefone")
                {
                    usuariosFiltrados = usuarios.Where(u => u.Telefone.ToLower().Contains(filtro)).ToList();
                }
            }

            currentPage = 1;
            MostrarPagina(currentPage);
        }

        private void MostrarPagina(int pagina)
        {
            dataGridView1.Rows.Clear();

            var paginaUsuarios = usuariosFiltrados.Skip((pagina - 1) * PageSize).Take(PageSize);

            foreach (var usuario in paginaUsuarios)
            {
                dataGridView1.Rows.Add(
                    usuario.Nome,
                    usuario.Email,
                    usuario.Telefone,
                    usuario.Cep,
                    usuario.Endereco,
                    usuario.Bairro,
                    usuario.Cidade,
                    usuario.Uf
                );
            }

            // Habilitar/Desabilitar botões
            buttonPrevPage.Enabled = pagina > 1;
            buttonNextPage.Enabled = (pagina * PageSize) < usuariosFiltrados.Count;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            FiltrarUsuarios();
        }

        private void buttonPrevPage_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
            {
                currentPage--;
                MostrarPagina(currentPage);
            }
        }

        private void buttonNextPage_Click(object sender, EventArgs e)
        {
            if ((currentPage * PageSize) < usuariosFiltrados.Count)
            {
                currentPage++;
                MostrarPagina(currentPage);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Lógica para quando o conteúdo de uma célula é clicado
        }
    }
}
