using ControleEstoque.View;
using System;
using System.Threading;
using System.Windows.Forms;

namespace ControleEstoque
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        Thread t1;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaCadEstoque);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaConEstoque);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnCadastraProduto_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaCadProduto);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnConsultarProduto_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaConProduto);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnProdutoEstoque_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaProdEstoque);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnProdEst_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbreJanelaInProdEstoque);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Você deseja sair do programa?","Finalizar Programa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }         
        }

        //Abertura de Janelas
        public void AbreJanelaCadEstoque()
        {
            Application.Run(new CadastrarEstoque());
        }

        public void AbreJanelaConEstoque()
        {
            Application.Run(new ConsultarEstoque());
        }

        public void AbreJanelaCadProduto()
        {
            Application.Run(new CadastrarProduto());
        }

        public void AbreJanelaConProduto()
        {
            Application.Run(new ConsultarProduto());
        }

        public void AbreJanelaProdEstoque()
        {
            Application.Run(new ConsultarProdEst());
        }

        public void AbreJanelaInProdEstoque()
        {
            Application.Run(new CadastrarProdEst());
        }
    }
}
