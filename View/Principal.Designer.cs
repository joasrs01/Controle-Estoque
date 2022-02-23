
namespace ControleEstoque
{
    partial class Principal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnConsultarProduto = new System.Windows.Forms.Button();
            this.btnCadastraProduto = new System.Windows.Forms.Button();
            this.btnProdutoEstoque = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnProdEst = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(52, 80);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(278, 58);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.TabStop = false;
            this.btnCadastrar.Text = "Cadastrar Estoque";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(53, 143);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(278, 58);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar Estoque";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnConsultarProduto
            // 
            this.btnConsultarProduto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConsultarProduto.Location = new System.Drawing.Point(52, 307);
            this.btnConsultarProduto.Name = "btnConsultarProduto";
            this.btnConsultarProduto.Size = new System.Drawing.Size(278, 58);
            this.btnConsultarProduto.TabIndex = 3;
            this.btnConsultarProduto.Text = "Consultar Produto";
            this.btnConsultarProduto.UseVisualStyleBackColor = true;
            this.btnConsultarProduto.Click += new System.EventHandler(this.btnConsultarProduto_Click);
            // 
            // btnCadastraProduto
            // 
            this.btnCadastraProduto.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastraProduto.Location = new System.Drawing.Point(51, 244);
            this.btnCadastraProduto.Name = "btnCadastraProduto";
            this.btnCadastraProduto.Size = new System.Drawing.Size(278, 58);
            this.btnCadastraProduto.TabIndex = 2;
            this.btnCadastraProduto.TabStop = false;
            this.btnCadastraProduto.Text = "Cadastrar Produto";
            this.btnCadastraProduto.UseVisualStyleBackColor = true;
            this.btnCadastraProduto.Click += new System.EventHandler(this.btnCadastraProduto_Click);
            // 
            // btnProdutoEstoque
            // 
            this.btnProdutoEstoque.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProdutoEstoque.Location = new System.Drawing.Point(467, 144);
            this.btnProdutoEstoque.Name = "btnProdutoEstoque";
            this.btnProdutoEstoque.Size = new System.Drawing.Size(278, 78);
            this.btnProdutoEstoque.TabIndex = 4;
            this.btnProdutoEstoque.TabStop = false;
            this.btnProdutoEstoque.Text = "Consultar produto no estoque";
            this.btnProdutoEstoque.UseVisualStyleBackColor = true;
            this.btnProdutoEstoque.Click += new System.EventHandler(this.btnProdutoEstoque_Click);
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSair.Location = new System.Drawing.Point(467, 307);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(278, 58);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Finalizar Programa";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnProdEst
            // 
            this.btnProdEst.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProdEst.Location = new System.Drawing.Point(467, 64);
            this.btnProdEst.Name = "btnProdEst";
            this.btnProdEst.Size = new System.Drawing.Size(278, 74);
            this.btnProdEst.TabIndex = 6;
            this.btnProdEst.Text = "Incluir produtos no estoque";
            this.btnProdEst.UseVisualStyleBackColor = true;
            this.btnProdEst.Click += new System.EventHandler(this.btnProdEst_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProdEst);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnProdutoEstoque);
            this.Controls.Add(this.btnConsultarProduto);
            this.Controls.Add(this.btnCadastraProduto);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnCadastrar);
            this.Name = "Principal";
            this.Text = "Controle de Estoque";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnConsultarProduto;
        private System.Windows.Forms.Button btnCadastraProduto;
        private System.Windows.Forms.Button btnProdutoEstoque;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnProdEst;
    }
}

