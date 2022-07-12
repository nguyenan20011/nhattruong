
namespace DoAn_QL_NhaHang
{
    partial class CongThucCheBien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CongThucCheBien));
            this.tableLayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.dataGrid_MonAn = new System.Windows.Forms.DataGridView();
            this.dataGrid_CongThuc = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CongThuc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutMain
            // 
            this.tableLayoutMain.ColumnCount = 3;
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.5F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tableLayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 535F));
            this.tableLayoutMain.Controls.Add(this.dataGrid_MonAn, 0, 0);
            this.tableLayoutMain.Controls.Add(this.dataGrid_CongThuc, 2, 0);
            this.tableLayoutMain.Controls.Add(this.label1, 1, 0);
            this.tableLayoutMain.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutMain.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutMain.Name = "tableLayoutMain";
            this.tableLayoutMain.RowCount = 3;
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 152F));
            this.tableLayoutMain.Size = new System.Drawing.Size(1343, 590);
            this.tableLayoutMain.TabIndex = 0;
            // 
            // dataGrid_MonAn
            // 
            this.dataGrid_MonAn.AllowUserToAddRows = false;
            this.dataGrid_MonAn.AllowUserToDeleteRows = false;
            this.dataGrid_MonAn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_MonAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_MonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_MonAn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_MonAn.Location = new System.Drawing.Point(3, 3);
            this.dataGrid_MonAn.MultiSelect = false;
            this.dataGrid_MonAn.Name = "dataGrid_MonAn";
            this.dataGrid_MonAn.ReadOnly = true;
            this.dataGrid_MonAn.RowHeadersWidth = 51;
            this.tableLayoutMain.SetRowSpan(this.dataGrid_MonAn, 3);
            this.dataGrid_MonAn.RowTemplate.Height = 24;
            this.dataGrid_MonAn.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_MonAn.Size = new System.Drawing.Size(499, 584);
            this.dataGrid_MonAn.TabIndex = 0;
            this.dataGrid_MonAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_MonAn_CellClick);
            // 
            // dataGrid_CongThuc
            // 
            this.dataGrid_CongThuc.AllowUserToAddRows = false;
            this.dataGrid_CongThuc.AllowUserToDeleteRows = false;
            this.dataGrid_CongThuc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGrid_CongThuc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid_CongThuc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_CongThuc.Location = new System.Drawing.Point(811, 3);
            this.dataGrid_CongThuc.MultiSelect = false;
            this.dataGrid_CongThuc.Name = "dataGrid_CongThuc";
            this.dataGrid_CongThuc.ReadOnly = true;
            this.dataGrid_CongThuc.RowHeadersWidth = 51;
            this.tableLayoutMain.SetRowSpan(this.dataGrid_CongThuc, 3);
            this.dataGrid_CongThuc.RowTemplate.Height = 24;
            this.dataGrid_CongThuc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_CongThuc.Size = new System.Drawing.Size(529, 584);
            this.dataGrid_CongThuc.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 219);
            this.label1.TabIndex = 2;
            this.label1.Text = "Công Thức Món ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CongThucCheBien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1367, 614);
            this.Controls.Add(this.tableLayoutMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CongThucCheBien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Công Thức Món Ăn";
            this.Load += new System.EventHandler(this.CongThucCheBien_Load);
            this.tableLayoutMain.ResumeLayout(false);
            this.tableLayoutMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_MonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_CongThuc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutMain;
        private System.Windows.Forms.DataGridView dataGrid_MonAn;
        private System.Windows.Forms.DataGridView dataGrid_CongThuc;
        private System.Windows.Forms.Label label1;
    }
}