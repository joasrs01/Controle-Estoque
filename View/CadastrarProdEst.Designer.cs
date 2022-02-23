
namespace ControleEstoque.View
{
    partial class CadastrarProdEst
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbQtd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRetornar = new System.Windows.Forms.Button();
            this.cbEstoques = new System.Windows.Forms.ComboBox();
            this.cbPodutos = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(211, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Estoque:";
            // 
            // btnIncluir
            // 
            this.btnIncluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnIncluir.Location = new System.Drawing.Point(547, 171);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(199, 36);
            this.btnIncluir.TabIndex = 26;
            this.btnIncluir.Text = "Incluir";
            this.btnIncluir.UseVisualStyleBackColor = true;
            this.btnIncluir.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(174, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 25);
            this.label4.TabIndex = 24;
            this.label4.Text = "Quantidade: ";
            // 
            // tbQtd
            // 
            this.tbQtd.Location = new System.Drawing.Point(301, 228);
            this.tbQtd.Name = "tbQtd";
            this.tbQtd.Size = new System.Drawing.Size(240, 23);
            this.tbQtd.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(211, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(115, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(249, 25);
            this.label2.TabIndex = 21;
            this.label2.Text = "Incluir produtos no estoque:";
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetornar.Location = new System.Drawing.Point(589, 402);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(199, 36);
            this.btnRetornar.TabIndex = 29;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // cbEstoques
            // 
            this.cbEstoques.FormattingEnabled = true;
            this.cbEstoques.Location = new System.Drawing.Point(301, 199);
            this.cbEstoques.Name = "cbEstoques";
            this.cbEstoques.Size = new System.Drawing.Size(240, 23);
            this.cbEstoques.TabIndex = 28;
            this.cbEstoques.Text = "  ";
            // 
            // cbPodutos
            // 
            this.cbPodutos.FormattingEnabled = true;
            this.cbPodutos.Location = new System.Drawing.Point(301, 171);
            this.cbPodutos.Name = "cbPodutos";
            this.cbPodutos.Size = new System.Drawing.Size(240, 23);
            this.cbPodutos.TabIndex = 25;
            this.cbPodutos.Text = "  ";
            // 
            // CadastrarProdEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRetornar);
            this.Controls.Add(this.cbEstoques);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.cbPodutos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "CadastrarProdEst";
            this.Text = "Cadastrar Produto ao Estoque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbQtd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.ComboBox cbEstoques;
        private System.Windows.Forms.ComboBox cbPodutos;
    }
}