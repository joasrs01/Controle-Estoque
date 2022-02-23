using ControleEstoque.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleEstoque.DAO
{
    class ProdutoDAO
    {
        Conexao con = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void Cadastrar(ProdutoEnt prodE)
        {
            try
            {
                comando.CommandText = $"INSERT INTO PRODUTO (DESCRICAO, DAT_CRIACAO) VALUES ('{prodE.Descricao}',getdate())";

                comando.Connection = con.Conectar();

                comando.ExecuteNonQuery();

                con.Desconectar();

                MessageBox.Show("Registro inserido com sucesso!", "Operação concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Não foi possivel concluir a operação \n {e}", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Consultar(DataGridView dgv)
        {
            try
            {
                comando.CommandText = $"SELECT COD_PRODUTO CÓDIGO,DESCRICAO DESCRIÇÃO, DAT_CRIACAO DATA_CRIAÇÃO FROM PRODUTO";

                comando.Connection = con.Conectar();

                SqlDataAdapter SqlDA = new SqlDataAdapter(comando);

                DataTable dt = new DataTable();

                SqlDA.Fill(dt);

                dgv.DataSource = dt;

                con.Desconectar();

            }
            catch (Exception e)
            {
                MessageBox.Show($"Não foi possivel concluir a operação \n {e}", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Deletar(int cod)
        {
            try
            {
                comando.CommandText = $"DELETE FROM PRODUTO WHERE COD_PRODUTO = {cod}";

                comando.Connection = con.Conectar();

                comando.ExecuteNonQuery();

                con.Desconectar();

                MessageBox.Show("Registro deletado com sucesso!", "Operação concluida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            catch (Exception e)
            {
                MessageBox.Show($"Não foi possivel concluir a operação \n {e}", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
