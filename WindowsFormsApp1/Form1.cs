﻿using System;
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

        private void Form1_Load(object sender, EventArgs e)
        {
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

            this.cbx_成績比賽.Items.Add("書法比賽");
            this.cbx_成績比賽.Items.Add("寫生比賽");
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

            using (var dbContext = new TianwenContext())
            {
                // dbContext.Competitors.Add(new Competitor { Name="張光華", EntryNumber="A123", Address="高雄市湖內區", Phone="123456"});
                //dbContext.SaveChanges();
            }
        }

        private void btn_匯入參賽者資料_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "請選擇檔案";
            dialog.Filter = "Excel檔案(*.xls)|*.xls";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                using (var dbContext = new TianwenContext())
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
            using (var dbContext = new TianwenContext())
            {
                dbContext.Database.ExecuteSqlCommand("TRUNCATE TABLE competitors");
                MessageBox.Show($"已刪除所有資料!!");
            }
        }

        private void btn_初始化所有資料_Click(object sender, EventArgs e)
        {
            using (var dbContext = new TianwenContext())
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

            using (var dbContext = new TianwenContext())
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
                using (var db = new TianwenContext())
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
                using (var db = new TianwenContext())
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
            using (var db = new TianwenContext())
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
                using (var db = new TianwenContext())
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
            using (var db = new TianwenContext())
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
            using (var db = new TianwenContext())
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
                using (var db = new TianwenContext())
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
                using (var db = new TianwenContext())
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
                using (var db = new TianwenContext())
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
                using (var db = new TianwenContext())
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
            int typeIndex = _CompetitionTypeList[this.cbx_排名作業選擇比賽.SelectedIndex];
            using (var db = new TianwenContext())
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
                        for (int i =0; i< indexs.Count(); i++)
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
    }
}
