using System.Drawing.Imaging;

namespace BatteryDischargeDemo2
{
    public partial class Form1 : Form
    {
        int voltageValue, ampereValue;
        public Form1()
        {
            InitializeComponent();
        }

        private void voltageBar_Scroll(object sender, EventArgs e)
        {
            voltageValue = voltageBar.Value;
            voltageLabel.Text = "Voltage Value: " + voltageValue.ToString();
        }

        private void ampereBar_Scroll(object sender, EventArgs e)
        {
            ampereValue = ampereBar.Value;
            ampereLabel.Text = "Ampere Value: " + ampereValue.ToString();
        }
        
        private void batteryCheck()
        {
            if (voltageValue >= 8) batteryShow(5);
        }
        private void batteryShow(int parramNum) {
            switch (parramNum) {
                case 1: 
                    battery1.Visible = true;
                    battery2.Visible = false;
                    battery3.Visible = false;
                    battery4.Visible = false;
                    battery5.Visible = false;
                    break;
                case 2:
                    battery1.Visible = false;
                    battery2.Visible = true;
                    battery3.Visible = false;
                    battery4.Visible = false;
                    battery5.Visible = false;
                    break;
                case 3:
                    battery1.Visible = false;
                    battery2.Visible = false;
                    battery3.Visible = true;
                    battery4.Visible = false;
                    battery5.Visible = false;
                    break;
                case 4:
                    battery1.Visible = false;
                    battery2.Visible = false;
                    battery3.Visible = false;
                    battery4.Visible = true;
                    battery5.Visible = false;
                    break;
                case 5:
                    battery1.Visible = false;
                    battery2.Visible = false;
                    battery3.Visible = false;
                    battery4.Visible = false;
                    battery5.Visible = true;
                    break;
            }
        }
    }
}
