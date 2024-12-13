using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Cep { get; set; }
    public string Endereco { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Uf { get; set; }
    public string Telefone { get; set; }
    public string Email { get; set; }
}

public class Endereco
{
    public string Cep { get; set; }
    public string Logradouro { get; set; }
    public string Complemento { get; set; }
    public string Bairro { get; set; }
    public string Localidade { get; set; }
    public string Uf { get; set; }
    public string Ibge { get; set; }
    public string Gia { get; set; }
    public string Ddd { get; set; }
    public string Siafi { get; set; }
}

public class ApiClient
{
    private readonly HttpClient _httpClient;

    public ApiClient()
    {
        _httpClient = new HttpClient();
    }

    public async Task<bool> InserirUsuarioAsync(Usuario usuario)
    {
        string url = "http://localhost:8000/api/insert_users";

        var jsonSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        var json = JsonConvert.SerializeObject(usuario, jsonSettings);
        Debug.WriteLine("JSON enviado: " + json); // Adiciona log para verificar o JSON
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            HttpResponseMessage response = await _httpClient.PostAsync(url, content);

            if (response.IsSuccessStatusCode)
            {
                return true; // Indica sucesso
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Console.WriteLine("Falha ao inserir o usuário. Status Code: " + response.StatusCode);
                Console.WriteLine("Resposta do servidor: " + responseContent);
                return false; // Indica falha
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao fazer a requisição: " + ex.Message);
            return false; // Indica falha
        }
    }

    public async Task<Endereco> BuscarEnderecoAsync(string cep)
    {
        string url = $"http://localhost:8000/api/via_cep/{cep}";
        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseContent = await response.Content.ReadAsStringAsync();
            var endereco = JsonConvert.DeserializeObject<Endereco>(responseContent);

            return endereco;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao fazer a requisição: " + ex.Message);
            return null; // Retorna null em caso de erro
        }
    }

    public async Task<List<Usuario>> BuscarUsuariosAsync()
    {
        string url = "http://localhost:8000/api/read_users";

        try
        {
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseContent = await response.Content.ReadAsStringAsync();
            var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(responseContent);

            Debug.WriteLine("Usuários carregados com sucesso: " + usuarios.Count);
            return usuarios;
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Erro ao fazer a requisição: " + ex.Message);
            return null; // Retorna null em caso de erro
        }
    }

    public async Task<Usuario> BuscarUsuarioPorTelefoneAsync(string telefone)
    {
        string url = "http://localhost:8000/api/read_users";

        try
        {
            Debug.WriteLine("Iniciando a requisição para: " + url);
            HttpResponseMessage response = await _httpClient.GetAsync(url);
            Debug.WriteLine("Resposta recebida: " + response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("Conteúdo da resposta: " + responseContent);

                var usuarios = JsonConvert.DeserializeObject<List<Usuario>>(responseContent);
                var usuario = usuarios?.FirstOrDefault(u => u.Telefone.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", "") == telefone.Replace(" ", "").Replace("(", "").Replace(")", "").Replace("-", ""));
                Debug.WriteLine("Usuário carregado com sucesso: " + (usuario != null ? usuario.Nome : "null"));
                return usuario;
            }
            else
            {
                Debug.WriteLine("Erro ao buscar usuário. Status Code: " + response.StatusCode);
                return null;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Erro ao fazer a requisição: " + ex.Message);
            return null;
        }
    }

    public async Task<bool> AtualizarUsuarioPorTelefoneAsync(string telefone, Usuario usuario)
    {
        string url = $"http://localhost:8000/api/update_user_by_phone/{telefone}";

        var jsonSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver()
        };

        var json = JsonConvert.SerializeObject(usuario, jsonSettings);
        var content = new StringContent(json, Encoding.UTF8, "application/json");

        try
        {
            Debug.WriteLine("Iniciando a requisição para: " + url);
            HttpResponseMessage response = await _httpClient.PutAsync(url, content);
            Debug.WriteLine("Resposta recebida: " + response.StatusCode);

            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine("Usuário atualizado com sucesso.");
                return true;
            }
            else
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Debug.WriteLine("Falha ao atualizar o usuário. Status Code: " + response.StatusCode);
                Debug.WriteLine("Resposta do servidor: " + responseContent);
                return false;
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine("Erro ao fazer a requisição: " + ex.Message);
            return false;
        }
    }



    public async Task<bool> DeletarUsuarioPorIDAsync(int id) { 
        string url = $"http://localhost:8000/api/delete_user/{id}"; 
        try { 
            HttpResponseMessage response = await _httpClient.DeleteAsync(url); 
            if (response.IsSuccessStatusCode) { 
                return true; 
            } else { 
                string responseContent = await response.Content.ReadAsStringAsync(); 
                Console.WriteLine("Falha ao deletar o usuário. Status Code: " + response.StatusCode); 
                Console.WriteLine("Resposta do servidor: " + responseContent); 
                return false; 
            } 
        } catch (Exception ex) { 
            Console.WriteLine("Erro ao fazer a requisição: " + ex.Message); 
            return false; 
        } 
    }
}
