using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PruebaConsultaGet
{
    public partial class FrmPrincipal : Form
    {
        string url;
        string cedula;
        string urlMasCedula;
        WebRequest wrGETURL;
        Stream objStream;


        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnConsultar_Click(object sender, EventArgs e)
        {
            TxtResultado.Clear();
            url = TxtUrl.Text;
            cedula = TxtCedula.Text;
            urlMasCedula = url + cedula;

            wrGETURL = WebRequest.Create(urlMasCedula);
            objStream = wrGETURL.GetResponse().GetResponseStream();

            StreamReader objReader = new StreamReader(objStream);

            string sLine = "";
            int i = 0;

            while (sLine != null)
            {
                i++;
                sLine = objReader.ReadLine();
                if (sLine != null)
                //TxtResultado.AppendText($"{i}:{sLine}");
                TxtResultado.AppendText($"{sLine}");
            }

            string resultado = TxtResultado.Text;


            //JavaScriptSerializer js = new JavaScriptSerializer();
            //dynamic blogObject = js.Deserialize<dynamic>(resultado);
            //string name = blogObject["Name"];
            //string description = blogObject["Description"];


            //dynamic jsonObj = JsonConvert.DeserializeObject(resultado);
            //var numero = jsonObj[1]["numero"].ToString();

            ObjetoJson objJson = JsonConvert.DeserializeObject<ObjetoJson>(resultado);
            string name = objJson.Nombre;


            //var personaIntermedioObject = JObject.Parse(resultado);
            //System.Collections.Generic.Dictionary<string, object> dic = new System.Collections.Generic.Dictionary<string, object>();
            ////foreach (JProperty obj in personaIntermedioObject.Properties())
            //    foreach (JProperty obj in personaIntermedioObject.Properties())
            //    {
            //    dic.Add(obj.Name, obj.Value);
            //    // O bien, imprimirlos en consola:
            //    Console.WriteLine("Clave: {0} | Valor: {1}", obj.Name, obj.Value.ToString());
            //}


        }
    }
}
