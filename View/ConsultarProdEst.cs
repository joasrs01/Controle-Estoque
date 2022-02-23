using ControleEstoque.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque.View
{
    public partial class ConsultarProdEst : Form
    {
        PrincipalModel prinM = new PrincipalModel();

        public ConsultarProdEst()
        {
            InitializeComponent();
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            prinM.Consultar(dgvProdEst);
        }
    }
}
