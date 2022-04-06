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
    public partial class fmrCadastroAtivo : Form
    {
        public fmrCadastroAtivo()
        {
            InitializeComponent();
        }

        private void btn_InserirAtivo(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeAtivo.Text == string.Empty)
                {
                    MessageBox.Show("Campo Nome do Ativo deve estar preenchido", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {


                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJ9K06\SQLEXPRESS;Initial Catalog=Ativo;Integrated Security=True;Pooling=False");
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;

                    comm.Parameters.AddWithValue("@Nome", txtNomeAtivo.Text);

                    comm.CommandText = "SELECT Nome FROM Ativo WHERE Nome = @Nome";

                    conn.Open();
                    comm.ExecuteNonQuery();

                    SqlDataReader dr = comm.ExecuteReader();

                    if (dr.HasRows)
                    {
                        MessageBox.Show("Ativo já existente, cadastre um novo", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        conn.Close();
                        conn.Open();
                        comm.CommandText = "INSERT INTO Ativo (Nome) VALUES (@Nome)";
                        comm.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Cadastrado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar", "Mensagem", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btn_Excluir(object sender, EventArgs e)
        {
            try
            {
                if (txtNomeAtivo.Text == string.Empty)
                {
                    MessageBox.Show("Campo Ativo Vazio", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJ9K06\SQLEXPRESS;Initial Catalog=Ativo;Integrated Security=True;Pooling=False");
                    SqlCommand comm = new SqlCommand();
                    comm.Connection = conn;

                    comm.Parameters.AddWithValue("@Nome", txtNomeAtivo.Text);

                    comm.CommandText = "SELECT Nome FROM Ativo WHERE Nome = @Nome";

                    conn.Open();
                    comm.ExecuteNonQuery();
                    SqlDataReader dr = comm.ExecuteReader();

                    if (!dr.HasRows)
                    {
                        MessageBox.Show("Ativo não encontrado", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    else
                    {
                        conn.Close();

                        conn.Open();
                        comm.CommandText = "DELETE FROM Ativo WHERE Nome = @Nome";
                        comm.ExecuteNonQuery();
                        conn.Close();

                        MessageBox.Show("Ativo excluido com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_AtualizarAtivo(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJ9K06\SQLEXPRESS;Initial Catalog=Ativo;Integrated Security=True;Pooling=False");
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            comm.CommandText = "UPDATE Ativo SET Nome = @Nome WHERE Nome = @Nome";

            comm.Parameters.AddWithValue("@Nome", txtNomeAtivo.Text);

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Ativo atualizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_ExibirAtivos(object sender, EventArgs e)
        {
            try
            {
                ExibirAtivos frmExibirAtivos = new ExibirAtivos();
                frmExibirAtivos.Show();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


    }
}
