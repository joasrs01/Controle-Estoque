using ControleEstoque.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque.View
{
    public partial class CadastrarProdEst : Form
    {
        PrincipalModel proEstM = new PrincipalModel();

        public CadastrarProdEst()
        {
            InitializeComponent();
            proEstM.ConsultaCB(cbEstoques, 1);
            proEstM.ConsultaCB(cbPodutos, 2);
        }

        Thread t1;

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            proEstM.Incluir(cbEstoques, cbPodutos, tbQtd.Text);
        }

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
