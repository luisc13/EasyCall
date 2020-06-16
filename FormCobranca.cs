using EasyCall.DAO;
using EasyCall.DAO.SendEmail;
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
        Empresa empresa = new Empresa();

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
            // faz um registro para ser gerado relatorio depois
            var registro = "chamada efetuada com duração de " + this.tempoLigacao / 60 + " minutos";
            //MessageBox.Show("A ligação durou: " + this.tempoLigacao);
            RelatorioDAO.inserirRegistro(this.d.idDivida, this.devedor.iddevedor, registro);
            this.onLigacao.Enabled = false;
            this.tempoLigacao = 0;

            //insere a data e hora atual na tabela divida para gerenciamento de ordem de ligações
            ddao.setUl(d.idDivida, DateTime.Now);

            limparDados();
            mostrarDados();
            listarDevedor();
            this.tParaLigacao.Enabled = true; // começa timer para proxima ligação
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            mostrarDados();
            listarDevedor();
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
            var lista = dao.listDevedor();

            DataTable dt = new DataTable();
            dt.Columns.Add("Cpf", typeof(string));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Email", typeof(string));
            dt.Columns.Add("Telefone", typeof(string));

            foreach (var item in lista)
            {
                dt.Rows.Add(item.cpf, item.nome, item.email,item.telefone);
            }
            
            gdvDevedor.DataSource = dt;
        }
        private void mostrarDados()
        {
            this.devedor = this.dao.getDevedor();

            this.d = this.ddao.getDivida(devedor.iddevedor);

            var hoje = DateTime.Now;
            int diasAtraso = (hoje.Date - d.dataVencimento.Date).Days;
            empresa = new EmpresaDAO().getEmpresa(d.idEmpresa);
            

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
            txbEmpresa.Text = empresa.nome;
            txbValorInicial.Text = d.valor.ToString("c");

            //lista de ultimas ocorrencias
            var listaOcr = new OcorrenciaDAO().listLastOcorrencias(d.idDivida);
            foreach (var item in listaOcr)
            {
                lbOcr.Items.Add(item.conteudo + "data: " + item.dataocorrencia.ToString());
                lbOcr.Items.Add("");
            }
        }

        private void onLigacao_Tick(object sender, EventArgs e)
        {
            this.tempoLigacao += 1;
        }

        private void btnBoleto_Click(object sender, EventArgs e)
        {
            new FormParcelas(this.d, this.devedor).Show();
        }

        private void btnOcr_Click(object sender, EventArgs e)
        {
            var ocorrencias = new FormOcorrencia(d.idDivida, devedor.iddevedor);
            ocorrencias.Show();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }
    }
}
