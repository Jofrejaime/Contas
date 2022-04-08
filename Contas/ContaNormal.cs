using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
// Outras Bibliotecas
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
namespace Contas
{
    class ContaNormal:Conta
    {
        
        public override void VerCadastros(BunifuCustomDataGrid data)
        {
            Adaptador = new MySqlDataAdapter("Select ID, Nome, Saldo From cadastros where tipo_conta=1", conector);
            tabela = new DataTable();
            tabela.Clear();
            Adaptador.Fill(tabela);
            data.DataSource = tabela;
        }
    }
}
