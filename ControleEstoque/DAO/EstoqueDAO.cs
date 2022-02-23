using ControleEstoque.Entity;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleEstoque.DAO
{
    class EstoqueDAO
    {
        Conexao con = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void Cadastrar(EstoqueEnt estE)
        {
            try
            {
                comando.CommandText = $"INSERT INTO ESTOQUE (DESCRICAO, DAT_CRIACAO) VALUES ('{estE.Descricao}',getdate())";

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
                comando.CommandText = $"SELECT COD_ESTOQUE CODIGO,DESCRICAO DESCRIÇÃO, DAT_CRIACAO DATA_CRIAÇÃO FROM ESTOQUE";

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
                comando.CommandText = $"DELETE FROM ESTOQUE WHERE COD_ESTOQUE = {cod}";

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
