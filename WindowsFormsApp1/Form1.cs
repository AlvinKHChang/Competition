using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Text.RegularExpressions;
using System.Net.NetworkInformation;
using ZXing;
using ZXing.QrCode;
using iTextSharp;
using iTextSharp.text.pdf;
using Newtonsoft.Json;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Regex> _DrawingIdEx = new List<Regex> { new Regex(@"^X[ABCDEFG]053\d{4}$", RegexOptions.Compiled), new Regex(@"^Y025\d{4}$", RegexOptions.Compiled) };

        private string _LocalMac;
        private List<string> _比賽名稱s = new List<String>()
        {
            "高雄市永安區天文宮第五十三屆全國書法比賽",
            "高雄市永安區天文宮第二十五屆全國寫生比賽"
        };
        private Dictionary<int, string> _比賽名稱Dict = new Dictionary<int, String>()
        {
            {110, "高雄市永安區天文宮第五十三屆全國書法比賽" },
            {111, "高雄市永安區天文宮第二十五屆全國寫生比賽" }
        };
        private List<string> _屆數中文s = new List<String>()
        {
            "五十三",
            "二十五"
        };
        private List<string> _屆數數字s = new List<String>()
        {
            "53",
            "25"
        };
        private List<string> _屆數英文s = new List<String>()
        {
            "53rd",
            "25th"
        };

        private List<string> _名次英文s = new List<String>()
        {
            "First Prize",
            "Second Prize",
            "Third Prize",
            "Quality Award"
        };

        private Dictionary<String, int> _GroupDict = new Dictionary<String, int>();
        private List<String> _GroupList = new List<String>() { "長青組", "社會組", "高中組", "國中組", "國小高年級組", "國小中年級組", "國小低年級組", "幼稚園組", "國際組" };
        private Dictionary<String, int> _RankDict = new Dictionary<String, int>();
        private List<String> _RankList = new List<String>() { "第一名", "第二名", "第三名", "優選", "佳作", "入選" };
        private List<int> _CompetitionTypeList = new List<int> { 110, 111 };
        private DataTable _統計表log;
        private DataTable _報到作業紀錄log;
        private DataTable _指導老師紀錄log;
        private DataTable _排名作業統計log;
        private DataTable _成績統計log;
        private SystemParameter _SystemParameter;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.LoadParameter();

            this.tabControl1.TabPages.Remove(this.tpg_統計);
            this.tabControl1.TabPages.Remove(this.tpg_報到作業);
            this.tabControl1.TabPages.Remove(this.tpg_指導老師);
            this.tabControl1.TabPages.Remove(this.tpg_排名作業);
            this.tabControl1.TabPages.Remove(this.tpg_成績統計);
        }

        private void InitTabPages()
        {
            this.tabControl1.TabPages.Add(this.tpg_統計);
            this.tabControl1.TabPages.Add(this.tpg_報到作業);
            this.tabControl1.TabPages.Add(this.tpg_指導老師);
            this.tabControl1.TabPages.Add(this.tpg_排名作業);
            this.tabControl1.TabPages.Add(this.tpg_成績統計);

            for (int i = 0; i < this._GroupList.Count(); i++)
            {
                this._GroupDict.Add(this._GroupList[i], i);
            }

            for (int i = 0; i < this._RankList.Count(); i++)
            {
                this._RankDict.Add(this._GroupList[i], i);
            }

            _統計表log = new DataTable();
            _統計表log.Columns.Add("組別", typeof(string));
            _統計表log.Columns.Add("報名", typeof(int));
            _統計表log.Columns.Add("報到", typeof(int));
            _統計表log.Columns.Add("圖紙", typeof(int));
            _統計表log.Columns.Add("第一名", typeof(int));
            _統計表log.Columns.Add("第二名", typeof(int));
            _統計表log.Columns.Add("第三名", typeof(int));
            _統計表log.Columns.Add("優選", typeof(int));
            _統計表log.Columns.Add("佳作", typeof(int));
            _統計表log.Columns.Add("入選", typeof(int));
            dgv_統計表.DataSource = _統計表log;
            foreach (DataGridViewColumn col in dgv_統計表.Columns)
            {
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv_統計表.Columns["組別"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            cbx_統計表選擇比賽.Items.Add("書法比賽");
            cbx_統計表選擇比賽.Items.Add("寫生比賽");
            cbx_統計表選擇比賽.SelectedIndex = 0;

            _報到作業紀錄log = new DataTable();
            _報到作業紀錄log.Columns.Add("組別", typeof(string));
            _報到作業紀錄log.Columns.Add("參賽編號", typeof(string));
            _報到作業紀錄log.Columns.Add("姓名", typeof(string));
            _報到作業紀錄log.Columns.Add("圖紙編號", typeof(string));
            _報到作業紀錄log.Columns.Add("時間", typeof(string));
            dgv_報到作業紀錄.DataSource = _報到作業紀錄log;

            cbx_報到作業選擇比賽.Items.Add("書法比賽");
            cbx_報到作業選擇比賽.Items.Add("寫生比賽");
            cbx_報到作業選擇比賽.SelectedIndex = 0;

            foreach (var group in _GroupList)
            {
                cbx_報到作業選擇分組.Items.Add(group);
            }
            cbx_報到作業選擇分組.SelectedIndex = 0;
            chk_報到作業選擇分組.Checked = true;

            this._指導老師紀錄log = new DataTable();
            this._指導老師紀錄log.Columns.Add("老師姓名", typeof(string));
            this._指導老師紀錄log.Columns.Add("電    話", typeof(string));
            this._指導老師紀錄log.Columns.Add("報名人數", typeof(string));
            this._指導老師紀錄log.Columns.Add("報到人數", typeof(string));
            dgv_指導老師.DataSource = this._指導老師紀錄log;

            this.cbx_指導老師選擇比賽.Items.Add("書法比賽");
            this.cbx_指導老師選擇比賽.Items.Add("寫生比賽");
            this.cbx_指導老師選擇比賽.SelectedIndex = 0;

            this.cbx_排名作業選擇比賽.Items.Add("書法比賽");
            this.cbx_排名作業選擇比賽.Items.Add("寫生比賽");
            this.cbx_排名作業選擇比賽.SelectedIndex = 0;

            foreach (var group in _GroupList)
            {
                cbx_排名作業分組.Items.Add(group);
            }
            cbx_排名作業分組.SelectedIndex = 0;

            foreach (var rank in _RankList)
            {
                cbx_排名作業名次.Items.Add(rank);
            }
            cbx_排名作業名次.SelectedIndex = 0;

            this._排名作業統計log = new DataTable();
            this._排名作業統計log.Columns.Add("組別", typeof(string));
            this._排名作業統計log.Columns.Add("名次", typeof(string));
            this._排名作業統計log.Columns.Add("參賽編號", typeof(string));
            this._排名作業統計log.Columns.Add("姓名", typeof(string));
            this._排名作業統計log.Columns.Add("圖紙編號", typeof(string));
            this._排名作業統計log.Columns.Add("時間", typeof(string));
            dgv_排名作業統計.DataSource = this._排名作業統計log;

            this.cbx_成績比賽.Items.Add("書法");
            this.cbx_成績比賽.Items.Add("寫生");
            this.cbx_成績比賽.SelectedIndex = 0;

            foreach (var group in _GroupList)
            {
                cbx_成績分組.Items.Add(group);
            }
            cbx_成績分組.SelectedIndex = 0;

            this._成績統計log = new DataTable();
            this._成績統計log.Columns.Add("組別", typeof(string));
            this._成績統計log.Columns.Add("第一名", typeof(string));
            this._成績統計log.Columns.Add("第二名", typeof(string));
            this._成績統計log.Columns.Add("第三名", typeof(string));
            this._成績統計log.Columns.Add("優選", typeof(string));
            this._成績統計log.Columns.Add("佳作", typeof(string));
            this._成績統計log.Columns.Add("入選", typeof(string));
            dgv_成績統計.DataSource = this._成績統計log;

            NetworkInterface[] nics = NetworkInterface.GetAllNetworkInterfaces();
            foreach (var nic in nics)
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet)
                {
                    this._LocalMac = nic.GetPhysicalAddress().ToString();
                    break;
                }
            }
            this.tabControl1.SelectedIndex = 1;
        }

        private void btn_匯入參賽者資料_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "請選擇檔案";
            dialog.Filter = "Excel檔案(*.xls)|*.xls";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var dbContext = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    FileInfo fi = new FileInfo(dialog.FileName);
                    using (FileStream fstream = new FileStream(fi.FullName, FileMode.Open))
                    {

                        IWorkbook wb = new HSSFWorkbook(fstream);
                        ISheet sheet = wb.GetSheetAt(0);

                        for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue;
                            string entryNumber = row.GetCell(0).StringCellValue;
                            if (dbContext.Competitors.Where(p => p.EntryNumber == entryNumber).Any())
                            {
                                MessageBox.Show($"資料庫內已有重複的比賽編號: {entryNumber} !!");
                                return;
                            }
                        }
                        for (int i = (sheet.FirstRowNum + 1); i <= sheet.LastRowNum; i++)
                        {
                            IRow row = sheet.GetRow(i);
                            if (row == null) continue;
                            try
                            {
                                var competitor = new Competitor()
                                {
                                    EntryNumber = row.GetCell(0).StringCellValue,
                                    CompetitionType = int.Parse(row.GetCell(2).StringCellValue),
                                    Group = row.GetCell(3).StringCellValue,
                                    GroupId = _GroupDict[row.GetCell(3).StringCellValue],
                                    Name = row.GetCell(4).StringCellValue,
                                    Gender = row.GetCell(5).StringCellValue,
                                    School = row.GetCell(6).StringCellValue,
                                    Address = row.GetCell(7).StringCellValue,
                                    Phone = row.GetCell(8).StringCellValue,
                                    RegPhone = Regex.Replace(row.GetCell(8).StringCellValue, "[^0-9]", ""),
                                    Email = row.GetCell(9).StringCellValue,
                                    TeacherName = row.GetCell(10).StringCellValue,
                                    TeacherPhone = row.GetCell(11).StringCellValue,
                                    RegTeacherPhone = Regex.Replace(row.GetCell(11).StringCellValue, "[^0-9]", ""),
                                    CheckIn = false,
                                    RankId = 999,
                                    UpdatedTime = DateTime.Now,
                                };
                                dbContext.Competitors.Add(competitor);
                            }
                            catch (Exception ex)
                            {
                                var temp = row;
                                MessageBox.Show($"資料有問題: {ex}");
                            }
                        }
                        dbContext.SaveChanges();
                    }
                }
                MessageBox.Show($"匯入完成!!");
            }
        }

        private void btn_刪除所有資料_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TianwenContext(this._SystemParameter.ServerIp))
            {
                dbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE competitors");
                MessageBox.Show($"已刪除所有資料!!");
            }
        }

        private void btn_初始化所有資料_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var competitors = dbContext.Competitors.ToList();
                foreach (var competitor in competitors)
                {
                    competitor.Rank = null;
                    competitor.RankId = 999;
                    competitor.DrawingId = null;
                    competitor.CheckIn = false;
                    competitor.UpdatedIp = null;
                    competitor.UpdatedTime = DateTime.Now;
                }
                dbContext.SaveChanges();
                MessageBox.Show($"已初始化所有資料!!");
            }
        }

        private void btn_更新統計表_Click(object sender, EventArgs e)
        {

            _統計表log.Rows.Clear();
            int competitionIndex = _CompetitionTypeList[this.cbx_統計表選擇比賽.SelectedIndex];

            using (var dbContext = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var groups = dbContext.Competitors.Where(x => x.CompetitionType == competitionIndex).GroupBy(g => g.GroupId).OrderBy(g => g.Key).ToList();
                foreach (var group in groups)
                {
                    DataRow row = _統計表log.NewRow();
                    row[0] = group.First().Group;
                    row[1] = group.Count();
                    row[2] = group.Where(x => x.CheckIn).Count();
                    row[3] = group.Where(x => x.RankId == 0).Count();
                    row[4] = group.Where(x => x.RankId == 1).Count();
                    row[5] = group.Where(x => x.RankId == 2).Count();
                    row[6] = group.Where(x => x.RankId == 3).Count();
                    row[7] = group.Where(x => x.RankId == 4).Count();
                    row[8] = group.Where(x => x.RankId == 5).Count();
                    row[9] = group.Where(x => x.RankId == 6).Count();
                    _統計表log.Rows.Add(row);
                }
            }
        }

        private void txt_報到作業參賽編號_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txt_報到作業參賽編號.Text))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_報到作業選擇比賽.SelectedIndex];
                int groupIndex = this.cbx_報到作業選擇分組.SelectedIndex;
                Boolean hasGroup = this.chk_報到作業選擇分組.Checked;
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var result = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.EntryNumber == txt_報到作業參賽編號.Text.ToString() && (!hasGroup || x.GroupId == groupIndex)).FirstOrDefault();
                    if (result != null)
                    {
                        this.rtb_報到作業參賽資料.Clear();
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"參賽編號: {result.EntryNumber}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"組    別: {result.Group}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"姓    名: {result.Name}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"電    話: {result.Phone}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"地    址: {result.Address}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = result.CheckIn ? Color.Red : Color.Green;
                        var 報到Msg = result.CheckIn ? "Yes" : "No";
                        this.rtb_報到作業參賽資料.AppendText($"報    到: {報到Msg}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = result.DrawingId != null ? Color.Red : Color.Green;
                        var drawingMsg = result.DrawingId != null ? result.DrawingId : "--";
                        this.rtb_報到作業參賽資料.AppendText($"圖紙編號: {drawingMsg}" + Environment.NewLine);

                        if (result.DrawingId == null)
                        {
                            MessageBox.Show($"已綁定圖紙編號!!");
                        }
                        else
                        {
                            this.txt_報到作業圖紙編號.Focus();
                        }

                    }
                    else
                    {
                        this.rtb_報到作業參賽資料.Clear();
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"參賽編號: {txt_報到作業參賽編號.Text}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Red;
                        this.rtb_報到作業參賽資料.AppendText($"無符合的資料" + Environment.NewLine);
                        MessageBox.Show($"無參賽者資料!!");
                    }
                }
            }
        }
        private void txt_報到作業圖紙編號_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txt_報到作業參賽編號.Text) && !String.IsNullOrEmpty(txt_報到作業圖紙編號.Text))
            {

                if (!this._DrawingIdEx[this.cbx_報到作業選擇比賽.SelectedIndex].IsMatch(txt_報到作業圖紙編號.Text))
                {
                    MessageBox.Show($"圖紙編號格式有問題!!");
                    return;
                }
                int typeIndex = _CompetitionTypeList[this.cbx_報到作業選擇比賽.SelectedIndex];
                int groupIndex = this.cbx_報到作業選擇分組.SelectedIndex;
                Boolean hasGroup = this.chk_報到作業選擇分組.Checked;
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var result = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.EntryNumber == txt_報到作業參賽編號.Text.ToString() && x.DrawingId == null && (!hasGroup || x.GroupId == groupIndex)).FirstOrDefault();
                    if (result != null)
                    {
                        result.DrawingId = txt_報到作業圖紙編號.Text.ToString();
                        result.CheckIn = true;
                        result.UpdatedIp = this._LocalMac;
                        result.UpdatedTime = DateTime.Now;
                        db.SaveChanges();
                        this.rtb_報到作業參賽資料.Clear();
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"參賽編號: {result.EntryNumber}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"組    別: {result.Group}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"姓    名: {result.Name}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"電    話: {result.Phone}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"地    址: {result.Address}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = !result.CheckIn ? Color.Red : Color.Green;
                        var 報到Msg = result.CheckIn ? "Yes" : "No";
                        this.rtb_報到作業參賽資料.AppendText($"報    到: {報到Msg}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = result.DrawingId == null ? Color.Red : Color.Green;
                        var drawingMsg = result.DrawingId != null ? result.DrawingId : "--";
                        this.rtb_報到作業參賽資料.AppendText($"圖紙編號: {drawingMsg}" + Environment.NewLine);

                        DataRow row = this._報到作業紀錄log.NewRow();
                        row[0] = result.Group;
                        row[1] = result.EntryNumber;
                        row[2] = result.Name;
                        row[3] = result.DrawingId;
                        row[4] = result.UpdatedTime.ToString("MM/dd HH:mm:ss");
                        this._報到作業紀錄log.Rows.InsertAt(row, 0);
                        this.dgv_報到作業紀錄.ClearSelection();
                        this.dgv_報到作業紀錄.Rows[0].Selected = true;

                        this.txt_報到作業參賽編號.Clear();
                        this.txt_報到作業圖紙編號.Clear();
                        this.txt_報到作業參賽編號.Focus();
                    }
                    else
                    {
                        MessageBox.Show($"無符合的參賽者資料!!");
                    }
                }
            }
        }

        private void btn_報到作業清除紀錄_Click(object sender, EventArgs e)
        {
            this._報到作業紀錄log.Rows.Clear();
        }

        private void btn_報到作業本機記錄_Click(object sender, EventArgs e)
        {
            int typeIndex = _CompetitionTypeList[this.cbx_報到作業選擇比賽.SelectedIndex];
            int groupIndex = this.cbx_報到作業選擇分組.SelectedIndex;
            Boolean hasGroup = this.chk_報到作業選擇分組.Checked;
            this._報到作業紀錄log.Rows.Clear();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.DrawingId != null && x.UpdatedIp == this._LocalMac && (!hasGroup || x.GroupId == groupIndex)).OrderByDescending(x => x.UpdatedTime).ToList();
                foreach (var result in results)
                {
                    DataRow row = this._報到作業紀錄log.NewRow();
                    row[0] = result.Group;
                    row[1] = result.EntryNumber;
                    row[2] = result.Name;
                    row[3] = result.DrawingId;
                    row[4] = result.UpdatedTime.ToString("MM/dd HH:mm:ss");
                    this._報到作業紀錄log.Rows.Add(row);
                }
                this.dgv_報到作業紀錄.ClearSelection();
                this.dgv_報到作業紀錄.Rows[0].Selected = true;
            }
        }

        private void btn_報到作業重置狀態_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_報到作業參賽編號.Text))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_報到作業選擇比賽.SelectedIndex];
                int groupIndex = this.cbx_報到作業選擇分組.SelectedIndex;
                Boolean hasGroup = this.chk_報到作業選擇分組.Checked;
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var result = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.EntryNumber == txt_報到作業參賽編號.Text.ToString() && (!hasGroup || x.GroupId == groupIndex)).FirstOrDefault();
                    if (result != null)
                    {
                        result.CheckIn = false;
                        result.DrawingId = null;
                        result.UpdatedIp = this._LocalMac;
                        result.UpdatedTime = DateTime.Now;
                        db.SaveChanges();
                        this.rtb_報到作業參賽資料.Clear();
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"參賽編號: {result.EntryNumber}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"組    別: {result.Group}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"姓    名: {result.Name}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"電    話: {result.Phone}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"地    址: {result.Address}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = result.CheckIn ? Color.Red : Color.Green;
                        var 報到Msg = result.CheckIn ? "Yes" : "No";
                        this.rtb_報到作業參賽資料.AppendText($"報    到: {報到Msg}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = result.DrawingId != null ? Color.Red : Color.Green;
                        var drawingMsg = result.DrawingId != null ? result.DrawingId : "--";
                        this.rtb_報到作業參賽資料.AppendText($"圖紙編號: {drawingMsg}" + Environment.NewLine);
                    }
                    else
                    {
                        this.rtb_報到作業參賽資料.Clear();
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Blue;
                        this.rtb_報到作業參賽資料.AppendText($"參賽編號: {txt_報到作業參賽編號.Text}" + Environment.NewLine);
                        this.rtb_報到作業參賽資料.SelectionColor = Color.Red;
                        this.rtb_報到作業參賽資料.AppendText($"無符合的資料" + Environment.NewLine);
                        MessageBox.Show($"無參賽者資料!!");
                    }
                }
            }
        }

        private void btn_指導老師更新_Click(object sender, EventArgs e)
        {
            int 報名人數 = 0;
            int 報到人數 = 0;
            int.TryParse(this.txt_指導老師報名人數.Text, out 報名人數);
            int.TryParse(this.txt_指導老師報到人數.Text, out 報到人數);

            int typeIndex = _CompetitionTypeList[this.cbx_指導老師選擇比賽.SelectedIndex];
            this._指導老師紀錄log.Rows.Clear();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var groups = db.Competitors.Where(x => x.CompetitionType == typeIndex && !String.IsNullOrEmpty(x.TeacherName) && !String.IsNullOrEmpty(x.RegTeacherPhone)).GroupBy(x => x.RegTeacherPhone).OrderBy(g => g.Key).ToList();
                foreach (var group in groups)
                {
                    int real報名人數 = group.Count();
                    int real報到人數 = group.Where(x => x.DrawingId != null).Count();
                    if (real報名人數 >= 報名人數 && real報到人數 >= 報到人數)
                    {
                        DataRow row = this._指導老師紀錄log.NewRow();
                        row[0] = group.First().TeacherName;
                        row[1] = group.First().TeacherPhone;
                        row[2] = real報名人數;
                        row[3] = real報到人數;
                        this._指導老師紀錄log.Rows.Add(row);
                    }

                }

            }
        }

        private void cbx_統計表選擇比賽_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_更新統計表.PerformClick();
        }

        private void cbx_指導老師選擇比賽_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_指導老師更新.PerformClick();
        }

        private void txt_指導老師報名人數_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_指導老師更新.PerformClick();
            }
        }

        private void txt_指導老師報到人數_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.btn_指導老師更新.PerformClick();
            }
        }

        private void btn_排名作業更新_Click(object sender, EventArgs e)
        {
            int typeIndex = _CompetitionTypeList[this.cbx_排名作業選擇比賽.SelectedIndex];
            this._排名作業統計log.Rows.Clear();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var comps = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.GroupId == this.cbx_排名作業分組.SelectedIndex && x.RankId == this.cbx_排名作業名次.SelectedIndex).OrderByDescending(g => g.UpdatedTime).ToList();
                foreach (var comp in comps)
                {
                    DataRow row = this._排名作業統計log.NewRow();
                    row[0] = comp.Group;
                    row[1] = comp.Rank;
                    row[2] = comp.EntryNumber;
                    row[3] = comp.Name;
                    row[4] = comp.DrawingId;
                    row[5] = comp.UpdatedTime.ToString("MM/dd HH:mm:ss");
                    this._排名作業統計log.Rows.Add(row);


                }
                this.dgv_排名作業統計.ClearSelection();
                this.dgv_排名作業統計.Rows[0].Selected = true;
                this.lbl_排名作業人數.Text = comps.Count().ToString();
            }
        }

        private void cbx_排名作業選擇比賽_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_排名作業更新.PerformClick();
        }

        private void cbx_排名作業分組_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_排名作業更新.PerformClick();
        }

        private void cbx_排名作業名次_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btn_排名作業更新.PerformClick();
        }

        private void txt_排名作業參賽編號_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txt_排名作業參賽編號.Text))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_排名作業選擇比賽.SelectedIndex];
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var comp = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.GroupId == this.cbx_排名作業分組.SelectedIndex && x.EntryNumber == txt_排名作業參賽編號.Text).FirstOrDefault();
                    if (comp == null)
                    {
                        MessageBox.Show($"沒有符合的參賽編號: {txt_排名作業參賽編號.Text}");
                        return;
                    }
                    else
                    {
                        if (comp.Rank != null)
                        {
                            MessageBox.Show($"參賽編號: {txt_排名作業參賽編號.Text} 已設定為: {comp.Rank}");
                            return;
                        }
                        else
                        {
                            comp.Rank = this.cbx_排名作業名次.SelectedItem.ToString();
                            comp.RankId = this.cbx_排名作業名次.SelectedIndex;
                            comp.UpdatedTime = DateTime.Now;
                            db.SaveChanges();
                            this.btn_排名作業更新.PerformClick();
                            txt_排名作業參賽編號.Clear();
                            txt_排名作業圖紙編號.Clear();
                            txt_排名作業參賽編號.Focus();
                        }

                    }

                }
            }
        }

        private void txt_排名作業圖紙編號_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !String.IsNullOrEmpty(txt_排名作業圖紙編號.Text))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_排名作業選擇比賽.SelectedIndex];
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var comp = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.GroupId == this.cbx_排名作業分組.SelectedIndex && x.DrawingId == txt_排名作業圖紙編號.Text).FirstOrDefault();
                    if (comp == null)
                    {
                        MessageBox.Show($"沒有符合的圖紙編號: {txt_排名作業圖紙編號.Text}");
                        return;
                    }
                    else
                    {
                        if (comp.Rank != null)
                        {
                            MessageBox.Show($"圖紙編號: {txt_排名作業圖紙編號.Text} 已設定為: {comp.Rank}");
                            return;
                        }
                        else
                        {
                            comp.Rank = this.cbx_排名作業名次.SelectedItem.ToString();
                            comp.RankId = this.cbx_排名作業名次.SelectedIndex;
                            comp.UpdatedTime = DateTime.Now;
                            db.SaveChanges();
                            this.btn_排名作業更新.PerformClick();
                            txt_排名作業參賽編號.Clear();
                            txt_排名作業圖紙編號.Clear();
                            txt_排名作業圖紙編號.Focus();
                        }

                    }
                }
            }
        }

        private void chk_Unlock_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_Unlock.Checked)
            {
                this.btn_Reset排名作業參賽編號.Enabled = true;
                this.btn_Reset排名作業圖紙編號.Enabled = true;
            }
            else
            {
                this.btn_Reset排名作業參賽編號.Enabled = false;
                this.btn_Reset排名作業圖紙編號.Enabled = false;
            }
        }

        private void btn_Reset排名作業參賽編號_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txt_Reset排名作業參賽編號.Text))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_排名作業選擇比賽.SelectedIndex];
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var comp = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.GroupId == this.cbx_排名作業分組.SelectedIndex && x.EntryNumber == txt_Reset排名作業參賽編號.Text).FirstOrDefault();
                    if (comp == null)
                    {
                        MessageBox.Show($"沒有符合的參賽編號: {txt_Reset排名作業參賽編號.Text}");
                    }
                    else
                    {
                        comp.Rank = null;
                        comp.RankId = 999;
                        comp.UpdatedTime = DateTime.Now;
                        db.SaveChanges();
                    }
                }
            }
            this.chk_Unlock.Checked = false;
            this.btn_Reset排名作業參賽編號.Enabled = false;
            this.btn_Reset排名作業圖紙編號.Enabled = false;
            this.txt_Reset排名作業參賽編號.Text = String.Empty;
            this.btn_排名作業更新.PerformClick();
        }

        private void btn_Reset排名作業圖紙編號_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(this.txt_Reset排名作業圖紙編號.Text))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_排名作業選擇比賽.SelectedIndex];
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var comp = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.GroupId == this.cbx_排名作業分組.SelectedIndex && x.DrawingId == txt_Reset排名作業圖紙編號.Text).FirstOrDefault();
                    if (comp == null)
                    {
                        MessageBox.Show($"沒有符合的圖紙編號: {txt_Reset排名作業圖紙編號.Text}");
                    }
                    else
                    {
                        comp.Rank = null;
                        comp.RankId = 999;
                        comp.UpdatedTime = DateTime.Now;
                        db.SaveChanges();
                    }
                }
            }
            this.chk_Unlock.Checked = false;
            this.btn_Reset排名作業參賽編號.Enabled = false;
            this.btn_Reset排名作業圖紙編號.Enabled = false;
            this.txt_Reset排名作業圖紙編號.Text = String.Empty;
            this.btn_排名作業更新.PerformClick();
        }

        private void btn_成績更新_Click(object sender, EventArgs e)
        {
            int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                this._成績統計log.Rows.Clear();
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                                && (this.chk_成績不分組.Checked || x.GroupId == this.cbx_成績分組.SelectedIndex)
                                && x.Rank != null)
                    .OrderBy(g => new { g.GroupId, g.RankId, g.EntryNumber }).ToList();

                List<StringBuilder> builders = new List<StringBuilder>();
                for (int i = 0; i < this._RankList.Count(); i++)
                {
                    builders.Add(new StringBuilder());
                }
                builders.ForEach(x => x.Clear());

                List<int> indexs = new List<int>(this._RankList.Count());
                for (int i = 0; i < this._RankList.Count(); i++)
                {
                    indexs.Add(0);
                }

                int groupIndex = -1;
                Boolean isFirst = true;
                string 組別 = string.Empty;
                foreach (var comp in results)
                {
                    if (groupIndex != comp.GroupId)
                    {
                        if (!isFirst)
                        {
                            var row = this._成績統計log.NewRow();
                            row[0] = 組別;
                            row[1] = builders[0].ToString();
                            row[2] = builders[1].ToString();
                            row[3] = builders[2].ToString();
                            row[4] = builders[3].ToString();
                            row[5] = builders[4].ToString();
                            row[6] = builders[5].ToString();
                            this._成績統計log.Rows.Add(row);
                        }
                        groupIndex = comp.GroupId;
                        for (int i = 0; i < indexs.Count(); i++)
                        {
                            indexs[i] = 0;
                        }
                        builders.ForEach(x => x.Clear());
                        isFirst = false;
                    }
                    indexs[comp.RankId]++;
                    組別 = comp.Group;
                    builders[comp.RankId].Append($"{indexs[comp.RankId]}.{comp.Name}({comp.EntryNumber})");
                    builders[comp.RankId].Append(Environment.NewLine);
                }
                {
                    var row = this._成績統計log.NewRow();
                    row[0] = 組別;
                    row[1] = builders[0].ToString();
                    row[2] = builders[1].ToString();
                    row[3] = builders[2].ToString();
                    row[4] = builders[3].ToString();
                    row[5] = builders[4].ToString();
                    row[6] = builders[5].ToString();
                    this._成績統計log.Rows.Add(row);
                }



            }
        }

        private void btn_匯出參賽證_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txt_報到作業參賽編號.Text))
            {
                var str = new StringBuilder();
                str.Clear();
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var result = db.Competitors.Where(x => x.EntryNumber == txt_報到作業參賽編號.Text.ToString()).FirstOrDefault();
                    if (result != null)
                    {

                        str.AppendLine(this._比賽名稱Dict[result.CompetitionType]);
                        str.AppendLine($"報名編號: {result.EntryNumber}");
                        str.AppendLine($"組    別: {result.Group}");
                        str.AppendLine($"姓    名: {result.Name}");
                        if (!String.IsNullOrEmpty(result.PassportName))
                        {
                            str.AppendLine($"Name    : {result.PassportName}");
                        }
                        str.AppendLine($"電    話: {result.Phone}");
                        str.AppendLine($"地    址: {result.Address}");
                    }
                    else
                    {
                        MessageBox.Show($"無參賽者資料!!");
                        return;
                    }
                }

                var stream = new MemoryStream();

                //建立文件
                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
                {
                    string chFontPath = "c:\\windows\\fonts\\kaiu.ttf"; //標楷體                           
                    BaseFont baseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font chtFont = new iTextSharp.text.Font(baseFont, 14);

                    using (var writer = PdfWriter.GetInstance(doc, stream))
                    {
                        var qrCodeWriter = new ZXing.BarcodeWriter
                        {
                            Format = ZXing.BarcodeFormat.QR_CODE,
                            Options = new QrCodeEncodingOptions
                            {
                                Height = 100,
                                Width = 100,
                                Margin = 0
                            }
                        };
                        Bitmap bitmap = qrCodeWriter.Write(this.txt_報到作業參賽編號.Text);
                        ImageConverter converter = new ImageConverter();
                        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(ImageToByte(bitmap));
                        doc.Open();

                        iTextSharp.text.Paragraph paraQR = new iTextSharp.text.Paragraph();
                        paraQR.Leading = 15;
                        paraQR.Add(img);
                        doc.Add(paraQR);

                        iTextSharp.text.Paragraph paraInfo = new iTextSharp.text.Paragraph();
                        paraInfo.Leading = 15;
                        paraInfo.Add(new iTextSharp.text.Chunk(str.ToString(), chtFont));
                        doc.Add(paraInfo);

                        doc.Close();
                    }
                }

                var path = $"{_SystemParameter.TWRoot}\\參賽證";
                Directory.CreateDirectory(path);
                var filename = $"{path}\\{this.txt_報到作業參賽編號.Text}_{DateTime.Now.ToString("HHmmss")}.pdf";
                FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
                stream.WriteTo(file);
                file.Close();
                stream.Close();
                System.Diagnostics.Process.Start("Acrobat.exe", filename);
                stream.Dispose();

            }
        }

        public static byte[] ImageToByte(System.Drawing.Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        private void chk_成績不分組_CheckedChanged(object sender, EventArgs e)
        {
            gbx_獎狀.Enabled = !chk_成績不分組.Checked;
        }

        private void btn_市政府獎狀_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.GroupId == this.cbx_成績分組.SelectedIndex)
                               && (x.RankId <= 3))
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
                {
                    string chFontPath = "c:\\windows\\fonts\\kaiu.ttf"; //標楷體                           
                    BaseFont baseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font chtFont = new iTextSharp.text.Font(baseFont, _SystemParameter.GovFontNumber);
                    iTextSharp.text.Font pageFont = new iTextSharp.text.Font(baseFont, 10);
                    iTextSharp.text.Rectangle pageSize = doc.PageSize;
                    using (var writer = PdfWriter.GetInstance(doc, stream))
                    {
                        doc.Open();
                        PdfContentByte cb = writer.DirectContent;

                        int pageIndex = 1;
                        foreach (var comp in results)
                        {
                            iTextSharp.text.Phrase txtName = new iTextSharp.text.Phrase(comp.Name, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtName, pageSize.GetLeft(_SystemParameter.GovName.PointX), pageSize.GetTop(_SystemParameter.GovName.PointY), 0);
                            iTextSharp.text.Phrase txt比賽名稱;
                            txt比賽名稱 = new iTextSharp.text.Phrase($"天文獎  全國{this.cbx_成績比賽.SelectedItem}", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt比賽名稱, pageSize.GetLeft(_SystemParameter.Gov比賽名稱.PointX), pageSize.GetTop(_SystemParameter.Gov比賽名稱.PointY), 0);

                            iTextSharp.text.Phrase txt屆數組別名次;
                            txt屆數組別名次 = new iTextSharp.text.Phrase($"第{this._屆數中文s[this.cbx_成績比賽.SelectedIndex]}屆  {comp.Group}  {comp.Rank}", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt屆數組別名次, pageSize.GetLeft(_SystemParameter.Gov比賽屆數分組名次.PointX), pageSize.GetTop(_SystemParameter.Gov比賽屆數分組名次.PointY), 0);

                            iTextSharp.text.Phrase txtPageNumber = new iTextSharp.text.Phrase(pageIndex.ToString(), pageFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtPageNumber, pageSize.GetLeft(_SystemParameter.GovPageNumber.PointX), pageSize.GetTop(_SystemParameter.GovPageNumber.PointY), 0);

                            doc.NewPage();

                            if (comp.RankId == 2)
                                pageIndex = 1;
                            else
                                pageIndex++;
                        }
                        doc.Close();
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\獎狀";
            Directory.CreateDirectory(path);
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_{this._GroupList[this.cbx_成績分組.SelectedIndex]}_市政府獎狀_{DateTime.Now.ToString("HHmm")}.pdf";
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Acrobat.exe", filename);

            stream.Dispose();
        }

        private void btn_天文宮_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.GroupId == this.cbx_成績分組.SelectedIndex)
                               && (x.RankId == 4 || x.RankId == 5))
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
                {
                    string chFontPath = "c:\\windows\\fonts\\kaiu.ttf"; //標楷體                           
                    BaseFont baseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font chtFont = new iTextSharp.text.Font(baseFont, _SystemParameter.TWFontNumber);
                    iTextSharp.text.Font pageFont = new iTextSharp.text.Font(baseFont, 10);
                    iTextSharp.text.Rectangle pageSize = doc.PageSize;
                    using (var writer = PdfWriter.GetInstance(doc, stream))
                    {
                        doc.Open();
                        PdfContentByte cb = writer.DirectContent;

                        int rankIndex = 0;
                        int pageIndex = 1;
                        foreach (var comp in results)
                        {
                            if (rankIndex != comp.RankId)
                            {
                                rankIndex = comp.RankId;
                                pageIndex = 1;
                            }
                            iTextSharp.text.Phrase txtName = new iTextSharp.text.Phrase(comp.Name, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtName, pageSize.GetLeft(_SystemParameter.TWName.PointX), pageSize.GetTop(_SystemParameter.TWName.PointY), 0);

                            iTextSharp.text.Phrase txt屆數
                                = new iTextSharp.text.Phrase(this._屆數數字s[this.cbx_成績比賽.SelectedIndex], chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt屆數, pageSize.GetLeft(_SystemParameter.TW屆數.PointX), pageSize.GetTop(_SystemParameter.TW屆數.PointY), 0);

                            iTextSharp.text.Phrase txt比賽名稱
                                = new iTextSharp.text.Phrase(this.cbx_成績比賽.SelectedItem.ToString(), chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt比賽名稱, pageSize.GetLeft(_SystemParameter.TW比賽.PointX), pageSize.GetTop(_SystemParameter.TW比賽.PointY), 0);

                            iTextSharp.text.Phrase txt組別名次
                                = new iTextSharp.text.Phrase($"{comp.Group}  {comp.Rank}", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt組別名次, pageSize.GetLeft(_SystemParameter.TW分組名次.PointX), pageSize.GetTop(_SystemParameter.TW分組名次.PointY), 0);

                            iTextSharp.text.Phrase txtYear
                                = new iTextSharp.text.Phrase(_SystemParameter.TWYear.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWYear.PointX), pageSize.GetTop(_SystemParameter.TWYear.PointY), 0);

                            iTextSharp.text.Phrase txtMonth
                                = new iTextSharp.text.Phrase(_SystemParameter.TWMonth.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWMonth.PointX), pageSize.GetTop(_SystemParameter.TWMonth.PointY), 0);

                            iTextSharp.text.Phrase txtDay
                                = new iTextSharp.text.Phrase(_SystemParameter.TWDay.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWDay.PointX), pageSize.GetTop(_SystemParameter.TWDay.PointY), 0);

                            iTextSharp.text.Phrase txtPageNumber = new iTextSharp.text.Phrase(pageIndex.ToString(), pageFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtPageNumber, pageSize.GetLeft(_SystemParameter.TWPageNumber.PointX), pageSize.GetTop(_SystemParameter.TWPageNumber.PointY), 0);

                            doc.NewPage();
                            //paraInfo.Leading = 15;
                            //paraInfo.Add(new iTextSharp.text.Chunk(comp.Name, chtFont));
                            //doc.Add(paraInfo).set;
                            if (comp.RankId == 2)
                                pageIndex = 1;
                            else
                                pageIndex++;
                        }
                        doc.Close();
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\獎狀";
            Directory.CreateDirectory(path);
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_{this._GroupList[this.cbx_成績分組.SelectedIndex]}_天文宮獎狀_{DateTime.Now.ToString("HHmm")}.pdf";
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Acrobat.exe", filename);

            stream.Dispose();
        }

        private void btn_國際組中文_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.GroupId == this.cbx_成績分組.SelectedIndex)
                               && (x.RankId <= 5))
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
                {
                    string chFontPath = "c:\\windows\\fonts\\kaiu.ttf"; //標楷體                           
                    BaseFont baseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font chtFont = new iTextSharp.text.Font(baseFont, _SystemParameter.TWFontNumber);
                    iTextSharp.text.Font pageFont = new iTextSharp.text.Font(baseFont, 10);
                    iTextSharp.text.Rectangle pageSize = doc.PageSize;
                    using (var writer = PdfWriter.GetInstance(doc, stream))
                    {
                        doc.Open();
                        PdfContentByte cb = writer.DirectContent;

                        int rankIndex = 0;
                        int pageIndex = 1;
                        foreach (var comp in results)
                        {
                            if (comp.RankId > 2 && rankIndex != comp.RankId)
                            {
                                rankIndex = comp.RankId;
                                pageIndex = 1;
                            }
                            iTextSharp.text.Phrase txtName = new iTextSharp.text.Phrase(comp.Name, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtName, pageSize.GetLeft(_SystemParameter.TWName.PointX), pageSize.GetTop(_SystemParameter.TWName.PointY), 0);

                            iTextSharp.text.Phrase txt屆數
                                = new iTextSharp.text.Phrase(this._屆數數字s[this.cbx_成績比賽.SelectedIndex], chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt屆數, pageSize.GetLeft(_SystemParameter.TW屆數.PointX), pageSize.GetTop(_SystemParameter.TW屆數.PointY), 0);

                            iTextSharp.text.Phrase txt比賽名稱
                                = new iTextSharp.text.Phrase(this.cbx_成績比賽.SelectedItem.ToString(), chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt比賽名稱, pageSize.GetLeft(_SystemParameter.TW比賽.PointX), pageSize.GetTop(_SystemParameter.TW比賽.PointY), 0);

                            iTextSharp.text.Phrase txt組別名次
                                = new iTextSharp.text.Phrase($"{comp.Group}  {comp.Rank}", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt組別名次, pageSize.GetLeft(_SystemParameter.TW分組名次.PointX), pageSize.GetTop(_SystemParameter.TW分組名次.PointY), 0);

                            iTextSharp.text.Phrase txtYear
                                = new iTextSharp.text.Phrase(_SystemParameter.TWYear.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWYear.PointX), pageSize.GetTop(_SystemParameter.TWYear.PointY), 0);

                            iTextSharp.text.Phrase txtMonth
                                = new iTextSharp.text.Phrase(_SystemParameter.TWMonth.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWMonth.PointX), pageSize.GetTop(_SystemParameter.TWMonth.PointY), 0);

                            iTextSharp.text.Phrase txtDay
                                = new iTextSharp.text.Phrase(_SystemParameter.TWDay.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWDay.PointX), pageSize.GetTop(_SystemParameter.TWDay.PointY), 0);

                            iTextSharp.text.Phrase txtPageNumber = new iTextSharp.text.Phrase(pageIndex.ToString(), pageFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtPageNumber, pageSize.GetLeft(_SystemParameter.TWPageNumber.PointX), pageSize.GetTop(_SystemParameter.TWPageNumber.PointY), 0);

                            doc.NewPage();
                            //paraInfo.Leading = 15;
                            //paraInfo.Add(new iTextSharp.text.Chunk(comp.Name, chtFont));
                            //doc.Add(paraInfo).set;
                            if (comp.RankId == 2)
                                pageIndex = 1;
                            else
                                pageIndex++;
                        }
                        doc.Close();
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\獎狀";
            Directory.CreateDirectory(path);
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_{this._GroupList[this.cbx_成績分組.SelectedIndex]}_國際組中文_{DateTime.Now.ToString("HHmm")}.pdf";
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Acrobat.exe", filename);

            stream.Dispose();
        }

        private void btn_國際組英文_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.GroupId == this.cbx_成績分組.SelectedIndex)
                               && (x.RankId < 4))
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4.Rotate()))
                {
                    string genFontPath = "c:\\windows\\fonts\\PALSCRI.ttf";
                    string nameFontPath = "c:\\windows\\fonts\\timesbi.ttf";
                    string timesFontPath = "c:\\windows\\fonts\\times.ttf";
                    string chFontPath = "c:\\windows\\fonts\\kaiu.ttf"; //標楷體   
                    BaseFont genBaseFont = BaseFont.CreateFont(genFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    BaseFont nameBaseFont = BaseFont.CreateFont(nameFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    BaseFont timesBaseFont = BaseFont.CreateFont(timesFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    BaseFont chBaseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                                        
                    float dist = iTextSharp.text.Utilities.MillimetersToPoints(_SystemParameter.Eng行距);
                    iTextSharp.text.Font genFont = new iTextSharp.text.Font(genBaseFont, _SystemParameter.EngFontNumber);
                    iTextSharp.text.Font nameFont = new iTextSharp.text.Font(nameBaseFont, _SystemParameter.EngNameFontNumber);
                    iTextSharp.text.Font chtFont = new iTextSharp.text.Font(chBaseFont, _SystemParameter.TWFontNumber, 3);
                    iTextSharp.text.Font pageFont = new iTextSharp.text.Font(timesBaseFont, 10);
                    iTextSharp.text.Rectangle pageSize = doc.PageSize;
                    using (var writer = PdfWriter.GetInstance(doc, stream))
                    {
                        doc.Open();
                        PdfContentByte cb = writer.DirectContent;

                        int rankIndex = 0;
                        int pageIndex = 1;
                        foreach (var comp in results)
                        {
                            if (comp.RankId > 2 && rankIndex != comp.RankId)
                            {
                                rankIndex = comp.RankId;
                                pageIndex = 1;
                            }

                            iTextSharp.text.Phrase txtPhrase1 = new iTextSharp.text.Phrase("This certificate is presented to", genFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_CENTER, txtPhrase1, pageSize.Right / 2, pageSize.Top / 2 + dist * 2, 0);

                            iTextSharp.text.Phrase txtPhrase2;
                            if (comp.PassportName != null && Regex.IsMatch(comp.PassportName, "[A-Za-z]"))
                            {
                                txtPhrase2 = new iTextSharp.text.Phrase(comp.PassportName, nameFont);
                            }
                            else
                            {
                                txtPhrase2 = new iTextSharp.text.Phrase(comp.Name, chtFont);
                            }
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_CENTER, txtPhrase2, pageSize.Right / 2, pageSize.Top / 2 + dist, 0);

                            iTextSharp.text.Phrase txtPhrase3 = new iTextSharp.text.Phrase("For Successfully Completing the", genFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_CENTER, txtPhrase3, pageSize.Right / 2, pageSize.Top / 2, 0);

                            iTextSharp.text.Phrase txtPhrase4 = new iTextSharp.text.Phrase(this._名次英文s[comp.RankId], nameFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_CENTER, txtPhrase4, pageSize.Right / 2, pageSize.Top / 2 - dist, 0);

                            iTextSharp.text.Phrase txtPhrase5 = new iTextSharp.text.Phrase("In The 53th Annual Calligraphy Competition of Tian Wen Temple", genFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_CENTER, txtPhrase5, pageSize.Right / 2, pageSize.Top / 2 - dist * 2, 0);
                                                        
                            iTextSharp.text.Phrase txtPageNumber = new iTextSharp.text.Phrase(pageIndex.ToString(), pageFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtPageNumber, pageSize.GetLeft(_SystemParameter.EnPageNumber.PointX), pageSize.GetTop(_SystemParameter.EnPageNumber.PointY), 0);

                            doc.NewPage();

                            //paraInfo.Leading = 15;
                            //paraInfo.Add(new iTextSharp.text.Chunk(comp.Name, chtFont));
                            //doc.Add(paraInfo).set;
                            if (comp.RankId == 2)
                                pageIndex = 1;
                            else
                                pageIndex++;
                        }
                        doc.Close();
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\獎狀";
            Directory.CreateDirectory(path);
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_{this._GroupList[this.cbx_成績分組.SelectedIndex]}_國際組英文_{DateTime.Now.ToString("HHmmss")}.pdf";
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();
            stream.Dispose();
            System.Diagnostics.Process.Start("Acrobat.exe", filename);

        }

        private void btn_領獎單_Click(object sender, EventArgs e)
        {
            Stream stream = new MemoryStream(Properties.Resources.領獎單範本);
            IWorkbook workbook = new HSSFWorkbook(stream);
            ISheet sheet = workbook.GetSheet("工作表1");

            ICellStyle headerCellStyle = sheet.GetRow(0).GetCell(0).CellStyle;
            sheet.GetRow(0).GetCell(0).SetCellValue($"{this._比賽名稱s[this.cbx_成績比賽.SelectedIndex]}{Environment.NewLine}{ this.cbx_成績分組.SelectedItem}  比賽領獎單");

            List<ICellStyle> cellStyles = new List<ICellStyle>();
            int cellsCount = 8;
            for (int i = 0; i < cellsCount; i++)
            {
                cellStyles.Add(sheet.GetRow(2).GetCell(i).CellStyle);
            }
            sheet.RemoveRow(sheet.GetRow(2));

            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.GroupId == this.cbx_成績分組.SelectedIndex)
                               && (x.RankId <= 5))
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                int rankIndex = 0;
                int serialNo = 1;
                int lastRowIndex = 2;
                int rowInPage = 0;
                foreach (var comp in results)
                {
                    if (comp.RankId > 2 && rankIndex != comp.RankId)
                    {
                        rankIndex = comp.RankId;
                        serialNo = 1;
                        sheet.SetRowBreak(lastRowIndex - 1);
                        rowInPage = 0;
                    }
                    IRow row = sheet.CreateRow(lastRowIndex);
                    for (int i = 0; i < cellsCount; i++)
                    {
                        ICell cell = row.CreateCell(i);
                        cell.CellStyle = cellStyles[i];
                    }
                    row.Cells[0].SetCellValue(serialNo.ToString());
                    row.Cells[1].SetCellValue(comp.EntryNumber);
                    row.Cells[2].SetCellValue(comp.Group);
                    row.Cells[3].SetCellValue(comp.Name);
                    row.Cells[4].SetCellValue(comp.Rank);
                    row.Cells[5].SetCellValue(comp.TeacherName);
                    row.Cells[6].SetCellValue(comp.School);
                    rowInPage++;
                    if (rowInPage >= 10)
                    {
                        sheet.SetRowBreak(lastRowIndex);
                        rowInPage = 0;
                    }
                    lastRowIndex++;
                    serialNo++;
                }

            }

            var path = $"{_SystemParameter.TWRoot}\\領獎單";
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_{this._GroupList[this.cbx_成績分組.SelectedIndex]}_領獎單_{DateTime.Now.ToString("HHmmss")}.xls";
            Directory.CreateDirectory(path);
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                workbook.Write(file);
                file.Close();
            }
            workbook.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Excel.exe", filename);

        }

        private void btn_名次公告_Click(object sender, EventArgs e)
        {
            Stream stream = new MemoryStream(Properties.Resources.成績公告範本);
            IWorkbook workbook = new HSSFWorkbook(stream);
            ISheet sheet = workbook.GetSheet("工作表1");

            ICellStyle headerCellStyle = sheet.GetRow(0).GetCell(0).CellStyle;
            sheet.GetRow(0).GetCell(0).SetCellValue($"{this._比賽名稱s[this.cbx_成績比賽.SelectedIndex]}{Environment.NewLine}{ this.cbx_成績分組.SelectedItem}  比賽成績公告");

            List<ICellStyle> cellStyles = new List<ICellStyle>();
            int cellsCount = 3;
            for (int i = 0; i < cellsCount; i++)
            {
                cellStyles.Add(sheet.GetRow(2).GetCell(i).CellStyle);
            }
            sheet.RemoveRow(sheet.GetRow(2));

            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.GroupId == this.cbx_成績分組.SelectedIndex)
                               && (x.RankId <= 5))
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                int rankIndex = 0;
                int lastRowIndex = 2;
                int rowInPage = 0;
                foreach (var comp in results)
                {
                    if (comp.RankId > 2 && rankIndex != comp.RankId)
                    {
                        rankIndex = comp.RankId;
                        sheet.SetRowBreak(lastRowIndex - 1);
                        rowInPage = 0;
                    }
                    IRow row = sheet.CreateRow(lastRowIndex);
                    for (int i = 0; i < cellsCount; i++)
                    {
                        ICell cell = row.CreateCell(i);
                        cell.CellStyle = cellStyles[i];
                    }
                    row.Cells[0].SetCellValue(comp.EntryNumber);
                    row.Cells[1].SetCellValue(this.MaskName(comp.Name));
                    row.Cells[2].SetCellValue(comp.Rank);
                    rowInPage++;
                    if (rowInPage >= 25)
                    {
                        sheet.SetRowBreak(lastRowIndex);
                        rowInPage = 0;
                    }
                    lastRowIndex++;
                }

            }

            var path = $"{_SystemParameter.TWRoot}\\領獎單";
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_{this._GroupList[this.cbx_成績分組.SelectedIndex]}_成績公告_{DateTime.Now.ToString("HHmmss")}.xls";
            Directory.CreateDirectory(path);
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                workbook.Write(file);
                file.Close();
            }
            workbook.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Excel.exe", filename);
        }


        private string MaskName(string val)
        {
            string maskstr;
            //符合英文的模式
            if (Regex.IsMatch(val, "[A-Za-z]"))
            {
                if (val.IndexOf("-") > 1)
                {
                    maskstr = val.Split('-')[1];
                    val = val.Replace(maskstr, "*");
                }
                if (val.IndexOf(" ") > 1)
                {
                    maskstr = val.Split(' ')[1];
                    val = val.Replace(maskstr, "*");
                }
            }
            else
            {
                //中文
                int strlen = val.Length;
                if (strlen == 2)
                {
                    return val.Substring(0, 1) + "O";
                }
                if (strlen == 3)
                {
                    return val.Substring(0, 1) + "O" + val.Substring(2, 1);
                }
                if (strlen >= 4)
                {
                    return val.Substring(0, 2) + "O" + val.Substring(3, strlen - 3);
                }
            }
            return val;
        }

        private string MaskPhone(string val)
        {
            int strlen = val.Length;
            if (strlen < 4)
            {
                return val;
            }
            else
            {
                return val.Substring(0, strlen - 4) + "xxxx";
            }
        }


        private void btn_老師領獎單_Click(object sender, EventArgs e)
        {
            Stream stream = new MemoryStream(Properties.Resources.帶隊老師領獎單範本);
            IWorkbook workbook = new HSSFWorkbook(stream);
            ISheet sheet = workbook.GetSheet("工作表1");

            ICellStyle headerCellStyle = sheet.GetRow(0).GetCell(0).CellStyle;
            sheet.GetRow(0).GetCell(0).SetCellValue($"{this._比賽名稱s[this.cbx_指導老師選擇比賽.SelectedIndex]}");

            List<ICellStyle> cellStyles = new List<ICellStyle>();
            int cellsCount = 6;
            for (int i = 0; i < cellsCount; i++)
            {
                cellStyles.Add(sheet.GetRow(3).GetCell(i).CellStyle);
            }
            sheet.RemoveRow(sheet.GetRow(3));

            int 報名人數 = 0;
            int 報到人數 = 0;
            int.TryParse(this.txt_指導老師報名人數.Text, out 報名人數);
            int.TryParse(this.txt_指導老師報到人數.Text, out 報到人數);

            int typeIndex = _CompetitionTypeList[this.cbx_指導老師選擇比賽.SelectedIndex];
            this._指導老師紀錄log.Rows.Clear();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var groups = db.Competitors.Where(x => x.CompetitionType == typeIndex && !String.IsNullOrEmpty(x.TeacherName) && !String.IsNullOrEmpty(x.RegTeacherPhone)).GroupBy(x => x.RegTeacherPhone).OrderBy(g => g.Key).ToList();
                int lastRowIndex = 3;
                int rowInPage = 0;
                foreach (var group in groups)
                {
                    int real報名人數 = group.Count();
                    int real報到人數 = group.Where(x => x.DrawingId != null).Count();
                    if (real報名人數 >= 報名人數 && real報到人數 >= 報到人數)
                    {
                        IRow row = sheet.CreateRow(lastRowIndex);
                        for (int i = 0; i < cellsCount; i++)
                        {
                            ICell cell = row.CreateCell(i);
                            cell.CellStyle = cellStyles[i];
                        }

                        row.Cells[0].SetCellValue((lastRowIndex - 2).ToString());
                        row.Cells[1].SetCellValue(group.First().TeacherName);
                        row.Cells[2].SetCellValue(group.First().TeacherPhone);
                        row.Cells[3].SetCellValue(real報名人數.ToString());
                        row.Cells[4].SetCellValue(real報到人數.ToString());
                        rowInPage++;
                        if (rowInPage >= 10)
                        {
                            sheet.SetRowBreak(lastRowIndex);
                            rowInPage = 0;
                        }
                        lastRowIndex++;
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\領獎單";
            var filename = $"{path}\\{this.cbx_指導老師選擇比賽.SelectedItem}_帶隊老師領獎單_{DateTime.Now.ToString("HHmmss")}.xls";
            Directory.CreateDirectory(path);
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                workbook.Write(file);
                file.Close();
            }
            workbook.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Excel.exe", filename);
        }

        private void btn_老師公告單_Click(object sender, EventArgs e)
        {
            Stream stream = new MemoryStream(Properties.Resources.帶隊老師公告範本);
            IWorkbook workbook = new HSSFWorkbook(stream);
            ISheet sheet = workbook.GetSheet("工作表1");

            ICellStyle headerCellStyle = sheet.GetRow(0).GetCell(0).CellStyle;
            sheet.GetRow(0).GetCell(0).SetCellValue($"{this._比賽名稱s[this.cbx_指導老師選擇比賽.SelectedIndex]}");

            List<ICellStyle> cellStyles = new List<ICellStyle>();
            int cellsCount = 5;
            for (int i = 0; i < cellsCount; i++)
            {
                cellStyles.Add(sheet.GetRow(3).GetCell(i).CellStyle);
            }
            sheet.RemoveRow(sheet.GetRow(3));

            int 報名人數 = 0;
            int 報到人數 = 0;
            int.TryParse(this.txt_指導老師報名人數.Text, out 報名人數);
            int.TryParse(this.txt_指導老師報到人數.Text, out 報到人數);

            int typeIndex = _CompetitionTypeList[this.cbx_指導老師選擇比賽.SelectedIndex];
            this._指導老師紀錄log.Rows.Clear();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var groups = db.Competitors.Where(x => x.CompetitionType == typeIndex && !String.IsNullOrEmpty(x.TeacherName) && !String.IsNullOrEmpty(x.RegTeacherPhone)).GroupBy(x => x.RegTeacherPhone).OrderBy(g => g.Key).ToList();
                int lastRowIndex = 3;
                int rowInPage = 0;
                foreach (var group in groups)
                {
                    int real報名人數 = group.Count();
                    int real報到人數 = group.Where(x => x.DrawingId != null).Count();
                    if (real報名人數 >= 報名人數 && real報到人數 >= 報到人數)
                    {
                        IRow row = sheet.CreateRow(lastRowIndex);
                        for (int i = 0; i < cellsCount; i++)
                        {
                            ICell cell = row.CreateCell(i);
                            cell.CellStyle = cellStyles[i];
                        }

                        row.Cells[0].SetCellValue((lastRowIndex - 2).ToString());
                        row.Cells[1].SetCellValue(this.MaskName(group.First().TeacherName));
                        row.Cells[2].SetCellValue(this.MaskPhone(group.First().TeacherPhone));
                        row.Cells[3].SetCellValue(real報名人數.ToString());
                        row.Cells[4].SetCellValue(real報到人數.ToString());
                        rowInPage++;
                        if (rowInPage >= 25)
                        {
                            sheet.SetRowBreak(lastRowIndex);
                            rowInPage = 0;
                        }
                        lastRowIndex++;
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\領獎單";
            var filename = $"{path}\\{this.cbx_指導老師選擇比賽.SelectedItem}_帶隊老師公告單_{DateTime.Now.ToString("HHmmss")}.xls";
            Directory.CreateDirectory(path);
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                workbook.Write(file);
                file.Close();
            }
            workbook.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Excel.exe", filename);
        }

        private void btn_英文獎狀測試_Click(object sender, EventArgs e)
        {
            this.btn_國際組英文.PerformClick();
        }

        private void btn_天文宮獎狀測試_Click(object sender, EventArgs e)
        {
            this.btn_天文宮.PerformClick();
        }

        private void btn_市政府獎狀測試_Click(object sender, EventArgs e)
        {
            this.btn_市政府獎狀.PerformClick();
        }

        private int UnlockDbSettingCnt = 0;

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            UnlockDbSettingCnt = 0;
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                UnlockDbSettingCnt++;
                if (UnlockDbSettingCnt >= 5)
                {
                    this.gbx_DbSetting.Visible = true;
                }
            }
            else
            {
                UnlockDbSettingCnt = 0;
            }
        }

        private void btn_清除報到輸入_Click(object sender, EventArgs e)
        {
            this.txt_報到作業參賽編號.Clear();
            this.txt_報到作業圖紙編號.Clear();
            this.rtb_報到作業參賽資料.Clear();
            this.txt_報到作業參賽編號.Focus();

        }

        private bool _From參賽編號;

        private void btn_排名欄位清除_Click(object sender, EventArgs e)
        {
            this.txt_排名作業參賽編號.Clear();
            this.txt_排名作業圖紙編號.Clear();
            if (_From參賽編號)
            {
                this.txt_排名作業參賽編號.Focus();
            }
            else
            {
                this.txt_排名作業圖紙編號.Focus();
            }
        }

        private void txt_排名作業參賽編號_Leave(object sender, EventArgs e)
        {
            _From參賽編號 = true;
        }

        private void txt_排名作業圖紙編號_Leave(object sender, EventArgs e)
        {
            _From參賽編號 = false;
        }

        private void btn_測試連線_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new TianwenContext(this._SystemParameter.ServerIp))
                {
                    var comp = db.Competitors.FirstOrDefault();
                    if (comp != null)
                    {
                        this.grb_市政府獎狀.Enabled = true;
                        this.grb_天文宮獎狀.Enabled = true;
                        this.grb_英文獎狀.Enabled = true;
                        this.InitTabPages();
                        MessageBox.Show("連線成功");
                    }
                    else
                    {
                        MessageBox.Show("無對應資料!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"連線失敗: {ex.Message}!!");
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            File.WriteAllText("SystemParameters.json", JsonConvert.SerializeObject(this._SystemParameter));
            MessageBox.Show("儲存成功");

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            this.LoadParameter();

        }

        private void LoadParameter()
        {
            string file = "SystemParameters.json";
            if (File.Exists(file))
            {
                var json = File.ReadAllText(file);
                var para = JsonConvert.DeserializeObject<SystemParameter>(json);
                if (para != null)
                    this._SystemParameter = para;
                else
                    this._SystemParameter = new SystemParameter();
            }
            else
            {
                this._SystemParameter = new SystemParameter();
            }

            this.bs_System.DataSource = this._SystemParameter;
            this.bs_TW比賽姓名.DataSource = this._SystemParameter.TWName;
            this.bs_TW比賽名稱.DataSource = this._SystemParameter.TW比賽;
            this.bs_TW屆數.DataSource = this._SystemParameter.TW屆數;
            this.bs_TW比賽分組.DataSource = this._SystemParameter.TW分組名次;
            this.bs_TW年.DataSource = this._SystemParameter.TWYear;
            this.bs_TW月.DataSource = this._SystemParameter.TWMonth;
            this.bs_TW日.DataSource = this._SystemParameter.TWDay;
            this.bs_TW序號.DataSource = this._SystemParameter.TWPageNumber;
            this.bs_Gov比賽姓名.DataSource = this._SystemParameter.GovName;
            this.bs_Gov比賽名稱.DataSource = this._SystemParameter.Gov比賽名稱;
            this.bs_Gov屆數分組名次.DataSource = this._SystemParameter.Gov比賽屆數分組名次;
            this.bs_Gov序號.DataSource = this._SystemParameter.GovPageNumber;
            this.bs_En序號.DataSource = this._SystemParameter.EnPageNumber;
        }

        private void btn_特別獎名次_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TianwenContext(this._SystemParameter.ServerIp))
            {
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '第一名', rank_id = 0 WHERE entry_name = 'BS0100001';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '第二名', rank_id = 1 WHERE entry_name = 'BS0100002';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '第三名', rank_id = 2 WHERE entry_name = 'BS0100003';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '優選', rank_id = 3 WHERE entry_name = 'BS0100004';;");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100005'");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100006';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100007';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100008';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100009';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100010';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100011';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100012';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET rank = '佳作', rank_id = 4 WHERE entry_name = 'BS0100013';");

                MessageBox.Show($"已更新特別獎名次!!");
            }
        }

        private void btn_特別獎獎狀_Click(object sender, EventArgs e)
        {
            var stream = new MemoryStream();
            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                var results = db.Competitors.Where(x => x.CompetitionType == 112)
                   .OrderBy(g => new { g.RankId, g.EntryNumber }).ToList();

                using (var doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4))
                {
                    string chFontPath = "c:\\windows\\fonts\\kaiu.ttf"; //標楷體                           
                    BaseFont baseFont = BaseFont.CreateFont(chFontPath, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);
                    iTextSharp.text.Font chtFont = new iTextSharp.text.Font(baseFont, _SystemParameter.TWFontNumber, 1);
                    iTextSharp.text.Font pageFont = new iTextSharp.text.Font(baseFont, 10);
                    iTextSharp.text.Rectangle pageSize = doc.PageSize;
                    using (var writer = PdfWriter.GetInstance(doc, stream))
                    {
                        doc.Open();
                        PdfContentByte cb = writer.DirectContent;

                        int rankIndex = 0;
                        int pageIndex = 1;
                        foreach (var comp in results)
                        {
                            if (comp.RankId >= 3 && rankIndex != comp.RankId)
                            {
                                rankIndex = comp.RankId;
                                pageIndex = 1;
                            }
                            iTextSharp.text.Phrase txtName = new iTextSharp.text.Phrase(comp.Name, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtName, pageSize.GetLeft(_SystemParameter.TWName.PointX), pageSize.GetTop(_SystemParameter.TWName.PointY), 0);

                            iTextSharp.text.Phrase txt屆數
                                = new iTextSharp.text.Phrase("25", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt屆數, pageSize.GetLeft(_SystemParameter.TW屆數.PointX), pageSize.GetTop(_SystemParameter.TW屆數.PointY), 0);

                            iTextSharp.text.Phrase txt比賽名稱
                                = new iTextSharp.text.Phrase("寫生", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt比賽名稱, pageSize.GetLeft(_SystemParameter.TW比賽.PointX), pageSize.GetTop(_SystemParameter.TW比賽.PointY), 0);

                            iTextSharp.text.Phrase txt組別名次
                                = new iTextSharp.text.Phrase($"特別獎 {comp.Group} {comp.Rank}", chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txt組別名次, pageSize.GetLeft(_SystemParameter.TW分組名次.PointX), pageSize.GetTop(_SystemParameter.TW分組名次.PointY), 0);

                            iTextSharp.text.Phrase txtYear
                                = new iTextSharp.text.Phrase(_SystemParameter.TWYear.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtYear, pageSize.GetLeft(_SystemParameter.TWYear.PointX), pageSize.GetTop(_SystemParameter.TWYear.PointY), 0);

                            iTextSharp.text.Phrase txtMonth
                                = new iTextSharp.text.Phrase(_SystemParameter.TWMonth.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtMonth, pageSize.GetLeft(_SystemParameter.TWMonth.PointX), pageSize.GetTop(_SystemParameter.TWMonth.PointY), 0);

                            iTextSharp.text.Phrase txtDay
                                = new iTextSharp.text.Phrase(_SystemParameter.TWDay.Label, chtFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtDay, pageSize.GetLeft(_SystemParameter.TWDay.PointX), pageSize.GetTop(_SystemParameter.TWDay.PointY), 0);

                            iTextSharp.text.Phrase txtPageNumber = new iTextSharp.text.Phrase(pageIndex.ToString(), pageFont);
                            ColumnText.ShowTextAligned(cb, iTextSharp.text.Element.ALIGN_LEFT, txtPageNumber, pageSize.GetLeft(_SystemParameter.TWPageNumber.PointX), pageSize.GetTop(_SystemParameter.TWPageNumber.PointY), 0);

                            doc.NewPage();

                            pageIndex++;
                        }
                        doc.Close();
                    }
                }
            }

            var path = $"{_SystemParameter.TWRoot}\\獎狀";
            Directory.CreateDirectory(path);
            var filename = $"{path}\\寫生特別獎_天文宮獎狀_{DateTime.Now.ToString("HHmm")}.pdf";
            FileStream file = new FileStream(filename, FileMode.Create, FileAccess.Write);
            stream.WriteTo(file);
            file.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Acrobat.exe", filename);

            stream.Dispose();
        }

        private void btn_LockDbSetting_Click(object sender, EventArgs e)
        {
            this.gbx_DbSetting.Visible = false;
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_國際組名字_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TianwenContext(this._SystemParameter.ServerIp))
            {
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '福島友理', passport_name = 'YURI FUKUSHIMA' WHERE entry_name = 'A05300536';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '何紫萱', passport_name = 'Parichat Apichayodom' WHERE entry_name = 'A05300533';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '寒星明', passport_name = 'Sophie Diana Haase' WHERE entry_name = 'A05300531';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '孫賽亞', passport_name = 'Asiah Jalon Crutchfield' WHERE entry_name = 'A05300530';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '湯大衛', passport_name = 'Trzcinski David' WHERE entry_name = 'A05300483';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '須山健大', passport_name = 'SUYAMA KENTA' WHERE entry_name = 'A05300480';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '小山穗乃香', passport_name = 'Koyama Honoka' WHERE entry_name = 'A05300307';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '松室亞美', passport_name = 'MATSUMURO AMI' WHERE entry_name = 'A05300097';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '洪賢植', passport_name = 'HERNAN FELIPE PUENTES CANTOR' WHERE entry_name = 'A05300080';");
                dbContext.Database.ExecuteSqlCommand("UPDATE competitors SET name = '黃海薇', passport_name = 'Huang Hai Wei' WHERE entry_name = 'A05300030';");
                MessageBox.Show($"已更新國際組姓名!!");
            }
        }

        private void btn_匯出得獎清單_Click_1(object sender, EventArgs e)
        {
            Stream stream = new MemoryStream(Properties.Resources.得獎名單範本);
            IWorkbook workbook = new HSSFWorkbook(stream);
            ISheet sheet = workbook.GetSheet("工作表1");
                      
            List<ICellStyle> cellStyles = new List<ICellStyle>();
            int cellsCount = 12;
            for (int i = 0; i < cellsCount; i++)
            {
                cellStyles.Add(sheet.GetRow(1).GetCell(i).CellStyle);
            }
            sheet.RemoveRow(sheet.GetRow(1));

            using (var db = new TianwenContext(this._SystemParameter.ServerIp))
            {
                int typeIndex = _CompetitionTypeList[this.cbx_成績比賽.SelectedIndex];
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex
                               && (x.RankId <= 5))
                   .OrderBy(g => new { g.GroupId, g.RankId, g.EntryNumber }).ToList();

                int lastRowIndex = 1;
                foreach (var comp in results)
                {
                    IRow row = sheet.CreateRow(lastRowIndex);
                    for (int i = 0; i < cellsCount; i++)
                    {
                        ICell cell = row.CreateCell(i);
                        cell.CellStyle = cellStyles[i];
                    }
                    row.Cells[0].SetCellValue(this.cbx_成績比賽.SelectedItem.ToString());
                    row.Cells[1].SetCellValue(comp.Group);
                    row.Cells[2].SetCellValue(comp.Rank);
                    row.Cells[3].SetCellValue(comp.EntryNumber);
                    row.Cells[4].SetCellValue(comp.Name);
                    row.Cells[5].SetCellValue(comp.PassportName);
                    row.Cells[6].SetCellValue(comp.Gender);
                    row.Cells[7].SetCellValue(comp.Phone);
                    row.Cells[8].SetCellValue(comp.Address);
                    row.Cells[9].SetCellValue(comp.School);
                    row.Cells[10].SetCellValue(comp.TeacherName);
                    row.Cells[11].SetCellValue(comp.TeacherPhone);
                    lastRowIndex++;
                }

            }

            var path = $"{_SystemParameter.TWRoot}\\領獎單";
            var filename = $"{path}\\{this.cbx_成績比賽.SelectedItem}_得獎名單_{DateTime.Now.ToString("HHmmss")}.xls";
            Directory.CreateDirectory(path);
            using (FileStream file = new FileStream(filename, FileMode.Create))
            {
                workbook.Write(file);
                file.Close();
            }
            workbook.Close();
            stream.Close();
            System.Diagnostics.Process.Start("Excel.exe", filename);
        }
    }
}
