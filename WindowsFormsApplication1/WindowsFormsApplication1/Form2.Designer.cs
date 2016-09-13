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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(621, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "getCode";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // showDevTools
            // 
            this.showDevTools.Location = new System.Drawing.Point(621, 65);
            this.showDevTools.Name = "showDevTools";
            this.showDevTools.Size = new System.Drawing.Size(68, 31);
            this.showDevTools.TabIndex = 1;
            this.showDevTools.Text = "DEV";
            this.showDevTools.UseVisualStyleBackColor = true;
            this.showDevTools.Click += new System.EventHandler(this.showDevTools_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 370);
            this.Controls.Add(this.showDevTools);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showDevTools;
    }
}