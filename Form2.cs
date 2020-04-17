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
    public partial class Form2 : Form
    {
        private int seg = 0;
        private object dao;

        public Form2()
        {
            InitializeComponent();
            tParaLigacao.Enabled = true;
        }

        private void tParaLigacao_Tick(object sender, EventArgs e)
        {
            this.seg += 1;
            if (seg == 10)
            {
                fazerligacao();
            }
        }

        public void fazerligacao()
        {
            MessageBox.Show("iniciando ligação...");
            this.seg = 0;
            tParaLigacao.Enabled = false;

            // ativar timer da ligação em si
            // buscar dados no banco
            // mostrar na tela os dados
            // depois que o tempo acabar apagar os dados da tela
            // inicicar timer para ligar novamente
        }

        private void btnDesligar_Click(object sender, EventArgs e)
        {
            var ocorrencias = new Ocorrencia();
            ocorrencias.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public double calculoJuros(Double valorParcela, DateTime dataVencimento)
        {
            Double valorJurosTotal;
            var hoje = DateTime.Now;
            int diasAtraso = 0;
            if (hoje > dataVencimento)
            {
                diasAtraso = (hoje.Date - dataVencimento.Date).Days;
                valorJurosTotal = ((valorParcela * 1) / 100 ) * diasAtraso;
                valorParcela = valorParcela + valorJurosTotal;                
            }
            return valorParcela;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Devedor devedor = new Devedor();
            DevedorDAO dao = new DevedorDAO();
            devedor = dao.getDevedor();

            Divida d = new Divida();
            DividaDAO ddao = new DividaDAO();
            d = ddao.getDivida(devedor.iddevedor);

            var hoje = DateTime.Now;
            int diasAtraso = diasAtraso = (hoje.Date - d.dataVencimento.Date).Days;
           
    

            txbDevedor.Text = devedor.nome;
            txbEmail.Text = devedor.email;
            txbCpf.Text = devedor.cpf;
            txbTelefone.Text = devedor.telefone;

            txbContrato.Text = d.idDivida.ToString();
            txbValor.Text = d.valor.ToString();
            txbDias.Text = diasAtraso.ToString();
            txbJurosdia.Text = "1%";
            txbParcelas.Text = 
            txbData.Text = d.dataVencimento.ToString("dd/MM/yyyy");
            txbCondicao.Text = d.status;
        }
    }
}
