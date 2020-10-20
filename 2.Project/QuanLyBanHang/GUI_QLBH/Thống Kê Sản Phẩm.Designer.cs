namespace GUI_QLBH
{
    partial class Thống_Kê_Sản_Phẩm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_SPNK = new System.Windows.Forms.TabPage();
            this.Tab_spNhapkho = new System.Windows.Forms.TabControl();
            this.Tab_SPTK = new System.Windows.Forms.TabPage();
            this.data_SPNK = new System.Windows.Forms.DataGridView();
            this.data_SPTK = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.tab_SPNK.SuspendLayout();
            this.Tab_spNhapkho.SuspendLayout();
            this.Tab_SPTK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_SPNK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_SPTK)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Tab_spNhapkho);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(765, 425);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Sản Phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê";
            // 
            // tab_SPNK
            // 
            this.tab_SPNK.Controls.Add(this.data_SPNK);
            this.tab_SPNK.Location = new System.Drawing.Point(4, 25);
            this.tab_SPNK.Name = "tab_SPNK";
            this.tab_SPNK.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SPNK.Size = new System.Drawing.Size(657, 268);
            this.tab_SPNK.TabIndex = 1;
            this.tab_SPNK.Text = "Sản Phẩm Nhập Kho";
            this.tab_SPNK.UseVisualStyleBackColor = true;
            // 
            // Tab_spNhapkho
            // 
            this.Tab_spNhapkho.Controls.Add(this.tab_SPNK);
            this.Tab_spNhapkho.Controls.Add(this.Tab_SPTK);
            this.Tab_spNhapkho.Location = new System.Drawing.Point(51, 94);
            this.Tab_spNhapkho.Name = "Tab_spNhapkho";
            this.Tab_spNhapkho.SelectedIndex = 0;
            this.Tab_spNhapkho.Size = new System.Drawing.Size(665, 297);
            this.Tab_spNhapkho.TabIndex = 1;
            // 
            // Tab_SPTK
            // 
            this.Tab_SPTK.Controls.Add(this.data_SPTK);
            this.Tab_SPTK.Location = new System.Drawing.Point(4, 25);
            this.Tab_SPTK.Name = "Tab_SPTK";
            this.Tab_SPTK.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_SPTK.Size = new System.Drawing.Size(657, 268);
            this.Tab_SPTK.TabIndex = 2;
            this.Tab_SPTK.Text = "Sản Phẩm Tồn Kho";
            this.Tab_SPTK.UseVisualStyleBackColor = true;
            // 
            // data_SPNK
            // 
            this.data_SPNK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_SPNK.Location = new System.Drawing.Point(27, 0);
            this.data_SPNK.Name = "data_SPNK";
            this.data_SPNK.RowHeadersWidth = 51;
            this.data_SPNK.RowTemplate.Height = 24;
            this.data_SPNK.Size = new System.Drawing.Size(589, 212);
            this.data_SPNK.TabIndex = 0;
            // 
            // data_SPTK
            // 
            this.data_SPTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_SPTK.Location = new System.Drawing.Point(28, 0);
            this.data_SPTK.Name = "data_SPTK";
            this.data_SPTK.RowHeadersWidth = 51;
            this.data_SPTK.RowTemplate.Height = 24;
            this.data_SPTK.Size = new System.Drawing.Size(598, 218);
            this.data_SPTK.TabIndex = 0;
            // 
            // Thống_Kê_Sản_Phẩm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Thống_Kê_Sản_Phẩm";
            this.Text = "Thống_Kê_Sản_Phẩm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_SPNK.ResumeLayout(false);
            this.Tab_spNhapkho.ResumeLayout(false);
            this.Tab_SPTK.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_SPNK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data_SPTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Tab_spNhapkho;
        private System.Windows.Forms.TabPage tab_SPNK;
        private System.Windows.Forms.DataGridView data_SPNK;
        private System.Windows.Forms.TabPage Tab_SPTK;
        private System.Windows.Forms.DataGridView data_SPTK;
    }
}