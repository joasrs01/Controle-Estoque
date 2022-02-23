using ControleEstoque.DAO;
using ControleEstoque.Entity;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Model
{
    class ProdutoModel
    {
        ProdutoEnt prodE = new ProdutoEnt();
        ProdutoDAO prodD = new ProdutoDAO();

        public void Cadastrar(string desc)
        {
            prodE.Descricao = desc;
            prodD.Cadastrar(prodE);

        }

        public void Consulta(DataGridView dtg)
        {
            prodD.Consultar(dtg);
        }

        public void Remover(string cod)
        {
            if (cod.Length <= 0)
            {
                MessageBox.Show($"Numero inválido", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            try
            {
                int codI = int.Parse(cod);
                prodD.Deletar(codI);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Numero inválido", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
