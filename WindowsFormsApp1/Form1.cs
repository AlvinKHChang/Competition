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

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Dictionary<String, int> _GroupDict = new Dictionary<String, int>();
        private Dictionary<String, int> _RankDict = new Dictionary<String, int>();

        private void Form1_Load(object sender, EventArgs e)
        {
            _GroupDict.Add("長青組", 1);
            _GroupDict.Add("社會組", 2);
            _GroupDict.Add("高中組", 3);
            _GroupDict.Add("國中組", 4);
            _GroupDict.Add("國小高年級組", 5);
            _GroupDict.Add("國小中年級組", 6);
            _GroupDict.Add("國小低年級組", 7);
            _GroupDict.Add("幼稚園組", 8);
            _GroupDict.Add("國際組", 9);

            _RankDict.Add("第一名", 1);
            _RankDict.Add("第二名", 2);
            _RankDict.Add("第三名", 3);
            _RankDict.Add("優選", 4);
            _RankDict.Add("佳作", 5);
            _RankDict.Add("入選", 6);

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
    }
}
