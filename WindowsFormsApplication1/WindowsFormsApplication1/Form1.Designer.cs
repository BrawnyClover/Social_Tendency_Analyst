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
            this.time = new System.Windows.Forms.TextBox();
            this.sourceText = new System.Windows.Forms.TextBox();
            this.parsedCode = new System.Windows.Forms.TextBox();
            this.parseTag = new System.Windows.Forms.TextBox();
            this.parseButton = new System.Windows.Forms.Button();
            this.copyBtn = new System.Windows.Forms.Button();
            this.showFriendList = new System.Windows.Forms.TextBox();
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
            // time
            // 
            this.time.Location = new System.Drawing.Point(427, 46);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(186, 28);
            this.time.TabIndex = 8;
            // 
            // sourceText
            // 
            this.sourceText.Location = new System.Drawing.Point(37, 125);
            this.sourceText.Multiline = true;
            this.sourceText.Name = "sourceText";
            this.sourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceText.Size = new System.Drawing.Size(487, 386);
            this.sourceText.TabIndex = 9;
            // 
            // parsedCode
            // 
            this.parsedCode.Location = new System.Drawing.Point(548, 125);
            this.parsedCode.Multiline = true;
            this.parsedCode.Name = "parsedCode";
            this.parsedCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.parsedCode.Size = new System.Drawing.Size(656, 180);
            this.parsedCode.TabIndex = 10;
            // 
            // parseTag
            // 
            this.parseTag.Location = new System.Drawing.Point(427, 80);
            this.parseTag.Name = "parseTag";
            this.parseTag.Size = new System.Drawing.Size(573, 28);
            this.parseTag.TabIndex = 11;
            this.parseTag.Text = "//body/div/div/div/div/div/div/div/div/div/h3";
            // 
            // parseButton
            // 
            this.parseButton.Location = new System.Drawing.Point(1006, 80);
            this.parseButton.Name = "parseButton";
            this.parseButton.Size = new System.Drawing.Size(123, 28);
            this.parseButton.TabIndex = 12;
            this.parseButton.Text = "parse";
            this.parseButton.UseVisualStyleBackColor = true;
            this.parseButton.Click += new System.EventHandler(this.parseButton_Click);
            // 
            // copyBtn
            // 
            this.copyBtn.Location = new System.Drawing.Point(1159, 46);
            this.copyBtn.Name = "copyBtn";
            this.copyBtn.Size = new System.Drawing.Size(45, 56);
            this.copyBtn.TabIndex = 13;
            this.copyBtn.Text = "Copy";
            this.copyBtn.UseVisualStyleBackColor = true;
            this.copyBtn.Click += new System.EventHandler(this.copyBtn_Click);
            // 
            // showFriendList
            // 
            this.showFriendList.Location = new System.Drawing.Point(548, 311);
            this.showFriendList.Multiline = true;
            this.showFriendList.Name = "showFriendList";
            this.showFriendList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showFriendList.Size = new System.Drawing.Size(656, 200);
            this.showFriendList.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 532);
            this.Controls.Add(this.showFriendList);
            this.Controls.Add(this.copyBtn);
            this.Controls.Add(this.parseButton);
            this.Controls.Add(this.parseTag);
            this.Controls.Add(this.parsedCode);
            this.Controls.Add(this.sourceText);
            this.Controls.Add(this.time);
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
        public System.Windows.Forms.TextBox time;
        public System.Windows.Forms.TextBox sourceText;
        public System.Windows.Forms.TextBox parsedCode;
        private System.Windows.Forms.TextBox parseTag;
        private System.Windows.Forms.Button parseButton;
        private System.Windows.Forms.Button copyBtn;
        public System.Windows.Forms.TextBox showFriendList;
    }
}

