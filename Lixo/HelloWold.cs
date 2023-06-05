using Lixo.dao;
using System.Reflection;

namespace Lixo
{
    public partial class HelloWold : Form
    {
        public HelloWold()
        {
            InitializeComponent();
            PreencherTabela();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lb_id.Text = "";
            lb_nome.Text = "";
            lb_email.Text = "";
            lb_cpf.Text = "";
            lb_telefone.Text = "";
            lb_senha.Text = "";
            lb_confirma.Text = "";
            jb_atualizar.Visible = false;
            jb_salvar.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lb_senha.Text.Equals(lb_confirma.Text))
            {
                Cliente c = new Cliente();
                c.Nome = lb_nome.Text;
                c.Email = lb_email.Text;
                c.Cpf = lb_cpf.Text;
                c.Telefone = lb_telefone.Text;
                c.Password = lb_senha.Text;

                lb_mensagem.Visible = false;

                ClienteDAO cdao = new ClienteDAO();

                bool ret_cadastro = cdao.Cadastrar(c);
                PreencherTabela();

                //lb_mensagem.Text = ret_cadastro.ToString();
            }
            else
            {
                lb_mensagem.Text = "Senha diferentes!";
                lb_mensagem.Visible = true;
            }


            //string nome = textBox1.Text;
            //label1.Text = nome;
            //Console.WriteLine(nome);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            c.Id_cliente = Convert.ToInt32(lb_id.Text);
            c.Nome = lb_nome.Text;
            c.Email = lb_email.Text;
            c.Cpf = lb_cpf.Text;
            c.Telefone = lb_telefone.Text;

            lb_mensagem.Visible = false;

            ClienteDAO cdao = new ClienteDAO();
            cdao.Altualizar(c);
            PreencherTabela();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_id = (listView1.SelectedItems[0].SubItems[0].Text).ToString();
            //MessageBox.Show("Código do produto escolhido: " + listView1.SelectedItems[0].SubItems[0].Text);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void listView1_Click(object sender, EventArgs e)
        {
            /*
            lb_id.Text = listView1.SelectedItems[0].SubItems[0].Text;
            lb_nome.Text = listView1.SelectedItems[0].SubItems[1].Text;
            lb_email.Text = listView1.SelectedItems[0].SubItems[2].Text;
            lb_cpf.Text = listView1.SelectedItems[0].SubItems[3].Text;
            lb_telefone.Text = listView1.SelectedItems[0].SubItems[3].Text;
            */
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                lb_id.Text = listView1.SelectedItems[0].SubItems[0].Text;
                lb_nome.Text = listView1.SelectedItems[0].SubItems[1].Text;
                lb_email.Text = listView1.SelectedItems[0].SubItems[2].Text;
                lb_cpf.Text = listView1.SelectedItems[0].SubItems[3].Text;
                lb_telefone.Text = listView1.SelectedItems[0].SubItems[3].Text;
                jb_atualizar.Visible = true;
                jb_salvar.Visible = false;
            }
        }



        private void button6_Click(object sender, EventArgs e)
        {
            errorProvider_nome.SetError(lb_nome, "Digite seu nome");
            lb_id.Text = "";
            lb_nome.Text = "";
            lb_email.Text = "";
            lb_cpf.Text = "";
            lb_telefone.Text = "";
            lb_senha.Text = "";
            lb_confirma.Text = "";
            jb_atualizar.Visible = false;
            jb_salvar.Visible = true;
            lb_nome.Focus();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string mensagem = "Você tem certeza que deseja excluir o cliente";
                if (MessageBox.Show(mensagem, "??", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    ClienteDAO cdao = new ClienteDAO();
                    int id_cliente = Convert.ToInt32(listView1.SelectedItems[0].SubItems[0].Text);
                    cdao.Excluir(id_cliente);
                    PreencherTabela();
                }
            }
            else
            {
                MessageBox.Show("Seleciona um cliente para excluir!");
            }

        }

        private void PreencherTabela()
        {
            ClienteDAO cdao = new ClienteDAO();
            List<Cliente> listaCliente = cdao.ListarClientes("");
            listView1.Items.Clear();

            //listView1.Columns.Add("Nome", 150).TextAlign = HorizontalAlignment.Left;
            //listView1.Columns.Add("CPF", 100).TextAlign = HorizontalAlignment.Left;
            //listView1.Columns.Add("E-mail", 120).TextAlign = HorizontalAlignment.Left;
            //listView1.Columns.Add("Telefone", 100).TextAlign = HorizontalAlignment.Left;

            //listView1.View = View.Details;

            string[] item = new string[5];
            foreach (Cliente c in listaCliente)
            {
                item[0] = c.Id_cliente.ToString();
                item[1] = c.Nome;
                item[2] = c.Email;
                item[3] = c.Cpf;
                item[4] = c.Telefone;
                listView1.Items.Add(new ListViewItem(item));
            }
        }


    }
}