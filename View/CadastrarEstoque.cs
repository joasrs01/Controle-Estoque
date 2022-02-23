using ControleEstoque.Model;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque.View
{

    public partial class CadastrarEstoque : Form
    {
        public CadastrarEstoque()
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

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            estM.Cadastrar(tbDescEstoque.Text);
        }

        public void AbreJanelaPrincipal()
        {
            Application.Run(new Principal());
        }
    }
}
