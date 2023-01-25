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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Regex> _DrawingIdEx = new List<Regex> { new Regex(@"^X[ABCDEFG]053\d{4}$",RegexOptions.Compiled), new Regex(@"^Y025\d{4}$", RegexOptions.Compiled) };
           
        private string _LocalMac;
        private Dictionary<String, int> _GroupDict = new Dictionary<String, int>();
        private List<String> _GroupList = new List<String>() { "長青組", "社會組", "高中組", "國中組", "國小高年級組", "國小中年級組", "國小低年級組", "幼稚園組", "國際組" };
        private Dictionary<String, int> _RankDict = new Dictionary<String, int>();
        private List<int> _CompetitionTypeList = new List<int> { 110, 111 };
        private DataTable _統計表log;
        private DataTable _排名作業紀錄log;
        private DataTable _指導老師紀錄log;

        private void Form1_Load(object sender, EventArgs e)
        {
            _GroupDict.Add("長青組", 0);
            _GroupDict.Add("社會組", 1);
            _GroupDict.Add("高中組", 2);
            _GroupDict.Add("國中組", 3);
            _GroupDict.Add("國小高年級組", 4);
            _GroupDict.Add("國小中年級組", 5);
            _GroupDict.Add("國小低年級組", 6);
            _GroupDict.Add("幼稚園組", 7);
            _GroupDict.Add("國際組", 8);

            _RankDict.Add("第一名", 0);
            _RankDict.Add("第二名", 1);
            _RankDict.Add("第三名", 2);
            _RankDict.Add("優選", 3);
            _RankDict.Add("佳作", 4);
            _RankDict.Add("入選", 5);

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

            _排名作業紀錄log = new DataTable();
            _排名作業紀錄log.Columns.Add("組別", typeof(string));
            _排名作業紀錄log.Columns.Add("參賽編號", typeof(string));
            _排名作業紀錄log.Columns.Add("姓名", typeof(string));
            _排名作業紀錄log.Columns.Add("圖紙編號", typeof(string));
            _排名作業紀錄log.Columns.Add("時間", typeof(string));
            dgv_排名作業紀錄.DataSource = _排名作業紀錄log;

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
            int[] 報名人數s = new int[_GroupDict.Count];
            int[] 報到人數s = new int[_GroupDict.Count];
            int[] 圖紙s = new int[_GroupDict.Count];
            int[] 第一名人數s = new int[_GroupDict.Count];
            int[] 第二名人數s = new int[_GroupDict.Count];
            int[] 第三名人數s = new int[_GroupDict.Count];
            int[] 優選人數s = new int[_GroupDict.Count];
            int[] 佳作人數s = new int[_GroupDict.Count];
            int[] 入選人數s = new int[_GroupDict.Count];
            _統計表log.Rows.Clear();
            int groupIndex = _CompetitionTypeList[this.cbx_統計表選擇比賽.SelectedIndex];

            using (var dbContext = new TianwenContext())
            {
                var comps = dbContext.Competitors.Where(x => x.CompetitionType == groupIndex).ToList();
                foreach (var comp in comps)
                {
                    var index = comp.GroupId;
                    報名人數s[index] += 1;
                    報到人數s[index] += comp.CheckIn ? 1 : 0;
                    圖紙s[index] += comp.DrawingId != null ? 1 : 0;
                    第一名人數s[index] += comp.RankId == 0 ? 1 : 0;
                    第二名人數s[index] += comp.RankId == 1 ? 1 : 0;
                    第三名人數s[index] += comp.RankId == 2 ? 1 : 0;
                    優選人數s[index] += comp.RankId == 3 ? 1 : 0;
                    佳作人數s[index] += comp.RankId == 4 ? 1 : 0;
                    入選人數s[index] += comp.RankId == 5 ? 1 : 0;
                }
            }

            for (int i = 0; i < _GroupDict.Count(); i++)
            {
                if (報名人數s[i] > 0)
                {
                    DataRow row = _統計表log.NewRow();
                    row[0] = _GroupList[i];
                    row[1] = 報名人數s[i];
                    row[2] = 報到人數s[i];
                    row[3] = 圖紙s[i];
                    row[4] = 第一名人數s[i];
                    row[5] = 第二名人數s[i];
                    row[6] = 第三名人數s[i];
                    row[7] = 優選人數s[i];
                    row[8] = 佳作人數s[i];
                    row[9] = 入選人數s[i];
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
                        this.rtb_報到作業參賽資料.AppendText($"參賽編號: {txt_報到作業參賽編號.Text}"+ Environment.NewLine);
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

                        DataRow row = this._排名作業紀錄log.NewRow();
                        row[0] = result.Group;
                        row[1] = result.EntryNumber;
                        row[2] = result.Name;
                        row[3] = result.DrawingId;
                        row[4] = result.UpdatedTime.ToString("MM/dd HH:mm:ss");
                        this._排名作業紀錄log.Rows.InsertAt(row, 0);
                        this.dgv_排名作業紀錄.ClearSelection();
                        this.dgv_排名作業紀錄.Rows[0].Selected = true;
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
            this._排名作業紀錄log.Rows.Clear();
        }

        private void btn_報到作業本機記錄_Click(object sender, EventArgs e)
        {
            int typeIndex = _CompetitionTypeList[this.cbx_報到作業選擇比賽.SelectedIndex];
            int groupIndex = this.cbx_報到作業選擇分組.SelectedIndex;
            Boolean hasGroup = this.chk_報到作業選擇分組.Checked;
            this._排名作業紀錄log.Rows.Clear();
            using (var db = new TianwenContext())
            {
                var results = db.Competitors.Where(x => x.CompetitionType == typeIndex && x.DrawingId != null && x.UpdatedIp == this._LocalMac && (!hasGroup || x.GroupId == groupIndex)).OrderByDescending(x=>x.UpdatedTime).ToList();
                foreach(var result in results)
                {
                    DataRow row = this._排名作業紀錄log.NewRow();
                    row[0] = result.Group;
                    row[1] = result.EntryNumber;
                    row[2] = result.Name;
                    row[3] = result.DrawingId;
                    row[4] = result.UpdatedTime.ToString("MM/dd HH:mm:ss");
                    this._排名作業紀錄log.Rows.Add(row);
                }
                this.dgv_排名作業紀錄.ClearSelection();
                this.dgv_排名作業紀錄.Rows[0].Selected = true;
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


            int typeIndex = _CompetitionTypeList[this.cbx_報到作業選擇比賽.SelectedIndex];
            this._指導老師紀錄log.Rows.Clear();
            using (var db = new TianwenContext())
            {
                var groups = db.Competitors.Where(x=>!String.IsNullOrEmpty(x.TeacherName) && !String.IsNullOrEmpty(x.RegTeacherPhone)).GroupBy(x => x.RegTeacherPhone).OrderBy(g => g.Key).ToList();
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
    }
}
