using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

using System.Diagnostics;


namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        Form1 frm;
        string url;
        public ChromiumWebBrowser browser;
        public void InitBrowser(string url)
        {
            this.url = url;
            Cef.Initialize(new CefSettings());
            browser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill,
            };
        
            this.Controls.Add(browser);
            //browser.Location = new Point(0, 0);
            //browser.Bounds = new Rectangle(0, 0, 500, 300);
        }
        public Form2(string url, Form1 _form)
        {
            InitializeComponent();
            InitBrowser(url);
            var settings = new CefSettings();
            frm = _form;
            //while(browser.IsLoading == false)
            //{
            //    Application.DoEvents();
            //}
            //browser.Focus();
            //login();
        }

        public void login()
        {
            string id = "sonbill@daum.net";
            string passwd = "adgjmadgjmadgjm";
            for (int i = 0; i < 4; i++) { SendKeys.Send("{tab}"); }
            for(int i=0; i<id.Length; i++)
            {
                SendKeys.Send(id[i].ToString());
            }
            SendKeys.Send("{tab}");
            for (int i = 0; i < passwd.Length; i++)
            {
                SendKeys.Send(passwd[i].ToString());
            }
            SendKeys.Send("{ENTER}");
        }
        void parseHtml()
        {
            Stopwatch sw = new Stopwatch();
            bool flag = false;
            int cnt = 0;
            /*frm.time.Text = "0000" + " : " + cnt.ToString();
            while (true)
            {
                Application.DoEvents();
                browser.Focus();
                if (flag == false)
                {
                    sw.Start();
                    flag = true;
                }
                if (sw.ElapsedMilliseconds > 2000)
                {
                    frm.time.Text = sw.ElapsedMilliseconds.ToString() + " : " + cnt.ToString();
                    ScrollToBottom();
                    sw.Stop();
                    sw.Reset();
                    flag = false;
                    if (++cnt > 3) break;
                }
                
            }
            //frm.sourceText.Text = browser.GetMainFrame().ViewSource();
            */
            browser.Focus();
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds > 8000) break;
                ScrollToBottom();
            }
            frm.sourceText.Text = browser.GetSourceAsync().Result;
        }

        private void ScrollToBottom()
        {
            // MOST IMP : processes all windows messages queue
            Application.DoEvents();
            SendKeys.Send(" ");
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            browser.Load("https://m.facebook.com/profile.php?v=friends&ref=bookmarks");
            parseHtml();
        }

        private void showDevTools_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
