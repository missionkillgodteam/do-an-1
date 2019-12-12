using QLSV.BD_layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV.BS_layer
{
    class BLThongKe
    {
        DataProvider db = null;
        public BLThongKe()
        {
            db = new DataProvider();
        }
        public DataTable GetTC(string MaSV)
        {
            string sqlString = 
                string.Format("select maSV,Sum(soTinChi) as stcHoc,hocKi,sum(case when KetQua.ketQua=1 then soTinChi else 0 end ) as stcdau" +
                " from KetQua, Mon " +
                "where ketQua.maMon = Mon.maMon and maSV = N'{0}' group by maSV, hocKi", MaSV);
            return db.MyExecuteQuery(sqlString);
        }
    }
}
