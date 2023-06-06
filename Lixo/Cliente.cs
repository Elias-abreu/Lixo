using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lixo
{
    /*Git pull e git Clone*/
    /* Git push e commit*/

    /*Git add. git commit e git push*/
    internal class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Email { get;set; }
        public string Password { get; set; }
        public string Telefone { get; set; }
    }
}
