using ControleEstoque.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque.View
{
    public partial class ConsultarEstoque : Form
    {
        public ConsultarEstoque()
        {
            InitializeComponent();
        }

        Thread t1;
        EstoqueModel estM = new EstoqueModel();

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
            estM.Consulta(dgvEstoque);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            estM.Remover(tbCod.Text);
        }
    }
}
