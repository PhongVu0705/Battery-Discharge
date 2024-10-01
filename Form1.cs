using System.Drawing.Imaging;

namespace BatteryDischargeDemo2
{
    public partial class Form1 : Form
    {
        public class DischargeStation
        {
            public int volt;
            public int ampere;
        }

        public int voltageValue, ampereValue;
        DischargeStation[] station = new DischargeStation[10];
        public Form1()
        {
            InitializeComponent();
            //khoi tao tram
            for (int i = 0; i < 10; i++) { 
                station[i] = new DischargeStation();
            }
        }
        //mo phong nguon vao
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

        //hien thi thong tin cua pin
        private void onS1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }
        ////thoi gian lay may 10ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            //lay gia tri dau vao
            station[1].volt = voltageValue;
            station[1].ampere = ampereValue;
            //hien thi
            voltageS1.Text = station[1].volt.ToString();
            ampereS1.Text = station[1].ampere.ToString();
            progressS1.Value = station[1].volt;
            if (station[1].volt >= 2)
            {
                statusS1.Text = "Discharging";
                statusS1.BackColor = Color.Red;
            }
            else if (station[1].volt < 2)
            {
                statusS1.Text = "Finish";
                statusS1.BackColor = Color.Blue;
                statusS1.ForeColor = Color.White;
            }
        }
        //xu ly su kien nut tat
        private void offS1_CheckedChanged(object sender, EventArgs e)
        {
            voltageS1.Text = "0";
            ampereS1.Text = "0";
            progressS1.Value = 0;
            statusS1.Text = "OFF";
            statusS1.BackColor = Color.White;
            statusS1.ForeColor = Color.Black;
            timer1.Stop();
        }
    }
}