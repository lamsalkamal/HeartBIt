namespace WebcamDemo
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
            this.btnCaptureImage = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRemoveAllImages = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxSources = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picbox90 = new System.Windows.Forms.PictureBox();
            this.picbox180 = new System.Windows.Forms.PictureBox();
            this.picbox270 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxResolution = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.HeartBeat = new System.Windows.Forms.Label();
            this.So2 = new System.Windows.Forms.Label();
            this.BPH = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.BPL = new System.Windows.Forms.Label();
            this.Emergency_but = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Yellow = new System.Windows.Forms.Panel();
            this.Red = new System.Windows.Forms.Panel();
            this.Green = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picbox90)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox180)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox270)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Location = new System.Drawing.Point(1109, 370);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(149, 23);
            this.btnCaptureImage.TabIndex = 1;
            this.btnCaptureImage.Text = "Capture Image";
            this.btnCaptureImage.UseVisualStyleBackColor = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 207);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            // 
            // btnRemoveAllImages
            // 
            this.btnRemoveAllImages.Location = new System.Drawing.Point(1109, 428);
            this.btnRemoveAllImages.Name = "btnRemoveAllImages";
            this.btnRemoveAllImages.Size = new System.Drawing.Size(149, 23);
            this.btnRemoveAllImages.TabIndex = 4;
            this.btnRemoveAllImages.Text = "Remove All Images";
            this.btnRemoveAllImages.UseVisualStyleBackColor = true;
            this.btnRemoveAllImages.Click += new System.EventHandler(this.btnRemoveAllImages_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(1112, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Webcam Source:";
            // 
            // cbxSources
            // 
            this.cbxSources.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSources.FormattingEnabled = true;
            this.cbxSources.Location = new System.Drawing.Point(1112, 263);
            this.cbxSources.Name = "cbxSources";
            this.cbxSources.Size = new System.Drawing.Size(146, 21);
            this.cbxSources.TabIndex = 13;
            this.cbxSources.SelectedIndexChanged += new System.EventHandler(this.cbxSources_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1094, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 217);
            this.panel1.TabIndex = 17;
            // 
            // picbox90
            // 
            this.picbox90.Image = global::WebcamDemo.Properties.Resources._90_normal;
            this.picbox90.Location = new System.Drawing.Point(1115, 343);
            this.picbox90.Name = "picbox90";
            this.picbox90.Size = new System.Drawing.Size(24, 21);
            this.picbox90.TabIndex = 24;
            this.picbox90.TabStop = false;
            this.picbox90.Click += new System.EventHandler(this.picbox90_Click);
            this.picbox90.MouseLeave += new System.EventHandler(this.picbox90_MouseLeave);
            this.picbox90.MouseHover += new System.EventHandler(this.picbox90_MouseHover);
            // 
            // picbox180
            // 
            this.picbox180.Image = global::WebcamDemo.Properties.Resources._180_normal;
            this.picbox180.Location = new System.Drawing.Point(1145, 343);
            this.picbox180.Name = "picbox180";
            this.picbox180.Size = new System.Drawing.Size(24, 21);
            this.picbox180.TabIndex = 25;
            this.picbox180.TabStop = false;
            this.picbox180.Click += new System.EventHandler(this.picbox180_Click);
            this.picbox180.MouseLeave += new System.EventHandler(this.picbox180_MouseLeave);
            this.picbox180.MouseHover += new System.EventHandler(this.picbox180_MouseHover);
            // 
            // picbox270
            // 
            this.picbox270.Image = global::WebcamDemo.Properties.Resources._270_normal;
            this.picbox270.Location = new System.Drawing.Point(1175, 343);
            this.picbox270.Name = "picbox270";
            this.picbox270.Size = new System.Drawing.Size(24, 21);
            this.picbox270.TabIndex = 26;
            this.picbox270.TabStop = false;
            this.picbox270.Click += new System.EventHandler(this.picbox270_Click);
            this.picbox270.MouseLeave += new System.EventHandler(this.picbox270_MouseLeave);
            this.picbox270.MouseHover += new System.EventHandler(this.picbox270_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(1109, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Resolution:";
            // 
            // cbxResolution
            // 
            this.cbxResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxResolution.FormattingEnabled = true;
            this.cbxResolution.Location = new System.Drawing.Point(1112, 303);
            this.cbxResolution.Name = "cbxResolution";
            this.cbxResolution.Size = new System.Drawing.Size(146, 21);
            this.cbxResolution.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(1112, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Rotate:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(38, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(718, 520);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // HeartBeat
            // 
            this.HeartBeat.AutoSize = true;
            this.HeartBeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeartBeat.Location = new System.Drawing.Point(1137, 502);
            this.HeartBeat.Name = "HeartBeat";
            this.HeartBeat.Size = new System.Drawing.Size(11, 13);
            this.HeartBeat.TabIndex = 33;
            this.HeartBeat.Text = " ";
            // 
            // So2
            // 
            this.So2.AutoSize = true;
            this.So2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.So2.Location = new System.Drawing.Point(1137, 530);
            this.So2.Name = "So2";
            this.So2.Size = new System.Drawing.Size(11, 13);
            this.So2.TabIndex = 34;
            this.So2.Text = " ";
            // 
            // BPH
            // 
            this.BPH.AutoSize = true;
            this.BPH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPH.Location = new System.Drawing.Point(1137, 555);
            this.BPH.Name = "BPH";
            this.BPH.Size = new System.Drawing.Size(11, 13);
            this.BPH.TabIndex = 35;
            this.BPH.Text = " ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1105, 497);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1196, 497);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 37;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1196, 526);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 39;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1104, 525);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(27, 23);
            this.button4.TabIndex = 38;
            this.button4.Text = "<";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(1196, 550);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(27, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = ">";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(1105, 550);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(27, 23);
            this.button6.TabIndex = 40;
            this.button6.Text = "<";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.AcceptsTab = true;
            this.richTextBox2.BulletIndent = 5;
            this.richTextBox2.Location = new System.Drawing.Point(762, 16);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(326, 516);
            this.richTextBox2.TabIndex = 43;
            this.richTextBox2.Text = "";
            // 
            // BPL
            // 
            this.BPL.AutoSize = true;
            this.BPL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPL.Location = new System.Drawing.Point(1169, 555);
            this.BPL.Name = "BPL";
            this.BPL.Size = new System.Drawing.Size(11, 13);
            this.BPL.TabIndex = 44;
            this.BPL.Text = " ";
            // 
            // Emergency_but
            // 
            this.Emergency_but.AutoSize = true;
            this.Emergency_but.Location = new System.Drawing.Point(1115, 475);
            this.Emergency_but.Name = "Emergency_but";
            this.Emergency_but.Size = new System.Drawing.Size(79, 17);
            this.Emergency_but.TabIndex = 45;
            this.Emergency_but.Text = "Emergency";
            this.Emergency_but.UseVisualStyleBackColor = true;
            this.Emergency_but.CheckedChanged += new System.EventHandler(this.Emergency_but_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 566);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 39);
            this.label5.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 566);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 39);
            this.label6.TabIndex = 48;
            this.label6.Text = "Pain Degree";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 614);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 39);
            this.label7.TabIndex = 49;
            this.label7.Text = "Facial Pain";
            // 
            // Yellow
            // 
            this.Yellow.Location = new System.Drawing.Point(542, 566);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(60, 62);
            this.Yellow.TabIndex = 50;
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(476, 566);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(60, 62);
            this.Red.TabIndex = 51;
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(608, 566);
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(62, 62);
            this.Green.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1112, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Simulated Vitals";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1224, 502);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 54;
            this.label9.Text = "Heart Beat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(1224, 531);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 55;
            this.label10.Text = "So2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(1224, 555);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 56;
            this.label11.Text = "BP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(1109, 399);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(149, 23);
            this.button7.TabIndex = 58;
            this.button7.Text = "Browse";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1304, 749);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.Yellow);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Emergency_but);
            this.Controls.Add(this.BPL);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BPH);
            this.Controls.Add(this.So2);
            this.Controls.Add(this.HeartBeat);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxResolution);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picbox270);
            this.Controls.Add(this.picbox180);
            this.Controls.Add(this.picbox90);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbxSources);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemoveAllImages);
            this.Controls.Add(this.btnCaptureImage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Cam Assess (Pain Assesment and Monitoring)";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picbox90)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox180)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox270)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCaptureImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRemoveAllImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxSources;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picbox90;
        private System.Windows.Forms.PictureBox picbox180;
        private System.Windows.Forms.PictureBox picbox270;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxResolution;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label HeartBeat;
        private System.Windows.Forms.Label So2;
        private System.Windows.Forms.Label BPH;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label BPL;
        private System.Windows.Forms.CheckBox Emergency_but;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel Yellow;
        private System.Windows.Forms.Panel Red;
        private System.Windows.Forms.Panel Green;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button7;
    }
}

