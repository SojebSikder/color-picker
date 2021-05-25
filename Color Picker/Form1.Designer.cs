namespace Color_Picker
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
            this.components = new System.ComponentModel.Container();
            this.panel5 = new System.Windows.Forms.Panel();
            this.track_red = new System.Windows.Forms.TrackBar();
            this.track_green = new System.Windows.Forms.TrackBar();
            this.track_blue = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lab_red = new System.Windows.Forms.Label();
            this.lab_green = new System.Windows.Forms.Label();
            this.lab_blue = new System.Windows.Forms.Label();
            this.lab_rgb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtHex = new System.Windows.Forms.TextBox();
            this.btnHexCopy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.magnifyingGlass1 = new DesktopColorPicker.MagnifyingGlass();
            ((System.ComponentModel.ISupportInitialize)(this.track_red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_blue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(88, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(257, 108);
            this.panel5.TabIndex = 0;
            // 
            // track_red
            // 
            this.track_red.Location = new System.Drawing.Point(88, 142);
            this.track_red.Maximum = 255;
            this.track_red.Name = "track_red";
            this.track_red.Size = new System.Drawing.Size(257, 45);
            this.track_red.TabIndex = 1;
            // 
            // track_green
            // 
            this.track_green.Location = new System.Drawing.Point(88, 193);
            this.track_green.Maximum = 255;
            this.track_green.Name = "track_green";
            this.track_green.Size = new System.Drawing.Size(257, 45);
            this.track_green.TabIndex = 2;
            // 
            // track_blue
            // 
            this.track_blue.Location = new System.Drawing.Point(88, 244);
            this.track_blue.Maximum = 255;
            this.track_blue.Name = "track_blue";
            this.track_blue.Size = new System.Drawing.Size(257, 45);
            this.track_blue.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "RED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "GREEN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "BLUE";
            // 
            // lab_red
            // 
            this.lab_red.AutoSize = true;
            this.lab_red.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_red.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_red.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_red.Location = new System.Drawing.Point(351, 142);
            this.lab_red.Name = "lab_red";
            this.lab_red.Size = new System.Drawing.Size(41, 23);
            this.lab_red.TabIndex = 4;
            this.lab_red.Text = "RED";
            this.lab_red.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_green
            // 
            this.lab_green.AutoSize = true;
            this.lab_green.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_green.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_green.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_green.Location = new System.Drawing.Point(351, 191);
            this.lab_green.Name = "lab_green";
            this.lab_green.Size = new System.Drawing.Size(61, 23);
            this.lab_green.TabIndex = 4;
            this.lab_green.Text = "GREEN";
            this.lab_green.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_blue
            // 
            this.lab_blue.AutoSize = true;
            this.lab_blue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lab_blue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lab_blue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_blue.Location = new System.Drawing.Point(351, 242);
            this.lab_blue.Name = "lab_blue";
            this.lab_blue.Size = new System.Drawing.Size(48, 23);
            this.lab_blue.TabIndex = 4;
            this.lab_blue.Text = "BLUE";
            this.lab_blue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lab_rgb
            // 
            this.lab_rgb.AutoSize = true;
            this.lab_rgb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_rgb.Location = new System.Drawing.Point(8, 314);
            this.lab_rgb.Name = "lab_rgb";
            this.lab_rgb.Size = new System.Drawing.Size(59, 21);
            this.lab_rgb.TabIndex = 4;
            this.lab_rgb.Text = "GREEN";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.track_red);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.track_green);
            this.groupBox1.Controls.Add(this.lab_rgb);
            this.groupBox1.Controls.Add(this.track_blue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lab_blue);
            this.groupBox1.Controls.Add(this.lab_red);
            this.groupBox1.Controls.Add(this.lab_green);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 410);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtHex);
            this.groupBox5.Controls.Add(this.btnHexCopy);
            this.groupBox5.Location = new System.Drawing.Point(248, 283);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(164, 109);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hexadecimal Colors";
            // 
            // txtHex
            // 
            this.txtHex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHex.Location = new System.Drawing.Point(6, 26);
            this.txtHex.Name = "txtHex";
            this.txtHex.Size = new System.Drawing.Size(152, 26);
            this.txtHex.TabIndex = 6;
            // 
            // btnHexCopy
            // 
            this.btnHexCopy.Location = new System.Drawing.Point(50, 72);
            this.btnHexCopy.Name = "btnHexCopy";
            this.btnHexCopy.Size = new System.Drawing.Size(47, 23);
            this.btnHexCopy.TabIndex = 5;
            this.btnHexCopy.Text = "Copy";
            this.btnHexCopy.UseVisualStyleBackColor = true;
            this.btnHexCopy.Click += new System.EventHandler(this.btnHexCopy_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(73, 283);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(164, 109);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RGB Colors";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "RED";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "GREEN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 21);
            this.label6.TabIndex = 4;
            this.label6.Text = "BLUE";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(182, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 100);
            this.panel1.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(22, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(131, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Show the current pixel";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(22, 190);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(178, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Show the current cursor position";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.magnifyingGlass1);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.checkBox1);
            this.groupBox2.Location = new System.Drawing.Point(455, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(345, 364);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Location = new System.Drawing.Point(22, 242);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 114);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Last selected color";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(112, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 74);
            this.panel2.TabIndex = 0;
            // 
            // magnifyingGlass1
            // 
            this.magnifyingGlass1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.magnifyingGlass1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.magnifyingGlass1.Location = new System.Drawing.Point(22, 22);
            this.magnifyingGlass1.Name = "magnifyingGlass1";
            this.magnifyingGlass1.PixelRange = 10;
            this.magnifyingGlass1.PixelSize = 5;
            this.magnifyingGlass1.PosAlign = System.Drawing.ContentAlignment.TopLeft;
            this.magnifyingGlass1.PosFormat = "#x ; #y";
            this.magnifyingGlass1.ShowPixel = true;
            this.magnifyingGlass1.ShowPosition = true;
            this.magnifyingGlass1.Size = new System.Drawing.Size(105, 105);
            this.magnifyingGlass1.TabIndex = 11;
            this.magnifyingGlass1.UseMovingGlass = true;
            this.magnifyingGlass1.DisplayUpdated += new DesktopColorPicker.MagnifyingGlass.DisplayUpdatedDelegate(this.magnifyingGlass1_DisplayUpdated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 529);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Deactivate += new System.EventHandler(this.GUI_Deactivate);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.track_red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.track_blue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion




        

            

       

        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TrackBar track_red;
        private System.Windows.Forms.TrackBar track_green;
        private System.Windows.Forms.TrackBar track_blue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lab_red;
        private System.Windows.Forms.Label lab_green;
        private System.Windows.Forms.Label lab_blue;
        private System.Windows.Forms.Label lab_rgb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private DesktopColorPicker.MagnifyingGlass magnifyingGlass1;
        private System.Windows.Forms.Button btnHexCopy;
        private System.Windows.Forms.TextBox txtHex;
    }
}

