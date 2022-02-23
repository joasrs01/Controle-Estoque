
namespace ControleEstoque.View
{
    partial class CadastrarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.tbDescProduto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(457, 207);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(199, 36);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetornar.Location = new System.Drawing.Point(596, 406);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(199, 36);
            this.btnRetornar.TabIndex = 7;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // tbDescProduto
            // 
            this.tbDescProduto.Location = new System.Drawing.Point(413, 178);
            this.tbDescProduto.Name = "tbDescProduto";
            this.tbDescProduto.Size = new System.Drawing.Size(243, 23);
            this.tbDescProduto.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(160, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Digite o nome do produto:";
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.tbDescProduto);
            this.Controls.Add(this.label1);
            this.Name = "CadastrarProduto";
            this.Text = "Cadastrar Produto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.TextBox tbDescProduto;
        private System.Windows.Forms.Label label1;
    }
}