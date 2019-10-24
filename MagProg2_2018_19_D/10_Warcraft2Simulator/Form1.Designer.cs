namespace _10_Warcraft2Simulator
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
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.lblOrcs = new System.Windows.Forms.Label();
            this.lblHumans = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCanvas
            // 
            this.pbCanvas.Location = new System.Drawing.Point(1, 35);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(100, 50);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // lblOrcs
            // 
            this.lblOrcs.AutoSize = true;
            this.lblOrcs.Location = new System.Drawing.Point(12, 9);
            this.lblOrcs.Name = "lblOrcs";
            this.lblOrcs.Size = new System.Drawing.Size(41, 13);
            this.lblOrcs.TabIndex = 1;
            this.lblOrcs.Text = "Orcs: 0";
            // 
            // lblHumans
            // 
            this.lblHumans.AutoSize = true;
            this.lblHumans.Location = new System.Drawing.Point(260, 9);
            this.lblHumans.Name = "lblHumans";
            this.lblHumans.Size = new System.Drawing.Size(58, 13);
            this.lblHumans.TabIndex = 2;
            this.lblHumans.Text = "Humans: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 410);
            this.Controls.Add(this.lblHumans);
            this.Controls.Add(this.lblOrcs);
            this.Controls.Add(this.pbCanvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblOrcs;
        private System.Windows.Forms.Label lblHumans;
    }
}

