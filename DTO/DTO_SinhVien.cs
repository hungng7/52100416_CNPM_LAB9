using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_SinhVien
    {
        public string MaSoSinhVien { get; set; }
        public string HoTen { get; set; }
        public string QueQuan { get; set; }
        public DateTime NgaySinh { get; set; }
        public string HocLuc { get; set; }
        public DTO_SinhVien(string MaSoSinhVien, string HoTen, string QueQuan, DateTime NgaySinh, string HocLuc)
        {
            this.MaSoSinhVien = MaSoSinhVien;
            this.HoTen = HoTen;
            this.QueQuan = QueQuan;
            this.NgaySinh = NgaySinh;
            this.HocLuc = HocLuc;
        }
    }
}