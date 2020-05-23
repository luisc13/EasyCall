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

namespace EasyCall.CarregarDados
{
    public partial class FormEscolherEmpresa : Form
    {
        List<Empresa> empresas = null;

        public FormEscolherEmpresa()
        {
            InitializeComponent();
        }

        private void FormEscolherEmpresa_Load(object sender, EventArgs e)
        {
            this.empresas = new EmpresaDAO().listEmpresas();
            foreach (var emp in empresas)
            {
                lbEmpresas.Items.Clear();
                lbEmpresas.Items.Add(emp.nome + " - " + emp.cnpj);
            }
        }

        private async void lbEmpresas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.lbEmpresas.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                try
                {
                    await Dados.carregarDados(empresas[index].nome);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);12
                }
            }
        }
    }
}
