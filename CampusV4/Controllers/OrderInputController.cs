using CampusV4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CampusV4.Controllers
{
    public class OrderInputController : Controller
    {
        public ActionResult Regist()
        {
            var model = new OrderInputViewModel();

            //主画面の値を設定
            model.Seiban = "000012345A01";
            model.HatyuNo = "0000000001";
            model.HatyuDate = DateTime.Parse("2023/01/30");
            model.KariHatyuFlag = false;
            model.CumpasId = "0000010001";
            model.CumpasName = "京都金型工業";
            model.SyanaiFlag = false;
            model.BusyoName = "営業部";
            model.TantouName = "渡辺　一郎";
            model.Address = "000-000-0000";
            model.MailAddress = "xxxxx@xxx.com";
            model.HatyuTantouCode = "USR00001";
            model.OrderManListCode = "USR00001";
            model.RingiNo = "0012345R01";
            model.HatyuFlag = true;
            model.GenpinFlag = true;
            model.Memo = "特になし";
            model.ApprovalType = "1";

            GetInitDataList(ref model);

            // 発注部品リストの取得
            var PartsListData = new List<Order_PartsListData>();
            PartsListData.Add(new Order_PartsListData(1, false, "B", "Upper Cull Block", "001602-A-B002", 1, 2, 1, "式", "001", "表面処理1", 260000, 520000, DateTime.Parse("2023/12/28"), "", false));
            PartsListData.Add(new Order_PartsListData(2, false, "D", "Upper Holder Vase", "001602-A-B003", 1, 2, 1, "式", "001", "表面処理1", 100000, 200000, DateTime.Parse("2023/12/28"), "", false));
            PartsListData.Add(new Order_PartsListData(3, false, "A", "Lower Main Cavity", "001602-A-B004", 1, 2, 1, "式", "001", "表面処理1", 150000, 300000, DateTime.Parse("2023/12/28"), "", false));
            PartsListData.Add(new Order_PartsListData(4, false, "A", "Lower Main Cavity", "001602-A-B004", 1, 2, 1, "式", "001", "表面処理1", 150000, 300000, DateTime.Parse("2023/12/28"), "", false));
            PartsListData.Add(new Order_PartsListData(5, false, "B", "Lower Port Block", "001602-A-B005", 1, 2, 1, "式", "001", "表面処理1", 100000, 200000, DateTime.Parse("2023/12/28"), "", false));
            model.oim_GridPartsDataList = PartsListData;

            return View(model);
        }

        [HttpPost]
        public ActionResult FileUpload()
        {
            string fileName = "";
            foreach (string fName in Request.Files)
            {
                fileName = fName;
            }

            return Json(new { Message = fileName });
        }

        [HttpPost]
        public ActionResult FileDelete(string name)
        {
            return Json(new { Message = name });
        }

        [HttpPost]
        public JsonResult GetPartsSelectData()
        {
            JavaScriptSerializer sz = new JavaScriptSerializer();
            var dataList = new List<PartsSelectData>();
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());
            dataList.Add(new PartsSelectData());

            string str = sz.Serialize(dataList);
            return Json(str);
        }

        //リストボックス値取得
        private void GetInitDataList(ref OrderInputViewModel model)
        {

            // 部品リストを取得
            var PartsList = new List<MasterData>();
            PartsList.Add(new MasterData("　", ""));
            PartsList.Add(new MasterData("A", "Upper Main Cavity"));
            PartsList.Add(new MasterData("B", "Upper Cull Block"));
            PartsList.Add(new MasterData("D", "Upper Holder Vase"));
            PartsList.Add(new MasterData("B", "Lower Port Block"));
            model.oim_PartsListData = PartsList;

            // 表面処理を取得
            var SurfaceList = new List<MasterData>();
            SurfaceList.Add(new MasterData("　", ""));
            SurfaceList.Add(new MasterData("001", "表面処理001"));
            SurfaceList.Add(new MasterData("002", "表面処理002"));
            SurfaceList.Add(new MasterData("003", "表面処理003"));
            SurfaceList.Add(new MasterData("004", "表面処理004"));
            SurfaceList.Add(new MasterData("005", "表面処理005"));
            model.oim_SurfaceListData = SurfaceList;

            // 設計担当者の取得
            var DesignManList = new List<MasterData>();
            DesignManList.Add(new MasterData("　", ""));
            DesignManList.Add(new MasterData("USR00001", "佐藤　一郎"));
            DesignManList.Add(new MasterData("USR00002", "佐藤　次郎"));
            DesignManList.Add(new MasterData("USR00003", "佐藤　三郎"));
            DesignManList.Add(new MasterData("USR00004", "佐藤　四朗"));
            DesignManList.Add(new MasterData("USR00005", "佐藤　五郎"));
            model.oim_DesignManListData = DesignManList;

            // 発注担当者の取得
            var OrderManList = new List<MasterData>();
            OrderManList.Add(new MasterData("　", ""));
            OrderManList.Add(new MasterData("USR00001", "佐藤　一郎"));
            OrderManList.Add(new MasterData("USR00002", "佐藤　次郎"));
            OrderManList.Add(new MasterData("USR00003", "佐藤　三郎"));
            OrderManList.Add(new MasterData("USR00004", "佐藤　四朗"));
            OrderManList.Add(new MasterData("USR00005", "佐藤　五郎"));
            model.oim_OrderManListData = OrderManList;

            // 部品選択用リスト
            var partsSelectListData = new List<OrderInput_PartsSelectListData>();
            //partsSelectListData.Add(new OrderInput_PartsSelectListData(true, 1, 1, "A", "Upper Main Cavity", "001602-A-B001", 2, 8));
            partsSelectListData.Add(new OrderInput_PartsSelectListData(true, 2, 2, "B", "Upper Cull Block", "001602-A-B002", 1, 2));
            partsSelectListData.Add(new OrderInput_PartsSelectListData(true, 3, 5, "D", "Upper Holder Vase", "001602-A-B003", 1, 2));
            partsSelectListData.Add(new OrderInput_PartsSelectListData(true, 4, 8, "A", "Lower Main Cavity", "001602-A-B004", 1, 2));
            partsSelectListData.Add(new OrderInput_PartsSelectListData(true, 5, 9, "A", "Lower Main Cavity", "001602-A-B004", 1, 2));
            partsSelectListData.Add(new OrderInput_PartsSelectListData(true, 6, 12, "B", "Lower Port Block", "001602-A-B005", 1, 2));
            model.GridPartsSelectDataList = partsSelectListData;


        }
    }
}