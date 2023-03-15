using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroConsumoEnergia
{
    public partial class Form1 : Form
    {
        // IList é uma coleção de dados
        private IList<Leitura> leituras = new BindingList<Leitura>();
        //Um objeto que serve como fonte de dados
        //Para controles visuais
        private BindingSource leituraSource = new BindingSource();
        public Form1()
        {
            InitializeComponent();
            leituraSource.DataSource = leituras;
            dgvLeituras.DataSource = leituraSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            RegistraConsulta(txtNrCasa.Text, Convert.ToDouble(txtConsumo.Text));
        }

        private void RegistraConsulta(string casa, double consumo)
        {
            Leitura leitura = new Leitura(casa, consumo);
            if (leituras.Contains(leitura))
            {
                MessageBox.Show("A leitura para " +
                    "esta casa ja foi registrada",
                    "Alerta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            else
            {
                this.leituras.Add(leitura);
                InicializaFormulario();
            }
        }
        private void InicializaFormulario()
        {
            txtNrCasa.Clear();
            txtConsumo.Clear();
            txtNrCasa.Focus();
        }
        private void ProcessarLeituras(DataGridView dgv)
        {
            DataGridViewCell cell = dgvLeituras.Rows[0].Cells[0];
            this.leituras.Add(new Leitura("Total", 0));
            for (int i = 0; i < 3; i++)
            {
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Blue;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.ForeColor = Color.Yellow;
                dgv.Rows[dgvLeituras.Rows.Count - 1].Cells[i].Style.Font = 
                    new Font(cell.InheritedStyle.Font, FontStyle.Bold);
            }

            double totalConsumo = 0, totalDesconto = 0;
            foreach (var l in leituras)
            {
                totalConsumo += l.Consumo;
                totalDesconto += l.Desconto;
            }
            dgv[0, dgv.Rows.Count - 1].Value = "Total";
            dgv[1, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            dgv[2, dgv.Rows.Count - 1].Value = totalConsumo.ToString("N");
            lblTotalConsumoSemDesconto.Text = (totalConsumo - totalDesconto).ToString("N");
        }

        private void btnProcessarDados_Click(object sender, EventArgs e)
        {
            ProcessarLeituras(dgvLeituras);
        }
    }
}
