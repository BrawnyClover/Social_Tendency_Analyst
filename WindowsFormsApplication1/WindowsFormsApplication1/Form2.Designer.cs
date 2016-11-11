namespace WindowsFormsApplication1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.smallTimer = new System.Windows.Forms.TextBox();
            this.expectedTimer = new System.Windows.Forms.TextBox();
            this.achieveLimit = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.quitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.showDevTools = new System.Windows.Forms.Button();
            this.getCodeButton = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.suspendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // smallTimer
            // 
            this.smallTimer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.smallTimer.Location = new System.Drawing.Point(686, 303);
            this.smallTimer.Name = "smallTimer";
            this.smallTimer.ReadOnly = true;
            this.smallTimer.Size = new System.Drawing.Size(112, 31);
            this.smallTimer.TabIndex = 4;
            // 
            // expectedTimer
            // 
            this.expectedTimer.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.expectedTimer.Location = new System.Drawing.Point(686, 340);
            this.expectedTimer.Name = "expectedTimer";
            this.expectedTimer.ReadOnly = true;
            this.expectedTimer.Size = new System.Drawing.Size(112, 31);
            this.expectedTimer.TabIndex = 5;
            // 
            // achieveLimit
            // 
            this.achieveLimit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.achieveLimit.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.achieveLimit.Location = new System.Drawing.Point(687, 266);
            this.achieveLimit.Name = "achieveLimit";
            this.achieveLimit.Size = new System.Drawing.Size(39, 31);
            this.achieveLimit.TabIndex = 27;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(547, 369);
            this.panel1.TabIndex = 30;
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Transparent;
            this.quitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("quitButton.BackgroundImage")));
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.quitButton.FlatAppearance.BorderSize = 0;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.quitButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.quitButton.Location = new System.Drawing.Point(610, 110);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(188, 44);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginButton.BackgroundImage")));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.FlatAppearance.BorderSize = 0;
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.loginButton.Location = new System.Drawing.Point(610, 17);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(188, 47);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // showDevTools
            // 
            this.showDevTools.BackColor = System.Drawing.Color.Transparent;
            this.showDevTools.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("showDevTools.BackgroundImage")));
            this.showDevTools.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.showDevTools.FlatAppearance.BorderSize = 0;
            this.showDevTools.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.showDevTools.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showDevTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showDevTools.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.showDevTools.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.showDevTools.Location = new System.Drawing.Point(610, 154);
            this.showDevTools.Name = "showDevTools";
            this.showDevTools.Size = new System.Drawing.Size(188, 43);
            this.showDevTools.TabIndex = 1;
            this.showDevTools.Text = "DEV tool";
            this.showDevTools.UseVisualStyleBackColor = false;
            this.showDevTools.Click += new System.EventHandler(this.showDevTools_Click);
            // 
            // getCodeButton
            // 
            this.getCodeButton.BackColor = System.Drawing.Color.Transparent;
            this.getCodeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("getCodeButton.BackgroundImage")));
            this.getCodeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.getCodeButton.FlatAppearance.BorderSize = 0;
            this.getCodeButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.getCodeButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.getCodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getCodeButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.getCodeButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.getCodeButton.Location = new System.Drawing.Point(610, 64);
            this.getCodeButton.Name = "getCodeButton";
            this.getCodeButton.Size = new System.Drawing.Size(188, 46);
            this.getCodeButton.TabIndex = 0;
            this.getCodeButton.Text = "getCode";
            this.getCodeButton.UseVisualStyleBackColor = false;
            this.getCodeButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(572, 262);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 33);
            this.button4.TabIndex = 31;
            this.button4.Text = "Get data for";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(732, 264);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(96, 33);
            this.button5.TabIndex = 33;
            this.button5.Text = "people";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(565, 301);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(120, 33);
            this.button6.TabIndex = 34;
            this.button6.Text = "Left Time";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(565, 338);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(120, 33);
            this.button7.TabIndex = 35;
            this.button7.Text = "Expected";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // suspendButton
            // 
            this.suspendButton.BackColor = System.Drawing.Color.Transparent;
            this.suspendButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("suspendButton.BackgroundImage")));
            this.suspendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.suspendButton.FlatAppearance.BorderSize = 0;
            this.suspendButton.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.suspendButton.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.suspendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suspendButton.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.suspendButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.suspendButton.Location = new System.Drawing.Point(610, 200);
            this.suspendButton.Name = "suspendButton";
            this.suspendButton.Size = new System.Drawing.Size(188, 44);
            this.suspendButton.TabIndex = 36;
            this.suspendButton.Text = "Suspend";
            this.suspendButton.UseVisualStyleBackColor = false;
            this.suspendButton.Click += new System.EventHandler(this.suspendButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.black_light_dark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(840, 393);
            this.Controls.Add(this.suspendButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.achieveLimit);
            this.Controls.Add(this.expectedTimer);
            this.Controls.Add(this.smallTimer);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.showDevTools);
            this.Controls.Add(this.getCodeButton);
            this.Name = "Form2";
            this.Text = "Crawling Broser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getCodeButton;
        private System.Windows.Forms.Button showDevTools;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button quitButton;
        public System.Windows.Forms.TextBox smallTimer;
        public System.Windows.Forms.TextBox expectedTimer;
        private System.Windows.Forms.TextBox achieveLimit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button suspendButton;
    }
}