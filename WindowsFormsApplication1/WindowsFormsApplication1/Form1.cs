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
            sourceText.Text = "";
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
            HtmlAgilityPack.HtmlNodeCollection nodeCol2 = null;
            try
            {
                nodeCol = mydoc.DocumentNode.SelectNodes(str+"/h3/a[@href]" +"|"+ str+"/h1/a[@href]");
                nodeCol2 = mydoc.DocumentNode.SelectNodes(str + "/h3" + "|" + str + "/h1");
            }
            catch (System.Xml.XPath.XPathException)
            {
                MessageBox.Show("XPathException!");
            }
            int cnt = 0;
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol2)
                {
                    showFriendList.Text += node.InnerText + "   ";
                    ++cnt;
                }
                showFriendList.Text += cnt.ToString();
                cnt = 0;
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    parsedCode.Text += node.GetAttributeValue("href","").ToString() + "   ";
                    ++cnt;
                }
                parsedCode.Text += cnt.ToString();
            }
            catch (NullReferenceException)
            {
                parsedCode.Text = "nothing found!";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            parsedCode.Text = "";
            parseTextFunc("//body/div/div/div/div/div/div/div/div/div");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sourceText.SelectAll();
            sourceText.Copy();
        }
    }
}
