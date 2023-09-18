
namespace ShopQuanAo
{
    partial class FrmThongKe
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.Bthongke = new System.Windows.Forms.Button();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dataGridVieTK = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieTK)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.Bthongke);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(29, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 64);
            this.panel2.TabIndex = 4;
            // 
            // Bthongke
            // 
            this.Bthongke.BackColor = System.Drawing.Color.Aqua;
            this.Bthongke.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bthongke.Location = new System.Drawing.Point(448, 12);
            this.Bthongke.Name = "Bthongke";
            this.Bthongke.Size = new System.Drawing.Size(120, 47);
            this.Bthongke.TabIndex = 1;
            this.Bthongke.Text = "Thống kê";
            this.Bthongke.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(217, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 0;
            // 
            // dataGridVieTK
            // 
            this.dataGridVieTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridVieTK.Location = new System.Drawing.Point(29, 82);
            this.dataGridVieTK.Name = "dataGridVieTK";
            this.dataGridVieTK.RowHeadersWidth = 51;
            this.dataGridVieTK.RowTemplate.Height = 24;
            this.dataGridVieTK.Size = new System.Drawing.Size(753, 356);
            this.dataGridVieTK.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ngày Đặt Hàng";
            // 
            // FrmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridVieTK);
            this.Name = "FrmThongKe";
            this.Text = "FrmThongKe";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridVieTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Bthongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dataGridVieTK;
        private System.Windows.Forms.Label label1;
    }
}