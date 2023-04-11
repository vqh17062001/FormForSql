namespace FormForSql
{
    partial class FormforSQL
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
            this.dataGridViewfordata = new System.Windows.Forms.DataGridView();
            this.listBox_choose = new System.Windows.Forms.ListBox();
            this.button_add = new System.Windows.Forms.Button();
            this.button_set = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfordata)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewfordata
            // 
            this.dataGridViewfordata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewfordata.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewfordata.Name = "dataGridViewfordata";
            this.dataGridViewfordata.RowHeadersWidth = 62;
            this.dataGridViewfordata.RowTemplate.Height = 28;
            this.dataGridViewfordata.Size = new System.Drawing.Size(1001, 207);
            this.dataGridViewfordata.TabIndex = 1;
            // 
            // listBox_choose
            // 
            this.listBox_choose.FormattingEnabled = true;
            this.listBox_choose.ItemHeight = 20;
            this.listBox_choose.Items.AddRange(new object[] {
            "THUỐC",
            "NSX"});
            this.listBox_choose.Location = new System.Drawing.Point(43, 300);
            this.listBox_choose.Name = "listBox_choose";
            this.listBox_choose.Size = new System.Drawing.Size(102, 44);
            this.listBox_choose.TabIndex = 2;
            this.listBox_choose.SelectedIndexChanged += new System.EventHandler(this.listBox_choose_SelectedIndexChanged);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(43, 368);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 52);
            this.button_add.TabIndex = 3;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_set
            // 
            this.button_set.Location = new System.Drawing.Point(171, 368);
            this.button_set.Name = "button_set";
            this.button_set.Size = new System.Drawing.Size(75, 52);
            this.button_set.TabIndex = 4;
            this.button_set.Text = "sửa";
            this.button_set.UseVisualStyleBackColor = true;
            // 
            // button_delete
            // 
            this.button_delete.Location = new System.Drawing.Point(299, 362);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 76);
            this.button_delete.TabIndex = 5;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = true;
            // 
            // FormforSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_set);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.listBox_choose);
            this.Controls.Add(this.dataGridViewfordata);
            this.Name = "FormforSQL";
            this.Text = "SQL_data";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewfordata)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label data_label;
        private System.Windows.Forms.DataGridView dataGridViewfordata;
        private System.Windows.Forms.ListBox listBox_choose;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_set;
        private System.Windows.Forms.Button button_delete;
    }
}

