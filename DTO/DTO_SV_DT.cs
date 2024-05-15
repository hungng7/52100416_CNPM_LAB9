using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SV_DT
    {
        public string MaSoSinhVien { get; set; }
        public string MaSoDeTai { get; set; }
        public string NoiThucTap { get; set; }
        public string QuangDUong { get; set; }
        public string KetQua { get; set; }

        public DTO_SV_DT(string MaSoSinhVien, string MaSoDeTai, string NoiThucTap ,string QuangDuong, string KetQua) { 
            this.MaSoSinhVien = MaSoSinhVien;
            this.MaSoDeTai = MaSoDeTai;
            this.NoiThucTap = NoiThucTap;
            this.QuangDUong = QuangDuong;
            this.KetQua = KetQua;
        }
    }
}
