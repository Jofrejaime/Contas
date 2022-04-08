using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
// Outras bibliotecas
using Bunifu.Framework.UI;
using MySql.Data.MySqlClient;
namespace Contas
{
class Conta
    {
       protected string Titular;
        protected double saldo;
      protected int numeroConta;
       public int tipoConta;
     public int PIN;
        protected MySqlConnection conector = new MySqlConnection("server=localhost; user=root; password=''; database=contas");
        protected MySqlCommand comando;
      protected MySqlDataAdapter Adaptador;
        protected DataTable tabela;
       
        public void verificarse(BunifuMaterialTextbox txtNumConta, PictureBox ima, BunifuThinButton2 btn)
        {
            int num = Convert.ToInt16(txtNumConta.Text);
            conector.Open();
            comando = new MySqlCommand("select id from cadastros where id = '" + num + "'", conector);
            int conta = Convert.ToInt16(comando.ExecuteScalar());
            conector.Close();
            if (conta==0)   {
                btn.Enabled = false;
                ima.BackgroundImage = global::Contas.Properties.Resources.icons8_delete_96px;
                throw new FormatException();

            }
            else
            {
                btn.Enabled = true;
                ima.BackgroundImage = global::Contas.Properties.Resources.icons8_ok_96px;
                conector.Open();
                comando = new MySqlCommand("select tipo_conta from cadastros where id = '" + num + "'", conector);
                this.tipoConta = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
              
            }
        }
        public void cadastrarConta(BunifuMaterialTextbox nome, BunifuMaterialTextbox saldo, NumericUpDown tipo_conta )
        {
           
            if (nome.Text.Equals("") || saldo.Text.Equals("") || saldo.Text.Equals(null)||nome.Text.Equals(null) || Convert.ToDouble(saldo.Text).Equals(null) )
            {
                throw new ArgumentNullException();
            }
            else
            {

                int tipoconta = Convert.ToInt16(tipo_conta.Value);
                double sald = Convert.ToDouble(saldo.Text.ToString());
                this.saldo = sald;
                this.tipoConta = tipoconta;
                this.Titular = nome.Text.ToString();
                if (tipoConta.Equals(2))
                {
                    Random pin = new Random();
                   
                    this.PIN = pin.Next(1000, 9999);
                    this.conector.Open();
                    comando = new MySqlCommand("insert into cadastros(nome, saldo,tipo_conta, pin) values(@nome,@saldo,@tipo,@pin)", conector);
                    comando.Parameters.Add("@nome", MySqlDbType.String).Value = nome.Text;
                    comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = sald;
                    comando.Parameters.Add("@tipo", MySqlDbType.Int16).Value = tipoconta;
                    comando.Parameters.Add("@pin", MySqlDbType.Int16).Value = this.PIN;
                    comando.ExecuteNonQuery();
                    conector.Close();

                }
                else
                {
                 this.conector.Open();
                comando = new MySqlCommand("insert into cadastros(nome, saldo,tipo_conta) values(@nome,@saldo,@tipo)",conector);
                comando.Parameters.Add("@nome", MySqlDbType.String).Value = nome.Text;
                comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = sald;
                comando.Parameters.Add("@tipo", MySqlDbType.Int16).Value = tipoconta;
                comando.ExecuteNonQuery();
                conector.Close();
                }
               
                
            }
        }
        public virtual void VerCadastros(BunifuCustomDataGrid data)
        {
            Adaptador = new MySqlDataAdapter("Select *From Cadastro", conector);
            tabela = new DataTable();
            tabela.Clear();
            Adaptador.Fill(tabela);
            data.DataSource = tabela;
        }
       
        public virtual void levantamento(BunifuMaterialTextbox numConta, BunifuMaterialTextbox montante)
        {
            if (numConta.Text.Equals("")||montante.Text.Equals("")|| montante.Text.Equals(null)|| numConta.Text.Equals(null))
            {
                throw new ArgumentNullException();
            }
            else
            {
               int numC= Convert.ToInt16(numConta.Text);
                double monte = Convert.ToDouble(montante.Text);

                conector.Open();
                comando = new MySqlCommand("select id from cadastros where id = '" + numC + "'", conector);
                int conta = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
                if (conta==0)
                {
                    throw new InvalidEnumArgumentException();
                }
                else if (monte<0)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                   this.conector.Open();
                   this.comando = new MySqlCommand("select saldo from cadastros where id = '"+conta+"'", conector);
                   double saldoF = Convert.ToDouble(comando.ExecuteScalar());
                   this.conector.Close();
                    if (monte>=saldoF)
                    {
                        throw new ArgumentException();

                    }
                    else
                    {
                        double saldoFinal = saldoF-  monte;
                        this.saldo = saldoFinal;
                        this.conector.Open();
                        this.comando = new MySqlCommand("update cadastros set saldo = @saldo where id = '"+conta+"' ", conector);
                        this.comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = saldoFinal;
                        this.comando.ExecuteNonQuery();
                       this.conector.Close();

                    }

                }
            }
        }
        public virtual void deposito(BunifuMaterialTextbox monte, BunifuMaterialTextbox nConta)
        {
            if (monte.Text.Equals("")||monte.Text.Equals(null) ||  nConta.Text.Equals("") || nConta.Text.Equals(null))
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
                comando = new MySqlCommand("select saldo from cadastros where id = '" + conta + "'", conector);
                this.saldo = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();

                if (conta <=0||conta.Equals(null))
                {
                    throw new ArgumentException();
                }
                else
                {
                    double mont = Convert.ToDouble(monte.Text);
                    if (mont<0 )
                    {
                        throw new InvalidEnumArgumentException();
                    }
                    else
                    {

                        this.conector.Open();
                        this.comando = new MySqlCommand("update cadastros set saldo = @saldo where id = '" + conta + "' ", conector);
                        this.comando.Parameters.Add("@saldo", MySqlDbType.Double).Value = this.saldo+mont;
                        this.comando.ExecuteNonQuery();
                        this.conector.Close();
                    }
                }

                }
        }

        public virtual void eliminarConta(BunifuMaterialTextbox numConta)
        {
            if (numConta.Text.Equals("")||numConta.Text.Equals(null)|| Convert.ToInt16(numConta.Text) < 0)
            {
                throw new ArgumentNullException();
            }
            else
            {
               int conta= Convert.ToInt16(numConta.Text);
                conector.Open();
                comando = new MySqlCommand("select id from cadastros where id = '" + conta + "'", conector);
                conta = Convert.ToInt16(comando.ExecuteScalar());
                conector.Close();
                if (conta<=0||conta.Equals(null))
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
    }
}
