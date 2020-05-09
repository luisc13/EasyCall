using EasyCall.modelo;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace EasyCall.DAO
{
    class JsonParser
    {
        public static Dados escolherArquivos()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.CheckFileExists = true;
            dialog.Title = "Selecione o arquivo para carregar os dados";
            dialog.CheckPathExists = true;
            dialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            dialog.ShowDialog();

            string path = dialog.FileName;
            string json = "";

            if (File.Exists(path))
            {
                json = File.ReadAllText(path);
            }

            var data = new JavaScriptSerializer().Deserialize<Dados>(json);
            return data;
        }
    }
}
