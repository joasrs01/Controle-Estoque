using ControleEstoque.DAO;
using ControleEstoque.Entity;
using System;
using System.Windows.Forms;

namespace ControleEstoque.Model
{
    public class EstoqueModel
    {
        EstoqueEnt estE = new EstoqueEnt();
        EstoqueDAO estD = new EstoqueDAO();

        public void Cadastrar(string desc)
        {
            estE.Descricao = desc;

            estD.Cadastrar(estE);
        }

        public void Consulta(DataGridView dtg)
        {
            estD.Consultar(dtg);
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
                estD.Deletar(codI);
            }
            catch (Exception e)
            {
                MessageBox.Show($"Numero inválido", "Anomalia ao concluir a operação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
