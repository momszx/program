namespace _03_WinFormWarcraft
{
    partial class AddOrcForm
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblDamage = new System.Windows.Forms.Label();
            this.nudHealth = new System.Windows.Forms.NumericUpDown();
            this.nudDamage = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.tbImage = new System.Windows.Forms.TextBox();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(18, 18);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(89, 14);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(379, 26);
            this.tbName.TabIndex = 1;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(18, 54);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(56, 20);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health";
            // 
            // lblDamage
            // 
            this.lblDamage.AutoSize = true;
            this.lblDamage.Location = new System.Drawing.Point(18, 90);
            this.lblDamage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDamage.Name = "lblDamage";
            this.lblDamage.Size = new System.Drawing.Size(70, 20);
            this.lblDamage.TabIndex = 4;
            this.lblDamage.Text = "Damage";
            // 
            // nudHealth
            // 
            this.nudHealth.Location = new System.Drawing.Point(89, 52);
            this.nudHealth.Name = "nudHealth";
            this.nudHealth.Size = new System.Drawing.Size(66, 26);
            this.nudHealth.TabIndex = 5;
            this.nudHealth.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // nudDamage
            // 
            this.nudDamage.Location = new System.Drawing.Point(89, 88);
            this.nudDamage.Maximum = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.nudDamage.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nudDamage.Name = "nudDamage";
            this.nudDamage.Size = new System.Drawing.Size(66, 26);
            this.nudDamage.TabIndex = 6;
            this.nudDamage.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(22, 168);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 30);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(20, 125);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(54, 20);
            this.lblImage.TabIndex = 8;
            this.lblImage.Text = "Image";
            // 
            // tbImage
            // 
            this.tbImage.Enabled = false;
            this.tbImage.Location = new System.Drawing.Point(89, 125);
            this.tbImage.Name = "tbImage";
            this.tbImage.Size = new System.Drawing.Size(298, 26);
            this.tbImage.TabIndex = 9;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(393, 125);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 26);
            this.btnOpen.TabIndex = 10;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // AddOrcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 210);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.tbImage);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.nudDamage);
            this.Controls.Add(this.nudHealth);
            this.Controls.Add(this.lblDamage);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.lblName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddOrcForm";
            this.Text = "Add new Orc";
            ((System.ComponentModel.ISupportInitialize)(this.nudHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDamage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblDamage;
        private System.Windows.Forms.NumericUpDown nudHealth;
        private System.Windows.Forms.NumericUpDown nudDamage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox tbImage;
        private System.Windows.Forms.Button btnOpen;
    }
}