using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class AcceptanceListSearchViewModel
    {
        //締次検収日
        public DateTime? AcceptanceDate { get; set; }

        //CAMPUS-ID_From
        public string CampusIdFrom { get; set; }

        //CAMPUS-ID_To
        public string CampusIdTo { get; set; }

        //会社名_From
        public string CompanyNameFrom { get; set; }
        
        //会社名_To
        public string CompanyNameTo { get; set; }
        
    }
}