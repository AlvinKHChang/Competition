
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
            this.btn_清除報到輸入 = new System.Windows.Forms.Button();
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
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_排名作業更新 = new System.Windows.Forms.Button();
            this.lbl_排名作業人數 = new System.Windows.Forms.Label();
            this.cbx_排名作業名次 = new System.Windows.Forms.ComboBox();
            this.cbx_排名作業分組 = new System.Windows.Forms.ComboBox();
            this.cbx_排名作業選擇比賽 = new System.Windows.Forms.ComboBox();
            this.dgv_排名作業統計 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btn_排名欄位清除 = new System.Windows.Forms.Button();
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
            this.gbx_DbSetting = new System.Windows.Forms.GroupBox();
            this.btn_國際組名字 = new System.Windows.Forms.Button();
            this.btn_LockDbSetting = new System.Windows.Forms.Button();
            this.btn_特別獎名次 = new System.Windows.Forms.Button();
            this.btn_初始化所有資料 = new System.Windows.Forms.Button();
            this.btn_刪除所有資料 = new System.Windows.Forms.Button();
            this.btn_匯入參賽者資料 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.btn_市政府獎狀測試 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.btn_特別獎獎狀 = new System.Windows.Forms.Button();
            this.btn_天文宮獎狀測試 = new System.Windows.Forms.Button();
            this.btn_英文獎狀測試 = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_ServerIp = new System.Windows.Forms.TextBox();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_測試連線 = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.textBox25 = new System.Windows.Forms.TextBox();
            this.textBox26 = new System.Windows.Forms.TextBox();
            this.textBox27 = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.textBox33 = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.textBox34 = new System.Windows.Forms.TextBox();
            this.textBox29 = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.label33 = new System.Windows.Forms.Label();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBox31 = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.textBox23 = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.textBox28 = new System.Windows.Forms.TextBox();
            this.bs_Gov序號 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_System = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Gov比賽名稱 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Gov屆數分組名次 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_Gov比賽姓名 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW序號 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW比賽名稱 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW日 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW月 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW年 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW比賽分組 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW屆數 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_TW比賽姓名 = new System.Windows.Forms.BindingSource(this.components);
            this.bs_En序號 = new System.Windows.Forms.BindingSource(this.components);
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
            this.gbx_DbSetting.SuspendLayout();
            this.panel7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov序號)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_System)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov比賽名稱)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov屆數分組名次)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov比賽姓名)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW序號)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW比賽名稱)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW日)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW月)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW年)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW比賽分組)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW屆數)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW比賽姓名)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_En序號)).BeginInit();
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "名次";
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "比賽";
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.04789F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.95211F));
            this.tableLayoutPanel1.Controls.Add(this.gbx_DbSetting, 1, 0);
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
            // gbx_DbSetting
            // 
            this.gbx_DbSetting.Controls.Add(this.btn_國際組名字);
            this.gbx_DbSetting.Controls.Add(this.btn_LockDbSetting);
            this.gbx_DbSetting.Controls.Add(this.btn_特別獎名次);
            this.gbx_DbSetting.Controls.Add(this.btn_初始化所有資料);
            this.gbx_DbSetting.Controls.Add(this.btn_刪除所有資料);
            this.gbx_DbSetting.Controls.Add(this.btn_匯入參賽者資料);
            this.gbx_DbSetting.Location = new System.Drawing.Point(940, 3);
            this.gbx_DbSetting.Name = "gbx_DbSetting";
            this.gbx_DbSetting.Size = new System.Drawing.Size(419, 426);
            this.gbx_DbSetting.TabIndex = 0;
            this.gbx_DbSetting.TabStop = false;
            this.gbx_DbSetting.Text = "DB  Setting";
            this.gbx_DbSetting.Visible = false;
            // 
            // btn_國際組名字
            // 
            this.btn_國際組名字.Location = new System.Drawing.Point(16, 277);
            this.btn_國際組名字.Name = "btn_國際組名字";
            this.btn_國際組名字.Size = new System.Drawing.Size(202, 55);
            this.btn_國際組名字.TabIndex = 5;
            this.btn_國際組名字.Text = "國際組名字";
            this.btn_國際組名字.UseVisualStyleBackColor = true;
            this.btn_國際組名字.Click += new System.EventHandler(this.btn_國際組名字_Click);
            // 
            // btn_LockDbSetting
            // 
            this.btn_LockDbSetting.Location = new System.Drawing.Point(329, 361);
            this.btn_LockDbSetting.Name = "btn_LockDbSetting";
            this.btn_LockDbSetting.Size = new System.Drawing.Size(74, 43);
            this.btn_LockDbSetting.TabIndex = 4;
            this.btn_LockDbSetting.Text = "Lock";
            this.btn_LockDbSetting.UseVisualStyleBackColor = true;
            this.btn_LockDbSetting.Click += new System.EventHandler(this.btn_LockDbSetting_Click);
            // 
            // btn_特別獎名次
            // 
            this.btn_特別獎名次.Location = new System.Drawing.Point(16, 215);
            this.btn_特別獎名次.Name = "btn_特別獎名次";
            this.btn_特別獎名次.Size = new System.Drawing.Size(202, 55);
            this.btn_特別獎名次.TabIndex = 3;
            this.btn_特別獎名次.Text = "特別獎名次";
            this.btn_特別獎名次.UseVisualStyleBackColor = true;
            this.btn_特別獎名次.Click += new System.EventHandler(this.btn_特別獎名次_Click);
            // 
            // btn_初始化所有資料
            // 
            this.btn_初始化所有資料.Location = new System.Drawing.Point(16, 153);
            this.btn_初始化所有資料.Name = "btn_初始化所有資料";
            this.btn_初始化所有資料.Size = new System.Drawing.Size(202, 55);
            this.btn_初始化所有資料.TabIndex = 2;
            this.btn_初始化所有資料.Text = "初始化所有資料";
            this.btn_初始化所有資料.UseVisualStyleBackColor = true;
            this.btn_初始化所有資料.Click += new System.EventHandler(this.btn_初始化所有資料_Click);
            // 
            // btn_刪除所有資料
            // 
            this.btn_刪除所有資料.Location = new System.Drawing.Point(16, 91);
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
            this.panel7.Controls.Add(this.groupBox9);
            this.panel7.Controls.Add(this.groupBox8);
            this.panel7.Controls.Add(this.groupBox7);
            this.panel7.Controls.Add(this.groupBox6);
            this.panel7.Controls.Add(this.groupBox5);
            this.panel7.Controls.Add(this.groupBox1);
            this.panel7.Controls.Add(this.groupBox4);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(931, 630);
            this.panel7.TabIndex = 1;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel9);
            this.groupBox8.Controls.Add(this.btn_市政府獎狀測試);
            this.groupBox8.Location = new System.Drawing.Point(0, 129);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(275, 469);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "市政府獎狀";
            // 
            // btn_市政府獎狀測試
            // 
            this.btn_市政府獎狀測試.Location = new System.Drawing.Point(37, 350);
            this.btn_市政府獎狀測試.Name = "btn_市政府獎狀測試";
            this.btn_市政府獎狀測試.Size = new System.Drawing.Size(163, 40);
            this.btn_市政府獎狀測試.TabIndex = 2;
            this.btn_市政府獎狀測試.Text = "市政府獎狀測試";
            this.btn_市政府獎狀測試.UseVisualStyleBackColor = true;
            this.btn_市政府獎狀測試.Click += new System.EventHandler(this.btn_市政府獎狀測試_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Location = new System.Drawing.Point(-33, -81);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(200, 100);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "groupBox7";
            // 
            // groupBox6
            // 
            this.groupBox6.Location = new System.Drawing.Point(-33, -81);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "groupBox6";
            // 
            // groupBox5
            // 
            this.groupBox5.Location = new System.Drawing.Point(-33, -81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "groupBox5";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel7);
            this.groupBox1.Controls.Add(this.btn_特別獎獎狀);
            this.groupBox1.Controls.Add(this.btn_天文宮獎狀測試);
            this.groupBox1.Location = new System.Drawing.Point(281, 129);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 469);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "天文宮獎狀";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.Controls.Add(this.label26, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox14, 2, 8);
            this.tableLayoutPanel7.Controls.Add(this.textBox16, 2, 3);
            this.tableLayoutPanel7.Controls.Add(this.textBox12, 2, 7);
            this.tableLayoutPanel7.Controls.Add(this.textBox18, 1, 9);
            this.tableLayoutPanel7.Controls.Add(this.textBox10, 2, 6);
            this.tableLayoutPanel7.Controls.Add(this.label25, 0, 9);
            this.tableLayoutPanel7.Controls.Add(this.textBox9, 2, 5);
            this.tableLayoutPanel7.Controls.Add(this.label27, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.textBox7, 2, 4);
            this.tableLayoutPanel7.Controls.Add(this.textBox17, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.textBox15, 1, 8);
            this.tableLayoutPanel7.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox5, 2, 2);
            this.tableLayoutPanel7.Controls.Add(this.label24, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.textBox3, 2, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox13, 1, 7);
            this.tableLayoutPanel7.Controls.Add(this.label18, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.label23, 0, 8);
            this.tableLayoutPanel7.Controls.Add(this.textBox11, 1, 6);
            this.tableLayoutPanel7.Controls.Add(this.label19, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.label20, 0, 5);
            this.tableLayoutPanel7.Controls.Add(this.textBox8, 1, 5);
            this.tableLayoutPanel7.Controls.Add(this.label21, 0, 6);
            this.tableLayoutPanel7.Controls.Add(this.label22, 0, 7);
            this.tableLayoutPanel7.Controls.Add(this.textBox6, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.textBox4, 1, 2);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(19, 29);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 10;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(241, 315);
            this.tableLayoutPanel7.TabIndex = 35;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label26.Location = new System.Drawing.Point(99, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 31);
            this.label26.TabIndex = 32;
            this.label26.Text = "X";
            // 
            // textBox14
            // 
            this.textBox14.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW序號, "Y", true));
            this.textBox14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox14.Location = new System.Drawing.Point(171, 251);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(67, 30);
            this.textBox14.TabIndex = 25;
            // 
            // textBox16
            // 
            this.textBox16.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW比賽名稱, "Y", true));
            this.textBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox16.Location = new System.Drawing.Point(171, 96);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(67, 30);
            this.textBox16.TabIndex = 28;
            // 
            // textBox12
            // 
            this.textBox12.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW日, "Y", true));
            this.textBox12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox12.Location = new System.Drawing.Point(171, 220);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(67, 30);
            this.textBox12.TabIndex = 22;
            // 
            // textBox18
            // 
            this.textBox18.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "TWFontNumber", true));
            this.textBox18.Location = new System.Drawing.Point(99, 282);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(66, 30);
            this.textBox18.TabIndex = 30;
            // 
            // textBox10
            // 
            this.textBox10.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW月, "Y", true));
            this.textBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox10.Location = new System.Drawing.Point(171, 189);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(67, 30);
            this.textBox10.TabIndex = 19;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label25.Location = new System.Drawing.Point(3, 279);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(90, 36);
            this.label25.TabIndex = 31;
            this.label25.Text = "字體大小";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox9
            // 
            this.textBox9.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW年, "Y", true));
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox9.Location = new System.Drawing.Point(171, 158);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(67, 30);
            this.textBox9.TabIndex = 13;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label27.Location = new System.Drawing.Point(171, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 31);
            this.label27.TabIndex = 33;
            this.label27.Text = "Y";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // textBox7
            // 
            this.textBox7.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW比賽分組, "Y", true));
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Location = new System.Drawing.Point(171, 127);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(67, 30);
            this.textBox7.TabIndex = 11;
            // 
            // textBox17
            // 
            this.textBox17.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW比賽名稱, "X", true));
            this.textBox17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox17.Location = new System.Drawing.Point(99, 96);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(66, 30);
            this.textBox17.TabIndex = 27;
            // 
            // textBox15
            // 
            this.textBox15.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW序號, "X", true));
            this.textBox15.Location = new System.Drawing.Point(99, 251);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(66, 30);
            this.textBox15.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(3, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(90, 31);
            this.label17.TabIndex = 14;
            this.label17.Text = "名字";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW屆數, "Y", true));
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(171, 65);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 30);
            this.textBox5.TabIndex = 9;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label24.Location = new System.Drawing.Point(3, 93);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 31);
            this.label24.TabIndex = 29;
            this.label24.Text = "比賽";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW比賽姓名, "Y", true));
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(171, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(67, 30);
            this.textBox3.TabIndex = 7;
            // 
            // textBox13
            // 
            this.textBox13.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW日, "X", true));
            this.textBox13.Location = new System.Drawing.Point(99, 220);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(66, 30);
            this.textBox13.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(3, 62);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 31);
            this.label18.TabIndex = 15;
            this.label18.Text = "屆數";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Location = new System.Drawing.Point(3, 248);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 31);
            this.label23.TabIndex = 26;
            this.label23.Text = "序號";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox11
            // 
            this.textBox11.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW月, "X", true));
            this.textBox11.Location = new System.Drawing.Point(99, 189);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(66, 30);
            this.textBox11.TabIndex = 18;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Location = new System.Drawing.Point(3, 124);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(90, 31);
            this.label19.TabIndex = 16;
            this.label19.Text = "分組";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Location = new System.Drawing.Point(3, 155);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(90, 31);
            this.label20.TabIndex = 17;
            this.label20.Text = "年";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox8
            // 
            this.textBox8.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW年, "X", true));
            this.textBox8.Location = new System.Drawing.Point(99, 158);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(66, 30);
            this.textBox8.TabIndex = 12;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label21.Location = new System.Drawing.Point(3, 186);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 31);
            this.label21.TabIndex = 20;
            this.label21.Text = "月";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label22.Location = new System.Drawing.Point(3, 217);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(90, 31);
            this.label22.TabIndex = 23;
            this.label22.Text = "日";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox6
            // 
            this.textBox6.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW比賽分組, "X", true));
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(99, 127);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 30);
            this.textBox6.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW比賽姓名, "X", true));
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(99, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 30);
            this.textBox2.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_TW屆數, "X", true));
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(99, 65);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(66, 30);
            this.textBox4.TabIndex = 8;
            // 
            // btn_特別獎獎狀
            // 
            this.btn_特別獎獎狀.Location = new System.Drawing.Point(19, 396);
            this.btn_特別獎獎狀.Name = "btn_特別獎獎狀";
            this.btn_特別獎獎狀.Size = new System.Drawing.Size(163, 40);
            this.btn_特別獎獎狀.TabIndex = 5;
            this.btn_特別獎獎狀.Text = "特別獎獎狀";
            this.btn_特別獎獎狀.UseVisualStyleBackColor = true;
            this.btn_特別獎獎狀.Click += new System.EventHandler(this.btn_特別獎獎狀_Click);
            // 
            // btn_天文宮獎狀測試
            // 
            this.btn_天文宮獎狀測試.Location = new System.Drawing.Point(19, 350);
            this.btn_天文宮獎狀測試.Name = "btn_天文宮獎狀測試";
            this.btn_天文宮獎狀測試.Size = new System.Drawing.Size(163, 40);
            this.btn_天文宮獎狀測試.TabIndex = 3;
            this.btn_天文宮獎狀測試.Text = "天文宮獎狀測試";
            this.btn_天文宮獎狀測試.UseVisualStyleBackColor = true;
            this.btn_天文宮獎狀測試.Click += new System.EventHandler(this.btn_天文宮獎狀測試_Click);
            // 
            // btn_英文獎狀測試
            // 
            this.btn_英文獎狀測試.Location = new System.Drawing.Point(6, 350);
            this.btn_英文獎狀測試.Name = "btn_英文獎狀測試";
            this.btn_英文獎狀測試.Size = new System.Drawing.Size(163, 40);
            this.btn_英文獎狀測試.TabIndex = 4;
            this.btn_英文獎狀測試.Text = "英文獎狀測試";
            this.btn_英文獎狀測試.UseVisualStyleBackColor = true;
            this.btn_英文獎狀測試.Click += new System.EventHandler(this.btn_英文獎狀測試_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel8);
            this.groupBox4.Controls.Add(this.btn_Load);
            this.groupBox4.Controls.Add(this.btn_Save);
            this.groupBox4.Controls.Add(this.btn_測試連線);
            this.groupBox4.Controls.Add(this.panel8);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(931, 123);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "設定";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.label16, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBox1, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.txt_ServerIp, 1, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(63, 29);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(280, 73);
            this.tableLayoutPanel8.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(3, 36);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(134, 37);
            this.label16.TabIndex = 6;
            this.label16.Text = "檔案匯出路徑";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "TWRoot", true));
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(143, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 30);
            this.textBox1.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 36);
            this.label12.TabIndex = 1;
            this.label12.Text = "Server IP";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_ServerIp
            // 
            this.txt_ServerIp.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "ServerIp", true));
            this.txt_ServerIp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_ServerIp.Location = new System.Drawing.Point(143, 3);
            this.txt_ServerIp.Name = "txt_ServerIp";
            this.txt_ServerIp.Size = new System.Drawing.Size(134, 30);
            this.txt_ServerIp.TabIndex = 0;
            // 
            // btn_Load
            // 
            this.btn_Load.Location = new System.Drawing.Point(505, 32);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(101, 35);
            this.btn_Load.TabIndex = 10;
            this.btn_Load.Text = "載入";
            this.btn_Load.UseVisualStyleBackColor = true;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(505, 73);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(101, 35);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "儲存";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_測試連線
            // 
            this.btn_測試連線.Location = new System.Drawing.Point(371, 32);
            this.btn_測試連線.Name = "btn_測試連線";
            this.btn_測試連線.Size = new System.Drawing.Size(101, 35);
            this.btn_測試連線.TabIndex = 8;
            this.btn_測試連線.Text = "測試連線";
            this.btn_測試連線.UseVisualStyleBackColor = true;
            this.btn_測試連線.Click += new System.EventHandler(this.btn_測試連線_Click);
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
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 3;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel9.Controls.Add(this.label28, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBox19, 2, 4);
            this.tableLayoutPanel9.Controls.Add(this.textBox20, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.textBox22, 1, 5);
            this.tableLayoutPanel9.Controls.Add(this.label29, 0, 5);
            this.tableLayoutPanel9.Controls.Add(this.label30, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.textBox25, 2, 3);
            this.tableLayoutPanel9.Controls.Add(this.textBox26, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.textBox27, 1, 4);
            this.tableLayoutPanel9.Controls.Add(this.label31, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.label32, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.textBox29, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.label34, 0, 4);
            this.tableLayoutPanel9.Controls.Add(this.label35, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.textBox33, 1, 3);
            this.tableLayoutPanel9.Controls.Add(this.textBox34, 1, 1);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 6;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(260, 193);
            this.tableLayoutPanel9.TabIndex = 36;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label28.Location = new System.Drawing.Point(107, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 32);
            this.label28.TabIndex = 32;
            this.label28.Text = "X";
            // 
            // textBox19
            // 
            this.textBox19.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov序號, "Y", true));
            this.textBox19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox19.Location = new System.Drawing.Point(185, 131);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(72, 30);
            this.textBox19.TabIndex = 25;
            // 
            // textBox20
            // 
            this.textBox20.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov比賽名稱, "Y", true));
            this.textBox20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox20.Location = new System.Drawing.Point(185, 67);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(72, 30);
            this.textBox20.TabIndex = 28;
            // 
            // textBox22
            // 
            this.textBox22.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "GovFontNumber", true));
            this.textBox22.Location = new System.Drawing.Point(107, 163);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(71, 30);
            this.textBox22.TabIndex = 30;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label29.Location = new System.Drawing.Point(3, 160);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(98, 33);
            this.label29.TabIndex = 31;
            this.label29.Text = "字體大小";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label30.Location = new System.Drawing.Point(185, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(72, 32);
            this.label30.TabIndex = 33;
            this.label30.Text = "Y";
            // 
            // textBox25
            // 
            this.textBox25.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov屆數分組名次, "Y", true));
            this.textBox25.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox25.Location = new System.Drawing.Point(185, 99);
            this.textBox25.Name = "textBox25";
            this.textBox25.Size = new System.Drawing.Size(72, 30);
            this.textBox25.TabIndex = 11;
            // 
            // textBox26
            // 
            this.textBox26.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov比賽名稱, "X", true));
            this.textBox26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox26.Location = new System.Drawing.Point(107, 67);
            this.textBox26.Name = "textBox26";
            this.textBox26.Size = new System.Drawing.Size(72, 30);
            this.textBox26.TabIndex = 27;
            // 
            // textBox27
            // 
            this.textBox27.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov序號, "X", true));
            this.textBox27.Location = new System.Drawing.Point(107, 131);
            this.textBox27.Name = "textBox27";
            this.textBox27.Size = new System.Drawing.Size(71, 30);
            this.textBox27.TabIndex = 24;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label34.Location = new System.Drawing.Point(3, 128);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(98, 32);
            this.label34.TabIndex = 26;
            this.label34.Text = "序號";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label35.Location = new System.Drawing.Point(3, 96);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(98, 32);
            this.label35.TabIndex = 16;
            this.label35.Text = "屆數分組";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox33
            // 
            this.textBox33.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov屆數分組名次, "X", true));
            this.textBox33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox33.Location = new System.Drawing.Point(107, 99);
            this.textBox33.Name = "textBox33";
            this.textBox33.Size = new System.Drawing.Size(72, 30);
            this.textBox33.TabIndex = 10;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label32.Location = new System.Drawing.Point(3, 64);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(98, 32);
            this.label32.TabIndex = 29;
            this.label32.Text = "比賽";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox34
            // 
            this.textBox34.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov比賽姓名, "X", true));
            this.textBox34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox34.Location = new System.Drawing.Point(107, 35);
            this.textBox34.Name = "textBox34";
            this.textBox34.Size = new System.Drawing.Size(72, 30);
            this.textBox34.TabIndex = 6;
            // 
            // textBox29
            // 
            this.textBox29.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_Gov比賽姓名, "Y", true));
            this.textBox29.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox29.Location = new System.Drawing.Point(185, 35);
            this.textBox29.Name = "textBox29";
            this.textBox29.Size = new System.Drawing.Size(72, 30);
            this.textBox29.TabIndex = 7;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label31.Location = new System.Drawing.Point(3, 32);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(98, 32);
            this.label31.TabIndex = 14;
            this.label31.Text = "名字";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tableLayoutPanel10);
            this.groupBox9.Controls.Add(this.btn_英文獎狀測試);
            this.groupBox9.Location = new System.Drawing.Point(562, 129);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(344, 447);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "英文獎狀";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 3;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27F));
            this.tableLayoutPanel10.Controls.Add(this.label33, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.label37, 2, 0);
            this.tableLayoutPanel10.Controls.Add(this.label40, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.textBox31, 1, 1);
            this.tableLayoutPanel10.Controls.Add(this.textBox21, 2, 1);
            this.tableLayoutPanel10.Controls.Add(this.label36, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.textBox24, 1, 2);
            this.tableLayoutPanel10.Controls.Add(this.label38, 0, 3);
            this.tableLayoutPanel10.Controls.Add(this.textBox23, 1, 3);
            this.tableLayoutPanel10.Controls.Add(this.label39, 0, 4);
            this.tableLayoutPanel10.Controls.Add(this.textBox28, 1, 4);
            this.tableLayoutPanel10.Location = new System.Drawing.Point(6, 24);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 6;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(285, 191);
            this.tableLayoutPanel10.TabIndex = 36;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label33.Location = new System.Drawing.Point(134, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(70, 31);
            this.label33.TabIndex = 32;
            this.label33.Text = "X";
            // 
            // textBox21
            // 
            this.textBox21.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_En序號, "Y", true));
            this.textBox21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox21.Location = new System.Drawing.Point(210, 34);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(72, 30);
            this.textBox21.TabIndex = 25;
            // 
            // textBox24
            // 
            this.textBox24.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "EngFontNumber", true));
            this.textBox24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox24.Location = new System.Drawing.Point(134, 65);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(70, 30);
            this.textBox24.TabIndex = 30;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label36.Location = new System.Drawing.Point(3, 62);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(125, 31);
            this.label36.TabIndex = 31;
            this.label36.Text = "描述字體大小";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label37.Location = new System.Drawing.Point(210, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(72, 31);
            this.label37.TabIndex = 33;
            this.label37.Text = "Y";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label40.Location = new System.Drawing.Point(3, 31);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(125, 31);
            this.label40.TabIndex = 26;
            this.label40.Text = "序號";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox31
            // 
            this.textBox31.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_En序號, "X", true));
            this.textBox31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox31.Location = new System.Drawing.Point(134, 34);
            this.textBox31.Name = "textBox31";
            this.textBox31.Size = new System.Drawing.Size(70, 30);
            this.textBox31.TabIndex = 24;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label38.Location = new System.Drawing.Point(3, 93);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(125, 31);
            this.label38.TabIndex = 34;
            this.label38.Text = "姓名字體大小";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox23
            // 
            this.textBox23.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "EngNameFontNumber", true));
            this.textBox23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox23.Location = new System.Drawing.Point(134, 96);
            this.textBox23.Name = "textBox23";
            this.textBox23.Size = new System.Drawing.Size(70, 30);
            this.textBox23.TabIndex = 35;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label39.Location = new System.Drawing.Point(3, 124);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(125, 31);
            this.label39.TabIndex = 36;
            this.label39.Text = "行距";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox28
            // 
            this.textBox28.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs_System, "Eng行距", true));
            this.textBox28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox28.Location = new System.Drawing.Point(134, 127);
            this.textBox28.Name = "textBox28";
            this.textBox28.Size = new System.Drawing.Size(70, 30);
            this.textBox28.TabIndex = 37;
            // 
            // bs_Gov序號
            // 
            this.bs_Gov序號.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_System
            // 
            this.bs_System.DataSource = typeof(WindowsFormsApp1.SystemParameter);
            // 
            // bs_Gov比賽名稱
            // 
            this.bs_Gov比賽名稱.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_Gov屆數分組名次
            // 
            this.bs_Gov屆數分組名次.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_Gov比賽姓名
            // 
            this.bs_Gov比賽姓名.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW序號
            // 
            this.bs_TW序號.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW比賽名稱
            // 
            this.bs_TW比賽名稱.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW日
            // 
            this.bs_TW日.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW月
            // 
            this.bs_TW月.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW年
            // 
            this.bs_TW年.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW比賽分組
            // 
            this.bs_TW比賽分組.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW屆數
            // 
            this.bs_TW屆數.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_TW比賽姓名
            // 
            this.bs_TW比賽姓名.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
            // 
            // bs_En序號
            // 
            this.bs_En序號.DataSource = typeof(WindowsFormsApp1.TextPrintInfo);
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
            this.gbx_DbSetting.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov序號)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_System)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov比賽名稱)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov屆數分組名次)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_Gov比賽姓名)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW序號)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW比賽名稱)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW日)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW月)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW年)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW比賽分組)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW屆數)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_TW比賽姓名)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_En序號)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpg_統計;
        private System.Windows.Forms.TabPage tpg_setting;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gbx_DbSetting;
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
        private System.Windows.Forms.Button btn_特別獎名次;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_特別獎獎狀;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.BindingSource bs_TW比賽姓名;
        private System.Windows.Forms.BindingSource bs_TW屆數;
        private System.Windows.Forms.BindingSource bs_TW比賽名稱;
        private System.Windows.Forms.BindingSource bs_TW比賽分組;
        private System.Windows.Forms.BindingSource bs_TW年;
        private System.Windows.Forms.BindingSource bs_TW月;
        private System.Windows.Forms.BindingSource bs_TW日;
        private System.Windows.Forms.BindingSource bs_TW序號;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Button btn_LockDbSetting;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btn_國際組名字;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox textBox20;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox textBox25;
        private System.Windows.Forms.TextBox textBox26;
        private System.Windows.Forms.TextBox textBox27;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox textBox33;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox29;
        private System.Windows.Forms.TextBox textBox34;
        private System.Windows.Forms.BindingSource bs_Gov比賽姓名;
        private System.Windows.Forms.BindingSource bs_Gov比賽名稱;
        private System.Windows.Forms.BindingSource bs_Gov屆數分組名次;
        private System.Windows.Forms.BindingSource bs_Gov序號;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox textBox31;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox textBox23;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.TextBox textBox28;
        private System.Windows.Forms.BindingSource bs_En序號;
    }
}

