using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class HomeViewModel
    {
        // 管理者（ホームグリッド用）
        public List<ManagerIndexGridData> ManagerIndexDataList { get; set; }
    }

    public class ManagerIndexGridData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_8 { get; set; }

        public ManagerIndexGridData(string _col_1, string _col_2, string _col_3,
                                    string _col_4, string _col_5, string _col_6,
                                    string _col_7, string _col_8)
        {
            Col_1 = _col_1;
            Col_2 = _col_2;
            Col_3 = _col_3;
            Col_4 = _col_4;
            Col_5 = _col_5;
            Col_6 = _col_6;
            Col_7 = _col_7;
            Col_8 = _col_8;
        }

    }
}