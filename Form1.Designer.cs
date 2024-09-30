namespace BatteryDischargeDemo2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            voltageBar = new TrackBar();
            panel1 = new Panel();
            voltageLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ampereLabel = new Label();
            ampereBar = new TrackBar();
            label4 = new Label();
            panel3 = new Panel();
            statusS1 = new TextBox();
            offS1 = new RadioButton();
            onS1 = new RadioButton();
            battery1 = new PictureBox();
            battery5 = new PictureBox();
            battery2 = new PictureBox();
            battery3 = new PictureBox();
            ampereS1 = new TextBox();
            voltageS1 = new TextBox();
            battery4 = new PictureBox();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            progressS1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)voltageBar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ampereBar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)battery1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battery5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battery2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battery3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)battery4).BeginInit();
            SuspendLayout();
            // 
            // voltageBar
            // 
            voltageBar.Location = new Point(42, 42);
            voltageBar.Name = "voltageBar";
            voltageBar.Size = new Size(148, 56);
            voltageBar.TabIndex = 0;
            voltageBar.Scroll += voltageBar_Scroll;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(voltageLabel);
            panel1.Controls.Add(voltageBar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 142);
            panel1.TabIndex = 1;
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(42, 101);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(107, 20);
            voltageLabel.TabIndex = 1;
            voltageLabel.Text = "Voltage Value: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 14);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 0;
            label1.Text = "Voltage Simulator";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(ampereLabel);
            panel2.Controls.Add(ampereBar);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(302, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 142);
            panel2.TabIndex = 2;
            // 
            // ampereLabel
            // 
            ampereLabel.AutoSize = true;
            ampereLabel.Location = new Point(42, 101);
            ampereLabel.Name = "ampereLabel";
            ampereLabel.Size = new Size(109, 20);
            ampereLabel.TabIndex = 1;
            ampereLabel.Text = "Ampere Value: ";
            // 
            // ampereBar
            // 
            ampereBar.Location = new Point(42, 42);
            ampereBar.Name = "ampereBar";
            ampereBar.Size = new Size(148, 56);
            ampereBar.TabIndex = 0;
            ampereBar.Scroll += ampereBar_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(52, 14);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 0;
            label4.Text = "Ampere Simulator";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(statusS1);
            panel3.Controls.Add(offS1);
            panel3.Controls.Add(onS1);
            panel3.Controls.Add(battery1);
            panel3.Controls.Add(battery5);
            panel3.Controls.Add(battery2);
            panel3.Controls.Add(battery3);
            panel3.Controls.Add(ampereS1);
            panel3.Controls.Add(voltageS1);
            panel3.Controls.Add(battery4);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(21, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 324);
            panel3.TabIndex = 3;
            // 
            // statusS1
            // 
            statusS1.BackColor = Color.White;
            statusS1.Location = new Point(52, 224);
            statusS1.Name = "statusS1";
            statusS1.Size = new Size(126, 27);
            statusS1.TabIndex = 6;
            statusS1.Text = "OFF";
            statusS1.TextAlign = HorizontalAlignment.Center;
            // 
            // offS1
            // 
            offS1.AutoSize = true;
            offS1.Location = new Point(123, 272);
            offS1.Name = "offS1";
            offS1.Size = new Size(55, 24);
            offS1.TabIndex = 11;
            offS1.TabStop = true;
            offS1.Text = "OFF";
            offS1.UseVisualStyleBackColor = true;
            offS1.CheckedChanged += offS1_CheckedChanged;
            // 
            // onS1
            // 
            onS1.AutoSize = true;
            onS1.Location = new Point(54, 272);
            onS1.Name = "onS1";
            onS1.Size = new Size(52, 24);
            onS1.TabIndex = 4;
            onS1.TabStop = true;
            onS1.Text = "ON";
            onS1.UseVisualStyleBackColor = true;
            onS1.CheckedChanged += onS1_CheckedChanged;
            // 
            // battery1
            // 
            battery1.Image = Properties.Resources.battery_5;
            battery1.Location = new Point(56, 145);
            battery1.Name = "battery1";
            battery1.Size = new Size(125, 62);
            battery1.SizeMode = PictureBoxSizeMode.StretchImage;
            battery1.TabIndex = 10;
            battery1.TabStop = false;
            // 
            // battery5
            // 
            battery5.Image = Properties.Resources.battery_1_full;
            battery5.Location = new Point(56, 145);
            battery5.Name = "battery5";
            battery5.Size = new Size(125, 62);
            battery5.SizeMode = PictureBoxSizeMode.StretchImage;
            battery5.TabIndex = 6;
            battery5.TabStop = false;
            // 
            // battery2
            // 
            battery2.Image = Properties.Resources.battery_4;
            battery2.Location = new Point(56, 145);
            battery2.Name = "battery2";
            battery2.Size = new Size(125, 62);
            battery2.SizeMode = PictureBoxSizeMode.StretchImage;
            battery2.TabIndex = 8;
            battery2.TabStop = false;
            // 
            // battery3
            // 
            battery3.Image = Properties.Resources.battery_3;
            battery3.Location = new Point(56, 145);
            battery3.Name = "battery3";
            battery3.Size = new Size(125, 62);
            battery3.SizeMode = PictureBoxSizeMode.StretchImage;
            battery3.TabIndex = 9;
            battery3.TabStop = false;
            // 
            // ampereS1
            // 
            ampereS1.Location = new Point(123, 98);
            ampereS1.Name = "ampereS1";
            ampereS1.Size = new Size(68, 27);
            ampereS1.TabIndex = 5;
            // 
            // voltageS1
            // 
            voltageS1.Location = new Point(123, 56);
            voltageS1.Name = "voltageS1";
            voltageS1.Size = new Size(68, 27);
            voltageS1.TabIndex = 4;
            // 
            // battery4
            // 
            battery4.Image = Properties.Resources.battery_2;
            battery4.Location = new Point(56, 145);
            battery4.Name = "battery4";
            battery4.Size = new Size(125, 62);
            battery4.SizeMode = PictureBoxSizeMode.StretchImage;
            battery4.TabIndex = 7;
            battery4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 101);
            label5.Name = "label5";
            label5.Size = new Size(62, 20);
            label5.TabIndex = 3;
            label5.Text = "Ampere";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 59);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Voltage";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(82, 17);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 1;
            label2.Text = "Station 1";
            // 
            // timer1
            // 
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // progressS1
            // 
            progressS1.Location = new Point(302, 375);
            progressS1.Maximum = 10;
            progressS1.Name = "progressS1";
            progressS1.Size = new Size(161, 29);
            progressS1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 652);
            Controls.Add(progressS1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)voltageBar).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ampereBar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)battery1).EndInit();
            ((System.ComponentModel.ISupportInitialize)battery5).EndInit();
            ((System.ComponentModel.ISupportInitialize)battery2).EndInit();
            ((System.ComponentModel.ISupportInitialize)battery3).EndInit();
            ((System.ComponentModel.ISupportInitialize)battery4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TrackBar voltageBar;
        private Panel panel1;
        private Label voltageLabel;
        private Label label1;
        private Panel panel2;
        private Label ampereLabel;
        private TrackBar ampereBar;
        private Label label4;
        private Panel panel3;
        private TextBox ampereS1;
        private TextBox voltageS1;
        private Label label5;
        private Label label3;
        private Label label2;
        private PictureBox battery5;
        private PictureBox battery4;
        private PictureBox battery2;
        private PictureBox battery3;
        private PictureBox battery1;
        private RadioButton onS1;
        private System.Windows.Forms.Timer timer1;
        private RadioButton offS1;
        private TextBox statusS1;
        private ProgressBar progressS1;
    }
}
