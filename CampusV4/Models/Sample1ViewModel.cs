using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class Sample1ViewModel
    {
        public List<SeibanData> GridDataList { get; set; }

        public List<IndexGridData> IndexDataList { get; set; }
        public List<DialogGridData> DialogDataList { get; set; }
    }

    public class SeibanData
    {

        public string Seiban { get; set; }
        public string Suuryou { get; set; }
        public string Tanka { get; set; }
        public string Kingaku { get; set; }
        public string Nouki { get; set; }
        public string Kyanserubi { get; set; }

        public SeibanData(string _Seiban)
        {
            Seiban = _Seiban;
        }
    }

    public class IndexGridData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
        public string Col_6 { get; set; }
        public string Col_7 { get; set; }
        public string Col_8 { get; set; }

        public IndexGridData(string col_1, string col_2, string col_3, string col_4, string col_5, string col_6, string col_7, string col_8)
        {
            Col_1 = col_1;
            Col_2 = col_2;
            Col_3 = col_3;
            Col_4 = col_4;
            Col_5 = col_5;
            Col_6 = col_6;
            Col_7 = col_7;
            Col_8 = col_8;
        }


    }

    public class DialogGridData
    {
        public string Col_1 { get; set; }
        public string Col_2 { get; set; }
        public string Col_3 { get; set; }
        public string Col_4 { get; set; }
        public string Col_5 { get; set; }
    }
}