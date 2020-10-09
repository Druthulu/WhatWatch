namespace WhatWatch
{
    partial class WhatWatch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WhatWatch));
            this.tex_list = new System.Windows.Forms.TextBox();
            this.but_random = new System.Windows.Forms.Button();
            this.tex_out = new System.Windows.Forms.TextBox();
            this.tex_cred = new System.Windows.Forms.TextBox();
            this.pic_cred = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cred)).BeginInit();
            this.SuspendLayout();
            // 
            // tex_list
            // 
            this.tex_list.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_list.Location = new System.Drawing.Point(36, 212);
            this.tex_list.Multiline = true;
            this.tex_list.Name = "tex_list";
            this.tex_list.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tex_list.Size = new System.Drawing.Size(381, 519);
            this.tex_list.TabIndex = 0;
            // 
            // but_random
            // 
            this.but_random.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.but_random.Location = new System.Drawing.Point(81, 101);
            this.but_random.Name = "but_random";
            this.but_random.Size = new System.Drawing.Size(282, 94);
            this.but_random.TabIndex = 1;
            this.but_random.Text = "Forfit all power to the mighty button and let it choose your fate";
            this.but_random.UseVisualStyleBackColor = true;
            this.but_random.Click += new System.EventHandler(this.but_random_Click);
            // 
            // tex_out
            // 
            this.tex_out.Font = new System.Drawing.Font("Mongolian Baiti", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_out.Location = new System.Drawing.Point(13, 13);
            this.tex_out.Name = "tex_out";
            this.tex_out.ReadOnly = true;
            this.tex_out.Size = new System.Drawing.Size(432, 72);
            this.tex_out.TabIndex = 3;
            this.tex_out.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tex_cred
            // 
            this.tex_cred.Font = new System.Drawing.Font("Mongolian Baiti", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tex_cred.Location = new System.Drawing.Point(121, 784);
            this.tex_cred.Name = "tex_cred";
            this.tex_cred.ReadOnly = true;
            this.tex_cred.Size = new System.Drawing.Size(318, 31);
            this.tex_cred.TabIndex = 4;
            this.tex_cred.Text = "Credits: Druthulu 2020";
            this.tex_cred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_cred
            // 
            this.pic_cred.Image = global::WhatWatch.Properties.Resources.tacotown2;
            this.pic_cred.Location = new System.Drawing.Point(13, 757);
            this.pic_cred.Name = "pic_cred";
            this.pic_cred.Size = new System.Drawing.Size(90, 83);
            this.pic_cred.TabIndex = 5;
            this.pic_cred.TabStop = false;
            // 
            // WhatWatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 853);
            this.Controls.Add(this.pic_cred);
            this.Controls.Add(this.tex_cred);
            this.Controls.Add(this.tex_out);
            this.Controls.Add(this.but_random);
            this.Controls.Add(this.tex_list);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WhatWatch";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "WhatWatch 0.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_cred)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tex_list;
        private System.Windows.Forms.Button but_random;
        private System.Windows.Forms.TextBox tex_out;
        private System.Windows.Forms.TextBox tex_cred;
        private System.Windows.Forms.PictureBox pic_cred;
    }
}

