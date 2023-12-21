namespace gownguru_rental_system
{
    partial class ucGown
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucGown));
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.txtPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDetails
            // 
            this.btnDetails.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDetails.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDetails.FlatAppearance.BorderSize = 0;
            this.btnDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetails.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetails.ForeColor = System.Drawing.Color.White;
            this.btnDetails.Location = new System.Drawing.Point(0, 199);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(153, 34);
            this.btnDetails.TabIndex = 7;
            this.btnDetails.Text = "Details";
            this.btnDetails.UseVisualStyleBackColor = false;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoSize = true;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(57, 165);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(36, 18);
            this.txtPrice.TabIndex = 6;
            this.txtPrice.Text = "0.00";
            this.txtPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(32, 149);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(87, 16);
            this.txtName.TabIndex = 5;
            this.txtName.Text = "Gown Name";
            this.txtName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPic
            // 
            this.txtPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPic.Image = ((System.Drawing.Image)(resources.GetObject("txtPic.Image")));
            this.txtPic.Location = new System.Drawing.Point(0, 0);
            this.txtPic.Margin = new System.Windows.Forms.Padding(4);
            this.txtPic.Name = "txtPic";
            this.txtPic.Size = new System.Drawing.Size(153, 145);
            this.txtPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.txtPic.TabIndex = 4;
            this.txtPic.TabStop = false;
            this.txtPic.Click += new System.EventHandler(this.txtPic_Click);
            // 
            // ucGown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPic);
            this.Name = "ucGown";
            this.Size = new System.Drawing.Size(153, 233);
            this.MouseEnter += new System.EventHandler(this.ucGown_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.ucGown_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.txtPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Label txtPrice;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.PictureBox txtPic;
    }
}
