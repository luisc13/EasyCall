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
    public partial class Ocorrencia : Form
    {
        public Ocorrencia()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            String ocr = TxbOcorrencia.Text;
            
            var dao = new DividaDAO();
            dao.setOcorrencia(ocr, 1);
            
            this.Close();
        }
    }
}
