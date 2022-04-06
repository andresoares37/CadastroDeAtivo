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
    public partial class ExibirAtivos : Form
    {
        public ExibirAtivos()
        {
            InitializeComponent();
        }

        private void ExibirAtivos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ativoDataSet.Ativo' table. You can move, or remove it, as needed.
            this.ativoTableAdapter.Fill(this.ativoDataSet.Ativo);

        }

        private void btn_AtualizarAtivo(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-1MJ9K06\SQLEXPRESS;Initial Catalog=Ativo;Integrated Security=True;Pooling=False");
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;

            comm.CommandText = "UPDATE Ativo SET Nome = @Nome WHERE Nome = @Nome";

            comm.Parameters.AddWithValue("@Nome", dataGridView1.SelectedRows);

            var a = dataGridView1.SelectedRows;

            conn.Open();
            comm.ExecuteNonQuery();
            conn.Close();

            MessageBox.Show("Ativo atualizado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ExibirAtivos frmExibirAtivos = new ExibirAtivos();

            frmExibirAtivos.Update();
        }
    }
}
