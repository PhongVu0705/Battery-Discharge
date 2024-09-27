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
            voltageBar = new TrackBar();
            panel1 = new Panel();
            voltageLabel = new Label();
            label1 = new Label();
            panel2 = new Panel();
            ampereLabel = new Label();
            ampereBar = new TrackBar();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)voltageBar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ampereBar).BeginInit();
            panel3.SuspendLayout();
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
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(21, 209);
            panel3.Name = "panel3";
            panel3.Size = new Size(237, 390);
            panel3.TabIndex = 3;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 59);
            label3.Name = "label3";
            label3.Size = new Size(60, 20);
            label3.TabIndex = 2;
            label3.Text = "Voltage";
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
            // textBox1
            // 
            textBox1.Location = new Point(123, 56);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(68, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(123, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(68, 27);
            textBox2.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 652);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
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
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label5;
        private Label label3;
        private Label label2;
    }
}
