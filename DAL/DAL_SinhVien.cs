using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using DTO;

namespace DAL
{
    public class DAL_SinhVien
    {
        public DataTable dsSinhVien()
        {
            string q = "SELECT MaSoSinhVien, HoTen, QueQuan," +
                        "FORMAT(NgaySinh, 'dd/MM/yyyy') AS NgaySinh, HocLuc FROM SinhVien";
            return Connection.selectQuery(q);
        }

     
        public bool KiemTraMa(string id)
        {
            string cmd = "SELECT MaSoSinhVien FROM SinhVien WHERE MaSoSinhVien = '" + id + "'";
            int row = Connection.selectQuery(cmd).Rows.Count;

            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public void ThemSinhVienMoi(string id, string name, string ht, DateTime birth, string rank)
        {
            String cmd = "INSERT INTO SinhVien VALUES ('" + id + "',N'" + name + "','" + ht + "','" 
                                                        + birth.ToString("yyyy-MM-dd") + "'," + "'" + rank + "')";
            Connection.actionQuery(cmd);
        }

        public void SuaSinhVien(string id, string name, string ht, DateTime birth, string rank)
        {
            String cmd = "UPDATE SinhVien SET HoTen = N'" + name + "', QueQuan = N'" + ht + "', NgaySinh = '" + birth.ToString("yyyy-MM-dd") + "'," +
                                                       "HocLuc = N'" + rank + "' WHERE MaSoSinhVien = '" + id + "'";
            Connection.actionQuery(cmd);
        }

        public void XoaSinhVien(string id)
        {
            // Kiểm tra dữ liệu Sinh viên có trong bảng SinhVien_Detai
            DataTable dtSinhVienDeTai = Connection.selectQuery("SELECT * FROM SinhVien_Detai WHERE MaSoSinhVien = '" + id + "'");
            if (dtSinhVienDeTai.Rows.Count > 0)
            {
                Connection.actionQuery("DELETE FROM SinhVien_detai WHERE MaSoSinhVien = '" + id + "'");
            }

            string cmd = "DELETE FROM SinhVien WHERE MaSoSinhVien = '" + id + "'";
            Connection.actionQuery(cmd);
        }
    }
}