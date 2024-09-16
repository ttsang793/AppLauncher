using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanMem
    {
        public string MaPM { get; set; }
        public string TenPM { get; set; }
        public string DuongDan { get; set; }
        public string Anh { get; set; }

        public PhanMem(string maPM, string tenPM, string duongDan, string anh)
        {
            this.MaPM = maPM;
            this.TenPM = tenPM;
            this.DuongDan = duongDan;
            this.Anh = anh;
        }
    }
}
