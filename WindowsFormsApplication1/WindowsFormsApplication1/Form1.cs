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
    struct personalData
    {
        public string name;
        public string href;
        
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navigator_Click(object sender, EventArgs e)
        {
            sourceText.Text = "";
            Form2 form = new Form2(urlString.Text, this);
            form.Owner = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handling hand = new handling();
            parsedCode.Text = "";
            hand.parseTextFunc("//body/div/div/div/div/div/div/div/div/div");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sourceText.SelectAll();
            sourceText.Copy();
        }
    }
    public class handling
    {
        Form1 setForm = new Form1();
        int cnt = 0;
        List<personalData> dataList = new List<personalData>();

        public void parseTextFunc(string str)
        {
            string parseStr = setForm.sourceText.Text;
            HtmlAgilityPack.HtmlDocument mydoc = new HtmlAgilityPack.HtmlDocument();
            mydoc.LoadHtml(parseStr);
            HtmlAgilityPack.HtmlNodeCollection nodeCol = null;
            HtmlAgilityPack.HtmlNodeCollection nodeCol2 = null;
            try
            {
                nodeCol = mydoc.DocumentNode.SelectNodes(str + "/h3/a[@href]" + "|" + str + "/h1/a[@href]");
                nodeCol2 = mydoc.DocumentNode.SelectNodes(str + "/h3" + "|" + str + "/h1");
            }
            catch (System.Xml.XPath.XPathException)
            {
                MessageBox.Show("XPathException!");
            }
            
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol2)
                {
                    personalData temp = new personalData();
                    temp.name = node.InnerText;
                    dataList.Add(temp);
                    //showFriendList.Text += node.InnerText + "   ";
                    ++cnt;
                }
                setForm.showFriendList.Text += cnt.ToString();
                cnt = 0;
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    string hrefString = "";
                    hrefString = node.GetAttributeValue("href", "").ToString();
                    changeData(dataList, cnt, hrefString);
                    //parsedCode.Text +=  hrefString + "   ";
                    ++cnt;
                }
                setForm.parsedCode.Text += cnt.ToString();
                output(dataList);
            }
            catch (NullReferenceException)
            {
                setForm.parsedCode.Text = "nothing found!";
            }
        }
        void output(List<personalData> dataList)
        {
            foreach (personalData data in dataList)
            {
                try
                {
                    setForm.parsedCode.Text += data.href + "        \n";
                }
                catch (NullReferenceException)
                {
                    setForm.parsedCode.Text += "empty value         \n";
                }
                try
                {
                    setForm.showFriendList.Text += data.name + "        \n";
                }
                catch (NullReferenceException)
                {
                    setForm.showFriendList.Text += "empty value         \n";
                }
            }
        }
        void changeData(List<personalData> temp, int index, string value)
        {
            personalData data = temp[index];
            data.href = value;
            temp[index] = data;
        }
    }
}
