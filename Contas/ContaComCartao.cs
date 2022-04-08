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
    class ContaComCartao:Conta
    {
        public override void VerCadastros(BunifuCustomDataGrid data)
        {
            Adaptador = new MySqlDataAdapter("Select ID, Nome, Saldo From cadastros where tipo_conta=2", conector);
            tabela = new DataTable();
            tabela.Clear();
            Adaptador.Fill(tabela);
            data.DataSource = tabela;
        }


        public void  levantamento(BunifuMaterialTextbox numConta, BunifuMaterialTextbox montante, BunifuMaterialTextbox pin)
        {
            if (numConta.Text.Equals("") || montante.Text.Equals("") || montante.Text.Equals(null) || numConta.Text.Equals(null)|| pin.Text.Equals(""))
            {
                throw new ArgumentNullException();
            }
            else
            {
                int numC = Convert.ToInt16(numConta.Text);
                double monte = Convert.ToDouble(montante.Text);

                conector.Open();
                comando = new MySqlCommand("select id from cadastros where id = '" + numC + "'", conector);
                int conta = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
                conector.Open();
                comando = new MySqlCommand("select PIN from cadastros where id = '" + numC + "'", conector);
                int p = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
             
                    if (conta <= 0 || p != Convert.ToInt32(pin.Text))
                {
                   
                    throw new InvalidEnumArgumentException();
                }
                
                else if (monte < 0)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    this.conector.Open();
                    this.comando = new MySqlCommand("select saldo from cadastros where id = '"+conta+"'", conector);
                    double saldoF = Convert.ToDouble(comando.ExecuteScalar());
                     this.conector.Close();
                    if (monte >= saldoF)
                    {
                        throw new ArgumentException();

                    }
                    else
                    {
                        double saldoFinal = saldoF - monte;
                        this.saldo = saldoFinal;
                        this.conector.Open();
                        this.comando = new MySqlCommand("update cadastros set saldo = @saldo where id = '" + conta + "' ", conector);
                        this.comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = saldoFinal;
                        this.comando.ExecuteNonQuery();
                        this.conector.Close();

                    }

                }
            }
        }
        public  void  deposito(BunifuMaterialTextbox monte, BunifuMaterialTextbox nConta, BunifuMaterialTextbox pin)
        {
            if (monte.Text.Equals("") || monte.Text.Equals(null) || nConta.Text.Equals("") || nConta.Text.Equals(null) || pin.Text.Equals(""))
            {
                throw new ArgumentNullException();
            }
            else
            {
                int conta = Convert.ToInt16(nConta.Text);

                conector.Open();
                comando = new MySqlCommand("select id from cadastros where id = '" + conta + "'", conector);
                conta = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
                conector.Open();
                comando = new MySqlCommand("select PIN from cadastros where id = '" + conta + "'", conector);
                int p = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
                conector.Open();
                comando = new MySqlCommand("select saldo from cadastros where id = '" + conta + "'", conector);
                this.saldo = Convert.ToInt32(comando.ExecuteScalar());
                conector.Close();
                if (conta <= 0 || conta.Equals(null) || p.Equals(0) || p.Equals(null) || !p.Equals(Convert.ToInt32(pin.Text.ToString())))
                {
                    throw new InvalidEnumArgumentException(); ;
                }
                else
                {
                    double mont = Convert.ToDouble(monte.Text);
                    if (mont < 0)
                    {
                        throw new InvalidOperationException();
                    }
                    else
                    {

                        this.conector.Open();
                        this.comando = new MySqlCommand("update cadastros set saldo = @saldo where id = '" + conta + "' ", conector);
                        this.comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = this.saldo + mont;
                        this.comando.ExecuteNonQuery();
                        this.conector.Close();
                    }
                }

            }
        }
        public  void eliminarConta(BunifuMaterialTextbox numConta, BunifuMaterialTextbox pin)
        {
            if (numConta.Text.Equals("") || numConta.Text.Equals(null) || Convert.ToInt16(numConta.Text) < 0||pin.Text.Equals(""))
            {
                throw new ArgumentNullException();
            }
            else
            {
                int conta = Convert.ToInt16(numConta.Text);
                conector.Open();
                comando = new MySqlCommand("select id from cadastros where id = '" + conta + "'", conector);
                conta = Convert.ToInt16(comando.ExecuteScalar());

                conector.Close();
                conector.Open();
                comando = new MySqlCommand("select PIN from cadastros where id = '" + conta + "'", conector);
                int p = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
                if (conta <= 0 || conta.Equals(null) || p.Equals(0) || p.Equals(null) || !p.Equals(Convert.ToInt32(pin.Text)))
                {
                    throw new InvalidOperationException();
                }
                else
                {

                    this.conector.Open();
                    this.comando = new MySqlCommand("delete from cadastros where id = '" + conta + "' ", conector);
                    this.comando.ExecuteNonQuery();
                    this.conector.Close();
                }


            }
        }
        public  void alterarPin(BunifuMaterialTextbox pinactual, BunifuMaterialTextbox pinnovo, BunifuMaterialTextbox numconta)
        {
           
            conector.Open();
            comando = new MySqlCommand("select PIN from cadastros where id = '" + numconta.Text+ "'", conector);
             
            int   p = Convert.ToInt32(comando.ExecuteScalar());
            
            conector.Close();
            if (!p.Equals(Convert.ToInt16(pinnovo.Text)) || p.Equals(0))
            {
                throw new ArgumentException();
            }
            else
            {
                if (Convert.ToInt16(pinnovo.Text).Equals(null))
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    this.conector.Open();
                    this.comando = new MySqlCommand("update cadastros set pin = @pin where id = '" + numconta.Text + "' ", conector);
                    this.comando.Parameters.Add("@pin", MySqlDbType.Int32).Value = Convert.ToInt32( pinactual.Text);
                    this.comando.ExecuteNonQuery();
                    this.conector.Close();
                }
            }
            if (Convert.ToInt16(pinnovo.Text).Equals(null))
            {
                throw new ArgumentNullException();
            }
            else
            {
            this.conector.Open();
            this.comando = new MySqlCommand("update cadastros set pin = @pin where id = '" + numconta.Text + "' ", conector);
            this.comando.Parameters.Add("@pin", MySqlDbType.Int32).Value =Convert.ToInt32( pinactual.Text);
            this.comando.ExecuteNonQuery();
            this.conector.Close();
            }
            
        }
    }


}
