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
            this.button1 = new System.Windows.Forms.Button();
            this.showDevTools = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.smallTimer = new System.Windows.Forms.TextBox();
            this.expectedTimer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.achieveLimit = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 0;
            this.button1.Text = "getCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showDevTools
            // 
            this.showDevTools.Location = new System.Drawing.Point(661, 148);
            this.showDevTools.Name = "showDevTools";
            this.showDevTools.Size = new System.Drawing.Size(112, 31);
            this.showDevTools.TabIndex = 1;
            this.showDevTools.Text = "DEV tool";
            this.showDevTools.UseVisualStyleBackColor = true;
            this.showDevTools.Click += new System.EventHandler(this.showDevTools_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(661, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(661, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 30);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // smallTimer
            // 
            this.smallTimer.Location = new System.Drawing.Point(661, 229);
            this.smallTimer.Name = "smallTimer";
            this.smallTimer.ReadOnly = true;
            this.smallTimer.Size = new System.Drawing.Size(112, 28);
            this.smallTimer.TabIndex = 4;
            // 
            // expectedTimer
            // 
            this.expectedTimer.Location = new System.Drawing.Point(661, 266);
            this.expectedTimer.Name = "expectedTimer";
            this.expectedTimer.ReadOnly = true;
            this.expectedTimer.Size = new System.Drawing.Size(112, 28);
            this.expectedTimer.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(572, 232);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(83, 21);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Left time";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Location = new System.Drawing.Point(572, 269);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(83, 21);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Expected";
            // 
            // textBox6
            // 
            this.textBox6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox6.Location = new System.Drawing.Point(263, 299);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(542, 112);
            this.textBox6.TabIndex = 26;
            this.textBox6.Text = resources.GetString("textBox6.Text");
            // 
            // achieveLimit
            // 
            this.achieveLimit.Location = new System.Drawing.Point(679, 191);
            this.achieveLimit.Name = "achieveLimit";
            this.achieveLimit.Size = new System.Drawing.Size(31, 28);
            this.achieveLimit.TabIndex = 27;
            // 
            // textBox4
            // 
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Location = new System.Drawing.Point(569, 194);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(103, 21);
            this.textBox4.TabIndex = 28;
            this.textBox4.Text = "Get data for";
            // 
            // textBox5
            // 
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(717, 194);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(54, 21);
            this.textBox5.TabIndex = 29;
            this.textBox5.Text = "people";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 424);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.achieveLimit);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.expectedTimer);
            this.Controls.Add(this.smallTimer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showDevTools);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Crawling Broser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showDevTools;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox smallTimer;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        public System.Windows.Forms.TextBox expectedTimer;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox achieveLimit;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
    }
}