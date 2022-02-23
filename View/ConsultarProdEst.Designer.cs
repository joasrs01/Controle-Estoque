
namespace ControleEstoque.View
{
    partial class ConsultarProdEst
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProdEst = new System.Windows.Forms.DataGridView();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdEst)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRetornar
            // 
            this.btnRetornar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnRetornar.Location = new System.Drawing.Point(589, 458);
            this.btnRetornar.Name = "btnRetornar";
            this.btnRetornar.Size = new System.Drawing.Size(199, 36);
            this.btnRetornar.TabIndex = 8;
            this.btnRetornar.Text = "Retornar";
            this.btnRetornar.UseVisualStyleBackColor = true;
            this.btnRetornar.Click += new System.EventHandler(this.btnRetornar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(169, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Localizar registros:";
            // 
            // dgvProdEst
            // 
            this.dgvProdEst.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvProdEst.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdEst.Location = new System.Drawing.Point(169, 130);
            this.dgvProdEst.Name = "dgvProdEst";
            this.dgvProdEst.RowTemplate.Height = 25;
            this.dgvProdEst.Size = new System.Drawing.Size(461, 157);
            this.dgvProdEst.TabIndex = 10;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConsultar.Location = new System.Drawing.Point(443, 293);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(187, 36);
            this.btnConsultar.TabIndex = 11;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ConsultarProdEst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 506);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.dgvProdEst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetornar);
            this.Name = "ConsultarProdEst";
            this.Text = "Consultar Totais";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdEst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRetornar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProdEst;
        private System.Windows.Forms.Button btnConsultar;
    }
}