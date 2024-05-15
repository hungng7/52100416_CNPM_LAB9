using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_DeTai
    {
        public string MaSoDeTai { get; set; }
        public string TenDeTai { get; set; }
        public string ChuNhiemDeTai { get; set; }
        public string KinhPhi { get; set; }
        public DTO_DeTai(string MaSoDeTai, string TenDeTai, string ChuNhiemDeTai, string KinhPhi)
        {
            this.MaSoDeTai = MaSoDeTai;
            this.TenDeTai = TenDeTai;
            this.ChuNhiemDeTai = ChuNhiemDeTai;
            this.KinhPhi = KinhPhi;
        }
    }
}