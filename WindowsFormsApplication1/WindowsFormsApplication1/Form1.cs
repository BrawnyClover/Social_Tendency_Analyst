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
using Spire.Xls;
using Json.NET.Web;
using Newtonsoft.Json;

namespace WindowsFormsApplication1
{
    
    public partial class Form1 : Form
    {
        Dictionary<string, object> jsonValues;
        Dictionary<string, int> resultValues = new Dictionary<string, int>();
        List<int> valueList = new List<int>();
        System.Text.Encoding utf8 = System.Text.Encoding.UTF8;

        public Form1()
        {
            InitializeComponent();
        }

        private void navigator_Click(object sender, EventArgs e) // 실행 시작 버튼 이벤트
        {
            taskText.Focus();
            Form2 form = new Form2("m.facebook.com", this); // url로 이동
            form.Owner = this;
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.Show();
            form.setId(idText.Text); // id 정보 전달
            form.setpswd(pswdText.Text); // password 정보 전달
        }

        private void taskText_TextChanged(object sender, EventArgs e)
        {
            taskText.SelectionStart = taskText.Text.Length;
            taskText.ScrollToCaret(); // 텍스트박스 제일 아래로 내리기
        }

        private void graphCreate_Click(object sender, EventArgs e)
        {
            Workbook workbook = new Workbook();
            workbook.CreateEmptySheets(1);
            Worksheet sheet = workbook.Worksheets[0];
            sheet.Name = "Chart data";
            sheet.GridLinesVisible = true;
            CreateChartData(sheet);
            Chart chart = sheet.Charts.Add();

            ChartColoring(sheet, chart);

            try
            {
                workbook.SaveToFile(Application.StartupPath+"\\results\\Result.xls");
                taskText.Text += "chart created\r\n";
            }
            catch (IOException)
            {
                MessageBox.Show("Already opened...");
                taskText.Text += "chart creation failed... try again later\r\n";
            }
            
        }
        public void ChartColoring(Worksheet sheet, Chart chart)
        {
            chart.LeftColumn = 1;
            chart.TopRow = 14;
            chart.RightColumn = 20;
            chart.BottomRow = 51;
            chart.DataRange = sheet.Range["A1:B13"];
            chart.SeriesDataFromRange = false;
            chart.ChartType = ExcelChartType.Radar;
            chart.ChartTitle = "Social Tendency Analized for " + idText.Text;
            chart.ChartTitleArea.IsBold = true;
            chart.ChartTitleArea.Size = 12;
            chart.PlotArea.Fill.Visible = true;
            chart.Legend.Position = LegendPositionType.Corner;
            chart.ChartArea.ForeGroundColor = Color.LightYellow;
            chart.PlotArea.ForeGroundColor = Color.LightYellow;


            sheet.Range["A1:A13"].Style.KnownColor = ExcelColors.LightYellow;
            sheet.Range["B1:B13"].Style.KnownColor = ExcelColors.LightOrange;
            sheet.Range["A1:A13"].Style.Font.IsBold = true;

            //Border
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeTop].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeTop].LineStyle = LineStyleType.Thin;
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeBottom].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeBottom].LineStyle = LineStyleType.Thin;
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeLeft].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeLeft].LineStyle = LineStyleType.Thin;
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeRight].Color = Color.FromArgb(0, 0, 128);
            sheet.Range["A1:B13"].Style.Borders[BordersLineType.EdgeRight].LineStyle = LineStyleType.Thin;

        }

        private void CreateChartData(Worksheet sheet)
        {
            string[] orderedList = { "기타", "건강/미용", "스포츠", "인문/예술", "사회", "종교", "여행/여가", "커뮤니티", "미디어", "과학", "IT", "비즈니스", "학습" };
            int i=0;
            
            foreach(string keys in orderedList)
            {
                ++i;
                if (i > 13) break;
                string range = 'A' + i.ToString();
                sheet.Range[range].Value = keys;
            }
            i = 0;
            foreach (string key in orderedList)
            {
                ++i;
                if (i > 13) break;
                string range = 'B' + i.ToString();
                sheet.Range[range].Value = resultValues[key].ToString();
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                var jsonChar = sr.ReadToEnd(); // json파일 읽어오기
                byte[] utf8Bytes = utf8.GetBytes(jsonChar);
                string json = utf8.GetString(utf8Bytes); 
                jsonValues = JsonConvert.DeserializeObject<Dictionary<string, object>>(json);
                sr.Close();
                int i = 0;
                foreach(string key in jsonValues.Keys)
                {
                    string value = jsonValues[key].ToString(); // "[실제값]" 형식의 문자열
                    string temp = value.Substring(5, value.Length-8); // 실제값 추출 -> "["와 "]" 제거
                    valueList.Add(Int32.Parse(temp));
                    resultValues.Add(key, valueList[i]);
                    showRes.Text += valueList[i++]+"\t";
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
    
