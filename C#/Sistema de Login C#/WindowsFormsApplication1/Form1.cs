using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using DevExpress.UserSkins;
using System.Net;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace WindowsFormsApplication1
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {

        XmlDocument Xml = new XmlDocument();
        public Form1()
        {
            
          
            InitializeComponent();
            
        }

        public class InternetConnection
        { 
            private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

            public static bool IsConnectedToInternet()
            {
                bool returnValue = false;
                try
                {
                    int Desc;
                    returnValue = InternetGetConnectedState(out Desc, 0);
                }
                catch
                {
                    returnValue = false;
                }
                return returnValue;
            }
        }
        


        private void Form1_Load(object sender, EventArgs e)
        {
             

        }

        

        private void simpleButton1_Click(object sender, EventArgs e)
        {

                XmlDocument doc1 = new XmlDocument();
                doc1.Load("http://www.bresosprx.com/oi.xml");
                XmlElement root = doc1.DocumentElement;
                XmlNodeList nodes = root.SelectNodes(textEdit1.Text);

                foreach (XmlNode node in nodes)
                {
                    string usuario = node["Name"].InnerText;
                    string senha = node["Senha"].InnerText;

                    if (textEdit2.Text == senha)
                    {
                        MessageBox.Show("Bem vindo " + textEdit1.Text + ", voce foi autenticado com sucesso");
                        Form2 novaform = new Form2();
                        novaform.Show();
                    }
                    else
                    {
                        MessageBox.Show(textEdit1.Text + ", sua senha esta incorreta");
                    }
                }
            
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
             
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://www.bresosprx.com/oi.xml");
            foreach (XmlNode xmlNode in xmlDoc.DocumentElement.ChildNodes[0])
                  
                       MessageBox.Show(xmlNode.Attributes["Name"].Value);
                   

            
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                bool internetConnected = InternetConnection.IsConnectedToInternet();
                MessageBox.Show(String.Format("Internet connection.{0}{1}",
                   Environment.NewLine, internetConnected), "System Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                // Add log if needed
            }
        }
    }
}
