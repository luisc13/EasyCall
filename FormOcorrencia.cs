using EasyCall.DAO;
using EasyCall.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EasyCall
{
    public partial class FormOcorrencia : Form
    {
        private int idDivida;
        private int idDevedor;
        public FormOcorrencia(int id, int devedorID)
        {
            InitializeComponent();
            this.idDivida = id;
            this.idDevedor = devedorID;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String ocr = TxbOcorrencia.Text;
            if (String.IsNullOrEmpty(ocr) ) {
                MessageBox.Show("Você deve fornecer uma ocorrência antes de prosseguir");
            }
            else
            {
                var dao = new OcorrenciaDAO();
                dao.setOcorrencia(ocr, idDivida);

                var registro = "ocorrencia registrada";
                Relatorio.inserirRegistro(idDivida, idDevedor, registro);

                this.Close();
            }
        }

        private void Ocorrencia_Load(object sender, EventArgs e)
        {

        }
    }
}
