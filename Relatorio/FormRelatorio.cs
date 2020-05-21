using EasyCall.DAO;
using EasyCall.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowNewFolderButton = true;
            folder.Description = "Selecione a pasta para salvar o arquivo";
            folder.ShowDialog();
            //MessageBox.Show(listRelatorio.Items[0].ToString());

            string path = folder.SelectedPath.Trim();

            StreamWriter sw = new StreamWriter(path + @"\Relatorio-EasyCall.txt");
            foreach (var item in listRelatorio.Items)
            {
                sw.WriteLine(item.ToString());
            }
            sw.Dispose();
        }
    }
}