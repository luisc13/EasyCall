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

namespace EasyCall.Relatorio
{
    public partial class FormOptions : Form
    {
        List<Devedor> listaDev = null;
        List<Divida> listDiv = null;
        public FormOptions()
        {
            InitializeComponent();
            cbBuscarPor.Items.Add("Devedor");
            cbBuscarPor.Items.Add("Divida");
        }

        private void cbBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLista();
        }

        private void setLista()
        {
            var item = cbBuscarPor.Text;
            switch (item.ToUpper())
            {
                case "DEVEDOR":
                    listOptions.Items.Clear();
                    listaDev = new DevedorDAO().listDevedor();
                    foreach (var dev in listaDev)
                    {
                        listOptions.Items.Add("Nome: " + dev.nome + " CPF: " + dev.cpf);
                    }
                    break;
                case "DIVIDA":
                    listOptions.Items.Clear();
                    listDiv = new DividaDAO().listDivida();
                    foreach (var div in listDiv)
                    {
                        listOptions.Items.Add("Valor: " + div.valor + " data de vencimento: " + div.dataVencimento.ToString());
                    }
                    break;
            }
        }

        private void listOptions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //new FormRelatorio(cbBuscarPor.Text, ).Show();
            int index = this.listOptions.IndexFromPoint(e.Location);
            if (index != ListBox.NoMatches)
            {
                switch (cbBuscarPor.Text.ToUpper())
                {
                    case "DIVIDA":
                        new FormRelatorio("DIVIDA", listDiv[index].idDivida).Show();
                        break;
                    case "DEVEDOR":
                        new FormRelatorio("DEVEDOR", listaDev[index].iddevedor).Show();
                        break;
                }
            }

        }
    }
}
