using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_DeTai
    {
        DAL_DeTai dDT;
        public BUS_DeTai()
        {
            dDT = new DAL_DeTai();
        }
        public DataTable hienDT()
        {
            return dDT.dsDeTai();
        }
        public bool KiemTraMaTonTai(string id)
        {
            return dDT.KiemTraMa(id);
        }
        public void themDT(string id, string name, string lead, string cost)
        {
            dDT.ThemDeTaiMoi(id, name, lead, cost);
        }
        public void suaDT(string id, string name, string lead, string cost)
        {
            dDT.SuaDeTai(id, name, lead, cost);
        }
        public void xoaDT(string id)
        {
            dDT.XoaDeTai(id);
        }
    }
}
