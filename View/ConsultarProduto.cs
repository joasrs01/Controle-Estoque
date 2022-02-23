using ControleEstoque.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque.View
{
    public partial class ConsultarProduto : Form
    {
        public ConsultarProduto()
        {
            InitializeComponent();
        }

        Thread t1;
        ProdutoModel prodM = new ProdutoModel();

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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            prodM.Consulta(dgvProduto);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            prodM.Remover(tbCod.Text);
        }
    }
}
