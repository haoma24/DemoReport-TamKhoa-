using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace ReportManagement.Controllers
{
    public class ReportController : Controller
    {
        BORO_EACCOUNTING_WEB_V1Entities db = new BORO_EACCOUNTING_WEB_V1Entities();
        // GET: Report
        public ActionResult Index(string[] list)
        {
            string _id = "";
            if (list != null)
            {
                foreach (string id in list)
                {
                    var model = db.PhieuThu.Where(x => x.Id == int.Parse(id));
                    if (model != null)
                        _id = id;
                }
            }
            else
                _id = "1";
            string url = System.Configuration.ConfigurationManager.AppSettings["SSRSReportsUrl"].ToString();
            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Remote;
            reportViewer.SizeToReportContent = true;
            reportViewer.AsyncRendering = true;
            reportViewer.BackColor = System.Drawing.Color.White;
            reportViewer.ServerReport.ReportServerUrl = new Uri(url);
            reportViewer.ServerReport.ReportPath = "/DemoReport/PhieuThuTienMat";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PhieuThuId", _id, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            return View();
        }
    }
}