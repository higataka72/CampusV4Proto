using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CampusV4.Models
{
    public class InspectViewModel
    {
        
        //CAMUS-ID
        public string Campus1ID { get; set; }       
        // CAMUS-NAME
        public string Campus1Name { get; set; }
        //CAMUS-ID
        public string CampusID { get; set; }
        // CAMUS-NAME
        public string CampusName { get; set; }

        //受入日From
        public DateTime? ReceiptDateFrom { get; set; }
        //受入日To
        public DateTime? ReceiptDateTo { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //発注区分（1:受入のみ(受入基準) / 2:発注残のみ(検収基準)/ 0:両方)
        public int Po_type { get; set; }

        //CAMUS-IDリスト
        public List<CampusData> CampusDataList { get; set; }

        //検収入力一覧リスト
        public List<InspectListData> GridDataList { get; set; }
    }

    public class CampusData
    {

        public string CampusID { get; set; }
        public string CampusName { get; set; }

        public CampusData(string _CampusID, string _CampusName)
        {
            CampusID = _CampusID;
            CampusName = _CampusName;
        }
    }

    //引合リスト一覧
    public class InspectListData
    {
        //検
        public Boolean? InspectCheck { get; set; }
        //状態
        public string Situation { get; set; }
        //製番
        public string ProductionNumber { get; set; }
        //発注日
        public DateTime? OrderDate { get; set; }
        //発注番号
        public string OrderNumber { get; set; }
        //受入日
        public DateTime? ReceiptDate { get; set; }
        //受入番号
        public string ReceiptNumber { get; set; }
        //品名
        public string PartsName { get; set; }
        //図面番号/型式
        public string DrawingNumber { get; set; }
        //発注数
        public double? OrderQuantity { get; set; }
        //受入数
        public double? ReceiptQuantity { get; set; }
        //不良数
        public double? DefectsQuantity { get; set; }
        //検収数
        public double? AcceptanceQuantity { get; set; }
        //単価
        public double? Unitprice { get; set; }
        //金額
        public double? Price { get; set; }
        //検収日
        public DateTime? AcceptanceDate { get; set; }
        //検収担当
        public string AcceptancePicCode { get; set; }
        //検収日
        public DateTime? AccountingConnectedDate { get; set; }


        public InspectListData()
        {
        }

    }

    }