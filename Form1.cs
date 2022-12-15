using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
namespace cad_clientes
{
    public partial class Form1 : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        MySqlDataAdapter da;
        MySqlDataReader dr;
        string strSQL;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=clientes;User Id=Leo;Password=123;");
                strSQL = "INSERT INTO CAD_CLIENTE (NOME,NUMERO,CPF,EMAIL) VALUES (@NOME,@NUMERO,@CPF,@EMAIL)";
                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@NOME", Tbx_Name.Text);
                command.Parameters.AddWithValue("@NUMERO", Tbx_Number.Text);
                command.Parameters.AddWithValue("@EMAIL", Tbx_Email.Text);
                command.Parameters.AddWithValue("@CPF", Tbx_CPF.Text);


                if (!validaEmail(Tbx_Email.Text))
                {
                    MessageBox.Show("Email Invalido");

                }
                else if (verificaCPF(Tbx_CPF.Text))
                {
                    MessageBox.Show("cpf já cadastrado");
                }
                else if (!CPF.validar(Tbx_CPF.Text))
                {
                    MessageBox.Show("cpf invalido");
                }
                else if (Tbx_Name.Text == "")
                {
                    MessageBox.Show("Escreva um nome");
                }
                else
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void BtnEditar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=clientes;User Id=Leo;Password=0305040305;");
                strSQL = "UPDATE CAD_CLIENTE SET NOME = @NOME, NUMERO= @NUMERO, EMAIL= @EMAIL, CPF=@CPF WHERE ID=@ID";
                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@NOME", Tbx_Name.Text);
                command.Parameters.AddWithValue("@NUMERO", Tbx_Number.Text);
                command.Parameters.AddWithValue("@EMAIL", Tbx_Email.Text);
                command.Parameters.AddWithValue("@ID", Tbx_ID.Text);
                command.Parameters.AddWithValue("@CPF", Tbx_CPF.Text);


                connection.Open();

                string verificaCPF = "select * from clientes where cpf=@cpf";
                verificaCPF = command.ExecuteNonQuery().ToString();
                
                
                if (verificaCPF!=null)
                {
                    MessageBox.Show("teste");
                }

                if (!validaEmail(Tbx_Email.Text))
                {
                    MessageBox.Show("Email Invalido");

                }

                else if (!CPF.validar(Tbx_CPF.Text))
                {
                    MessageBox.Show("cpf invalido");
                }
                else if (Tbx_Name.Text == "")
                {
                    MessageBox.Show("Escreva um nome");
                }
                else
                {
                    connection.Open();

                    command.ExecuteNonQuery();
                    MessageBox.Show("Salvo com sucesso");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void BtnConsultar_Click_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=clientes;User Id=Leo;Password=0305040305;");
                strSQL = "SELECT * FROM CAD_CLIENTE WHERE ID=@ID or NUMERO=@NUMBER OR NOME=@NAME OR CPF=@CPF    ";
                command = new MySqlCommand(strSQL, connection);
                string cpf = Tbx_CPF.Text;
                command.Parameters.AddWithValue("@ID", Tbx_ID.Text);
                command.Parameters.AddWithValue("@NAME", Tbx_Name.Text);
                command.Parameters.AddWithValue("@NUMBER", Tbx_Number.Text);
                
                command.Parameters.AddWithValue("@CPF", Tbx_CPF.Text);



                connection.Open();
                command.ExecuteNonQuery();

        

                da = new MySqlDataAdapter(command);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv_clientes.DataSource = dt;

                dr = command.ExecuteReader();
                while (dr.Read())
                {
                    Tbx_ID.Text = Convert.ToString(dr["id"]);
                    Tbx_Name.Text = Convert.ToString(dr["nome"]);
                    Tbx_Number.Text = Convert.ToString(dr["numero"]);
                    Tbx_Email.Text = Convert.ToString(dr["email"]);
                    Tbx_CPF.Text = Convert.ToString(dr["cpf"]);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void BtnExibir_Click_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=clientes;User Id=Leo;Password=0305040305;");
                strSQL = "SELECT * FROM CAD_CLIENTE";

                da = new MySqlDataAdapter(strSQL, connection);
                DataTable dt = new DataTable();

                da.Fill(dt);

                dgv_clientes.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void BtnExcluir_Click_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("Server=localhost;Database=clientes;User Id=Leo;Password=0305040305;");
                strSQL = "DELETE FROM CAD_CLIENTE WHERE ID = @ID";
                command = new MySqlCommand(strSQL, connection);
                command.Parameters.AddWithValue("@ID", Tbx_ID.Text);
    

                connection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                connection.Close();
                connection = null;
                command = null;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Tbx_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tbx_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Tbx_Number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private static bool validaEmail (string email)
        {
            try
            {
                var endEmail = new System.Net.Mail.MailAddress(email);
                return endEmail.Address == email;

            }

            catch
            {
                return false;
            }


        }

        private void BtnExportar_Click_Click(object sender, EventArgs e)
        {
            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for(int i=1; i<dgv_clientes.Columns.Count + 1; i++)
            {
                xlApp.Cells[1, i] = dgv_clientes.Columns[i - 1].HeaderText;
            }
            for( int i=0; i < dgv_clientes.Rows.Count; i++)
            {
                for(int j = 0; j < dgv_clientes.Columns.Count; j++)
                {
                    xlApp.Cells[i + 2, j + 1] = dgv_clientes.Rows[i].Cells[j].Value.ToString();
                }
            }

            xlApp.Columns.AutoFit();
            xlApp.Visible = true;


        }
        public bool verificaCPF(string cpf)
        {
            connection = new MySqlConnection("Server=localhost;Database=clientes;User Id=Leo;Password=0305040305;");
            strSQL = "SELECT COUNT(1) FROM CAD_CLIENTE WHERE CPF=@CPF";
            command = new MySqlCommand(strSQL, connection);

            command.Parameters.AddWithValue("@CPF", cpf);

            connection.Open();
            var result = command.ExecuteScalar();
            if (Convert.ToInt32(result) > 0) 
            {

                return true; ;

            }
            return false;
        }
        
    }

}
