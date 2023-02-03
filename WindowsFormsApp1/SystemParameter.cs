using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public class SystemParameter
    {
        public string ServerIp { get; set; } = "192.168.0.1";

        public string TWRoot { get; set; } = "D:\\2023比賽";

        public TextPrintInfo GovName { get; set; } = new TextPrintInfo() { Label="Name", X=46, Y=111 };
        
        public TextPrintInfo Gov比賽名稱 { get; set; } = new TextPrintInfo() { Label = "天文獎  全國書法", X = 38, Y = 142 };

        public TextPrintInfo Gov比賽屆數分組名次 { get; set; } = new TextPrintInfo() { Label = "第五十三屆  長青組第一名", X = 38, Y = 156 };

        public TextPrintInfo GovPageNumber { get; set; } = new TextPrintInfo() { Label = "1", X = 175, Y = 260 };

        public int GovFontNumber = 18;

        public TextPrintInfo TWName { get; set; } = new TextPrintInfo() { Label = "Name", X = 42, Y = 95 };

        public TextPrintInfo TW屆數 { get; set; } = new TextPrintInfo() { Label = "53", X = 93, Y = 110 };

        public TextPrintInfo TW比賽 { get; set; } = new TextPrintInfo() { Label = "書法", X = 140, Y = 110 };

        public TextPrintInfo TW分組名次 { get; set; } = new TextPrintInfo() { Label = "長青組  第一名", X = 70, Y = 127 };

        public TextPrintInfo TWYear { get; set; } = new TextPrintInfo() { Label = "112", X = 83, Y = 267 };

        public TextPrintInfo TWMonth { get; set; } = new TextPrintInfo() { Label = "2", X = 120, Y = 267 };

        public TextPrintInfo TWDay { get; set; } = new TextPrintInfo() { Label = "5", X = 157, Y = 267 };

        public TextPrintInfo TWPageNumber { get; set; } = new TextPrintInfo() { Label = "1", X = 184, Y = 260 };

        public int TWFontNumber = 18;

        public int EngFontNumber = 30;

        public int EngNameFontNumber = 30;

        public float Eng行距 = 20.0f;

        public TextPrintInfo EnDate { get; set; } = new TextPrintInfo() { Label = "February 5th, 2023", X = 0, Y = 180 };
        public TextPrintInfo EnPageNumber { get; set; } = new TextPrintInfo() { Label = "1", X = 260, Y = 184 };

    }

    public class TextPrintInfo
    {
        public string Label { get; set; }
        public float X { get; set; }
        public float Y { get; set; }

        [JsonIgnore]
        public float PointX { get { return iTextSharp.text.Utilities.MillimetersToPoints(this.X); } }

        [JsonIgnore]
        public float PointY { get { return iTextSharp.text.Utilities.MillimetersToPoints(this.Y); } }
    }
}
