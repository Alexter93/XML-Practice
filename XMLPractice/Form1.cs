using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLPractice
{
    public partial class Form1 : Form
    {
        private string xmlFileName = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        // allows the user to select an XML file
        private void btnBrowseXML_Click(object sender, EventArgs e)
        {
            OpenFileDialog getXMLFile = new OpenFileDialog();
            getXMLFile.Filter = "XML files (*.xml)|*.xml";
            if (getXMLFile.ShowDialog() == DialogResult.OK)
            {
                xmlFileName = getXMLFile.FileName;
                txtXMLFile.Text = xmlFileName;
            }   
        }

        // displays the content of the XML file in the textbox below 
        private void btnViewXMLFile_Click(object sender, EventArgs e)
        {
            bool hadText = false;
            bool endElementTwice = false;
            int tabs = 0;
            XmlTextReader xmlReader;

            if (txtXMLFile.Text == string.Empty)
                MessageBox.Show("Please select a XML file.");
            else
            {
                xmlReader = new XmlTextReader(xmlFileName);

                txtFileContent.Text = string.Empty;

                while(xmlReader.Read())
                {
                    switch (xmlReader.NodeType)
                    {
                        case XmlNodeType.Element:
                        {
                            if (txtFileContent.Text == string.Empty)
                                txtFileContent.Text += "<" + xmlReader.Name + ">";
                            else
                                txtFileContent.Text += "\r\n" + getTabs(tabs) + "<" + xmlReader.Name + ">";
                            tabs++;
                            break;
                        }
                        case XmlNodeType.Text:
                        {
                            txtFileContent.Text += xmlReader.Value;
                            hadText = true;
                            break;
                        }
                        case XmlNodeType.EndElement:
                        {
                            if (hadText)
                            {
                                txtFileContent.Text += "</" + xmlReader.Name + ">";
                                endElementTwice = true;
                            }
                            else
                            {
                                if (endElementTwice)
                                {
                                    tabs--;
                                    endElementTwice = false;
                                }
                                txtFileContent.Text += "\r\n" + getTabs(tabs) + "</" + xmlReader.Name + ">";
                            }
                                    
                            hadText = false;

                            tabs--;
                            break;
                        }
                    }
                    //txtFileContent.Text += "  (" + tabs + ")";
                }
                //MessageBox.Show("Ding!");
            }
        }

        private string getTabs (int t)
        {
            string theTabs = string.Empty;
            for (int i = 0; i < t; i++)
                theTabs += "    ";

            return theTabs;
        }
    }
}
