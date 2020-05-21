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
    public partial class FormRelatorio : Form
    {
        string buscarPor = null;
        int id = 0;
        public FormRelatorio(string _buscarPor, int _id)
        {
            InitializeComponent();
            this.buscarPor = _buscarPor;
            this.id = _id;
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            List<Registro> registros = RelatorioDAO.gerarRelatorio(this.buscarPor, id);
            foreach (var item in registros)
            {
                listRelatorio.Items.Add(item.idrelatorio.ToString() + " Descrição: " + item.descricao
                    + " Data: " + item.data.ToString("dd/mm/yyyy") + " hora: " + item.hora.ToString("HH/mm"));
            }
        }
    }
}