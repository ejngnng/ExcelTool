namespace PriceCalcu
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_FILE_PATH = new System.Windows.Forms.TextBox();
            this.BTN_FILE_EXPLOR = new System.Windows.Forms.Button();
            this.BTN_IMPORT = new System.Windows.Forms.Button();
            this.SourceDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 55);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(792, 392);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SourceDataGridView);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(784, 366);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "原始数据";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(784, 410);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(787, 42);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BTN_IMPORT);
            this.groupBox2.Controls.Add(this.BTN_FILE_EXPLOR);
            this.groupBox2.Controls.Add(this.TXT_FILE_PATH);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(7, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(771, 57);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原始文件：";
            // 
            // TXT_FILE_PATH
            // 
            this.TXT_FILE_PATH.Location = new System.Drawing.Point(98, 22);
            this.TXT_FILE_PATH.Name = "TXT_FILE_PATH";
            this.TXT_FILE_PATH.Size = new System.Drawing.Size(278, 21);
            this.TXT_FILE_PATH.TabIndex = 1;
            // 
            // BTN_FILE_EXPLOR
            // 
            this.BTN_FILE_EXPLOR.Location = new System.Drawing.Point(401, 17);
            this.BTN_FILE_EXPLOR.Name = "BTN_FILE_EXPLOR";
            this.BTN_FILE_EXPLOR.Size = new System.Drawing.Size(78, 28);
            this.BTN_FILE_EXPLOR.TabIndex = 2;
            this.BTN_FILE_EXPLOR.Text = "浏览";
            this.BTN_FILE_EXPLOR.UseVisualStyleBackColor = true;
            this.BTN_FILE_EXPLOR.Click += new System.EventHandler(this.BTN_FILE_EXPLOR_Click);
            // 
            // BTN_IMPORT
            // 
            this.BTN_IMPORT.Location = new System.Drawing.Point(507, 17);
            this.BTN_IMPORT.Name = "BTN_IMPORT";
            this.BTN_IMPORT.Size = new System.Drawing.Size(78, 28);
            this.BTN_IMPORT.TabIndex = 3;
            this.BTN_IMPORT.Text = "导入";
            this.BTN_IMPORT.UseVisualStyleBackColor = true;
            this.BTN_IMPORT.Click += new System.EventHandler(this.BTN_IMPORT_Click);
            // 
            // SourceDataGridView
            // 
            this.SourceDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SourceDataGridView.Location = new System.Drawing.Point(6, 76);
            this.SourceDataGridView.Name = "SourceDataGridView";
            this.SourceDataGridView.RowTemplate.Height = 23;
            this.SourceDataGridView.Size = new System.Drawing.Size(771, 277);
            this.SourceDataGridView.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SourceDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BTN_IMPORT;
        private System.Windows.Forms.Button BTN_FILE_EXPLOR;
        private System.Windows.Forms.TextBox TXT_FILE_PATH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView SourceDataGridView;
    }
}

