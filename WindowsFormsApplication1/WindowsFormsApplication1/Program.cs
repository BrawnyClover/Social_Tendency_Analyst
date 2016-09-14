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
    public class gathering
    {
        Form1 form1;
        Form2 form2;
        public gathering(Form1 form1, Form2 form2)
        {
            this.form1 = form1;
            this.form2 = form2;
        }
        public void parseHtml()
        {
            Stopwatch sw = new Stopwatch();
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
            form2.browser.Focus();
            sw.Start();
            while (true)
            {
                if (sw.ElapsedMilliseconds > 8000) break;
                ScrollToBottom();
            }
            form1.sourceText.Text = form2.browser.GetSourceAsync().Result;
        }
        private void ScrollToBottom()
        {
            // MOST IMP : processes all windows messages queue
            Application.DoEvents();
            SendKeys.Send(" ");
        }
    }
    public class handling
    {
        Form1 setForm;
        int cnt = 0;
        List<personalData> dataList = new List<personalData>();
        public handling(Form1 form)
        {
            setForm = form;
        }
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
                setForm.showFriendList.Text += cnt.ToString()+Environment.NewLine;
                setForm.showFriendList.AppendText(Environment.NewLine);
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
                setForm.showFriendList.AppendText(Environment.NewLine);
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
        }
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

