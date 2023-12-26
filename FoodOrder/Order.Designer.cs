namespace FoodOrder
{
    partial class Order
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
            this.nmQuantity = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pctbDelete = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lbTotal = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // nmQuantity
            // 
            this.nmQuantity.BackColor = System.Drawing.Color.Transparent;
            this.nmQuantity.BorderColor = System.Drawing.Color.Tomato;
            this.nmQuantity.BorderRadius = 6;
            this.nmQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nmQuantity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nmQuantity.Location = new System.Drawing.Point(170, 38);
            this.nmQuantity.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.nmQuantity.Name = "nmQuantity";
            this.nmQuantity.ShadowDecoration.BorderRadius = 4;
            this.nmQuantity.Size = new System.Drawing.Size(75, 38);
            this.nmQuantity.TabIndex = 0;
            this.nmQuantity.UpDownButtonFillColor = System.Drawing.Color.Tomato;
            this.nmQuantity.ValueChanged += new System.EventHandler(this.nmQuantity_ValueChanged);
            // 
            // lbName
            // 
            this.lbName.AutoSize = false;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(42, 35);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(119, 67);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Bún bò Huế";
            // 
            // pctbDelete
            // 
            this.pctbDelete.Image = global::FoodOrder.Properties.Resources.bin;
            this.pctbDelete.ImageRotate = 0F;
            this.pctbDelete.Location = new System.Drawing.Point(6, 33);
            this.pctbDelete.Name = "pctbDelete";
            this.pctbDelete.Size = new System.Drawing.Size(30, 37);
            this.pctbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctbDelete.TabIndex = 3;
            this.pctbDelete.TabStop = false;
            this.pctbDelete.Click += new System.EventHandler(this.pctbDelete_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = false;
            this.lbTotal.BackColor = System.Drawing.Color.Transparent;
            this.lbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(252, 31);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(104, 46);
            this.lbTotal.TabIndex = 4;
            this.lbTotal.Text = "30.000 VNĐ";
            this.lbTotal.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(130)))), ((int)(((byte)(68)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(362, 26);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(155, 51);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Xác nhận";
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.pctbDelete);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.nmQuantity);
            this.Name = "Order";
            this.Size = new System.Drawing.Size(538, 108);
            ((System.ComponentModel.ISupportInitialize)(this.nmQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctbDelete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2NumericUpDown nmQuantity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbName;
        private Guna.UI2.WinForms.Guna2PictureBox pctbDelete;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTotal;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
    }
}
