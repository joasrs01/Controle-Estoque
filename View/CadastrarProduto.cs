using ControleEstoque.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque.View
{
    public partial class CadastrarProduto : Form
    {
        public CadastrarProduto()
        {
            InitializeComponent();
        }

        ProdutoModel prodM = new ProdutoModel();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            prodM.Cadastrar(tbDescProduto.Text);
        }

        Thread t1;

        private void btnRetornar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaPrincipal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void AbreJanelaPrincipal()
        {
            Application.Run(new Principal());
        }
    }
}
