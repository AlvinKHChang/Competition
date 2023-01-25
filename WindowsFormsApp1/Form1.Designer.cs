
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tpg_setting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_匯入參賽者資料 = new System.Windows.Forms.Button();
            this.btn_刪除所有資料 = new System.Windows.Forms.Button();
            this.btn_初始化所有資料 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpg_setting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tpg_setting);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1405, 642);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tpg_setting
            // 
            this.tpg_setting.Controls.Add(this.tableLayoutPanel1);
            this.tpg_setting.Location = new System.Drawing.Point(4, 29);
            this.tpg_setting.Name = "tpg_setting";
            this.tpg_setting.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_setting.Size = new System.Drawing.Size(1405, 642);
            this.tpg_setting.TabIndex = 1;
            this.tpg_setting.Text = "設定";
            this.tpg_setting.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1399, 636);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_初始化所有資料);
            this.groupBox1.Controls.Add(this.btn_刪除所有資料);
            this.groupBox1.Controls.Add(this.btn_匯入參賽者資料);
            this.groupBox1.Location = new System.Drawing.Point(702, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btn_匯入參賽者資料
            // 
            this.btn_匯入參賽者資料.Location = new System.Drawing.Point(16, 29);
            this.btn_匯入參賽者資料.Name = "btn_匯入參賽者資料";
            this.btn_匯入參賽者資料.Size = new System.Drawing.Size(202, 55);
            this.btn_匯入參賽者資料.TabIndex = 0;
            this.btn_匯入參賽者資料.Text = "匯入參賽者資料";
            this.btn_匯入參賽者資料.UseVisualStyleBackColor = true;
            this.btn_匯入參賽者資料.Click += new System.EventHandler(this.btn_匯入參賽者資料_Click);
            // 
            // btn_刪除所有資料
            // 
            this.btn_刪除所有資料.Location = new System.Drawing.Point(16, 105);
            this.btn_刪除所有資料.Name = "btn_刪除所有資料";
            this.btn_刪除所有資料.Size = new System.Drawing.Size(202, 55);
            this.btn_刪除所有資料.TabIndex = 1;
            this.btn_刪除所有資料.Text = "刪除所有資料";
            this.btn_刪除所有資料.UseVisualStyleBackColor = true;
            this.btn_刪除所有資料.Click += new System.EventHandler(this.btn_刪除所有資料_Click);
            // 
            // btn_初始化所有資料
            // 
            this.btn_初始化所有資料.Location = new System.Drawing.Point(16, 183);
            this.btn_初始化所有資料.Name = "btn_初始化所有資料";
            this.btn_初始化所有資料.Size = new System.Drawing.Size(202, 55);
            this.btn_初始化所有資料.TabIndex = 2;
            this.btn_初始化所有資料.Text = "初始化所有資料";
            this.btn_初始化所有資料.UseVisualStyleBackColor = true;
            this.btn_初始化所有資料.Click += new System.EventHandler(this.btn_初始化所有資料_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1413, 675);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpg_setting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tpg_setting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_匯入參賽者資料;
        private System.Windows.Forms.Button btn_刪除所有資料;
        private System.Windows.Forms.Button btn_初始化所有資料;
    }
}

