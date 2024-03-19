using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace telerik_demo_grid_by_datatable.Controllers
{
    public class HomeController : Controller
    {
        public static DataTable db = new DataTable();
        public ActionResult Index()
        {
            db = GetDataTable();
            return View(db);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(db.ToDataSourceResult(request));
        }

        private DataTable GetDataTable()
        {
            DataTable dt = new DataTable();
            DataColumn column;
            DataRow row;

            column = new DataColumn();
            column.ColumnName = "OrderID";
            column.DataType = typeof(int);
            column.Caption = "Order ID";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "Freight";
            column.DataType = typeof(decimal);
            column.Caption = "Freight";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "ShipName";
            column.DataType = typeof(string);
            column.Caption = "Ship Name";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "ShipCity";
            column.DataType = typeof(string);
            column.Caption = "Ship City";
            dt.Columns.Add(column);

            column = new DataColumn();
            column.ColumnName = "ShipCountry";
            column.DataType = typeof(string);
            column.Caption = "Ship Country";
            dt.Columns.Add(column);

            dt.PrimaryKey = new DataColumn[] { dt.Columns["OrderID"] };

            for (int i = 0; i < 50; i++)
            {
                row = dt.NewRow();
                row["OrderID"] = i;
                row["Freight"] = i * 10;
                row["ShipName"] = "ShipName " + i;
                row["ShipCity"] = "ShipCity " + i;
                row["ShipCountry"] = "ShipCountry " + i;

                dt.Rows.Add(row);
            }

            return dt;
        }
    }
}