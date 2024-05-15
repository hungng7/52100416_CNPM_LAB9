using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_DeTai
    {
        public DataTable dsDeTai()
        {
            string q = "SELECT * FROM DeTai";
            return Connection.selectQuery(q);
        }


        public bool KiemTraMa(string id)
        {
            string cmd = "SELECT MaSoDeTai FROM DeTai WHERE MaSoDeTai = '" + id + "'";
            int row = Connection.selectQuery(cmd).Rows.Count;

            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public void ThemDeTaiMoi(string id, string name, string lecture, string cost)
        {
            String cmd = "INSERT INTO DeTai VALUES ('" + id + "',N'" + name + "',N'" 
                                                       + lecture + "','" + cost + "')";
           
            Connection.actionQuery(cmd);
        }

        public void SuaDeTai(string id, string name, string lecture, string cost)
        {
            String cmd = "UPDATE DeTai SET TenDeTai = N'" + name + "',ChuNhiemDeTai = N'" + lecture + "'," +
                            "KinhPhi = '" + cost + "' WHERE MaSoDeTai = '" + id + "'";
            Connection.actionQuery(cmd);
        }

        public void XoaDeTai(string id)
        {
            // Kiểm tra dữ liệu Đề tài có trong bảng SinhVien_Detai
            DataTable dtSinhVienDeTai = Connection.selectQuery("SELECT * FROM SinhVien_Detai WHERE MaSoDeTai = '" + id + "'");
            if (dtSinhVienDeTai.Rows.Count > 0)
            {
                Connection.actionQuery("DELETE FROM SinhVien_detai WHERE MaSoDeTai = '" + id + "'");
            }

            string cmd = "DELETE FROM DeTai WHERE MaSoDeTai = '" + id + "'";
            Connection.actionQuery(cmd);
        }
    }
}
