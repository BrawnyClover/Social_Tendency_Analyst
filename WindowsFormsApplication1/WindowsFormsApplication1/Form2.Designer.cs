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
            this.button1 = new System.Windows.Forms.Button();
            this.showDevTools = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.smallTimer = new System.Windows.Forms.TextBox();
            this.expectedTimer = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "getCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showDevTools
            // 
            this.showDevTools.Location = new System.Drawing.Point(621, 65);
            this.showDevTools.Name = "showDevTools";
            this.showDevTools.Size = new System.Drawing.Size(112, 31);
            this.showDevTools.TabIndex = 1;
            this.showDevTools.Text = "DEV tool";
            this.showDevTools.UseVisualStyleBackColor = true;
            this.showDevTools.Click += new System.EventHandler(this.showDevTools_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(621, 102);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 30);
            this.button2.TabIndex = 2;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(621, 138);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 34);
            this.button3.TabIndex = 3;
            this.button3.Text = "Quit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // smallTimer
            // 
            this.smallTimer.Location = new System.Drawing.Point(621, 178);
            this.smallTimer.Name = "smallTimer";
            this.smallTimer.Size = new System.Drawing.Size(112, 28);
            this.smallTimer.TabIndex = 4;
            // 
            // expectedTimer
            // 
            this.expectedTimer.Location = new System.Drawing.Point(621, 212);
            this.expectedTimer.Name = "expectedTimer";
            this.expectedTimer.Size = new System.Drawing.Size(112, 28);
            this.expectedTimer.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(532, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(83, 28);
            this.textBox2.TabIndex = 6;
            this.textBox2.Text = "Left time";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(532, 212);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(83, 28);
            this.textBox3.TabIndex = 6;
            this.textBox3.Text = "Expected";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(637, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 370);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.expectedTimer);
            this.Controls.Add(this.smallTimer);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.showDevTools);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
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
        private System.Windows.Forms.Button button4;
    }
}