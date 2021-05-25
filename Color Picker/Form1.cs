using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopColorPicker;




namespace Color_Picker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            magnifyingGlass1.UpdateTimer.Start();
            magnifyingGlass1.MovingGlass.MagnifyingGlass.Click += new EventHandler(MagnifyingGlass_Click);
            magnifyingGlass1.MovingGlass.VisibleChanged += new EventHandler(MovingGlass_VisibleChanged);
            magnifyingGlass1.MovingGlass.MagnifyingGlass.BeforeMakingScreenshot += new MagnifyingGlass.MakingScreenshotDelegate(MagnifyingGlass_BeforeMakingScreenshot);
            magnifyingGlass1.MovingGlass.MagnifyingGlass.AfterMakingScreenshot += new MagnifyingGlass.MakingScreenshotDelegate(MagnifyingGlass_AfterMakingScreenshot);
        }



        private void MovingGlass_VisibleChanged(object sender, EventArgs e)
        {
            // Make this not the top window if the moving glass is shown because it will hide the glass display otherwise
            TopMost = !magnifyingGlass1.MovingGlass.Visible;
        }

        private void MagnifyingGlass_Click(object sender, EventArgs e)
        {
            // Select the color trough the moving glass
            SelectColor();
        }

        private void magnifyingGlass1_DisplayUpdated(MagnifyingGlass sender)
        {
            // Update the current color preview panels background color
            panel1.BackColor = magnifyingGlass1.PixelColor;
        }


        private void GUI_Deactivate(object sender, EventArgs e)
        {
            // Select the current color if the form lost the focus
            if (!magnifyingGlass1.MovingGlass.Visible)
            {
                SelectColor();
            }
        }


        private void SelectColor()
        {
            // Show the selected color and properties
            panel2.BackColor = panel1.BackColor;
            label4.Text = "R: " + panel2.BackColor.R.ToString();
            label5.Text = "G: " + panel2.BackColor.G.ToString();
            label6.Text = "B: " + panel2.BackColor.B.ToString();

            txtHex.Text ="#"+ panel2.BackColor.R.ToString("X2") + panel2.BackColor.G.ToString("X2") + panel2.BackColor.B.ToString("X2");

            // Try to activate the form after selecting a color because we lost the focus for sure
            Activate();
        }
        /*
        private static String HexConverter(System.Drawing.Color c)
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
         * */



        private void MagnifyingGlass_AfterMakingScreenshot(object sender)
        {
            // Show this again after the screenshot has been taken
            Show();
        }

        private void MagnifyingGlass_BeforeMakingScreenshot(object sender)
        {
            // Hide this before the moving glass will take thescreenshot for working with it as screen image
            Hide();
        }














        private void timer1_Tick(object sender, EventArgs e)
        {

            


            //..........................
            panel5.BackColor = Color.FromArgb(track_red.Value,track_green.Value,track_blue.Value);
            
            lab_red.Text = track_red.Value.ToString();
            lab_green.Text = track_green.Value.ToString();
            lab_blue.Text = track_blue.Value.ToString();

            lab_rgb.Text = "rgb(" + track_red.Value.ToString() + "," + track_green.Value.ToString() + "," + track_blue.Value.ToString() + ")";

        }

        private void lab_hex_Click(object sender, EventArgs e)
        {
           // Color color = (Color)ColorConverter.ConvertFromString("#FFDFD991");

           // lab_rgb.Text = "HEX Value("+Color.;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // Troggle the pixel view
            magnifyingGlass1.ShowPixel = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            // Troggle the position view
            magnifyingGlass1.ShowPosition = checkBox2.Checked;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnHexCopy_Click(object sender, EventArgs e)
        {
           

            Clipboard.SetText(txtHex.Text);


        }





    }
}
