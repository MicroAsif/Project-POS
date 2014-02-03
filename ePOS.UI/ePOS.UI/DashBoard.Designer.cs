namespace ePOS.UI
{
    partial class DashBoard
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
            this.setting = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setting
            // 
            this.setting.Location = new System.Drawing.Point(463, 12);
            this.setting.Name = "setting";
            this.setting.Size = new System.Drawing.Size(83, 40);
            this.setting.TabIndex = 0;
            this.setting.Text = "Store setting";
            this.setting.UseVisualStyleBackColor = true;
            this.setting.Click += new System.EventHandler(this.setting_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(374, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 40);
            this.button2.TabIndex = 0;
            this.button2.Text = "Customer";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(285, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 40);
            this.button3.TabIndex = 0;
            this.button3.Text = "Supplier";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(196, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(83, 40);
            this.button4.TabIndex = 0;
            this.button4.Text = "Employee";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(107, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(83, 40);
            this.button5.TabIndex = 0;
            this.button5.Text = "Item";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(18, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(83, 40);
            this.button6.TabIndex = 0;
            this.button6.Text = "Category";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(374, 68);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(172, 40);
            this.button7.TabIndex = 0;
            this.button7.Text = "Return";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(196, 68);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(172, 40);
            this.button8.TabIndex = 0;
            this.button8.Text = "Sell";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(18, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(172, 40);
            this.button9.TabIndex = 0;
            this.button9.Text = "Report";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 461);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.setting);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button setting;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}