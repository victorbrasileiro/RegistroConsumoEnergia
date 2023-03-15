
namespace RegistroConsumoEnergia
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNrCasa = new System.Windows.Forms.Label();
            this.txtNrCasa = new System.Windows.Forms.TextBox();
            this.lblConsumo = new System.Windows.Forms.Label();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvLeituras = new System.Windows.Forms.DataGridView();
            this.btnProcessarDados = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalConsumoSemDesconto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNrCasa
            // 
            this.lblNrCasa.AutoSize = true;
            this.lblNrCasa.Location = new System.Drawing.Point(24, 29);
            this.lblNrCasa.Name = "lblNrCasa";
            this.lblNrCasa.Size = new System.Drawing.Size(59, 17);
            this.lblNrCasa.TabIndex = 0;
            this.lblNrCasa.Text = "Nr.Casa";
            // 
            // txtNrCasa
            // 
            this.txtNrCasa.Location = new System.Drawing.Point(89, 24);
            this.txtNrCasa.Name = "txtNrCasa";
            this.txtNrCasa.Size = new System.Drawing.Size(100, 22);
            this.txtNrCasa.TabIndex = 1;
            // 
            // lblConsumo
            // 
            this.lblConsumo.AutoSize = true;
            this.lblConsumo.Location = new System.Drawing.Point(211, 29);
            this.lblConsumo.Name = "lblConsumo";
            this.lblConsumo.Size = new System.Drawing.Size(67, 17);
            this.lblConsumo.TabIndex = 2;
            this.lblConsumo.Text = "Consumo";
            // 
            // txtConsumo
            // 
            this.txtConsumo.Location = new System.Drawing.Point(284, 24);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(156, 22);
            this.txtConsumo.TabIndex = 3;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(467, 24);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvLeituras
            // 
            this.dgvLeituras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeituras.Location = new System.Drawing.Point(27, 87);
            this.dgvLeituras.Name = "dgvLeituras";
            this.dgvLeituras.RowHeadersWidth = 51;
            this.dgvLeituras.RowTemplate.Height = 24;
            this.dgvLeituras.Size = new System.Drawing.Size(515, 267);
            this.dgvLeituras.TabIndex = 5;
            // 
            // btnProcessarDados
            // 
            this.btnProcessarDados.Location = new System.Drawing.Point(27, 380);
            this.btnProcessarDados.Name = "btnProcessarDados";
            this.btnProcessarDados.Size = new System.Drawing.Size(137, 34);
            this.btnProcessarDados.TabIndex = 6;
            this.btnProcessarDados.Text = "Processar Dados";
            this.btnProcessarDados.UseVisualStyleBackColor = true;
            this.btnProcessarDados.Click += new System.EventHandler(this.btnProcessarDados_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(281, 389);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(195, 17);
            this.lblTotal.TabIndex = 7;
            this.lblTotal.Text = "Total Consumo com desconto";
            // 
            // lblTotalConsumoSemDesconto
            // 
            this.lblTotalConsumoSemDesconto.AutoSize = true;
            this.lblTotalConsumoSemDesconto.Location = new System.Drawing.Point(514, 389);
            this.lblTotalConsumoSemDesconto.Name = "lblTotalConsumoSemDesconto";
            this.lblTotalConsumoSemDesconto.Size = new System.Drawing.Size(28, 17);
            this.lblTotalConsumoSemDesconto.TabIndex = 8;
            this.lblTotalConsumoSemDesconto.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 433);
            this.Controls.Add(this.lblTotalConsumoSemDesconto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnProcessarDados);
            this.Controls.Add(this.dgvLeituras);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.lblConsumo);
            this.Controls.Add(this.txtNrCasa);
            this.Controls.Add(this.lblNrCasa);
            this.Name = "Form1";
            this.Text = "Registro de Consumo de Energia";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeituras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNrCasa;
        private System.Windows.Forms.TextBox txtNrCasa;
        private System.Windows.Forms.Label lblConsumo;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvLeituras;
        private System.Windows.Forms.Button btnProcessarDados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalConsumoSemDesconto;
    }
}

