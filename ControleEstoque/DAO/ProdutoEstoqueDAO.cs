using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ControleEstoque.DAO
{
    public class ProdutoEstoqueDAO
    {
        Conexao con = new Conexao();
        SqlCommand comando = new SqlCommand();

        public void Incluir(int codEstoque, int codProduto, float qtd)
        {
            try
            {
                comando.CommandText = $"INSERT INTO ESTOQUE_PRODUTO (COD_ESTOQUE, COD_PRODUTO, QUANTIDADE) VALUES ({codEstoque}, {codProduto}, {qtd.ToString("F2", CultureInfo.InvariantCulture)})";

                comando.Connection = con.Conectar();

                comando.ExecuteNonQuery();

                MessageBox.Show("Registro adicionado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Desconectar();
            }
            catch (Exception e)
            {
                MessageBox.Show($"Não foi possivel concluir a operação \n {e}", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public int VerificaCodCombBox(string desc, int op)
        {
            comando.Connection = con.Conectar();

            if (op == 1)
            {
                comando.CommandText = $"SELECT COD_ESTOQUE FROM ESTOQUE WHERE DESCRICAO = '{desc}'";
            }
            else
            {
                comando.CommandText = $"SELECT COD_PRODUTO FROM PRODUTO WHERE DESCRICAO = '{desc}'";
            }

            SqlDataReader dr = comando.ExecuteReader();

            if (dr.Read())
            {
                con.Desconectar();

                comando.Connection = con.Conectar();

                int cod = (Int32)comando.ExecuteScalar();

                con.Desconectar();

                return cod;
            }

            return 0;
        }


        public void Consultar(DataGridView dgv)
        {
            try
            {
                comando.CommandText = $"SELECT EP.COD_ESTOQUE_PRODUTO, P.DESCRICAO PRODUTO, E.DESCRICAO ESTOQUE,  EP.QUANTIDADE " +
                                       "FROM ESTOQUE_PRODUTO AS EP " +
                                       "INNER JOIN ESTOQUE AS E ON " +
                                       "E.COD_ESTOQUE = EP.COD_ESTOQUE " +
                                       "INNER JOIN PRODUTO AS P ON " +
                                       "P.COD_PRODUTO = EP.COD_PRODUTO";

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

        public void ConsultaCB(ComboBox cb, int op)
        {
            try
            {
                if (op == 1)
                {
                    comando.CommandText = $"SELECT DESCRICAO FROM ESTOQUE";
                }
                else
                {
                    comando.CommandText = $"SELECT DESCRICAO FROM PRODUTO";
                }

                comando.Connection = con.Conectar();

                SqlDataAdapter SqlDA = new SqlDataAdapter(comando);

                DataTable dt = new DataTable();

                SqlDA.Fill(dt);

                con.Desconectar();

                cb.DisplayMember = "DESCRICAO";
                cb.DataSource = dt;
                cb.SelectedIndex = -1;
            }
            catch (SqlException e)
            {
                MessageBox.Show("Anomalia ao consultar os estoques \n" + e, "Anomalia na execução do programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
