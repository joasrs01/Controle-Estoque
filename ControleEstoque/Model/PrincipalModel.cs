using ControleEstoque.DAO;
using System.Windows.Forms;

namespace ControleEstoque.Model
{
    public class PrincipalModel
    {
        ProdutoEstoqueDAO prodEstD = new ProdutoEstoqueDAO();

        public void ConsultaCB(ComboBox cb, int op)
        {
            prodEstD.ConsultaCB(cb, op);
        }

        public void Incluir(ComboBox cbEstoque, ComboBox cbProduto, string sQtd)
        {
            int codEstoque = prodEstD.VerificaCodCombBox(cbEstoque.Text, 1);
            int codProduto = prodEstD.VerificaCodCombBox(cbProduto.Text, 2);

            float qtd = float.Parse(sQtd);

            prodEstD.Incluir(codEstoque, codProduto, qtd);
        }

        public void Consultar(DataGridView dgv)
        {
            prodEstD.Consultar(dgv);
        }
    }
}
