namespace FormForSql.NhatForm
{
    partial class frmQuanLyKho
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
            this.dgvQuanLyKho = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKho)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvQuanLyKho
            // 
            this.dgvQuanLyKho.AllowUserToAddRows = false;
            this.dgvQuanLyKho.AllowUserToDeleteRows = false;
            this.dgvQuanLyKho.AllowUserToOrderColumns = true;
            this.dgvQuanLyKho.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuanLyKho.BackgroundColor = System.Drawing.Color.White;
            this.dgvQuanLyKho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyKho.Location = new System.Drawing.Point(25, 300);
            this.dgvQuanLyKho.Name = "dgvQuanLyKho";
            this.dgvQuanLyKho.ReadOnly = true;
            this.dgvQuanLyKho.RowHeadersWidth = 62;
            this.dgvQuanLyKho.RowTemplate.Height = 28;
            this.dgvQuanLyKho.Size = new System.Drawing.Size(1277, 503);
            this.dgvQuanLyKho.TabIndex = 0;
            this.dgvQuanLyKho.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuanLyKho_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(25, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 56);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Thêm mới";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(417, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(617, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 39);
            this.button3.TabIndex = 2;
            this.button3.Text = "Tìm Kiếm";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 8);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "Chỉnh Sửa";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(817, 10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 39);
            this.button5.TabIndex = 4;
            this.button5.Text = "Xuất file";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1328, 830);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvQuanLyKho);
            this.Name = "frmQuanLyKho";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmQuanLyKho_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyKho)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuanLyKho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
    }
}