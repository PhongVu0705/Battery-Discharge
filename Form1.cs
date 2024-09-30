using System.Drawing.Imaging;

namespace BatteryDischargeDemo2
{
    public partial class Form1 : Form
    {
        public int voltageValue, ampereValue;
        DischargeStation[] station = new DischargeStation[10];
        public Form1()
        {
            InitializeComponent();
            //batteryCheck();
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

        ////hien thi % pin
        //private void batteryCheck()
        //{
        //    if (voltageValue >= 8) batteryShow(5);
        //    else if (voltageValue >= 6) batteryShow(4);
        //    else if (voltageValue >= 4) batteryShow(3);
        //    else if (voltageValue >= 2) batteryShow(2);
        //    else batteryShow(1);
        //}
        //private void batteryShow(int parramNum)
        //{
        //    switch (parramNum)
        //    {
        //        case 1:
        //            battery1.Visible = true;
        //            battery2.Visible = false;
        //            battery3.Visible = false;
        //            battery4.Visible = false;
        //            battery5.Visible = false;
        //            break;
        //        case 2:
        //            battery1.Visible = false;
        //            battery2.Visible = true;
        //            battery3.Visible = false;
        //            battery4.Visible = false;
        //            battery5.Visible = false;
        //            break;
        //        case 3:
        //            battery1.Visible = false;
        //            battery2.Visible = false;
        //            battery3.Visible = true;
        //            battery4.Visible = false;
        //            battery5.Visible = false;
        //            break;
        //        case 4:
        //            battery1.Visible = false;
        //            battery2.Visible = false;
        //            battery3.Visible = false;
        //            battery4.Visible = true;
        //            battery5.Visible = false;
        //            break;
        //        case 5:
        //            battery1.Visible = false;
        //            battery2.Visible = false;
        //            battery3.Visible = false;
        //            battery4.Visible = false;
        //            battery5.Visible = true;
        //            break;
        //    }
        //}
        //hien thi thong tin cua pin
        private void onS1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Start();
        }
        //thoi gian lay may 10ms
        private void timer1_Tick(object sender, EventArgs e)
        {
            voltageS1.Text = voltageValue.ToString();
            ampereS1.Text = ampereValue.ToString();
            progressS1.Value = voltageValue;
            //batteryCheck();
            if(voltageValue >= 2)
            {
                statusS1.Text = "Discharging";
                statusS1.BackColor = Color.Red;
            }
            else if(voltageValue < 2)
            {
                statusS1.Text = "Finish";
                statusS1.BackColor = Color.Blue;
                statusS1.ForeColor = Color.White;
            }
        }
        //xu ly su kien nut tat
        private void offS1_CheckedChanged(object sender, EventArgs e)
        {
            batteryShow(1);
            voltageS1.Text = "0";
            ampereS1.Text = "0";
            progressS1.Value = 0;
            statusS1.Text = "OFF";
            statusS1.BackColor = Color.White;
            statusS1.ForeColor = Color.Black;
            timer1.Stop();
        }
    }
    public class DischargeStation
    {
        int status;
        int volt;
        int ampere;
    }
}
