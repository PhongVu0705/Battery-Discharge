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
    }
}
