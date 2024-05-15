using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL_SV_DT
    {
        public DataTable dsKQ()
        {
            string q = "SELECT * FROM SinhVien_detai";
            return Connection.selectQuery(q);
        }


        public bool KiemTraMa(string idSV, string idDT)
        {
            string cmd = "SELECT MaSoSinhVien FROM SinhVien_detai WHERE MaSoSinhVien = '" + idSV + 
                            "' AND MaSoDeTai = '" + idDT + "'";
            int row = Connection.selectQuery(cmd).Rows.Count;

            if (row > 0)
            {
                return true;
            }
            return false;
        }

        public void ThemKetQua(string idSV, string idDT, string location, string distance, string score)
        {
            String cmd = "INSERT INTO SinhVien_detai VALUES ('" + idSV + "','" + idDT + "' , '" + location + "' , '"
                                                        + distance + "' ," + "'" + score + "')";
            Connection.actionQuery(cmd);
        }

        public void SuaKetQua(string idSV, string idDT, string location, string distance, string score)
        {
            String cmd = "UPDATE SinhVien_detai SET NoiThucTap = N'" + location + "' , QuangDuong = '"  + distance 
                        + "' , KetQua = '" + score + "' WHERE MaSoSinhVien = '" + idSV + "' AND MaSoDeTai = '" + idDT + "'  ";
            Connection.actionQuery(cmd);
        }

        public void XoaKetQua(string idSV, string idDT)
        { 
            string cmd = "DELETE FROM SinhVien_detai WHERE MaSoSinhVien = '" + idSV + "' AND MaSoDeTai = '" + idDT + "' ";
            Connection.actionQuery(cmd);
        }
    }
}
