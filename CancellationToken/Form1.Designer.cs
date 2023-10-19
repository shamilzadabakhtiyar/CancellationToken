namespace CancellationTokenApp
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
            lbLogs = new ListBox();
            numericCheckTime = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnGettingData = new Button();
            btnCheckNow = new Button();
            ((System.ComponentModel.ISupportInitialize)numericCheckTime).BeginInit();
            SuspendLayout();
            // 
            // lbLogs
            // 
            lbLogs.Dock = DockStyle.Bottom;
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new Point(0, 356);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(800, 94);
            lbLogs.TabIndex = 0;
            // 
            // numericCheckTime
            // 
            numericCheckTime.Location = new Point(362, 104);
            numericCheckTime.Name = "numericCheckTime";
            numericCheckTime.Size = new Size(120, 23);
            numericCheckTime.TabIndex = 1;
            numericCheckTime.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 86);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 2;
            label2.Text = "Check time second";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(362, 148);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(120, 23);
            btnStart.TabIndex = 3;
            btnStart.Text = "Start app";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Location = new Point(362, 192);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(120, 23);
            btnStop.TabIndex = 4;
            btnStop.Text = "Stop app";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnGettingData
            // 
            btnGettingData.Location = new Point(488, 192);
            btnGettingData.Name = "btnGettingData";
            btnGettingData.Size = new Size(120, 23);
            btnGettingData.TabIndex = 5;
            btnGettingData.Text = "Stop getting data";
            btnGettingData.UseVisualStyleBackColor = true;
            btnGettingData.Click += btnGettingData_Click;
            // 
            // btnCheckNow
            // 
            btnCheckNow.Location = new Point(488, 148);
            btnCheckNow.Name = "btnCheckNow";
            btnCheckNow.Size = new Size(120, 23);
            btnCheckNow.TabIndex = 6;
            btnCheckNow.Text = "Check now";
            btnCheckNow.UseVisualStyleBackColor = true;
            btnCheckNow.Click += btnCheckNow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCheckNow);
            Controls.Add(btnGettingData);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericCheckTime);
            Controls.Add(lbLogs);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericCheckTime).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbLogs;
        private NumericUpDown numericCheckTime;
        private Label label1;
        private Label label2;
        private Button btnStart;
        private Button btnStop;
        private Button btnGettingData;
        private Button btnCheckNow;
    }
}