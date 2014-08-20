namespace ExcelAddIn1.Forms
{
    partial class SendBasicPlot
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
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxAPIKey = new System.Windows.Forms.TextBox();
            this.textBoxOrigin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFilename = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxFileOption = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxServiceURL = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxXColumn = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxYColumn = new System.Windows.Forms.TextBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(181, 59);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(293, 20);
            this.textBoxUsername.TabIndex = 0;
            // 
            // textBoxAPIKey
            // 
            this.textBoxAPIKey.Location = new System.Drawing.Point(181, 97);
            this.textBoxAPIKey.Name = "textBoxAPIKey";
            this.textBoxAPIKey.Size = new System.Drawing.Size(293, 20);
            this.textBoxAPIKey.TabIndex = 1;
            // 
            // textBoxOrigin
            // 
            this.textBoxOrigin.Location = new System.Drawing.Point(181, 135);
            this.textBoxOrigin.Name = "textBoxOrigin";
            this.textBoxOrigin.Size = new System.Drawing.Size(293, 20);
            this.textBoxOrigin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "API Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Origin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Platform";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(181, 173);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(293, 20);
            this.textBoxPlatform.TabIndex = 6;
            this.textBoxPlatform.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Filename";
            // 
            // textBoxFilename
            // 
            this.textBoxFilename.Location = new System.Drawing.Point(181, 213);
            this.textBoxFilename.Name = "textBoxFilename";
            this.textBoxFilename.Size = new System.Drawing.Size(293, 20);
            this.textBoxFilename.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "File Option";
            // 
            // textBoxFileOption
            // 
            this.textBoxFileOption.Location = new System.Drawing.Point(181, 251);
            this.textBoxFileOption.Name = "textBoxFileOption";
            this.textBoxFileOption.Size = new System.Drawing.Size(293, 20);
            this.textBoxFileOption.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Service URL";
            // 
            // textBoxServiceURL
            // 
            this.textBoxServiceURL.Location = new System.Drawing.Point(181, 21);
            this.textBoxServiceURL.Name = "textBoxServiceURL";
            this.textBoxServiceURL.Size = new System.Drawing.Size(293, 20);
            this.textBoxServiceURL.TabIndex = 12;
            this.textBoxServiceURL.Text = "http://plot.ly/clientresp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "X Column";
            // 
            // textBoxXColumn
            // 
            this.textBoxXColumn.Location = new System.Drawing.Point(181, 292);
            this.textBoxXColumn.Name = "textBoxXColumn";
            this.textBoxXColumn.Size = new System.Drawing.Size(293, 20);
            this.textBoxXColumn.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Y Column";
            // 
            // textBoxYColumn
            // 
            this.textBoxYColumn.Location = new System.Drawing.Point(181, 327);
            this.textBoxYColumn.Name = "textBoxYColumn";
            this.textBoxYColumn.Size = new System.Drawing.Size(293, 20);
            this.textBoxYColumn.TabIndex = 16;
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(399, 369);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(75, 23);
            this.ButtonSubmit.TabIndex = 18;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(181, 431);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(293, 20);
            this.textBox10.TabIndex = 19;
            // 
            // SendBasicPlot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 477);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.ButtonSubmit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBoxYColumn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxXColumn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxServiceURL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxFileOption);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxFilename);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxPlatform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxOrigin);
            this.Controls.Add(this.textBoxAPIKey);
            this.Controls.Add(this.textBoxUsername);
            this.Name = "SendBasicPlot";
            this.Text = "SendBasicPlot";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxAPIKey;
        private System.Windows.Forms.TextBox textBoxOrigin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFilename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxFileOption;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxServiceURL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxXColumn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxYColumn;
        private System.Windows.Forms.Button ButtonSubmit;
        private System.Windows.Forms.TextBox textBox10;
    }
}