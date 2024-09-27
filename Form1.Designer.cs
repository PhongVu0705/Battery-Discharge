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
            label1 = new Label();
            voltageLabel = new Label();
            panel2 = new Panel();
            ampereLabel = new Label();
            ampereBar = new TrackBar();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)voltageBar).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ampereBar).BeginInit();
            SuspendLayout();
            // 
            // voltageBar
            // 
            voltageBar.Location = new Point(42, 37);
            voltageBar.Name = "voltageBar";
            voltageBar.Size = new Size(148, 56);
            voltageBar.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(voltageLabel);
            panel1.Controls.Add(voltageBar);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(21, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(237, 120);
            panel1.TabIndex = 1;
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
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(42, 84);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(107, 20);
            voltageLabel.TabIndex = 1;
            voltageLabel.Text = "Voltage Value: ";
            // 
            // panel2
            // 
            panel2.Controls.Add(ampereLabel);
            panel2.Controls.Add(ampereBar);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(302, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(237, 120);
            panel2.TabIndex = 2;
            // 
            // ampereLabel
            // 
            ampereLabel.AutoSize = true;
            ampereLabel.Location = new Point(42, 84);
            ampereLabel.Name = "ampereLabel";
            ampereLabel.Size = new Size(109, 20);
            ampereLabel.TabIndex = 1;
            ampereLabel.Text = "Ampere Value: ";
            // 
            // ampereBar
            // 
            ampereBar.Location = new Point(42, 37);
            ampereBar.Name = "ampereBar";
            ampereBar.Size = new Size(148, 56);
            ampereBar.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(978, 652);
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
    }
}
