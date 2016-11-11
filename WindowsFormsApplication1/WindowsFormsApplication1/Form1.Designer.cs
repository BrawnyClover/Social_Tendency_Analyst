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
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // navigator
            // 
            this.navigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navigator.BackColor = System.Drawing.Color.Transparent;
            this.navigator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("navigator.BackgroundImage")));
            this.navigator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.navigator.FlatAppearance.BorderSize = 0;
            this.navigator.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.navigator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigator.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.navigator.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.navigator.Location = new System.Drawing.Point(29, 101);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(103, 40);
            this.navigator.TabIndex = 6;
            this.navigator.Text = "navigate";
            this.navigator.UseVisualStyleBackColor = false;
            this.navigator.Click += new System.EventHandler(this.navigator_Click);
            // 
            // idText
            // 
            this.idText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idText.BackColor = System.Drawing.SystemColors.Control;
            this.idText.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.idText.Location = new System.Drawing.Point(142, 12);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(354, 31);
            this.idText.TabIndex = 7;
            this.idText.Text = "sonbill@daum.net";
            // 
            // pswdText
            // 
            this.pswdText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pswdText.BackColor = System.Drawing.SystemColors.Control;
            this.pswdText.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pswdText.Location = new System.Drawing.Point(142, 49);
            this.pswdText.Name = "pswdText";
            this.pswdText.Size = new System.Drawing.Size(354, 31);
            this.pswdText.TabIndex = 7;
            this.pswdText.Text = "adgjmadgjmadgjm";
            this.pswdText.UseSystemPasswordChar = true;
            // 
            // taskText
            // 
            this.taskText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.taskText.BackColor = System.Drawing.Color.Silver;
            this.taskText.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.taskText.Location = new System.Drawing.Point(771, 183);
            this.taskText.Multiline = true;
            this.taskText.Name = "taskText";
            this.taskText.ReadOnly = true;
            this.taskText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskText.Size = new System.Drawing.Size(354, 358);
            this.taskText.TabIndex = 15;
            this.taskText.TextChanged += new System.EventHandler(this.taskText_TextChanged);
            // 
            // dataShow
            // 
            this.dataShow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataShow.BackColor = System.Drawing.Color.Silver;
            this.dataShow.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dataShow.Location = new System.Drawing.Point(393, 184);
            this.dataShow.Multiline = true;
            this.dataShow.Name = "dataShow";
            this.dataShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataShow.Size = new System.Drawing.Size(360, 357);
            this.dataShow.TabIndex = 16;
            // 
            // showRes
            // 
            this.showRes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showRes.BackColor = System.Drawing.Color.Silver;
            this.showRes.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showRes.Location = new System.Drawing.Point(30, 183);
            this.showRes.Multiline = true;
            this.showRes.Name = "showRes";
            this.showRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showRes.Size = new System.Drawing.Size(344, 358);
            this.showRes.TabIndex = 17;
            // 
            // graphCreate
            // 
            this.graphCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.graphCreate.BackColor = System.Drawing.Color.Transparent;
            this.graphCreate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("graphCreate.BackgroundImage")));
            this.graphCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.graphCreate.FlatAppearance.BorderSize = 0;
            this.graphCreate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.graphCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphCreate.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.graphCreate.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.graphCreate.Location = new System.Drawing.Point(267, 101);
            this.graphCreate.Name = "graphCreate";
            this.graphCreate.Size = new System.Drawing.Size(89, 40);
            this.graphCreate.TabIndex = 18;
            this.graphCreate.Text = "Graph";
            this.graphCreate.UseVisualStyleBackColor = false;
            this.graphCreate.Click += new System.EventHandler(this.graphCreate_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BrowseButton.BackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BrowseButton.BackgroundImage")));
            this.BrowseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BrowseButton.FlatAppearance.BorderSize = 0;
            this.BrowseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.BrowseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrowseButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.BrowseButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.BrowseButton.Location = new System.Drawing.Point(151, 101);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(89, 40);
            this.BrowseButton.TabIndex = 19;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = false;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox1.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(30, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(92, 31);
            this.textBox1.TabIndex = 20;
            this.textBox1.Text = "ID";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox2.Font = new System.Drawing.Font("함초롬돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(30, 49);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(92, 31);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = "Password";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.textBox6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox6.Location = new System.Drawing.Point(567, 12);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(558, 132);
            this.textBox6.TabIndex = 25;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(30, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 33);
            this.button1.TabIndex = 26;
            this.button1.Text = "JSON data";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(770, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 33);
            this.button2.TabIndex = 27;
            this.button2.Text = "Process Log";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(394, 150);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 33);
            this.button3.TabIndex = 28;
            this.button3.Text = "Data";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.black_and_red_abstract;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 553);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox6);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Social Tendency Analyser";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

