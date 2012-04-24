namespace BeamSaver
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
            this.lbl_WUID = new System.Windows.Forms.Label();
            this.txt_WUid = new System.Windows.Forms.TextBox();
            this.lbl_interval = new System.Windows.Forms.Label();
            this.txt_Interval = new System.Windows.Forms.TextBox();
            this.btt_startStop = new System.Windows.Forms.Button();
            this.lbl_MaxWind = new System.Windows.Forms.Label();
            this.txt_MaxWind = new System.Windows.Forms.TextBox();
            this.btt_ComPortConfig = new System.Windows.Forms.Button();
            this.tmrInterval = new System.Windows.Forms.Timer(this.components);
            this.CB_ComPort = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_WUID
            // 
            this.lbl_WUID.AutoSize = true;
            this.lbl_WUID.Location = new System.Drawing.Point(13, 11);
            this.lbl_WUID.Name = "lbl_WUID";
            this.lbl_WUID.Size = new System.Drawing.Size(312, 13);
            this.lbl_WUID.TabIndex = 0;
            this.lbl_WUID.Text = "Please enter the ID of the closest Weather Underground Station:\r\n";
            // 
            // txt_WUid
            // 
            this.txt_WUid.Location = new System.Drawing.Point(338, 8);
            this.txt_WUid.Name = "txt_WUid";
            this.txt_WUid.Size = new System.Drawing.Size(95, 20);
            this.txt_WUid.TabIndex = 1;
            // 
            // lbl_interval
            // 
            this.lbl_interval.AutoSize = true;
            this.lbl_interval.Location = new System.Drawing.Point(13, 50);
            this.lbl_interval.Name = "lbl_interval";
            this.lbl_interval.Size = new System.Drawing.Size(319, 13);
            this.lbl_interval.TabIndex = 2;
            this.lbl_interval.Text = "Please enter the Interval that you would like it to check in minutes:";
            // 
            // txt_Interval
            // 
            this.txt_Interval.Location = new System.Drawing.Point(338, 47);
            this.txt_Interval.Name = "txt_Interval";
            this.txt_Interval.Size = new System.Drawing.Size(95, 20);
            this.txt_Interval.TabIndex = 3;
            // 
            // btt_startStop
            // 
            this.btt_startStop.Location = new System.Drawing.Point(334, 201);
            this.btt_startStop.Name = "btt_startStop";
            this.btt_startStop.Size = new System.Drawing.Size(95, 30);
            this.btt_startStop.TabIndex = 90;
            this.btt_startStop.Text = "Start";
            this.btt_startStop.UseVisualStyleBackColor = true;
            this.btt_startStop.Click += new System.EventHandler(this.btt_startStop_Click);
            // 
            // lbl_MaxWind
            // 
            this.lbl_MaxWind.AutoSize = true;
            this.lbl_MaxWind.Location = new System.Drawing.Point(13, 81);
            this.lbl_MaxWind.Name = "lbl_MaxWind";
            this.lbl_MaxWind.Size = new System.Drawing.Size(175, 13);
            this.lbl_MaxWind.TabIndex = 5;
            this.lbl_MaxWind.Text = "Wind Speed to enable autorotation:\r\n";
            // 
            // txt_MaxWind
            // 
            this.txt_MaxWind.Location = new System.Drawing.Point(338, 78);
            this.txt_MaxWind.Name = "txt_MaxWind";
            this.txt_MaxWind.Size = new System.Drawing.Size(95, 20);
            this.txt_MaxWind.TabIndex = 4;
            // 
            // btt_ComPortConfig
            // 
            this.btt_ComPortConfig.Location = new System.Drawing.Point(12, 192);
            this.btt_ComPortConfig.Name = "btt_ComPortConfig";
            this.btt_ComPortConfig.Size = new System.Drawing.Size(97, 39);
            this.btt_ComPortConfig.TabIndex = 89;
            this.btt_ComPortConfig.Text = "Configure Com Port";
            this.btt_ComPortConfig.UseVisualStyleBackColor = true;
            this.btt_ComPortConfig.Visible = false;
            this.btt_ComPortConfig.Click += new System.EventHandler(this.btt_ComPortConfig_Click);
            // 
            // tmrInterval
            // 
            this.tmrInterval.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CB_ComPort
            // 
            this.CB_ComPort.FormattingEnabled = true;
            this.CB_ComPort.Location = new System.Drawing.Point(338, 109);
            this.CB_ComPort.Name = "CB_ComPort";
            this.CB_ComPort.Size = new System.Drawing.Size(95, 21);
            this.CB_ComPort.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Please Select Com Port of the rotor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 243);
            this.Controls.Add(this.CB_ComPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btt_ComPortConfig);
            this.Controls.Add(this.txt_MaxWind);
            this.Controls.Add(this.lbl_MaxWind);
            this.Controls.Add(this.btt_startStop);
            this.Controls.Add(this.txt_Interval);
            this.Controls.Add(this.lbl_interval);
            this.Controls.Add(this.txt_WUid);
            this.Controls.Add(this.lbl_WUID);
            this.Name = "Form1";
            this.Text = "Beam Saver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_WUID;
        private System.Windows.Forms.TextBox txt_WUid;
        private System.Windows.Forms.Label lbl_interval;
        private System.Windows.Forms.TextBox txt_Interval;
        private System.Windows.Forms.Button btt_startStop;
        private System.Windows.Forms.Label lbl_MaxWind;
        private System.Windows.Forms.TextBox txt_MaxWind;
        private System.Windows.Forms.Button btt_ComPortConfig;
        private System.Windows.Forms.Timer tmrInterval;
        private System.Windows.Forms.ComboBox CB_ComPort;
        private System.Windows.Forms.Label label1;
    }
}

