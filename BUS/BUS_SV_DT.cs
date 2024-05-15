using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    
    public class BUS_SV_DT
    {
        DAL_SV_DT dSVDT;
        public BUS_SV_DT() { 
            dSVDT = new DAL_SV_DT();
        }
        public DataTable hienKQ()
        {
            return dSVDT.dsKQ();
        }
        public bool KiemTraMaTonTai(string idSV, string idDT)
        {
            return dSVDT.KiemTraMa(idSV,idDT);
        }
        public void themKQ(string idSV, string idDT, string location, string distance, string score)
        {
            dSVDT.ThemKetQua(idSV,idDT,location,distance,score);
        }
        public void suaKQ(string idSV, string idDT, string location, string distance, string score)
        {
            dSVDT.SuaKetQua(idSV,idDT,location,distance,score);
        }
        public void xoaKQ(string idSV, string idDT)
        {
            dSVDT.XoaKetQua(idSV,idDT);
        }
    }
}
