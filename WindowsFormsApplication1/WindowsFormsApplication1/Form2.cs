using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using System.Diagnostics;

using Microsoft.Scripting.Hosting;

using IronPython;
using IronPython.Hosting;
using IronPython.Runtime;
using IronPython.Modules;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public bool isOkay = false;
        Form1 frm;
        string url;
        private string id;
        private string passwd;
        List<personalData> dataList;
       

        public void setId(string id)
        {
            this.id = id;
        }
        public void setpswd(string passwd)
        {
            this.passwd = passwd;
        }
        public ChromiumWebBrowser browser;
        private BackgroundWorker worker;
        public TimeSpan expectedTime = new TimeSpan(0,0,10);

        public void InitBrowser(string url)
        {
            this.url = url;
            try
            {
                Cef.Initialize(new CefSettings());
            }
            catch (System.Exception) { }
            browser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill,
            };
        
            panel1.Controls.Add(browser);
        } // CEFsharp브라우저 initialize
        
        public Form2(string url, Form1 _form)
        {
            InitializeComponent();
           
            InitBrowser(url);
            var settings = new CefSettings();
            frm = _form;
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = false;
            worker.WorkerSupportsCancellation = true;
            //worker.DoWork += new DoWorkEventHandler(dowork);
            //worker.RunWorkerCompleted += Worker_RunWorkerCompleted;;

        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void login() 
        {
            browser.Focus();
            for (int i = 0; i < 3; i++) { SendKeys.Send("{tab}"); }
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
        }// 자동 로그인 메소드

        private void dowork(/*object sender, DoWorkEventArgs e*/)
        {
            frm.taskText.Text += "Entering friends list gathering process...\r\n\r\n";
            Application.DoEvents();

            string htmlCode = "";
            gathering Gatherer = new gathering(frm, this);
            htmlCode = Gatherer.getHtml("https://m.facebook.com/profile.php?v=friends&ref=bookmarks");
            handling hand = new handling(frm, this);
            //frm.parsedCode.Text = "";
            hand.getFriendsData(htmlCode); // 친구 정보 파싱하기
            this.dataList = hand.getList(); // 정보 리스트 가져오기


            
            int tempCnt = 0;
            int achieve = dataList.Count;
            try
            {
                if (achieve > Int32.Parse(achieveLimit.Text)) // 자료 수집 목표 인원수 받아오기
                {
                    achieve = Int32.Parse(achieveLimit.Text);
                    frm.taskText.Text += "Achieve Limit setted : " + achieve.ToString() + "\r\n\r\n";
                }
            }
            catch (Exception){
                frm.taskText.Text += "Achieve Limit setted : for all\r\n\r\n";
            }

            expectedTime = new TimeSpan(0, 0, (achieve-1) * 15 + 15);
            expectedTimer.Text = expectedTime.ToString();

            foreach (personalData data in dataList)
            {
                if (tempCnt >= achieve) break;
                ++tempCnt;
                browser.Focus();
                try {
                    hand.getLikesData("https://facebook.com" + data.href + "&sk=likes", data.name, tempCnt, dataList.Count); // 좋아요 정보 파싱
                }
                catch (Exception) { }
            }    
            System.Diagnostics.Process.Start("cmd.exe", "/c " + Application.StartupPath + "//python//python.bat"); // python 스크립트 실행
        }

        private void button1_Click(object sender, EventArgs e) // '실행하기' 버튼 이벤트
        {
            dowork();
            this.Close();
        }

        private void showDevTools_Click(object sender, EventArgs e)
        {
            browser.ShowDevTools(); // 개발자 브라우저 보여주기
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Process.GetCurrentProcess().Kill();
            Application.ExitThread();
            Environment.Exit(0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void suspendButton_Click(object sender, EventArgs e)
        {
            isOkay = !isOkay;
            Thread.Sleep(3000);
        }
    }
}
