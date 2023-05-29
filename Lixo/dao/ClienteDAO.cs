using MySql.Data.MySqlClient;


namespace Lixo.dao
{
    internal class ClienteDAO
    {
        public bool Cadastrar(Cliente cliente)
        {
            try
            {                
                string sql = "INSERT INTO cliente(nome,email,cpf, telefone, senha) VALUES(@nome,@email,@cpf,@telefone,@senha)";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@senha", cliente.Password);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado com sucesso! ");
                Conexao.FecharConexao();
                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar o cliente! {ex.Message} ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception(ex.Message);
                return false;
            }
        }

        public bool Excluir(int id_cliente)
        {
            try
            {
                string sql = "DELETE FROM cliente WHERE id_cliente = @id_cliente";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@id_cliente", id_cliente);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente excluido com sucesso!");
                Conexao.FecharConexao();
                return true;
            }catch (Exception ex)
            {
                MessageBox.Show($"Erro ao excluir o cliente {ex.Message} ","Erro!" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception(ex.Message);
                return false;
            }


        }

        public bool Altualizar(Cliente cliente)
        {
            try
            {
                string sql = "UPDATE cliente SET nome = @nome, email = @email, cpf = @cpf, " +
                    "telefone = @telefone WHERE id_cliente = @id_cliente";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                comando.Parameters.AddWithValue("@nome", cliente.Nome);
                comando.Parameters.AddWithValue("@email", cliente.Email);
                comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
                comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@id_cliente", cliente.Id_cliente);
                comando.ExecuteNonQuery();
                MessageBox.Show("Cliente atualizado com sucesso! ");
                Conexao.FecharConexao();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar o cliente {ex.Message} ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw new Exception(ex.Message);
                return false;
            }
        }

        public List<Cliente> ListarClientes(string nome)
        {
            List<Cliente> listaCLientes = new List<Cliente> ();
            try
            {     
                var sql = "SELECT * FROM cliente ORDER BY nome";
                MySqlCommand comando = new MySqlCommand(sql, Conexao.Conectar());
                // comando.Parameters.AddWithValue("@nome", nome);
                using (MySqlDataReader dr = comando.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Id_cliente = (int)dr["id_cliente"];
                        cliente.Nome = (String)dr["nome"];
                        cliente.Email = (String)dr["email"];
                        cliente.Cpf = (String)dr["cpf"];
                        cliente.Telefone = (String)dr["telefone"];

                        listaCLientes.Add(cliente);
                    }
                }
                Conexao.FecharConexao();
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Erro aos listar os clientes! {ex.Message} ", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return listaCLientes;
        }
    }
}