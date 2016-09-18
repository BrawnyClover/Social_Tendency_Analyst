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
            Form2 form = new Form2(urlString.Text, this);
            form.Owner = this;
            form.Show();
            form.setId(idText.Text);
            form.setpswd(pswdText.Text);
        }
        /*private void copyBtn_Click(object sender, EventArgs e)
{
   sourceText.SelectAll();
   sourceText.Copy();
}*/
    }
}
    
