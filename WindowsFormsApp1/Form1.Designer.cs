
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpg_統計 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgv_統計表 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_更新統計表 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbx_統計表選擇比賽 = new System.Windows.Forms.ComboBox();
            this.tpg_報到作業 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_報到作業選擇分組 = new System.Windows.Forms.ComboBox();
            this.chk_報到作業選擇分組 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbx_報到作業選擇比賽 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_匯出參賽證 = new System.Windows.Forms.Button();
            this.btn_報到作業重置狀態 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_報到作業清除紀錄 = new System.Windows.Forms.Button();
            this.btn_報到作業本機記錄 = new System.Windows.Forms.Button();
            this.txt_報到作業圖紙編號 = new System.Windows.Forms.TextBox();
            this.txt_報到作業參賽編號 = new System.Windows.Forms.TextBox();
            this.rtb_報到作業參賽資料 = new System.Windows.Forms.RichTextBox();
            this.dgv_報到作業紀錄 = new System.Windows.Forms.DataGridView();
            this.tpg_指導老師 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_老師公告單 = new System.Windows.Forms.Button();
            this.btn_老師領獎單 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_指導老師報到人數 = new System.Windows.Forms.TextBox();
            this.txt_指導老師報名人數 = new System.Windows.Forms.TextBox();
            this.btn_指導老師更新 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_指導老師選擇比賽 = new System.Windows.Forms.ComboBox();
            this.dgv_指導老師 = new System.Windows.Forms.DataGridView();
            this.tpg_排名作業 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_排名作業更新 = new System.Windows.Forms.Button();
            this.lbl_排名作業人數 = new System.Windows.Forms.Label();
            this.cbx_排名作業名次 = new System.Windows.Forms.ComboBox();
            this.cbx_排名作業分組 = new System.Windows.Forms.ComboBox();
            this.cbx_排名作業選擇比賽 = new System.Windows.Forms.ComboBox();
            this.dgv_排名作業統計 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_排名作業圖紙編號 = new System.Windows.Forms.TextBox();
            this.txt_排名作業參賽編號 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chk_Unlock = new System.Windows.Forms.CheckBox();
            this.btn_Reset排名作業圖紙編號 = new System.Windows.Forms.Button();
            this.btn_Reset排名作業參賽編號 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_Reset排名作業圖紙編號 = new System.Windows.Forms.TextBox();
            this.txt_Reset排名作業參賽編號 = new System.Windows.Forms.TextBox();
            this.tpg_成績統計 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk_成績不分組 = new System.Windows.Forms.CheckBox();
            this.btn_成績更新 = new System.Windows.Forms.Button();
            this.cbx_成績分組 = new System.Windows.Forms.ComboBox();
            this.cbx_成績比賽 = new System.Windows.Forms.ComboBox();
            this.gbx_獎狀 = new System.Windows.Forms.GroupBox();
            this.btn_領獎公告 = new System.Windows.Forms.Button();
            this.btn_領獎單 = new System.Windows.Forms.Button();
            this.btn_國際組英文 = new System.Windows.Forms.Button();
            this.btn_國際組中文 = new System.Windows.Forms.Button();
            this.btn_天文宮 = new System.Windows.Forms.Button();
            this.btn_市政府獎狀 = new System.Windows.Forms.Button();
            this.dgv_成績統計 = new System.Windows.Forms.DataGridView();
            this.tpg_setting = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_初始化所有資料 = new System.Windows.Forms.Button();
            this.btn_刪除所有資料 = new System.Windows.Forms.Button();
            this.btn_匯入參賽者資料 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_英文獎狀測試 = new System.Windows.Forms.Button();
            this.btn_天文宮獎狀測試 = new System.Windows.Forms.Button();
            this.btn_市政府獎狀測試 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ServerIp = new System.Windows.Forms.TextBox();
            this.btn_清除報到輸入 = new System.Windows.Forms.Button();
            this.btn_排名欄位清除 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_測試連線 = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.bs_System = new System.Windows.Forms.BindingSource(this.components);
            this.btn_Load = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpg_統計.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_統計表)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tpg_報到作業.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_報到作業紀錄)).BeginInit();
            this.tpg_指導老師.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_指導老師)).BeginInit();
            this.tpg_排名作業.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_排名作業統計)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.tpg_成績統計.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbx_獎狀.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_成績統計)).BeginInit();
            this.tpg_setting.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_System)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpg_統計);
            this.tabControl1.Controls.Add(this.tpg_報到作業);
            this.tabControl1.Controls.Add(this.tpg_指導老師);
            this.tabControl1.Controls.Add(this.tpg_排名作業);
            this.tabControl1.Controls.Add(this.tpg_成績統計);
            this.tabControl1.Controls.Add(this.tpg_setting);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1413, 675);
            this.tabControl1.TabIndex = 0;
            // 
            // tpg_統計
            // 
            this.tpg_統計.Controls.Add(this.tableLayoutPanel2);
            this.tpg_統計.Location = new System.Drawing.Point(4, 29);
            this.tpg_統計.Name = "tpg_統計";
            this.tpg_統計.Padding = new System.Windows.Forms.Padding(3);
            this.tpg_統計.Size = new System.Drawing.Size(1405, 642);
            this.tpg_統計.TabIndex = 0;
            this.tpg_統計.Text = "統計";
            this.tpg_統計.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.dgv_統計表, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1399, 636);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dgv_統計表
            // 
            this.dgv_統計表.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_統計表.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_統計表.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_統計表.Enabled = false;
            this.dgv_統計表.Location = new System.Drawing.Point(3, 98);
            this.dgv_統計表.Name = "dgv_統計表";
            this.dgv_統計表.RowTemplate.Height = 24;
            this.dgv_統計表.Size = new System.Drawing.Size(1393, 535);
            this.dgv_統計表.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_更新統計表);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbx_統計表選擇比賽);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(586, 85);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // btn_更新統計表
            // 
            this.btn_更新統計表.Location = new System.Drawing.Point(253, 30);
            this.btn_更新統計表.Name = "btn_更新統計表";
            this.btn_更新統計表.Size = new System.Drawing.Size(75, 33);
            this.btn_更新統計表.TabIndex = 2;
            this.btn_更新統計表.Text = "更新統計表";
            this.btn_更新統計表.UseVisualStyleBackColor = true;
            this.btn_更新統計表.Click += new System.EventHandler(this.btn_更新統計表_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "比賽";
            // 
            // cbx_統計表選擇比賽
            // 
            this.cbx_統計表選擇比賽.FormattingEnabled = true;
            this.cbx_統計表選擇比賽.Location = new System.Drawing.Point(81, 29);
            this.cbx_統計表選擇比賽.Name = "cbx_統計表選擇比賽";
            this.cbx_統計表選擇比賽.Size = new System.Drawing.Size(128, 27);
            this.cbx_統計表選擇比賽.TabIndex = 0;
            this.cbx_統計表選擇比賽.SelectedIndexChanged += new System.EventHandler(this.cbx_統計表選擇比賽_SelectedIndexChanged);
            // 
            // tpg_報到作業
            // 
            this.tpg_報到作業.Controls.Add(this.tableLayoutPanel3);
            this.tpg_報到作業.Location = new System.Drawing.Point(4, 29);
            this.tpg_報到作業.Name = "tpg_報到作業";
            this.tpg_報到作業.Size = new System.Drawing.Size(1405, 642);
            this.tpg_報到作業.TabIndex = 2;
            this.tpg_報到作業.Text = "報到作業";
            this.tpg_報到作業.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.87189F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.12811F));
            this.tableLayoutPanel3.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rtb_報到作業參賽資料, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.dgv_報到作業紀錄, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1405, 642);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbx_報到作業選擇分組);
            this.panel1.Controls.Add(this.chk_報到作業選擇分組);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbx_報到作業選擇比賽);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 101);
            this.panel1.TabIndex = 0;
            // 
            // cbx_報到作業選擇分組
            // 
            this.cbx_報到作業選擇分組.FormattingEnabled = true;
            this.cbx_報到作業選擇分組.Location = new System.Drawing.Point(95, 52);
            this.cbx_報到作業選擇分組.Name = "cbx_報到作業選擇分組";
            this.cbx_報到作業選擇分組.Size = new System.Drawing.Size(128, 27);
            this.cbx_報到作業選擇分組.TabIndex = 5;
            // 
            // chk_報到作業選擇分組
            // 
            this.chk_報到作業選擇分組.AutoSize = true;
            this.chk_報到作業選擇分組.Location = new System.Drawing.Point(9, 56);
            this.chk_報到作業選擇分組.Name = "chk_報到作業選擇分組";
            this.chk_報到作業選擇分組.Size = new System.Drawing.Size(68, 23);
            this.chk_報到作業選擇分組.TabIndex = 4;
            this.chk_報到作業選擇分組.Text = "分組";
            this.chk_報到作業選擇分組.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "比賽";
            // 
            // cbx_報到作業選擇比賽
            // 
            this.cbx_報到作業選擇比賽.FormattingEnabled = true;
            this.cbx_報到作業選擇比賽.Location = new System.Drawing.Point(95, 11);
            this.cbx_報到作業選擇比賽.Name = "cbx_報到作業選擇比賽";
            this.cbx_報到作業選擇比賽.Size = new System.Drawing.Size(128, 27);
            this.cbx_報到作業選擇比賽.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_清除報到輸入);
            this.panel2.Controls.Add(this.btn_匯出參賽證);
            this.panel2.Controls.Add(this.btn_報到作業重置狀態);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btn_報到作業清除紀錄);
            this.panel2.Controls.Add(this.btn_報到作業本機記錄);
            this.panel2.Controls.Add(this.txt_報到作業圖紙編號);
            this.panel2.Controls.Add(this.txt_報到作業參賽編號);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(507, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(895, 101);
            this.panel2.TabIndex = 1;
            // 
            // btn_匯出參賽證
            // 
            this.btn_匯出參賽證.Location = new System.Drawing.Point(473, 9);
            this.btn_匯出參賽證.Name = "btn_匯出參賽證";
            this.btn_匯出參賽證.Size = new System.Drawing.Size(132, 33);
            this.btn_匯出參賽證.TabIndex = 7;
            this.btn_匯出參賽證.Text = "參賽證";
            this.btn_匯出參賽證.UseVisualStyleBackColor = true;
            this.btn_匯出參賽證.Click += new System.EventHandler(this.btn_匯出參賽證_Click);
            // 
            // btn_報到作業重置狀態
            // 
            this.btn_報到作業重置狀態.Location = new System.Drawing.Point(749, 8);
            this.btn_報到作業重置狀態.Name = "btn_報到作業重置狀態";
            this.btn_報到作業重置狀態.Size = new System.Drawing.Size(132, 37);
            this.btn_報到作業重置狀態.TabIndex = 6;
            this.btn_報到作業重置狀態.Text = "重置狀態";
            this.btn_報到作業重置狀態.UseVisualStyleBackColor = true;
            this.btn_報到作業重置狀態.Click += new System.EventHandler(this.btn_報到作業重置狀態_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "圖紙編號";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "參賽編號";
            // 
            // btn_報到作業清除紀錄
            // 
            this.btn_報到作業清除紀錄.Location = new System.Drawing.Point(611, 48);
            this.btn_報到作業清除紀錄.Name = "btn_報到作業清除紀錄";
            this.btn_報到作業清除紀錄.Size = new System.Drawing.Size(132, 42);
            this.btn_報到作業清除紀錄.TabIndex = 3;
            this.btn_報到作業清除紀錄.Text = "清除紀錄";
            this.btn_報到作業清除紀錄.UseVisualStyleBackColor = true;
            this.btn_報到作業清除紀錄.Click += new System.EventHandler(this.btn_報到作業清除紀錄_Click);
            // 
            // btn_報到作業本機記錄
            // 
            this.btn_報到作業本機記錄.Location = new System.Drawing.Point(611, 11);
            this.btn_報到作業本機記錄.Name = "btn_報到作業本機記錄";
            this.btn_報到作業本機記錄.Size = new System.Drawing.Size(132, 33);
            this.btn_報到作業本機記錄.TabIndex = 2;
            this.btn_報到作業本機記錄.Text = "本機記錄";
            this.btn_報到作業本機記錄.UseVisualStyleBackColor = true;
            this.btn_報到作業本機記錄.Click += new System.EventHandler(this.btn_報到作業本機記錄_Click);
            // 
            // txt_報到作業圖紙編號
            // 
            this.txt_報到作業圖紙編號.Location = new System.Drawing.Point(126, 57);
            this.txt_報到作業圖紙編號.Name = "txt_報到作業圖紙編號";
            this.txt_報到作業圖紙編號.Size = new System.Drawing.Size(155, 30);
            this.txt_報到作業圖紙編號.TabIndex = 1;
            this.txt_報到作業圖紙編號.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_報到作業圖紙編號_KeyDown);
            // 
            // txt_報到作業參賽編號
            // 
            this.txt_報到作業參賽編號.Location = new System.Drawing.Point(126, 16);
            this.txt_報到作業參賽編號.Name = "txt_報到作業參賽編號";
            this.txt_報到作業參賽編號.Size = new System.Drawing.Size(155, 30);
            this.txt_報到作業參賽編號.TabIndex = 0;
            this.txt_報到作業參賽編號.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_報到作業參賽編號_KeyDown);
            // 
            // rtb_報到作業參賽資料
            // 
            this.rtb_報到作業參賽資料.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_報到作業參賽資料.Location = new System.Drawing.Point(3, 110);
            this.rtb_報到作業參賽資料.Name = "rtb_報到作業參賽資料";
            this.rtb_報到作業參賽資料.Size = new System.Drawing.Size(498, 529);
            this.rtb_報到作業參賽資料.TabIndex = 2;
            this.rtb_報到作業參賽資料.Text = "";
            // 
            // dgv_報到作業紀錄
            // 
            this.dgv_報到作業紀錄.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_報到作業紀錄.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_報到作業紀錄.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_報到作業紀錄.Location = new System.Drawing.Point(507, 110);
            this.dgv_報到作業紀錄.Name = "dgv_報到作業紀錄";
            this.dgv_報到作業紀錄.ReadOnly = true;
            this.dgv_報到作業紀錄.RowTemplate.Height = 24;
            this.dgv_報到作業紀錄.Size = new System.Drawing.Size(895, 529);
            this.dgv_報到作業紀錄.TabIndex = 3;
            // 
            // tpg_指導老師
            // 
            this.tpg_指導老師.Controls.Add(this.tableLayoutPanel4);
            this.tpg_指導老師.Location = new System.Drawing.Point(4, 29);
            this.tpg_指導老師.Name = "tpg_指導老師";
            this.tpg_指導老師.Size = new System.Drawing.Size(1405, 642);
            this.tpg_指導老師.TabIndex = 3;
            this.tpg_指導老師.Text = "指導老師";
            this.tpg_指導老師.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dgv_指導老師, 0, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.73209F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.26791F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1405, 642);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btn_老師公告單);
            this.panel3.Controls.Add(this.btn_老師領獎單);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.txt_指導老師報到人數);
            this.panel3.Controls.Add(this.txt_指導老師報名人數);
            this.panel3.Controls.Add(this.btn_指導老師更新);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.cbx_指導老師選擇比賽);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1399, 95);
            this.panel3.TabIndex = 0;
            // 
            // btn_老師公告單
            // 
            this.btn_老師公告單.Location = new System.Drawing.Point(985, 8);
            this.btn_老師公告單.Name = "btn_老師公告單";
            this.btn_老師公告單.Size = new System.Drawing.Size(120, 33);
            this.btn_老師公告單.TabIndex = 15;
            this.btn_老師公告單.Text = "老師公告單";
            this.btn_老師公告單.UseVisualStyleBackColor = true;
            this.btn_老師公告單.Click += new System.EventHandler(this.btn_老師公告單_Click);
            // 
            // btn_老師領獎單
            // 
            this.btn_老師領獎單.Location = new System.Drawing.Point(848, 9);
            this.btn_老師領獎單.Name = "btn_老師領獎單";
            this.btn_老師領獎單.Size = new System.Drawing.Size(120, 33);
            this.btn_老師領獎單.TabIndex = 14;
            this.btn_老師領獎單.Text = "老師領獎單";
            this.btn_老師領獎單.UseVisualStyleBackColor = true;
            this.btn_老師領獎單.Click += new System.EventHandler(this.btn_老師領獎單_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "報到人數";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(206, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 19);
            this.label6.TabIndex = 11;
            this.label6.Text = "報名人數";
            // 
            // txt_指導老師報到人數
            // 
            this.txt_指導老師報到人數.Location = new System.Drawing.Point(553, 12);
            this.txt_指導老師報到人數.Name = "txt_指導老師報到人數";
            this.txt_指導老師報到人數.Size = new System.Drawing.Size(155, 30);
            this.txt_指導老師報到人數.TabIndex = 10;
            this.txt_指導老師報到人數.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_指導老師報到人數_KeyDown);
            // 
            // txt_指導老師報名人數
            // 
            this.txt_指導老師報名人數.Location = new System.Drawing.Point(301, 12);
            this.txt_指導老師報名人數.Name = "txt_指導老師報名人數";
            this.txt_指導老師報名人數.Size = new System.Drawing.Size(155, 30);
            this.txt_指導老師報名人數.TabIndex = 9;
            this.txt_指導老師報名人數.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_指導老師報名人數_KeyDown);
            // 
            // btn_指導老師更新
            // 
            this.btn_指導老師更新.Location = new System.Drawing.Point(756, 9);
            this.btn_指導老師更新.Name = "btn_指導老師更新";
            this.btn_指導老師更新.Size = new System.Drawing.Size(75, 33);
            this.btn_指導老師更新.TabIndex = 8;
            this.btn_指導老師更新.Text = "更新統計表";
            this.btn_指導老師更新.UseVisualStyleBackColor = true;
            this.btn_指導老師更新.Click += new System.EventHandler(this.btn_指導老師更新_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 7;
            this.label5.Text = "比賽";
            // 
            // cbx_指導老師選擇比賽
            // 
            this.cbx_指導老師選擇比賽.FormattingEnabled = true;
            this.cbx_指導老師選擇比賽.Location = new System.Drawing.Point(65, 12);
            this.cbx_指導老師選擇比賽.Name = "cbx_指導老師選擇比賽";
            this.cbx_指導老師選擇比賽.Size = new System.Drawing.Size(128, 27);
            this.cbx_指導老師選擇比賽.TabIndex = 6;
            this.cbx_指導老師選擇比賽.SelectedIndexChanged += new System.EventHandler(this.cbx_指導老師選擇比賽_SelectedIndexChanged);
            // 
            // dgv_指導老師
            // 
            this.dgv_指導老師.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_指導老師.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_指導老師.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_指導老師.Location = new System.Drawing.Point(3, 104);
            this.dgv_指導老師.Name = "dgv_指導老師";
            this.dgv_指導老師.RowTemplate.Height = 24;
            this.dgv_指導老師.Size = new System.Drawing.Size(1399, 535);
            this.dgv_指導老師.TabIndex = 1;
            // 
            // tpg_排名作業
            // 
            this.tpg_排名作業.Controls.Add(this.tableLayoutPanel5);
            this.tpg_排名作業.Location = new System.Drawing.Point(4, 29);
            this.tpg_排名作業.Name = "tpg_排名作業";
            this.tpg_排名作業.Size = new System.Drawing.Size(1405, 642);
            this.tpg_排名作業.TabIndex = 4;
            this.tpg_排名作業.Text = "排名作業";
            this.tpg_排名作業.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.06762F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.93238F));
            this.tableLayoutPanel5.Controls.Add(this.panel4, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.dgv_排名作業統計, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel5, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.panel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.00311F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.99689F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1405, 642);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label15);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.btn_排名作業更新);
            this.panel4.Controls.Add(this.lbl_排名作業人數);
            this.panel4.Controls.Add(this.cbx_排名作業名次);
            this.panel4.Controls.Add(this.cbx_排名作業分組);
            this.panel4.Controls.Add(this.cbx_排名作業選擇比賽);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(852, 115);
            this.panel4.TabIndex = 0;
            // 
            // btn_排名作業更新
            // 
            this.btn_排名作業更新.Location = new System.Drawing.Point(688, 41);
            this.btn_排名作業更新.Name = "btn_排名作業更新";
            this.btn_排名作業更新.Size = new System.Drawing.Size(79, 37);
            this.btn_排名作業更新.TabIndex = 10;
            this.btn_排名作業更新.Text = "更新";
            this.btn_排名作業更新.UseVisualStyleBackColor = true;
            this.btn_排名作業更新.Click += new System.EventHandler(this.btn_排名作業更新_Click);
            // 
            // lbl_排名作業人數
            // 
            this.lbl_排名作業人數.AutoSize = true;
            this.lbl_排名作業人數.Font = new System.Drawing.Font("標楷體", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl_排名作業人數.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_排名作業人數.Location = new System.Drawing.Point(490, 41);
            this.lbl_排名作業人數.Name = "lbl_排名作業人數";
            this.lbl_排名作業人數.Size = new System.Drawing.Size(55, 37);
            this.lbl_排名作業人數.TabIndex = 9;
            this.lbl_排名作業人數.Text = "XX";
            this.lbl_排名作業人數.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbx_排名作業名次
            // 
            this.cbx_排名作業名次.FormattingEnabled = true;
            this.cbx_排名作業名次.Location = new System.Drawing.Point(321, 51);
            this.cbx_排名作業名次.Name = "cbx_排名作業名次";
            this.cbx_排名作業名次.Size = new System.Drawing.Size(128, 27);
            this.cbx_排名作業名次.TabIndex = 8;
            this.cbx_排名作業名次.SelectedIndexChanged += new System.EventHandler(this.cbx_排名作業名次_SelectedIndexChanged);
            // 
            // cbx_排名作業分組
            // 
            this.cbx_排名作業分組.FormattingEnabled = true;
            this.cbx_排名作業分組.Location = new System.Drawing.Point(170, 51);
            this.cbx_排名作業分組.Name = "cbx_排名作業分組";
            this.cbx_排名作業分組.Size = new System.Drawing.Size(128, 27);
            this.cbx_排名作業分組.TabIndex = 7;
            this.cbx_排名作業分組.SelectedIndexChanged += new System.EventHandler(this.cbx_排名作業分組_SelectedIndexChanged);
            // 
            // cbx_排名作業選擇比賽
            // 
            this.cbx_排名作業選擇比賽.FormattingEnabled = true;
            this.cbx_排名作業選擇比賽.Location = new System.Drawing.Point(17, 51);
            this.cbx_排名作業選擇比賽.Name = "cbx_排名作業選擇比賽";
            this.cbx_排名作業選擇比賽.Size = new System.Drawing.Size(128, 27);
            this.cbx_排名作業選擇比賽.TabIndex = 6;
            this.cbx_排名作業選擇比賽.SelectedIndexChanged += new System.EventHandler(this.cbx_排名作業選擇比賽_SelectedIndexChanged);
            // 
            // dgv_排名作業統計
            // 
            this.dgv_排名作業統計.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_排名作業統計.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_排名作業統計.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_排名作業統計.Location = new System.Drawing.Point(3, 124);
            this.dgv_排名作業統計.Name = "dgv_排名作業統計";
            this.dgv_排名作業統計.RowTemplate.Height = 24;
            this.dgv_排名作業統計.Size = new System.Drawing.Size(852, 515);
            this.dgv_排名作業統計.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btn_排名欄位清除);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.txt_排名作業圖紙編號);
            this.panel5.Controls.Add(this.txt_排名作業參賽編號);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(861, 124);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(541, 515);
            this.panel5.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "圖紙編號";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "參賽編號";
            // 
            // txt_排名作業圖紙編號
            // 
            this.txt_排名作業圖紙編號.Location = new System.Drawing.Point(146, 109);
            this.txt_排名作業圖紙編號.Name = "txt_排名作業圖紙編號";
            this.txt_排名作業圖紙編號.Size = new System.Drawing.Size(155, 30);
            this.txt_排名作業圖紙編號.TabIndex = 7;
            this.txt_排名作業圖紙編號.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_排名作業圖紙編號_KeyDown);
            this.txt_排名作業圖紙編號.Leave += new System.EventHandler(this.txt_排名作業圖紙編號_Leave);
            // 
            // txt_排名作業參賽編號
            // 
            this.txt_排名作業參賽編號.Location = new System.Drawing.Point(146, 34);
            this.txt_排名作業參賽編號.Name = "txt_排名作業參賽編號";
            this.txt_排名作業參賽編號.Size = new System.Drawing.Size(155, 30);
            this.txt_排名作業參賽編號.TabIndex = 6;
            this.txt_排名作業參賽編號.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_排名作業參賽編號_KeyDown);
            this.txt_排名作業參賽編號.Leave += new System.EventHandler(this.txt_排名作業參賽編號_Leave);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chk_Unlock);
            this.panel6.Controls.Add(this.btn_Reset排名作業圖紙編號);
            this.panel6.Controls.Add(this.btn_Reset排名作業參賽編號);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Controls.Add(this.txt_Reset排名作業圖紙編號);
            this.panel6.Controls.Add(this.txt_Reset排名作業參賽編號);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(861, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(541, 115);
            this.panel6.TabIndex = 3;
            // 
            // chk_Unlock
            // 
            this.chk_Unlock.AutoSize = true;
            this.chk_Unlock.Location = new System.Drawing.Point(398, 59);
            this.chk_Unlock.Name = "chk_Unlock";
            this.chk_Unlock.Size = new System.Drawing.Size(68, 23);
            this.chk_Unlock.TabIndex = 16;
            this.chk_Unlock.Text = "解鎖";
            this.chk_Unlock.UseVisualStyleBackColor = true;
            this.chk_Unlock.CheckedChanged += new System.EventHandler(this.chk_Unlock_CheckedChanged);
            // 
            // btn_Reset排名作業圖紙編號
            // 
            this.btn_Reset排名作業圖紙編號.Enabled = false;
            this.btn_Reset排名作業圖紙編號.Location = new System.Drawing.Point(285, 55);
            this.btn_Reset排名作業圖紙編號.Name = "btn_Reset排名作業圖紙編號";
            this.btn_Reset排名作業圖紙編號.Size = new System.Drawing.Size(75, 29);
            this.btn_Reset排名作業圖紙編號.TabIndex = 15;
            this.btn_Reset排名作業圖紙編號.Text = "重置";
            this.btn_Reset排名作業圖紙編號.UseVisualStyleBackColor = true;
            this.btn_Reset排名作業圖紙編號.Click += new System.EventHandler(this.btn_Reset排名作業圖紙編號_Click);
            // 
            // btn_Reset排名作業參賽編號
            // 
            this.btn_Reset排名作業參賽編號.Enabled = false;
            this.btn_Reset排名作業參賽編號.Location = new System.Drawing.Point(280, 10);
            this.btn_Reset排名作業參賽編號.Name = "btn_Reset排名作業參賽編號";
            this.btn_Reset排名作業參賽編號.Size = new System.Drawing.Size(80, 31);
            this.btn_Reset排名作業參賽編號.TabIndex = 14;
            this.btn_Reset排名作業參賽編號.Text = "重置";
            this.btn_Reset排名作業參賽編號.UseVisualStyleBackColor = true;
            this.btn_Reset排名作業參賽編號.Click += new System.EventHandler(this.btn_Reset排名作業參賽編號_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "圖紙編號";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 19);
            this.label11.TabIndex = 12;
            this.label11.Text = "參賽編號";
            // 
            // txt_Reset排名作業圖紙編號
            // 
            this.txt_Reset排名作業圖紙編號.Location = new System.Drawing.Point(119, 54);
            this.txt_Reset排名作業圖紙編號.Name = "txt_Reset排名作業圖紙編號";
            this.txt_Reset排名作業圖紙編號.Size = new System.Drawing.Size(155, 30);
            this.txt_Reset排名作業圖紙編號.TabIndex = 11;
            // 
            // txt_Reset排名作業參賽編號
            // 
            this.txt_Reset排名作業參賽編號.Location = new System.Drawing.Point(119, 11);
            this.txt_Reset排名作業參賽編號.Name = "txt_Reset排名作業參賽編號";
            this.txt_Reset排名作業參賽編號.Size = new System.Drawing.Size(155, 30);
            this.txt_Reset排名作業參賽編號.TabIndex = 10;
            // 
            // tpg_成績統計
            // 
            this.tpg_成績統計.Controls.Add(this.tableLayoutPanel6);
            this.tpg_成績統計.Location = new System.Drawing.Point(4, 29);
            this.tpg_成績統計.Name = "tpg_成績統計";
            this.tpg_成績統計.Size = new System.Drawing.Size(1405, 642);
            this.tpg_成績統計.TabIndex = 5;
            this.tpg_成績統計.Text = "成績統計";
            this.tpg_成績統計.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.gbx_獎狀, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.dgv_成績統計, 0, 2);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 3;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1405, 642);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk_成績不分組);
            this.groupBox3.Controls.Add(this.btn_成績更新);
            this.groupBox3.Controls.Add(this.cbx_成績分組);
            this.groupBox3.Controls.Add(this.cbx_成績比賽);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1399, 58);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "比賽/分組";
            // 
            // chk_成績不分組
            // 
            this.chk_成績不分組.AutoSize = true;
            this.chk_成績不分組.Checked = true;
            this.chk_成績不分組.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_成績不分組.Location = new System.Drawing.Point(315, 29);
            this.chk_成績不分組.Name = "chk_成績不分組";
            this.chk_成績不分組.Size = new System.Drawing.Size(88, 23);
            this.chk_成績不分組.TabIndex = 15;
            this.chk_成績不分組.Text = "不分組";
            this.chk_成績不分組.UseVisualStyleBackColor = true;
            this.chk_成績不分組.CheckedChanged += new System.EventHandler(this.chk_成績不分組_CheckedChanged);
            // 
            // btn_成績更新
            // 
            this.btn_成績更新.Location = new System.Drawing.Point(686, 15);
            this.btn_成績更新.Name = "btn_成績更新";
            this.btn_成績更新.Size = new System.Drawing.Size(79, 37);
            this.btn_成績更新.TabIndex = 14;
            this.btn_成績更新.Text = "更新";
            this.btn_成績更新.UseVisualStyleBackColor = true;
            this.btn_成績更新.Click += new System.EventHandler(this.btn_成績更新_Click);
            // 
            // cbx_成績分組
            // 
            this.cbx_成績分組.FormattingEnabled = true;
            this.cbx_成績分組.Location = new System.Drawing.Point(168, 25);
            this.cbx_成績分組.Name = "cbx_成績分組";
            this.cbx_成績分組.Size = new System.Drawing.Size(128, 27);
            this.cbx_成績分組.TabIndex = 12;
            // 
            // cbx_成績比賽
            // 
            this.cbx_成績比賽.FormattingEnabled = true;
            this.cbx_成績比賽.Location = new System.Drawing.Point(15, 25);
            this.cbx_成績比賽.Name = "cbx_成績比賽";
            this.cbx_成績比賽.Size = new System.Drawing.Size(128, 27);
            this.cbx_成績比賽.TabIndex = 11;
            // 
            // gbx_獎狀
            // 
            this.gbx_獎狀.Controls.Add(this.btn_領獎公告);
            this.gbx_獎狀.Controls.Add(this.btn_領獎單);
            this.gbx_獎狀.Controls.Add(this.btn_國際組英文);
            this.gbx_獎狀.Controls.Add(this.btn_國際組中文);
            this.gbx_獎狀.Controls.Add(this.btn_天文宮);
            this.gbx_獎狀.Controls.Add(this.btn_市政府獎狀);
            this.gbx_獎狀.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbx_獎狀.Enabled = false;
            this.gbx_獎狀.Location = new System.Drawing.Point(3, 67);
            this.gbx_獎狀.Name = "gbx_獎狀";
            this.gbx_獎狀.Size = new System.Drawing.Size(1399, 58);
            this.gbx_獎狀.TabIndex = 1;
            this.gbx_獎狀.TabStop = false;
            this.gbx_獎狀.Text = "獎狀/領獎單";
            // 
            // btn_領獎公告
            // 
            this.btn_領獎公告.Location = new System.Drawing.Point(653, 20);
            this.btn_領獎公告.Name = "btn_領獎公告";
            this.btn_領獎公告.Size = new System.Drawing.Size(122, 32);
            this.btn_領獎公告.TabIndex = 5;
            this.btn_領獎公告.Text = "名次公告";
            this.btn_領獎公告.UseVisualStyleBackColor = true;
            this.btn_領獎公告.Click += new System.EventHandler(this.btn_名次公告_Click);
            // 
            // btn_領獎單
            // 
            this.btn_領獎單.Location = new System.Drawing.Point(525, 20);
            this.btn_領獎單.Name = "btn_領獎單";
            this.btn_領獎單.Size = new System.Drawing.Size(122, 32);
            this.btn_領獎單.TabIndex = 4;
            this.btn_領獎單.Text = "領獎單";
            this.btn_領獎單.UseVisualStyleBackColor = true;
            this.btn_領獎單.Click += new System.EventHandler(this.btn_領獎單_Click);
            // 
            // btn_國際組英文
            // 
            this.btn_國際組英文.Location = new System.Drawing.Point(386, 20);
            this.btn_國際組英文.Name = "btn_國際組英文";
            this.btn_國際組英文.Size = new System.Drawing.Size(122, 32);
            this.btn_國際組英文.TabIndex = 3;
            this.btn_國際組英文.Text = "國際組英文";
            this.btn_國際組英文.UseVisualStyleBackColor = true;
            this.btn_國際組英文.Click += new System.EventHandler(this.btn_國際組英文_Click);
            // 
            // btn_國際組中文
            // 
            this.btn_國際組中文.Location = new System.Drawing.Point(247, 20);
            this.btn_國際組中文.Name = "btn_國際組中文";
            this.btn_國際組中文.Size = new System.Drawing.Size(122, 32);
            this.btn_國際組中文.TabIndex = 2;
            this.btn_國際組中文.Text = "國際組中文";
            this.btn_國際組中文.UseVisualStyleBackColor = true;
            this.btn_國際組中文.Click += new System.EventHandler(this.btn_國際組中文_Click);
            // 
            // btn_天文宮
            // 
            this.btn_天文宮.Location = new System.Drawing.Point(141, 20);
            this.btn_天文宮.Name = "btn_天文宮";
            this.btn_天文宮.Size = new System.Drawing.Size(80, 32);
            this.btn_天文宮.TabIndex = 1;
            this.btn_天文宮.Text = "天文宮";
            this.btn_天文宮.UseVisualStyleBackColor = true;
            this.btn_天文宮.Click += new System.EventHandler(this.btn_天文宮_Click);
            // 
            // btn_市政府獎狀
            // 
            this.btn_市政府獎狀.Location = new System.Drawing.Point(35, 20);
            this.btn_市政府獎狀.Name = "btn_市政府獎狀";
            this.btn_市政府獎狀.Size = new System.Drawing.Size(80, 32);
            this.btn_市政府獎狀.TabIndex = 0;
            this.btn_市政府獎狀.Text = "市政府";
            this.btn_市政府獎狀.UseVisualStyleBackColor = true;
            this.btn_市政府獎狀.Click += new System.EventHandler(this.btn_市政府獎狀_Click);
            // 
            // dgv_成績統計
            // 
            this.dgv_成績統計.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_成績統計.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_成績統計.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("標楷體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_成績統計.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_成績統計.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_成績統計.Location = new System.Drawing.Point(3, 131);
            this.dgv_成績統計.Name = "dgv_成績統計";
            this.dgv_成績統計.RowTemplate.Height = 24;
            this.dgv_成績統計.Size = new System.Drawing.Size(1399, 508);
            this.dgv_成績統計.TabIndex = 2;
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
            this.tableLayoutPanel1.Controls.Add(this.panel7, 0, 0);
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
            this.groupBox1.Visible = false;
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
            // panel7
            // 
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(693, 630);
            this.panel7.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_Load);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Controls.Add(this.btn_測試連線);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Controls.Add(this.btn_英文獎狀測試);
            this.groupBox4.Controls.Add(this.btn_天文宮獎狀測試);
            this.groupBox4.Controls.Add(this.btn_市政府獎狀測試);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txt_ServerIp);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(693, 630);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "設定";
            // 
            // panel8
            // 
            this.panel8.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.天文logo;
            this.panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel8.Location = new System.Drawing.Point(6, 28);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(51, 48);
            this.panel8.TabIndex = 5;
            this.panel8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel8_MouseClick);
            this.panel8.MouseLeave += new System.EventHandler(this.panel8_MouseLeave);
            // 
            // btn_英文獎狀測試
            // 
            this.btn_英文獎狀測試.Location = new System.Drawing.Point(354, 317);
            this.btn_英文獎狀測試.Name = "btn_英文獎狀測試";
            this.btn_英文獎狀測試.Size = new System.Drawing.Size(163, 40);
            this.btn_英文獎狀測試.TabIndex = 4;
            this.btn_英文獎狀測試.Text = "英文獎狀測試";
            this.btn_英文獎狀測試.UseVisualStyleBackColor = true;
            this.btn_英文獎狀測試.Click += new System.EventHandler(this.btn_英文獎狀測試_Click);
            // 
            // btn_天文宮獎狀測試
            // 
            this.btn_天文宮獎狀測試.Location = new System.Drawing.Point(354, 271);
            this.btn_天文宮獎狀測試.Name = "btn_天文宮獎狀測試";
            this.btn_天文宮獎狀測試.Size = new System.Drawing.Size(163, 40);
            this.btn_天文宮獎狀測試.TabIndex = 3;
            this.btn_天文宮獎狀測試.Text = "天文宮獎狀測試";
            this.btn_天文宮獎狀測試.UseVisualStyleBackColor = true;
            this.btn_天文宮獎狀測試.Click += new System.EventHandler(this.btn_天文宮獎狀測試_Click);
            // 
            // btn_市政府獎狀測試
            // 
            this.btn_市政府獎狀測試.Location = new System.Drawing.Point(354, 216);
            this.btn_市政府獎狀測試.Name = "btn_市政府獎狀測試";
            this.btn_市政府獎狀測試.Size = new System.Drawing.Size(163, 40);
            this.btn_市政府獎狀測試.TabIndex = 2;
            this.btn_市政府獎狀測試.Text = "市政府獎狀測試";
            this.btn_市政府獎狀測試.UseVisualStyleBackColor = true;
            this.btn_市政府獎狀測試.Click += new System.EventHandler(this.btn_市政府獎狀測試_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(99, 19);
            this.label12.TabIndex = 1;
            this.label12.Text = "Server IP";
            // 
            // txt_ServerIp
            // 
            this.txt_ServerIp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "ServerIp", true));
            this.txt_ServerIp.Location = new System.Drawing.Point(162, 94);
            this.txt_ServerIp.Name = "txt_ServerIp";
            this.txt_ServerIp.Size = new System.Drawing.Size(192, 30);
            this.txt_ServerIp.TabIndex = 0;
            // 
            // btn_清除報到輸入
            // 
            this.btn_清除報到輸入.Location = new System.Drawing.Point(315, 8);
            this.btn_清除報到輸入.Name = "btn_清除報到輸入";
            this.btn_清除報到輸入.Size = new System.Drawing.Size(132, 33);
            this.btn_清除報到輸入.TabIndex = 8;
            this.btn_清除報到輸入.Text = "清除欄位";
            this.btn_清除報到輸入.UseVisualStyleBackColor = true;
            this.btn_清除報到輸入.Click += new System.EventHandler(this.btn_清除報到輸入_Click);
            // 
            // btn_排名欄位清除
            // 
            this.btn_排名欄位清除.Location = new System.Drawing.Point(324, 36);
            this.btn_排名欄位清除.Name = "btn_排名欄位清除";
            this.btn_排名欄位清除.Size = new System.Drawing.Size(107, 37);
            this.btn_排名欄位清除.TabIndex = 11;
            this.btn_排名欄位清除.Text = "欄位清除";
            this.btn_排名欄位清除.UseVisualStyleBackColor = true;
            this.btn_排名欄位清除.Click += new System.EventHandler(this.btn_排名欄位清除_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "比賽";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(166, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "分組";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "名次";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(27, 141);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(129, 19);
            this.label16.TabIndex = 6;
            this.label16.Text = "檔案匯出路徑";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "TWRoot", true));
            this.textBox1.Location = new System.Drawing.Point(162, 138);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(192, 30);
            this.textBox1.TabIndex = 7;
            // 
            // btn_測試連線
            // 
            this.btn_測試連線.Location = new System.Drawing.Point(398, 94);
            this.btn_測試連線.Name = "btn_測試連線";
            this.btn_測試連線.Size = new System.Drawing.Size(101, 35);
            this.btn_測試連線.TabIndex = 8;
            this.btn_測試連線.Text = "測試連線";
            this.btn_測試連線.UseVisualStyleBackColor = true;
            this.btn_測試連線.Click += new System.EventHandler(this.btn_測試連線_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(461, 28);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 35);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // bs_System
            // 
            this.bs_System.DataSource = typeof(WindowsFormsApp1.SystemParameter);
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(371, 28);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(75, 35);
            this.btn_Load.TabIndex = 10;
            this.btn_Load.Text = "載入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
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
            this.tpg_統計.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_統計表)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpg_報到作業.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_報到作業紀錄)).EndInit();
            this.tpg_指導老師.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_指導老師)).EndInit();
            this.tpg_排名作業.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_排名作業統計)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.tpg_成績統計.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbx_獎狀.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_成績統計)).EndInit();
            this.tpg_setting.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_System)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpg_統計;
        private System.Windows.Forms.TabPage tpg_setting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_匯入參賽者資料;
        private System.Windows.Forms.Button btn_刪除所有資料;
        private System.Windows.Forms.Button btn_初始化所有資料;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dgv_統計表;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbx_統計表選擇比賽;
        private System.Windows.Forms.Button btn_更新統計表;
        private System.Windows.Forms.TabPage tpg_報到作業;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbx_報到作業選擇分組;
        private System.Windows.Forms.CheckBox chk_報到作業選擇分組;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbx_報到作業選擇比賽;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_報到作業清除紀錄;
        private System.Windows.Forms.Button btn_報到作業本機記錄;
        private System.Windows.Forms.TextBox txt_報到作業圖紙編號;
        private System.Windows.Forms.TextBox txt_報到作業參賽編號;
        private System.Windows.Forms.RichTextBox rtb_報到作業參賽資料;
        private System.Windows.Forms.DataGridView dgv_報到作業紀錄;
        private System.Windows.Forms.Button btn_報到作業重置狀態;
        private System.Windows.Forms.TabPage tpg_指導老師;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_指導老師更新;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbx_指導老師選擇比賽;
        private System.Windows.Forms.DataGridView dgv_指導老師;
        private System.Windows.Forms.TextBox txt_指導老師報到人數;
        private System.Windows.Forms.TextBox txt_指導老師報名人數;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tpg_排名作業;
        private System.Windows.Forms.TabPage tpg_成績統計;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_排名作業更新;
        private System.Windows.Forms.Label lbl_排名作業人數;
        private System.Windows.Forms.ComboBox cbx_排名作業名次;
        private System.Windows.Forms.ComboBox cbx_排名作業分組;
        private System.Windows.Forms.ComboBox cbx_排名作業選擇比賽;
        private System.Windows.Forms.DataGridView dgv_排名作業統計;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_排名作業圖紙編號;
        private System.Windows.Forms.TextBox txt_排名作業參賽編號;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_Reset排名作業圖紙編號;
        private System.Windows.Forms.TextBox txt_Reset排名作業參賽編號;
        private System.Windows.Forms.CheckBox chk_Unlock;
        private System.Windows.Forms.Button btn_Reset排名作業圖紙編號;
        private System.Windows.Forms.Button btn_Reset排名作業參賽編號;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk_成績不分組;
        private System.Windows.Forms.Button btn_成績更新;
        private System.Windows.Forms.ComboBox cbx_成績分組;
        private System.Windows.Forms.ComboBox cbx_成績比賽;
        private System.Windows.Forms.GroupBox gbx_獎狀;
        private System.Windows.Forms.DataGridView dgv_成績統計;
        private System.Windows.Forms.Button btn_匯出參賽證;
        private System.Windows.Forms.Button btn_市政府獎狀;
        private System.Windows.Forms.Button btn_天文宮;
        private System.Windows.Forms.Button btn_國際組中文;
        private System.Windows.Forms.Button btn_國際組英文;
        private System.Windows.Forms.BindingSource bs_System;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txt_ServerIp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_領獎單;
        private System.Windows.Forms.Button btn_領獎公告;
        private System.Windows.Forms.Button btn_老師公告單;
        private System.Windows.Forms.Button btn_老師領獎單;
        private System.Windows.Forms.Button btn_英文獎狀測試;
        private System.Windows.Forms.Button btn_天文宮獎狀測試;
        private System.Windows.Forms.Button btn_市政府獎狀測試;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_清除報到輸入;
        private System.Windows.Forms.Button btn_排名欄位清除;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_測試連線;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Load;
    }
}

