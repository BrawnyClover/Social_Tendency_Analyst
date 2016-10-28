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
            this.urlString = new System.Windows.Forms.TextBox();
            this.navigator = new System.Windows.Forms.Button();
            this.idText = new System.Windows.Forms.TextBox();
            this.pswdText = new System.Windows.Forms.TextBox();
            this.taskText = new System.Windows.Forms.TextBox();
            this.dataShow = new System.Windows.Forms.TextBox();
            this.showRes = new System.Windows.Forms.TextBox();
            this.graphCreate = new System.Windows.Forms.Button();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // urlString
            // 
            this.urlString.Location = new System.Drawing.Point(37, 12);
            this.urlString.Name = "urlString";
            this.urlString.Size = new System.Drawing.Size(679, 28);
            this.urlString.TabIndex = 5;
            this.urlString.Text = "m.facebook.com";
            // 
            // navigator
            // 
            this.navigator.Location = new System.Drawing.Point(751, 12);
            this.navigator.Name = "navigator";
            this.navigator.Size = new System.Drawing.Size(89, 28);
            this.navigator.TabIndex = 6;
            this.navigator.Text = "navigate";
            this.navigator.UseVisualStyleBackColor = true;
            this.navigator.Click += new System.EventHandler(this.navigator_Click);
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(37, 46);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(354, 28);
            this.idText.TabIndex = 7;
            this.idText.Text = "sonbill@daum.net";
            // 
            // pswdText
            // 
            this.pswdText.Location = new System.Drawing.Point(37, 80);
            this.pswdText.Name = "pswdText";
            this.pswdText.Size = new System.Drawing.Size(354, 28);
            this.pswdText.TabIndex = 7;
            this.pswdText.Text = "adgjmadgjmadgjm";
            this.pswdText.UseSystemPasswordChar = true;
            // 
            // taskText
            // 
            this.taskText.Location = new System.Drawing.Point(37, 122);
            this.taskText.Multiline = true;
            this.taskText.Name = "taskText";
            this.taskText.ReadOnly = true;
            this.taskText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.taskText.Size = new System.Drawing.Size(354, 385);
            this.taskText.TabIndex = 15;
            this.taskText.TextChanged += new System.EventHandler(this.taskText_TextChanged);
            // 
            // dataShow
            // 
            this.dataShow.Location = new System.Drawing.Point(397, 122);
            this.dataShow.Multiline = true;
            this.dataShow.Name = "dataShow";
            this.dataShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataShow.Size = new System.Drawing.Size(360, 384);
            this.dataShow.TabIndex = 16;
            // 
            // showRes
            // 
            this.showRes.Location = new System.Drawing.Point(772, 122);
            this.showRes.Multiline = true;
            this.showRes.Name = "showRes";
            this.showRes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showRes.Size = new System.Drawing.Size(344, 385);
            this.showRes.TabIndex = 17;
            // 
            // graphCreate
            // 
            this.graphCreate.Location = new System.Drawing.Point(751, 46);
            this.graphCreate.Name = "graphCreate";
            this.graphCreate.Size = new System.Drawing.Size(89, 28);
            this.graphCreate.TabIndex = 18;
            this.graphCreate.Text = "Graph";
            this.graphCreate.UseVisualStyleBackColor = true;
            this.graphCreate.Click += new System.EventHandler(this.graphCreate_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(846, 46);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(83, 28);
            this.BrowseButton.TabIndex = 19;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 532);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.graphCreate);
            this.Controls.Add(this.showRes);
            this.Controls.Add(this.dataShow);
            this.Controls.Add(this.taskText);
            this.Controls.Add(this.pswdText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.navigator);
            this.Controls.Add(this.urlString);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox urlString;
        private System.Windows.Forms.Button navigator;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox pswdText;
        public System.Windows.Forms.TextBox taskText;
        public System.Windows.Forms.TextBox dataShow;
        public System.Windows.Forms.TextBox showRes;
        private System.Windows.Forms.Button graphCreate;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

