using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Cmp;
using System.Text.Json;

namespace Selecoes;

public class BD
{
    private static string StringConexao =
        Environment.GetEnvironmentVariable("MYSQL_URI")!;

    public static void InserirCadastro(Cadastro novoCadastro)
    {
        try
        {
            var mysqlConexao = new MySqlConnection(StringConexao);
            mysqlConexao.Open();
            var sql = "INSERT INTO cadastros(cidade, turnos, data_termo_aceito ) VALUES(@cidade, @turnos, @data_termo_aceito)";

            var mysqlComando = new MySqlCommand(sql, mysqlConexao);

            mysqlComando.Parameters.AddWithValue("@cidade",
                novoCadastro.Cidade);
                 mysqlComando.Parameters.AddWithValue("@turnos", JsonSerializer.Serialize(novoCadastro.Turnos));
                 mysqlComando.Parameters.AddWithValue("@data_termo_aceito", novoCadastro.DataTermoAceito);

            var linhasAfetadas = mysqlComando.ExecuteNonQuery();
            if (linhasAfetadas > 0)
            {
                MessageBox.Show("Cadastro realizado com sucesso!", 
                    "Sucesso!", MessageBoxButtons.OK , MessageBoxIcon.Information);

            }

        }
        catch
        {
            MessageBox.Show("Ocorreu um erro ao tentar inserir um novo cadastro.","Erro!", MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
    public static List<Cadastro> RecuperarCadastros()
    {
        try
        {
            var mysqlConexao = new MySqlConnection(StringConexao);
            mysqlConexao.Open();

            var sql = "SELECT * FROM cadastros";

            var mysqlComando = new MySqlCommand(sql, mysqlConexao);

            var leitor = mysqlComando.ExecuteReader();

            List<Cadastro> cadastroExternos = [];

            while (leitor.Read())
            {
                var cadastroBanco = new Cadastro();
                cadastroBanco.Cidade = leitor["Cidade"].ToString();
                cadastroBanco.Turnos = JsonSerializer.Deserialize<List<String>>(leitor["turnos"].ToString());
                cadastroBanco.DataTermoAceito = Convert.ToDateTime(leitor["data_termo_aceito"]);
                cadastroExternos.Add(cadastroBanco);
            }
            return cadastroExternos;
        }
        catch
        {
            MessageBox.Show("Não foi possível recuperar os cadastros salvos no banco de dados!", "Error ao recuperar dados");
            return [];
        }
    }
} 