namespace Number_speaker_Projects
{
    partial class Main
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
            this.numberTXT = new System.Windows.Forms.TextBox();
            this.speakBTN = new System.Windows.Forms.Button();
            this.SayNumberchekbox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numberTXT
            // 
            this.numberTXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberTXT.Location = new System.Drawing.Point(12, 57);
            this.numberTXT.MaxLength = 4;
            this.numberTXT.Name = "numberTXT";
            this.numberTXT.Size = new System.Drawing.Size(226, 98);
            this.numberTXT.TabIndex = 0;
            this.numberTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numberTXT_KeyPress);
            // 
            // speakBTN
            // 
            this.speakBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.speakBTN.Location = new System.Drawing.Point(12, 161);
            this.speakBTN.Name = "speakBTN";
            this.speakBTN.Size = new System.Drawing.Size(226, 59);
            this.speakBTN.TabIndex = 1;
            this.speakBTN.Text = "صدا زدن";
            this.speakBTN.UseVisualStyleBackColor = false;
            this.speakBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // SayNumberchekbox
            // 
            this.SayNumberchekbox.AutoSize = true;
            this.SayNumberchekbox.Location = new System.Drawing.Point(12, 226);
            this.SayNumberchekbox.Name = "SayNumberchekbox";
            this.SayNumberchekbox.Size = new System.Drawing.Size(132, 17);
            this.SayNumberchekbox.TabIndex = 2;
            this.SayNumberchekbox.Text = "شماره گفتن قبل از عدد";
            this.SayNumberchekbox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "نرم افزار شماره صدا زن";
            // 
            // InfoBTN
            // 
            this.InfoBTN.BackColor = System.Drawing.Color.White;
            this.InfoBTN.Location = new System.Drawing.Point(12, 8);
            this.InfoBTN.Name = "InfoBTN";
            this.InfoBTN.Size = new System.Drawing.Size(23, 26);
            this.InfoBTN.TabIndex = 4;
            this.InfoBTN.Text = "؟";
            this.InfoBTN.UseVisualStyleBackColor = false;
            this.InfoBTN.Click += new System.EventHandler(this.InfoBTN_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(256, 249);
            this.Controls.Add(this.InfoBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SayNumberchekbox);
            this.Controls.Add(this.speakBTN);
            this.Controls.Add(this.numberTXT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chixo Fastfood Speaker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberTXT;
        private System.Windows.Forms.Button speakBTN;
        private System.Windows.Forms.CheckBox SayNumberchekbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button InfoBTN;
    }
}

