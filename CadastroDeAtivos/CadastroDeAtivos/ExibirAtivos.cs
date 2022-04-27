using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CadastroDeAtivos
{
    public partial class fmrExibirAtivos : Form
    {
        int ID = 0;
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJ9K06\SQLEXPRESS;Initial Catalog=Ativo;Integrated Security=True;Pooling=False");
        SqlCommand comm;
        SqlDataAdapter adapt;

        public void LimparDados()
        {
            txtNomeAtivo.Text = "";
        }

        public fmrExibirAtivos()
        {
            InitializeComponent();
            ExibirAtivo();
        }     

        public void ExibirAtivo()
        {
            try
            {
                conn.Open();
                DataTable dt = new DataTable();
                adapt = new SqlDataAdapter("SELECT Nome FROM Ativo", conn);
                adapt.Fill(dt);
                dgvAtivos.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                throw;
            }
            finally
            {
                conn.Close();
            }
        }

        private void btn_NovoAtivo(object sender, EventArgs e)
        {
            txtNomeAtivo.Text = "";
        }

        private void btn_InserirAtivo(object sender, EventArgs e)
        {
            if (txtNomeAtivo.Text != "")
            {
                try
                {
                    comm = new SqlCommand("INSERT INTO Ativo (Nome) VALUES (@Nome)", conn);
                    conn.Open();
                    comm.Parameters.AddWithValue("@nome", txtNomeAtivo.Text.ToUpper());
                    comm.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                    throw;
                }
                finally
                {
                    conn.Close();
                    ExibirAtivo();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void btn_EditarAtivo(object sender, EventArgs e)
        {
            if (txtNomeAtivo.Text != "")
            {
                try
                {
                    comm = new SqlCommand("UPDATE Ativo set Nome = @nome where id = @id and nome = @nome", conn);
                    conn.Open();
                    comm.Parameters.AddWithValue("@id", ID);
                    comm.Parameters.AddWithValue("@nome", txtNomeAtivo.Text);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Registro atualizado com sucesso...");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro : " + ex.Message);
                    throw;
                }
                finally
                {
                    conn.Close();
                    ExibirAtivo();
                    LimparDados();
                }
            }
            else
            {
                MessageBox.Show("Informe todos os dados requeridos");
            }
        }

        private void btn_ExcluirAtivo(object sender, EventArgs e)
        {
            if (ID != 0)
            {
                if (MessageBox.Show("Deseja Deletar este registro ?", "Ativo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        comm = new SqlCommand("DELETE Ativo WHERE ID = @id", conn);
                        conn.Open();
                        comm.Parameters.AddWithValue("@id", ID);
                        comm.ExecuteNonQuery();
                        MessageBox.Show("registro deletado com sucesso...!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro : " + ex.Message);
                        throw;
                    }
                    finally
                    {
                        conn.Close();
                        ExibirAtivo();
                        LimparDados();
                    }
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para deletar");
            }
        }        

        private void dgvAtivos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = Convert.ToInt32(dgvAtivos.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNomeAtivo.Text = dgvAtivos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro : " + ex.Message);
                throw;
            }
        }

        
        
    }
}
