namespace _03_WinFormWarcraft
{
    partial class MainWindow
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.dgvOrcs = new System.Windows.Forms.DataGridView();
            this.btnAddOrc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcs)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(237, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Warcraft characters";
            // 
            // dgvOrcs
            // 
            this.dgvOrcs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrcs.Location = new System.Drawing.Point(18, 46);
            this.dgvOrcs.Name = "dgvOrcs";
            this.dgvOrcs.Size = new System.Drawing.Size(619, 288);
            this.dgvOrcs.TabIndex = 6;
            this.dgvOrcs.DoubleClick += new System.EventHandler(this.dgvOrcs_DoubleClick);
            // 
            // btnAddOrc
            // 
            this.btnAddOrc.Location = new System.Drawing.Point(644, 46);
            this.btnAddOrc.Name = "btnAddOrc";
            this.btnAddOrc.Size = new System.Drawing.Size(132, 32);
            this.btnAddOrc.TabIndex = 7;
            this.btnAddOrc.Text = "Add new Orc";
            this.btnAddOrc.UseVisualStyleBackColor = true;
            this.btnAddOrc.Click += new System.EventHandler(this.btnAddOrc_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(793, 346);
            this.Controls.Add(this.btnAddOrc);
            this.Controls.Add(this.dgvOrcs);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainWindow";
            this.Text = "Warcraft characters register";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrcs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvOrcs;
        private System.Windows.Forms.Button btnAddOrc;


    }
}

