
namespace EnalogClock
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mintueBox4 = new System.Windows.Forms.PictureBox();
            this.hourBox = new System.Windows.Forms.PictureBox();
            this.secondBox2 = new System.Windows.Forms.PictureBox();
            this.ClockBox1 = new System.Windows.Forms.PictureBox();
            this.EnalogClock = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mintueBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::EnalogClock.Properties.Resources.YouTube_Profile_Image;
            this.panel1.Controls.Add(this.mintueBox4);
            this.panel1.Controls.Add(this.hourBox);
            this.panel1.Controls.Add(this.secondBox2);
            this.panel1.Controls.Add(this.ClockBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 676);
            this.panel1.TabIndex = 0;
            // 
            // mintueBox4
            // 
            this.mintueBox4.BackColor = System.Drawing.Color.Transparent;
            this.mintueBox4.Image = global::EnalogClock.Properties.Resources.second;
            this.mintueBox4.Location = new System.Drawing.Point(334, 512);
            this.mintueBox4.Name = "mintueBox4";
            this.mintueBox4.Size = new System.Drawing.Size(249, 220);
            this.mintueBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.mintueBox4.TabIndex = 3;
            this.mintueBox4.TabStop = false;
            // 
            // hourBox
            // 
            this.hourBox.BackColor = System.Drawing.Color.Transparent;
            this.hourBox.Image = global::EnalogClock.Properties.Resources.hour;
            this.hourBox.Location = new System.Drawing.Point(506, 387);
            this.hourBox.Name = "hourBox";
            this.hourBox.Size = new System.Drawing.Size(260, 249);
            this.hourBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourBox.TabIndex = 2;
            this.hourBox.TabStop = false;
            // 
            // secondBox2
            // 
            this.secondBox2.BackColor = System.Drawing.Color.Transparent;
            this.secondBox2.Image = global::EnalogClock.Properties.Resources.second;
            this.secondBox2.Location = new System.Drawing.Point(406, 302);
            this.secondBox2.Name = "secondBox2";
            this.secondBox2.Size = new System.Drawing.Size(317, 271);
            this.secondBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondBox2.TabIndex = 1;
            this.secondBox2.TabStop = false;
            // 
            // ClockBox1
            // 
            this.ClockBox1.BackColor = System.Drawing.Color.Transparent;
            this.ClockBox1.Image = global::EnalogClock.Properties.Resources.Clock;
            this.ClockBox1.Location = new System.Drawing.Point(158, 93);
            this.ClockBox1.Name = "ClockBox1";
            this.ClockBox1.Size = new System.Drawing.Size(602, 510);
            this.ClockBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClockBox1.TabIndex = 0;
            this.ClockBox1.TabStop = false;
            // 
            // EnalogClock
            // 
            this.EnalogClock.Enabled = true;
            this.EnalogClock.Interval = 1000;
            this.EnalogClock.Tick += new System.EventHandler(this.timerClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 669);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Enalog Clock";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mintueBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClockBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox mintueBox4;
        private System.Windows.Forms.PictureBox hourBox;
        private System.Windows.Forms.PictureBox secondBox2;
        private System.Windows.Forms.PictureBox ClockBox1;
        private System.Windows.Forms.Timer EnalogClock;
    }
}

