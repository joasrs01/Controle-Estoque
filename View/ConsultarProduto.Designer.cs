
namespace ControleEstoque.View
{
    partial class ConsultarProduto
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
            this.btnRetornar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetornar.Location = new System.Drawing.Point(589, 402);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(199, 36);
            this.btnRetornar.TabIndex = 9;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluir.Location = new System.Drawing.Point(490, 268);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(199, 36);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(46, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Digite o numero do registro a ser excluido:";
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(244, 281);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(240, 23);
            this.tbCod.TabIndex = 16;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(490, 90);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(199, 36);
            this.btnConsultar.TabIndex = 15;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvProduto
            // 
            this.dgvProduto.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(139, 90);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.RowTemplate.Height = 25;
            this.dgvProduto.Size = new System.Drawing.Size(345, 122);
            this.dgvProduto.TabIndex = 19;
            // 
            // ConsultarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProduto);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnRetornar);
            this.Name = "ConsultarProduto";
            this.Text = "Consultar Produto";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvProduto;
    }
}