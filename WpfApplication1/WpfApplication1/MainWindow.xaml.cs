using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using HtmlAgilityPack;
using System.IO;

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string htmlcode = "";

        public MainWindow()
        {
            InitializeComponent();
            StreamReader sw = new StreamReader("z.txt");
            while (!sw.EndOfStream)
            {
                htmlcode += sw.ReadLine();
            }
            sw.Close();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";
            textBox2.Text = "";
            string tag = textBox1.Text;
            HtmlAgilityPack.HtmlDocument mydoc = new HtmlAgilityPack.HtmlDocument();
            mydoc.LoadHtml(htmlcode);
            HtmlAgilityPack.HtmlNodeCollection nodeCol = null;
            try
            {
                nodeCol = mydoc.DocumentNode.SelectNodes(tag);
            }
            catch (Exception)
            {

            }
            int cnt = 0;
            try
            {
                foreach (HtmlAgilityPack.HtmlNode node in nodeCol)
                {
                    //textBox.Text += node.InnerHtml;
                    textBox2.Text += node.InnerText;
                    textBox2.Text += "-----";
                    cnt++;
                }
            }
            catch (NullReferenceException)
            {
                textBox.Text = "nothing found!";
            }
            textBox.Text = cnt.ToString();
        }
    }
}
