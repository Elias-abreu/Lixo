
using MySql.Data.MySqlClient;
public static class Conexao
{
    static MySqlConnection conexao;
    public static MySqlConnection Conectar()
    {
        try
        {
            string strconexao = "server=localhost;uid=root;pwd=abreu;database=bancoTeste";
            conexao = new MySqlConnection(strconexao);
            conexao.Open();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Impossível estabelecer conexão ", ex.Message);
          
        }
        return conexao;
    }

    public static void FecharConexao()
    {
        conexao.Close();
    }


}