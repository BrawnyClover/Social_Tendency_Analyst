using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CefSharp;
using CefSharp.WinForms;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    public struct personalData
    {
        public string name;
        public string href;
    }
    public class gathering // html코드를 가져오기
    {
        Form1 form1;
        Form2 form2;
        public string htmlCode="";
        public gathering() { }
        public gathering(Form1 form1, Form2 form2)
        {
            this.form1 = form1;
            this.form2 = form2;
        }
        public string parseHtml(string url)// html코드 가져오는 메소드
        {
            form2.browser.Load(url);
            Stopwatch sw = new Stopwatch();// 시간 측정 도구
            #region using browser;

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
            #endregion
            form2.browser.Focus();// 브라우저에 포커스 맞추기
            sw.Start();// 측정 시작
            while (true)
            {
                if (sw.ElapsedMilliseconds > 8000) break;
                ScrollToBottom();// 스크롤 아래로 내리기
            }
            htmlCode = form2.browser.GetSourceAsync().Result;// 가져온 코드를 string형으로 반환
            return htmlCode;
        }
        private void ScrollToBottom()
        {
            // MOST IMP : processes all windows messages queue
            Application.DoEvents();
            SendKeys.Send(" ");
        }
    }
    public class handling // 가져온 html코드를 파싱하고 정리
    {
        Form1 setForm;
        int cnt = 0;
        string htmlCode;
        List<personalData> dataList = new List<personalData>(); // 이름, href를 저장할 구조체 리스트
        
        public handling(Form1 form, string htmlCode)
        {
            setForm = form;
            this.htmlCode = htmlCode;
        }

        public void getFriendsName(HtmlAgilityPack.HtmlNodeCollection nodeCol)// 친구 이름 파싱하기
        {
            cnt = 0;
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    personalData temp = new personalData();// 임시 personalData객체 생성
                    temp.name = node.InnerText;
                    dataList.Add(temp);// dataList에 객체 추가
                    ++cnt;
                }
            }
            catch (NullReferenceException)
            {
                setForm.parsedCode.Text = "nothing found!";
            }
        }

        public void getHrefLink(HtmlAgilityPack.HtmlNodeCollection nodeCol)// href링크 파싱하기
        {
            cnt = 0;
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    string hrefString = "";
                    hrefString = node.GetAttributeValue("href", "").ToString();//href링크 가져오기
                    changeData(dataList, cnt, hrefString);//dataList의 인덱스가 cnt인 객체에 href링크 문자열 추가
                    ++cnt;
                }
            }
            catch (NullReferenceException)
            {
                setForm.parsedCode.Text = "nothing found!";
            }
        }
        
        public void getFriendsData()// 친구 정보를 가져오는 중심 메소드
        {
            string str = "//body/div/div/div/div/div/div/div/div/div";
            HtmlAgilityPack.HtmlNodeCollection hrefCol = null;
            HtmlAgilityPack.HtmlNodeCollection nameCol = null;
            hrefCol = parseTextFunc(str + "/h3/a[@href]" + "|" + str + "/h1/a[@href]");// href링크를 가져오기
            nameCol = parseTextFunc(str + "/h3" + "|" + str + "/h1");// 이름 가져오기

            getFriendsName(nameCol);// dataList에 이름 추가
            getHrefLink(hrefCol);// dataList에 href링크 추가
            output(dataList);// 일단 dataList출력
        }

        public void getLikesData()// 친구 정보를 바탕으로 '좋아요를 누른 페이지' 정보 가져오는 중심 메소드
        {
            //parseHtml("https://www.facebook.com" + dataList[0].href + "&sk=likes");

        }

        public HtmlAgilityPack.HtmlNodeCollection parseTextFunc(string str)// tag가 str인 요소 파싱하는 메소드
        {
            string parseStr = htmlCode;
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
            return nodeCol;
        }

        void output(List<personalData> dataList)
        {
            foreach (personalData data in dataList)
            {
                try
                {
                    setForm.parsedCode.Text += data.href;
                    setForm.parsedCode.AppendText(Environment.NewLine);
                }
                catch (NullReferenceException)
                {
                    setForm.parsedCode.Text += "empty value";
                    setForm.parsedCode.AppendText(Environment.NewLine);
                }
                try
                {
                    setForm.showFriendList.Text += data.name+"  ";
                    setForm.parsedCode.AppendText(Environment.NewLine);
                }
                catch (NullReferenceException)
                {
                    setForm.showFriendList.Text += "empty value";
                    setForm.parsedCode.AppendText(Environment.NewLine);
                }
            }
        }

        void changeData(List<personalData> temp, int index, string value)
        {
            personalData data = temp[index];
            data.href = value;
            temp[index] = data;
        }// personalData에 href정보 추가 메소드

        public List<personalData> getList()
        {
            return dataList;
        }// dataList를 외부로 반출
    }
    //public class temp
    //{
    //    Form1 form = new Form1();
    //    public void tex()
    //    {
    //        form.parsedCode.Text += "kfdajsljf;ladsj";
    //    }
    //}
}

