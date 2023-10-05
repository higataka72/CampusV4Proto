using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class Sample2ViewModel
    {
        public List<MitsumoriData> GridDataList { get; set; }
  
    }

    public class MitsumoriData
    {

        public string Code { get; set; }
        public string Hinmei { get; set; }
        public string Suryou { get; set; }
        public string Tanni { get; set; }
        public string Tannka { get; set; }
        public string Kingaku { get; set; }

        public MitsumoriData(string _Code)
        {
            Code = _Code;
        }
    }
}