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
            this.parsedCode = new System.Windows.Forms.TextBox();
            this.showFriendList = new System.Windows.Forms.TextBox();
            this.loaded = new System.Windows.Forms.TextBox();
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
            // parsedCode
            // 
            this.parsedCode.Location = new System.Drawing.Point(37, 114);
            this.parsedCode.Multiline = true;
            this.parsedCode.Name = "parsedCode";
            this.parsedCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.parsedCode.Size = new System.Drawing.Size(576, 148);
            this.parsedCode.TabIndex = 10;
            // 
            // showFriendList
            // 
            this.showFriendList.Location = new System.Drawing.Point(619, 114);
            this.showFriendList.Multiline = true;
            this.showFriendList.Name = "showFriendList";
            this.showFriendList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.showFriendList.Size = new System.Drawing.Size(505, 148);
            this.showFriendList.TabIndex = 14;
            // 
            // loaded
            // 
            this.loaded.Location = new System.Drawing.Point(37, 268);
            this.loaded.Multiline = true;
            this.loaded.Name = "loaded";
            this.loaded.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.loaded.Size = new System.Drawing.Size(576, 239);
            this.loaded.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 532);
            this.Controls.Add(this.loaded);
            this.Controls.Add(this.showFriendList);
            this.Controls.Add(this.parsedCode);
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
        public System.Windows.Forms.TextBox parsedCode;
        public System.Windows.Forms.TextBox showFriendList;
        public System.Windows.Forms.TextBox loaded;
    }
}

