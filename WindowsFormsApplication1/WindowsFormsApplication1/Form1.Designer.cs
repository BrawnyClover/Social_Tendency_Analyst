namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.navigator = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.pswdText = new System.Windows.Forms.TextBox();
            this.taskText = new System.Windows.Forms.TextBox();
            this.dataShow = new System.Windows.Forms.TextBox();
            this.showRes = new System.Windows.Forms.TextBox();
            this.graphCreate = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // navigator
            // 
            this.navigator.Location = new System.Drawing.Point(507, 12);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(89, 28);
            this.navigator.TabIndex = 6;
            this.navigator.Text = "navigate";
            this.navigator.UseVisualStyleBackColor = true;
            this.navigator.Click += new System.EventHandler(this.navigator_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(138, 12);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(354, 28);
            this.idText.TabIndex = 7;
            this.idText.Text = "sonbill@daum.net";
            // 
            // pswdText
            // 
            this.pswdText.Location = new System.Drawing.Point(138, 49);
            this.pswdText.Name = "pswdText";
            this.pswdText.Size = new System.Drawing.Size(354, 28);
            this.pswdText.TabIndex = 7;
            this.pswdText.Text = "adgjmadgjmadgjm";
            this.pswdText.UseSystemPasswordChar = true;
            // 
            // taskText
            // 
            this.taskText.Location = new System.Drawing.Point(30, 145);
            this.taskText.Multiline = true;
            this.taskText.Name = "taskText";
            this.taskText.ReadOnly = true;
            this.taskText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskText.Size = new System.Drawing.Size(354, 375);
            this.taskText.TabIndex = 15;
            this.taskText.TextChanged += new System.EventHandler(this.taskText_TextChanged);
            // 
            // dataShow
            // 
            this.dataShow.Location = new System.Drawing.Point(399, 145);
            this.dataShow.Multiline = true;
            this.dataShow.Name = "dataShow";
            this.dataShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataShow.Size = new System.Drawing.Size(360, 374);
            this.dataShow.TabIndex = 16;
            // 
            // showRes
            // 
            this.showRes.Location = new System.Drawing.Point(765, 145);
            this.showRes.Multiline = true;
            this.showRes.Name = "showRes";
            this.showRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showRes.Size = new System.Drawing.Size(344, 375);
            this.showRes.TabIndex = 17;
            // 
            // graphCreate
            // 
            this.graphCreate.Location = new System.Drawing.Point(507, 89);
            this.graphCreate.Name = "graphCreate";
            this.graphCreate.Size = new System.Drawing.Size(89, 28);
            this.graphCreate.TabIndex = 18;
            this.graphCreate.Text = "Graph";
            this.graphCreate.UseVisualStyleBackColor = true;
            this.graphCreate.Click += new System.EventHandler(this.graphCreate_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(507, 49);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(89, 28);
            this.BrowseButton.TabIndex = 19;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(29, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 21);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "ID";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(29, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(103, 21);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Password";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(30, 118);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(103, 21);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = "Process Log";
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(399, 117);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(103, 21);
            this.textBox4.TabIndex = 23;
            this.textBox4.Text = "Datas";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(765, 118);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(103, 21);
            this.textBox5.TabIndex = 24;
            this.textBox5.Text = "for Debugger";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(624, 12);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(542, 105);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 532);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.graphCreate);
            this.Controls.Add(this.showRes);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.taskText);
            this.Controls.Add(this.pswdText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.navigator);
            this.Name = "Form1";
            this.Text = "Social Tendency Analyser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button navigator;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox pswdText;
        public System.Windows.Forms.TextBox taskText;
        public System.Windows.Forms.TextBox dataShow;
        public System.Windows.Forms.TextBox showRes;
        private System.Windows.Forms.Button graphCreate;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
    }
}

