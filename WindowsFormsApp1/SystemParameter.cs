using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class SystemParameter
    {
        string ServerIp { get; set; } = "192.168.0.1";

        TextPrintInfo GovName { get; set; } = new TextPrintInfo() { Label="Name", x=46, y=111 };
        TextPrintInfo Gov比賽名稱 { get; set; } = new TextPrintInfo() { Label = "天文獎  全國書法", x = 38, y = 142 };

        TextPrintInfo Gov比賽屆數分組名次 { get; set; } = new TextPrintInfo() { Label = "第五十三屆  長青組第一名", x = 38, y = 156 };

        TextPrintInfo GovPageNumber { get; set; } = new TextPrintInfo() { Label = "1", x = 175, y = 260 };

        TextPrintInfo TWName { get; set; } = new TextPrintInfo() { Label = "Name", x = 42, y = 95 };

        TextPrintInfo TW屆數 { get; set; } = new TextPrintInfo() { Label = "53", x = 93, y = 110 };

        TextPrintInfo TW比賽 { get; set; } = new TextPrintInfo() { Label = "書法", x = 140, y = 110 };

        TextPrintInfo TW分組名次 { get; set; } = new TextPrintInfo() { Label = "長青組  第一名", x = 70, y = 127 };

        TextPrintInfo TWYear { get; set; } = new TextPrintInfo() { Label = "112", x = 83, y = 267 };

        TextPrintInfo TWMonth { get; set; } = new TextPrintInfo() { Label = "2", x = 120, y = 267 };

        TextPrintInfo TWDay { get; set; } = new TextPrintInfo() { Label = "5", x = 157, y = 267 };

        TextPrintInfo TWPageNumber { get; set; } = new TextPrintInfo() { Label = "1", x = 184, y = 260 };


    }

    public class TextPrintInfo
    {
        public string Label { get; set; }
        public int x { get; set; }
        public int y { get; set; }
    }
}
