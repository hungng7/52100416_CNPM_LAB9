using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_SinhVien
    {
        DAL_SinhVien dSV;
        public BUS_SinhVien()
        {
            dSV = new DAL_SinhVien();
        }
        public DataTable hienSV()
        {
            return dSV.dsSinhVien();
        }
        public bool KiemTraMaTonTai(string id)
        {
            return dSV.KiemTraMa(id);
        }
        public void themSV(string id, string name, string ht, DateTime birth, string rank)
        {
            dSV.ThemSinhVienMoi(id,name,ht,birth,rank);
        }
        public void suaSV(string id, string name, string ht, DateTime birth, string rank)
        {
            dSV.SuaSinhVien(id, name, ht, birth, rank);
        }
        public void xoaSV(string id)
        {
            dSV.XoaSinhVien(id);
        }
    }
}
