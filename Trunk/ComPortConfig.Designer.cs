namespace BeamSaver
{
    partial class ComPortConfig
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
            this.label1 = new System.Windows.Forms.Label();
            this.CB_ComPort = new System.Windows.Forms.ComboBox();
            this.btt_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Select Com Port of the rotor:";
            // 
            // CB_ComPort
            // 
            this.CB_ComPort.FormattingEnabled = true;
            this.CB_ComPort.Location = new System.Drawing.Point(226, 6);
            this.CB_ComPort.Name = "CB_ComPort";
            this.CB_ComPort.Size = new System.Drawing.Size(121, 21);
            this.CB_ComPort.TabIndex = 1;
            // 
            // btt_save
            // 
            this.btt_save.Location = new System.Drawing.Point(265, 78);
            this.btt_save.Name = "btt_save";
            this.btt_save.Size = new System.Drawing.Size(82, 28);
            this.btt_save.TabIndex = 2;
            this.btt_save.Text = "Save";
            this.btt_save.UseVisualStyleBackColor = true;
            this.btt_save.Click += new System.EventHandler(this.btt_save_Click);
            // 
            // ComPortConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 118);
            this.Controls.Add(this.btt_save);
            this.Controls.Add(this.CB_ComPort);
            this.Controls.Add(this.label1);
            this.Name = "ComPortConfig";
            this.Text = "ComPortConfig";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_ComPort;
        private System.Windows.Forms.Button btt_save;
    }
}