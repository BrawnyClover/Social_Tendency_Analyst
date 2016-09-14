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
            form.setId(idText.Text);
            form.setpswd(pswdText.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            handling hand = new handling(this);
            parsedCode.Text = "";
            hand.parseTextFunc("//body/div/div/div/div/div/div/div/div/div");
            //temp t = new temp();
            //t.tex();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            sourceText.SelectAll();
            sourceText.Copy();
        }
    }
}
    
