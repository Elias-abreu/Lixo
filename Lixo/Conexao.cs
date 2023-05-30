
using MySql.Data.MySqlClient;
public static class Conexao
{
    static MySqlConnection conexao;
    public static MySqlConnection Conectar()
    {
        try
        {
            //Alteração para verificar git e github
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