using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DuLieu
    {
        public string MaDL { get; set; }
        public string TenDL { get; set; }
        public string DuongDan { get; set; }
        public string DuoiDL { get; set; }
        public string Anh { get; set; }

        public DuLieu(string MaDL, string TenDL, string DuongDan, string DuoiDL, string Anh)
        {
            this.MaDL = MaDL;
            this.TenDL = TenDL;
            this.DuongDan = DuongDan;
            this.DuoiDL = DuoiDL;
            this.Anh = Anh;
        }
    }
}
