namespace LSB
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabEncode = new System.Windows.Forms.TabPage();
            this.encodeImage2 = new System.Windows.Forms.PictureBox();
            this.encodeImage1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.encodeMessage = new System.Windows.Forms.TextBox();
            this.encodeInputImage = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabDecode = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.decodeInputImage = new System.Windows.Forms.TextBox();
            this.decodeMessage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.decodeImage = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabEncode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage1)).BeginInit();
            this.tabDecode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decodeImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabEncode);
            this.tabControl1.Controls.Add(this.tabDecode);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 449);
            this.tabControl1.TabIndex = 0;
            // 
            // tabEncode
            // 
            this.tabEncode.BackColor = System.Drawing.Color.Honeydew;
            this.tabEncode.Controls.Add(this.encodeImage2);
            this.tabEncode.Controls.Add(this.encodeImage1);
            this.tabEncode.Controls.Add(this.button2);
            this.tabEncode.Controls.Add(this.button1);
            this.tabEncode.Controls.Add(this.encodeMessage);
            this.tabEncode.Controls.Add(this.encodeInputImage);
            this.tabEncode.Controls.Add(this.label4);
            this.tabEncode.Controls.Add(this.label3);
            this.tabEncode.Controls.Add(this.label2);
            this.tabEncode.Controls.Add(this.label1);
            this.tabEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEncode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabEncode.Location = new System.Drawing.Point(4, 30);
            this.tabEncode.Name = "tabEncode";
            this.tabEncode.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncode.Size = new System.Drawing.Size(676, 415);
            this.tabEncode.TabIndex = 0;
            this.tabEncode.Text = "Encode ";
            // 
            // encodeImage2
            // 
            this.encodeImage2.Image = ((System.Drawing.Image)(resources.GetObject("encodeImage2.Image")));
            this.encodeImage2.Location = new System.Drawing.Point(373, 69);
            this.encodeImage2.Name = "encodeImage2";
            this.encodeImage2.Size = new System.Drawing.Size(262, 203);
            this.encodeImage2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encodeImage2.TabIndex = 9;
            this.encodeImage2.TabStop = false;
            this.encodeImage2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // encodeImage1
            // 
            this.encodeImage1.BackColor = System.Drawing.Color.DimGray;
            this.encodeImage1.Image = ((System.Drawing.Image)(resources.GetObject("encodeImage1.Image")));
            this.encodeImage1.Location = new System.Drawing.Point(21, 69);
            this.encodeImage1.Name = "encodeImage1";
            this.encodeImage1.Size = new System.Drawing.Size(262, 203);
            this.encodeImage1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.encodeImage1.TabIndex = 8;
            this.encodeImage1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(526, 370);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 30);
            this.button2.TabIndex = 7;
            this.button2.Text = "Encode";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(526, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "Open File";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // encodeMessage
            // 
            this.encodeMessage.Location = new System.Drawing.Point(178, 370);
            this.encodeMessage.Name = "encodeMessage";
            this.encodeMessage.Size = new System.Drawing.Size(327, 26);
            this.encodeMessage.TabIndex = 5;
            // 
            // encodeInputImage
            // 
            this.encodeInputImage.Location = new System.Drawing.Point(176, 310);
            this.encodeInputImage.Name = "encodeInputImage";
            this.encodeInputImage.Size = new System.Drawing.Size(329, 26);
            this.encodeInputImage.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Your Message";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(60, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "After";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(60, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Before";
            // 
            // tabDecode
            // 
            this.tabDecode.BackColor = System.Drawing.Color.Honeydew;
            this.tabDecode.Controls.Add(this.button4);
            this.tabDecode.Controls.Add(this.button3);
            this.tabDecode.Controls.Add(this.decodeInputImage);
            this.tabDecode.Controls.Add(this.decodeMessage);
            this.tabDecode.Controls.Add(this.label6);
            this.tabDecode.Controls.Add(this.label5);
            this.tabDecode.Controls.Add(this.decodeImage);
            this.tabDecode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDecode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tabDecode.Location = new System.Drawing.Point(4, 30);
            this.tabDecode.Name = "tabDecode";
            this.tabDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecode.Size = new System.Drawing.Size(676, 415);
            this.tabDecode.TabIndex = 1;
            this.tabDecode.Text = "Decode";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button4.Location = new System.Drawing.Point(531, 368);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 30);
            this.button4.TabIndex = 6;
            this.button4.Text = "Decode";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button3.Location = new System.Drawing.Point(531, 298);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 30);
            this.button3.TabIndex = 5;
            this.button3.Text = "Open File";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // decodeInputImage
            // 
            this.decodeInputImage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.decodeInputImage.Location = new System.Drawing.Point(213, 372);
            this.decodeInputImage.Name = "decodeInputImage";
            this.decodeInputImage.Size = new System.Drawing.Size(262, 26);
            this.decodeInputImage.TabIndex = 4;
            this.decodeInputImage.TextChanged += new System.EventHandler(this.decodeMessage_TextChanged);
            // 
            // decodeMessage
            // 
            this.decodeMessage.Location = new System.Drawing.Point(213, 302);
            this.decodeMessage.Name = "decodeMessage";
            this.decodeMessage.Size = new System.Drawing.Size(262, 26);
            this.decodeMessage.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Hidden Message";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(94, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Input Image";
            // 
            // decodeImage
            // 
            this.decodeImage.BackColor = System.Drawing.Color.Black;
            this.decodeImage.Image = ((System.Drawing.Image)(resources.GetObject("decodeImage.Image")));
            this.decodeImage.Location = new System.Drawing.Point(213, 28);
            this.decodeImage.Name = "decodeImage";
            this.decodeImage.Size = new System.Drawing.Size(262, 203);
            this.decodeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.decodeImage.TabIndex = 0;
            this.decodeImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 459);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "LSB | Nguyen Ba lam  - N14DCAT141";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabEncode.ResumeLayout(false);
            this.tabEncode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.encodeImage1)).EndInit();
            this.tabDecode.ResumeLayout(false);
            this.tabDecode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.decodeImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabEncode;
        private System.Windows.Forms.TabPage tabDecode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox encodeMessage;
        private System.Windows.Forms.TextBox encodeInputImage;
        private System.Windows.Forms.PictureBox encodeImage2;
        private System.Windows.Forms.PictureBox encodeImage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox decodeInputImage;
        private System.Windows.Forms.TextBox decodeMessage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox decodeImage;
    }
}

