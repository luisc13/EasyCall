using EasyCall.DAO;
using EasyCall.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall
{
    public partial class FormCobranca : Form
    {
        private int seg = 0;
        private int tempoLigacao = 0;

        Devedor devedor = new Devedor();
        DevedorDAO dao = new DevedorDAO();

        Divida d = new Divida();
        DividaDAO ddao = new DividaDAO();
        public FormCobranca()
        {
            InitializeComponent();
        }

        private void tParaLigacao_Tick(object sender, EventArgs e)
        {
            this.seg += 1;
            if (seg == 10 && tParaLigacao.Enabled == true)
            {
                fazerligacao();
            }
        }

        public void fazerligacao()
        {
            MessageBox.Show("iniciando ligação...");
            this.seg = 0;
            tParaLigacao.Enabled = false;
            onLigacao.Enabled = true;
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            var registro = "chamada efetuada com duração de " + this.tempoLigacao / 60 + " minutos";
            MessageBox.Show("A ligação durou: " + this.tempoLigacao);
            RelatorioDAO.inserirRegistro(this.d.idDivida, this.devedor.iddevedor, registro);
            this.onLigacao.Enabled = false;
            this.tempoLigacao = 0;


            limparDados();
            mostrarDados();
            this.tParaLigacao.Enabled = true;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrarDados();
            tParaLigacao.Enabled = true;
         
        }

        private void limparDados()
        {
            txbDevedor.Text = null;
            txbEmail.Text = null;
            txbCpf.Text = null;
            txbTelefone.Text = null;
            txbContrato.Text = null;
            txbValor.Text = null;
            txbDias.Text = null;
            txbJurosdia.Text = null;
            txbData.Text = null;
            txbCondicao.Text = null;
        }
        private void listarDevedor()
        {

        }
        private void mostrarDados()
        {
            this.devedor = this.dao.getDevedor();

            this.d = this.ddao.getDivida(devedor.iddevedor);

            var hoje = DateTime.Now;
            int diasAtraso = (hoje.Date - d.dataVencimento.Date).Days;

            txbDevedor.Text = devedor.nome;
            txbEmail.Text = devedor.email;
            txbCpf.Text = devedor.cpf;
            txbTelefone.Text = devedor.telefone;

            txbContrato.Text = d.idDivida.ToString();
            txbValor.Text = Utilitarios.calculoJuros(d.valor, d.dataVencimento).ToString("c");
            txbDias.Text = diasAtraso.ToString();
            txbJurosdia.Text = "1%";
            txbData.Text = d.dataVencimento.ToString("dd/MM/yyyy");
            txbCondicao.Text = d.status;
        }

        private void onLigacao_Tick(object sender, EventArgs e)
        {
            this.tempoLigacao += 1;
        }

        private async void btnEmail_Click(object sender, EventArgs e)
        {
            Email mail = new Email();
            await mail.enviarEmail(devedor.email, Utilitarios.calculoJuros(d.valor, d.dataVencimento));

            var registro = "Email enviado com o valor a ser pago";
            RelatorioDAO.inserirRegistro(d.idDivida, devedor.iddevedor, registro);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var ocorrencias = new FormOcorrencia(d.idDivida, devedor.iddevedor);
            ocorrencias.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
