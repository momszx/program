namespace _03_WinFormWarcraft
{
    partial class DisplayOrcForm
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNameData = new System.Windows.Forms.Label();
            this.lblHealthData = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblDeadData = new System.Windows.Forms.Label();
            this.lblDead = new System.Windows.Forms.Label();
            this.lblDamageData = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.pgProfilePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pgProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblNameData
            // 
            this.lblNameData.AutoSize = true;
            this.lblNameData.Location = new System.Drawing.Point(89, 9);
            this.lblNameData.Name = "lblNameData";
            this.lblNameData.Size = new System.Drawing.Size(101, 20);
            this.lblNameData.TabIndex = 1;
            this.lblNameData.Text = "lblNameData";
            // 
            // lblHealthData
            // 
            this.lblHealthData.AutoSize = true;
            this.lblHealthData.Location = new System.Drawing.Point(89, 40);
            this.lblHealthData.Name = "lblHealthData";
            this.lblHealthData.Size = new System.Drawing.Size(51, 20);
            this.lblHealthData.TabIndex = 3;
            this.lblHealthData.Text = "label1";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(12, 40);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(56, 20);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health";
            // 
            // lblDeadData
            // 
            this.lblDeadData.AutoSize = true;
            this.lblDeadData.Location = new System.Drawing.Point(89, 69);
            this.lblDeadData.Name = "lblDeadData";
            this.lblDeadData.Size = new System.Drawing.Size(51, 20);
            this.lblDeadData.TabIndex = 5;
            this.lblDeadData.Text = "label3";
            // 
            // lblDead
            // 
            this.lblDead.AutoSize = true;
            this.lblDead.Location = new System.Drawing.Point(12, 69);
            this.lblDead.Name = "lblDead";
            this.lblDead.Size = new System.Drawing.Size(48, 20);
            this.lblDead.TabIndex = 4;
            this.lblDead.Text = "Dead";
            // 
            // lblDamageData
            // 
            this.lblDamageData.AutoSize = true;
            this.lblDamageData.Location = new System.Drawing.Point(89, 98);
            this.lblDamageData.Name = "lblDamageData";
            this.lblDamageData.Size = new System.Drawing.Size(51, 20);
            this.lblDamageData.TabIndex = 7;
            this.lblDamageData.Text = "label5";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(12, 98);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(70, 20);
            this.lblDamage.TabIndex = 6;
            this.lblDamage.Text = "Damage";
            // 
            // pgProfilePicture
            // 
            this.pgProfilePicture.Location = new System.Drawing.Point(304, 9);
            this.pgProfilePicture.Name = "pgProfilePicture";
            this.pgProfilePicture.Size = new System.Drawing.Size(122, 109);
            this.pgProfilePicture.TabIndex = 8;
            this.pgProfilePicture.TabStop = false;
            // 
            // DisplayOrcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 132);
            this.Controls.Add(this.pgProfilePicture);
            this.Controls.Add(this.lblDamageData);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblDeadData);
            this.Controls.Add(this.lblDead);
            this.Controls.Add(this.lblHealthData);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblNameData);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayOrcForm";
            this.Text = "DisplayOrcForm";
            ((System.ComponentModel.ISupportInitialize)(this.pgProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNameData;
        private System.Windows.Forms.Label lblHealthData;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblDeadData;
        private System.Windows.Forms.Label lblDead;
        private System.Windows.Forms.Label lblDamageData;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.PictureBox pgProfilePicture;
    }
}