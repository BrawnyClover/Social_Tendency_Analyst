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

        private void navigator_Click(object sender, EventArgs e) // 실행 시작 버튼 이벤트
        {
            loaded.Focus();
            Form2 form = new Form2(urlString.Text, this); // url로 이동
            form.Owner = this;
            form.Show();
            form.setId(idText.Text); // id 정보 전달
            form.setpswd(pswdText.Text); // password 정보 전달
        }
        /*private void copyBtn_Click(object sender, EventArgs e)
{
   sourceText.SelectAll();
   sourceText.Copy();
}*/
    }
}
    
