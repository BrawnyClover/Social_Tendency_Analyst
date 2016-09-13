using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using CefSharp;
using CefSharp.WinForms;
using Facebook;
using HtmlAgilityPack;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void navigator_Click(object sender, EventArgs e)
        {
            
            Form2 form = new Form2(urlString.Text,this);
            form.Owner = this;
            form.Show();
        }
        void parseTextFunc(string str)
        {
            string parseStr = sourceText.Text;
            HtmlAgilityPack.HtmlDocument mydoc = new HtmlAgilityPack.HtmlDocument();
            mydoc.LoadHtml(parseStr);
            HtmlAgilityPack.HtmlNodeCollection nodeCol = null;
            try
            {
                nodeCol = mydoc.DocumentNode.SelectNodes(str);
            }
            catch (System.Xml.XPath.XPathException)
            {
                MessageBox.Show("XPathException!");
            }
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    parsedCode.Text += node.InnerHtml + "\n";
                }
            }
            catch (NullReferenceException)
            {
                parsedCode.Text = "nothing found!";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parsedCode.Text = "";
            parseTextFunc("//body/div/div/div/div/div/div/div/div/div/h3");
            parseTextFunc("//body/div/div/div/div/div/div/div/div/div/h1");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sourceText.SelectAll();
            sourceText.Copy();
        }
    }
}
