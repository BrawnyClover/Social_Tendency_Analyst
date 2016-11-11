using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using CefSharp;
using CefSharp.WinForms;
using System.IO;
using System.Text;

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
    
    public struct pageData
    {
        public string name;
        public string pageClass;
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

        public string getHtml(string url)// html코드 가져오는 메소드
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
                TimeSpan lim = new TimeSpan(0, 0, 15);
                form2.smallTimer.Text = (lim-sw.Elapsed).ToString();
                form2.expectedTimer.Text = (form2.expectedTime - sw.Elapsed).ToString();
                if (sw.ElapsedMilliseconds > 15000) break; // 1인당 15초간 스크롤바 내리기
                
                ScrollToBottom();// 스크롤 아래로 내리기
            }
            form2.expectedTime = form2.expectedTime - sw.Elapsed;
            htmlCode = form2.browser.GetSourceAsync().Result;// 가져온 코드를 string형으로 반환
            return htmlCode;
        }

        private void ScrollToBottom()  // 스크롤바 아래로 내리는 메소드   
        {
            // MOST IMP : processes all windows messages queue
            Application.DoEvents();
            form2.browser.Focus();
            if (form2.TopLevel == true)
            {
                SendKeys.Send("{DOWN}");
            }
        
        }
    }

    public class handling // 가져온 html코드를 파싱하고 정리
    {
        Dictionary<String, int> dictionary = new Dictionary<string, int>();

        Form1 form1;
        Form2 form2;
        int cnt = 0;
        List<personalData> dataList = new List<personalData>(); // 친구 이름, href를 저장할 구조체 리스트
        List<pageData> pageInfoList = new List<pageData>(); // 페이지 이름, 분류를 저장할 구조체 리스트
        public handling(Form1 form1, Form2 form2)
        {
            this.form1 = form1;
            this.form2 = form2;
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
               // form1.parsedCode.Text = "nothing found!";
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
                //form1.parsedCode.Text = "nothing found!";
            }
        }

        public void getPageName(HtmlAgilityPack.HtmlNodeCollection nodeCol)// 페이지 이름 파싱하기
        {
            cnt = 0;
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    pageData temp = new pageData();// 임시 pageData객체 생성
                    temp.name = node.InnerText;
                    pageInfoList.Add(temp);// pageInfoList에 객체 추가
                    ++cnt;
                }
            }
            catch (NullReferenceException)
            {
                form1.taskText.Text += "nothing found!";
            }
        }

        public void getPageClass(HtmlAgilityPack.HtmlNodeCollection nodeCol)// 페이지 분류정보 파싱하기
        {
            cnt = 0;
            string classInfo = "";
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    classInfo = node.InnerText;
                    if (dictionary.ContainsKey(classInfo))
                    {
                        dictionary[classInfo] += 1;
                    }
                    else
                    {
                        dictionary.Add(classInfo, 1);
                    }
                    changeData(pageInfoList, cnt, classInfo);//classInfoList의 인덱스가 cnt인 객체에 page Class 문자열 추가
                    ++cnt;
                }
            }
            catch (NullReferenceException)
            {
                form1.taskText.Text += "nothing found?";
            }
        }
        
        public void getFriendsData(string htmlCode)// 친구 정보를 가져오는 중심 메소드
        {
            string str = "//body/div/div/div/div/div/div/div/div/div";
            HtmlAgilityPack.HtmlNodeCollection hrefCol = null;
            HtmlAgilityPack.HtmlNodeCollection nameCol = null;
            hrefCol = parseTextFunc(str + "/h3/a[@href]" + "|" + str + "/h1/a[@href]", htmlCode);// href링크를 가져오기
            nameCol = parseTextFunc(str + "/h3" + "|" + str + "/h1", htmlCode);// 이름 가져오기

            getFriendsName(nameCol);// dataList에 이름 추가
            getHrefLink(hrefCol);// dataList에 href링크 추가

            form1.taskText.Text += "Complete gathering friend list\r\n\r\n";
            Application.DoEvents();
        }

        public void getLikesData(string url,string name, int index, int size)// 친구 정보를 바탕으로 '좋아요를 누른 페이지' 정보 가져오는 중심 메소드
        {
            string tempCode = "";

            form1.taskText.Text += "Entering page class data gathering process for friend " + name + "...\r\n";
            form1.taskText.Text += index.ToString() + "th friend of " + size.ToString() + " friends" + "\r\n\r\n";
            Application.DoEvents();

            string tag = "//body/div[@class='_li']/div/div/div/div[@id='mainContainer']/div[@id='contentCol']/div[@id='contentArea']/div[@class='_5h60']/div/div/div/div/div[@class='_3i9']/div/ul/li/div[@class='_3owb']/div/div/div/div";
            gathering gather = new gathering(form1, form2);
            tempCode = gather.getHtml(url);
            HtmlAgilityPack.HtmlNodeCollection nameCol = null;
            HtmlAgilityPack.HtmlNodeCollection classCol = null;
            nameCol = parseTextFunc(tag + "/div[@class='fsl fwb fcb']", tempCode); // 이름 컬렉션
            classCol = parseTextFunc(tag + "/div[@class='fsm fwn fcg']", tempCode); // 분류/태그 컬렉션
            getPageName(nameCol);
            getPageClass(classCol);
            //output(pageInfoList);

            form1.taskText.Text += "Complete gathering page Class data\r\n";            
            output();
            form1.taskText.Text += "the number of gathered item = " + dictionary.Count.ToString()+"\r\n\r\n";

            dataOut(); // 데이터를 json파일로 내보내기
        }   

        public HtmlAgilityPack.HtmlNodeCollection parseTextFunc(string str, string htmlCode)// tag가 str인 요소 파싱하는 메소드
        {
            HtmlAgilityPack.HtmlDocument mydoc = new HtmlAgilityPack.HtmlDocument();
            mydoc.LoadHtml(htmlCode);
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

        /*void output(List<personalData> dataList)
        {
            foreach (personalData data in dataList)
            {
                try
                {
                    form1.parsedCode.Text += data.href;
                    form1.parsedCode.AppendText(Environment.NewLine);
                }
                catch (NullReferenceException)
                {
                    form1.parsedCode.Text += "empty value";
                    form1.parsedCode.AppendText(Environment.NewLine);
                }
                try
                {
                    form1.showFriendList.Text += data.name+"  ";
                    form1.parsedCode.AppendText(Environment.NewLine);
                }
                catch (NullReferenceException)
                {
                    form1.showFriendList.Text += "empty value";
                    form1.parsedCode.AppendText(Environment.NewLine);
                }
            }
        }*/

        void output(List<pageData> pageInfoData)
        {
            foreach (pageData temp in pageInfoData)
            {
                form1.dataShow.Text += temp.name +' ';
                form1.taskText.Text += temp.pageClass + ' ';
            }
        }

        void output()
        {
            form1.dataShow.Text = "";
            foreach(var info in dictionary)
            {
                form1.dataShow.Text += info.Key.ToString() + " : " + info.Value.ToString()+"\r\n";
            }
        }

        void changeData(List<personalData> temp, int index, string value)
        {
            personalData data = temp[index];
            data.href = value;
            temp[index] = data;
        }// personalData에 href정보 추가 메소드

        void changeData(List<pageData> temp, int index, string value)
        {
            pageData data = temp[index];
            data.pageClass = value;
            temp[index] = data;
        }

        public List<personalData> getList()
        {
            return dataList;
        }// dataList를 외부로 반출
    
        public void dataOut()
        {
            string path = Application.StartupPath + "//python//data.json"; //@"C:\\Users\\sonbi\\Desktop\\data.json";
            try
            {
                FileStream temp = File.Create(path);
                temp.Close();
            }
            catch (Exception) { }
            StreamWriter sw = new StreamWriter(path);
            
            string temp1 = MyDictionaryToJson();
            form1.showRes.Text = temp1;
            byte[] encoder = Encoding.UTF8.GetBytes(temp1); // utf8로 인코딩
            sw.WriteLine(Encoding.UTF8.GetString(encoder));
            sw.Close();
            
        }

        string MyDictionaryToJson()
        {
            var entries = dictionary.Select(d =>
                string.Format("\"{0}\": [{1}]", d.Key, string.Join(",", d.Value)));
            return "{" + string.Join(",\n", entries) + "}";
        }
    }
}

