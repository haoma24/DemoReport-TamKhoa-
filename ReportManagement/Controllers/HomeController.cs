using Microsoft.Ajax.Utilities;
using ReportManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using System.Configuration;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Web.UI;
namespace ReportManagement.Controllers
{
    public class ReportViewerInitializer
    {
        private string url;
        private ReportViewer reportViewer;

        public ReportViewerInitializer()
        {
            // Khai báo và khởi tạo các thuộc tính trong constructor
            url = ConfigurationManager.AppSettings["SSRSReportsUrl"].ToString();
            reportViewer = new ReportViewer
            {
                ProcessingMode = ProcessingMode.Remote,
                SizeToReportContent = true,
                AsyncRendering = true,
                Width = Unit.Percentage(100),
                Height = Unit.Percentage(100)
            };
            reportViewer.ServerReport.ReportServerUrl = new Uri(url);
        }

        public ReportViewer GetReportViewer()
        {
            return reportViewer;
        }
    }
    public class HomeController : Controller
    {
        
        BORO_EACCOUNTING_WEB_V1Entities db = new BORO_EACCOUNTING_WEB_V1Entities();
        KetNoi knA00 = new KetNoi("Data Source=192.168.1.3\\TAMKHOAJSC;" +
              "Initial Catalog=A0000000;" +
              "User id=sa;" +
              "Password=Tamkhoa@123;");
        KetNoi knBoroWeb = new KetNoi("Data Source=192.168.1.3\\TAMKHOAJSC;" +
              "Initial Catalog=BORO_EACCOUNTING_WEB_V1;" +
              "User id=sa;" +
              "Password=Tamkhoa@123;");
        ReportViewer reportViewer = new ReportViewerInitializer().GetReportViewer();
        public ActionResult Index()
        {
            return View();
        }

        //VIEW BAO CAO - BEGIN
        //BCPT
        public ActionResult BaoCaoPhieuThu(string[] list) 
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
            reportViewer.ServerReport.ReportPath = "/DemoReport/PhieuThuTienMat";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PhieuThuId", _id, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "PhieuThuTienMat";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCPC
        public ActionResult BaoCaoPhieuChi(string[] list)
        {
            string _id = "";
            if (list != null)
            {
                foreach (string id in list)
                {
                    var model = db.PhieuChi.Where(x => x.Id == int.Parse(id));
                    if (model != null)
                        _id = id;
                }
            }
            else
                _id = "1";

            reportViewer.ServerReport.ReportPath = "/DemoReport/PhieuChiTienMat";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PhieuChiId", _id, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "PhieuChiTienMat";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCDMKH
        public ActionResult BaoCaoDanhMucKhachHang(string[] list)
        {
            string _id = "";
            if (list != null)
            {
                foreach (string id in list)
                {
                    var model = db.KhachHang.Where(x => x.Id == int.Parse(id));
                    if (model != null)
                        _id = id;
                }
            }
            else
                _id = "1";

            reportViewer.ServerReport.ReportPath = "/DemoReport/DanhMucKhachHang";
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "DanhMucKhachHang";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCPN
        public ActionResult BaoCaoPhieuNhap(string[] list)
        {
            string _id = "";
            if (list != null)
            {
                foreach (string id in list)
                {
                    var model = db.PhieuNhap.Where(x => x.Id == int.Parse(id));
                    if (model != null)
                        _id = id;
                }
            }
            else
                _id = "1";

            reportViewer.ServerReport.ReportPath = "/DemoReport/PhieuNhapKho";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PhieuNhapId", _id, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "PhieuNhap";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCPXK
        public ActionResult BaoCaoPhieuXuatKho(string[] list)
        {
            string _id = "";
            if (list != null)
            {
                foreach (string id in list)
                {
                    var model = db.PhieuNhap.Where(x => x.Id == int.Parse(id));
                    if (model != null)
                        _id = id;
                }
            }
            else
                _id = "1";

            reportViewer.ServerReport.ReportPath = "/DemoReport/PhieuXuatKhoNoiBo";
            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("PhieuXuatKhoId", _id, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "PhieuXuatKhoNoiBo";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCDMVT
        public ActionResult BaoCaoDanhMucVatTu(string[] list)
        {
            string _id = "";
            if (list != null)
            {
                foreach (string id in list)
                {
                    var model = db.VatTu.Where(x => x.Id == int.Parse(id));
                    if (model != null)
                        _id = id;
                }
            }
            else
                _id = "1";

            reportViewer.ServerReport.ReportPath = "/DemoReport/DanhMucVatTu";
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "DanhMucVatTu";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSQ
        public ActionResult BaoCaoSoQuy(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            string _id = form["taikhoanid"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoQuyTienMat";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("taikhoan_id", _id, true);
            parameters[1] = new ReportParameter("tungay", tungay, true);
            parameters[2] = new ReportParameter("denngay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoQuyTienMat";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSTQGNH
        public ActionResult BaoCaoSoQuyTienGuiNganHang(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null).ToString("MM/dd/yyyy");
            string _id = form["Id"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoQuyTienMat";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("taikhoan_id", _id, true);
            parameters[1] = new ReportParameter("tungay", tungay, true);
            parameters[2] = new ReportParameter("denngay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoTienGuiNganHang";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSTCV
        public ActionResult BaoCaoSoTienChoVay(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            string _TkId = form["TkId"];
            string _KhId = form["KhId"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoChiTietTienVay";
            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("TaiKhoan_id", _TkId, true);
            parameters[1] = new ReportParameter("TuNgay", tungay, true);
            parameters[2] = new ReportParameter("DenNgay", denngay, true);
            parameters[3] = new ReportParameter("KhachHang_id", _KhId, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoTienVay";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSTCV
        public ActionResult BaoCaoSoCtThanhToanNgBan(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            string _TkId = form["TkId"];
            string _KhId = form["KhId"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoCtThanhToanNgBan";
            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("TaiKhoan_id", _TkId, true);
            parameters[1] = new ReportParameter("TuNgay", tungay, true);
            parameters[2] = new ReportParameter("DenNgay", denngay, true);
            parameters[3] = new ReportParameter("KhachHang_id", _KhId, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoCtThanhToanNgBan";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCBKPN
        public ActionResult BaoCaoBangKePhieuNhap(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            

            reportViewer.ServerReport.ReportPath = "/DemoReport/BangKePhieuNhap";
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("TuNgay", tungay, true);
            parameters[1] = new ReportParameter("DenNgay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "BangKePhieuNhap";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCBKHDDV
        public ActionResult BaoCaoBangKeHDDV(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");


            reportViewer.ServerReport.ReportPath = "/DemoReport/BangKeHoaDonMuaHangVaDichVu";
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("TuNgay", tungay, true);
            parameters[1] = new ReportParameter("DenNgay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "BangKeHDDV";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCBKHDDV
        public ActionResult BaoCaoHangNhap2CT(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("dd/MM/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("dd/MM/yyyy");


            reportViewer.ServerReport.ReportPath = "/DemoReport/BaoCaoHangNhapNhomTheo2ChiTiet";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("tungay", tungay, true);
            parameters[1] = new ReportParameter("denngay", denngay, true);
            parameters[2] = new ReportParameter("LoaiBC", "4", true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "BangKeHDDV";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSNKMH
        public ActionResult BaoCaoSoNhatKyMuaHang(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var tkno = form["TkNo"];
            var tkco = form["TkCo"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoNhatKyMuaHang";
            ReportParameter[] parameters = new ReportParameter[4];
            parameters[0] = new ReportParameter("TuNgay", tungay, true);
            parameters[1] = new ReportParameter("DenNgay", denngay, true);
            parameters[2] = new ReportParameter("TkNo", tkno, true);
            parameters[3] = new ReportParameter("TkCo", tkco, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSQTM
        public ActionResult BaoCaoSoQuyTienMat(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            string _id = form["taikhoanid"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoQuyTienMatTheoNgay";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("taikhoan_id", _id, true);
            parameters[1] = new ReportParameter("tungay", tungay, true);
            parameters[2] = new ReportParameter("denngay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoQuyTienMatTheoNgay";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSTHCT
        public ActionResult BaoCaoSoTongHopChuT(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            string _id = form["taikhoanid"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoTongHopChuT";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("taikhoan_id", _id, true);
            parameters[1] = new ReportParameter("tungay", tungay, true);
            parameters[2] = new ReportParameter("denngay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoTongHopChuT";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCSCTMTK
        public ActionResult BaoCaoSoChiTietMotTaiKhoan(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("MM/dd/yyyy");
            string _id = form["taikhoanid"];

            reportViewer.ServerReport.ReportPath = "/DemoReport/SoChiTietMotTaiKhoan";
            ReportParameter[] parameters = new ReportParameter[3];
            parameters[0] = new ReportParameter("taikhoan_id", _id, true);
            parameters[1] = new ReportParameter("tungay", tungay, true);
            parameters[2] = new ReportParameter("denngay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "SoChiTietTaiKhoan";
            return View("~/Views/Report/Index.cshtml");
        }
        //BCTHHNM
        public ActionResult BaoCaoTongHopHangNhapMua(FormCollection form)
        {
            var tungay = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null).ToString("dd/MM/yyyy");
            var denngay = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null).ToString("dd/MM/yyyy");
            string mauBC = form["MauBc"];
            if (mauBC.IsNullOrWhiteSpace())
                mauBC = "1";
            reportViewer.ServerReport.ReportPath = "/DemoReport/TongHopHangNhapMuaMau"+mauBC;
            ReportParameter[] parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("TuNgay", tungay, true);
            parameters[1] = new ReportParameter("DenNgay", denngay, true);
            reportViewer.ServerReport.SetParameters(parameters);
            ViewBag.ReportViewer = reportViewer;
            ViewBag.ViewName = "TongHopHangNhap";
            return View("~/Views/Report/Index.cshtml");
        }
        //VIEW BAO CAO - END

        //NBC
        public ActionResult NgayBaoCao(string name)
        {
            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
            ViewBag.viewName = name;
            return View();
        }
        //NBCSQ
        public ActionResult NgayBaoCaoSoQuy(string name)
        {
            var tk = db.TaiKhoan.OrderBy(x => x.Id);
            List<SelectListItem> listTaiKhoan = new List<SelectListItem>();
                foreach (var item in tk)
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.TaiKhoanUd,
                    Text = item.TaiKhoanUd
                };
                listTaiKhoan.Add(listItem);
            };


            ViewData["TaiKhoanId"] = listTaiKhoan;
            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;
            return View();
        }
        //NBCSTGNH
        public ActionResult NgayBaoCaoSoTienGuiNganHang(string name)
        {
            //Return list TaikhoanUd and fetch to dropdownlist
            var tk = db.TaiKhoan.OrderBy(x => x.Id);
            List<SelectListItem> listTaiKhoan = new List<SelectListItem>();
            foreach (var item in tk.Where(x => x.Id == 5 || x.TaiKhoanParentId == 5))
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.TaiKhoanUd,
                    Text = item.TaiKhoanUd
                };
                listTaiKhoan.Add(listItem);
            };
            ViewData["TaiKhoanId"] = listTaiKhoan;
            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;
            return View();
        }
        //NBCSCTTV
        public ActionResult NgayBaoCaoSoTienVay(string name)
        {
            var tk = db.TaiKhoan.OrderBy(x => x.Id);
            List<SelectListItem> listTaiKhoan = new List<SelectListItem>();
            foreach (var item in tk.Where(x => x.Id == 139 || x.TaiKhoanParentId == 139))
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.TaiKhoanUd,
                    Text = item.TaiKhoanUd
                };
                listTaiKhoan.Add(listItem);
            };
            ViewData["TaiKhoanId"] = listTaiKhoan;

            //Return list KhachHangNm and fetch to dropdownlist
            var kh = db.KhachHang.OrderBy(x => x.Id);
            List<SelectListItem> listKhachHang = new List<SelectListItem>();
            foreach (var item in kh)
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.KhachHangUd,
                    Text = item.KhachHangUd
                };
                listKhachHang.Add(listItem);
            };
            ViewData["KhachHangId"] = listKhachHang;

            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;
            return View();
        }
        //NBCSCTTTNB
        public ActionResult NgayBaoCaoSoCtThanhToanNgBan(string name)
        {
            var tk = db.TaiKhoan.OrderBy(x => x.Id);
            List<SelectListItem> listTaiKhoan = new List<SelectListItem>();
            foreach (var item in tk.Where(x => x.TaiKhoanParentId == 16 || x.Id == 22 || x.Id == 23 || x.TaiKhoanParentId
            == 23 || x.Id == 29 || x.TaiKhoanParentId == 29 || x.Id == 37 || x.Id == 38 || x.Id == 101 || x.Id == 112 || x.Id == 124  || x.TaiKhoanParentId == 124))
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.TaiKhoanUd,
                    Text = item.TaiKhoanUd
                };
                listTaiKhoan.Add(listItem);
            };
            ViewData["TaiKhoanId"] = listTaiKhoan;

            //Return list KhachHangNm and fetch to dropdownlist
            var kh = db.KhachHang.OrderBy(x => x.Id);
            List<SelectListItem> listKhachHang = new List<SelectListItem>();
            foreach (var item in kh)
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.KhachHangUd,
                    Text = item.KhachHangUd
                };
                listKhachHang.Add(listItem);
            };
            ViewData["KhachHangId"] = listKhachHang;

            //Return list KhachHangNm and fetch to dropdownlist
            var cn = db.ChiNhanh.OrderBy(x => x.Id);
            List<SelectListItem> listChiNhanh = new List<SelectListItem>();
            foreach (var item in cn)
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.ChiNhanhUd,
                    Text = item.ChiNhanhUd
                };
                listChiNhanh.Add(listItem);
            };
            ViewData["ChiNhanhId"] = listChiNhanh;

            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;
            return View();
        }
        public ActionResult NgayBaoCaoTongHopHangNhapMua(string name)
        {
            var tk = db.TaiKhoan.OrderBy(x => x.Id);
            List<SelectListItem> listTaiKhoan = new List<SelectListItem>();
            foreach (var item in tk.Where(x => x.Id == 5 || x.TaiKhoanParentId == 5))
            {
                SelectListItem listItem = new SelectListItem()
                {
                    Value = item.TaiKhoanUd,
                    Text = item.TaiKhoanUd
                };
                listTaiKhoan.Add(listItem);
            };


            ViewData["TaiKhoanId"] = listTaiKhoan;
            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;

            return View();
        }
        public ActionResult NgayBaoCaoHangNhap2CT(string name)
        {
            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;

            return View();
        }
        public ActionResult NgayBaoCaoSoNhatKyMuaHang(string name)
        {
            if (name == "" || name == null || name.Contains(" "))
            {
                ViewBag.viewName = (string)Session["ViewName"];
            }
            else
                ViewBag.viewName = name;

            return View();
        }

        //VIEW DANH SACH - BEGIN
        //PTTM
        public ActionResult PhieuThuTienMat(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                string name = "PhieuThuTienMat";
                Session["ViewName"] = name;
                return RedirectToAction("NgayBaoCao", "Home", new { name = name });
            }

        kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            var pt = db.PhieuThu.OrderBy(x => x.Id).Where(x => x.NgayLap > fromDate && x.NgayLap < toDate);
            return View(pt.Take(10).ToList());
        }
        //PCTM
        public ActionResult PhieuChiTienMat(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"]!=null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                string name = "PhieuChiTienMat";
                Session["ViewName"] = name;
                return RedirectToAction("NgayBaoCao", "Home", new {name = name});
            }

            kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            var pt = db.PhieuChi.OrderBy(x => x.Id).Where(x => x.NgayLap > fromDate && x.NgayLap < toDate);
            return View(pt.Take(10).ToList());
        }
        //SQTM
        public ActionResult SoQuyTienMat(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                taikhoanud = int.Parse(taiKhoan.Id);
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '" + taikhoanud + "'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["TaiKhoanId"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoQuyTienMat";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }


        kt: Session["TaiKhoanId"] = taikhoanid;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec SoQuyTienMat @taikhoan_id = "+taikhoanid+", @tungay= '" + fromDate.ToString("MM/dd/yyyy")+"', @denngay='"+ toDate.ToString("MM/dd/yyyy")+"'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //SQTMTN
        public ActionResult SoQuyTienMatTheoNgay(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                taikhoanud = int.Parse(taiKhoan.Id);
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '" + taikhoanud + "'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["TaiKhoanId"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoQuyTienMatTheoNgay";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }

        kt: Session["TaiKhoanId"] = taikhoanid;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec SoQuyTienMatTheoNgay @_taikhoan_id = "+taikhoanid+", @_tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @_denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //STGNH
        public ActionResult SoTienGuiNganHang(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                taikhoanud = int.Parse(taiKhoan.Id);
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '" + taikhoanud + "'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["TaiKhoanId"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoTienGuiNganHang";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }

        kt: Session["TaiKhoanId"] = taikhoanid;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec SoQuyTienMat @taikhoan_id = "+taikhoanid+", @tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //SCTTV
        public ActionResult SoTienVay(FormCollection form, KH_TKModel model)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            int khid = 1549;
            string khud = "BORO";
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                taikhoanud = int.Parse(model.TaiKhoanModel.Id);
                khud = model.KHachHangModel.Id;
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '" + taikhoanud + "'";
                string sql2 = "select khachhang_id from KhachHang where KhachHang_ud = '" + khud + "'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                DataTable tempdt2 = knA00.ExecuteQuery(sql2, null);
                khid = tempdt2.Rows[0].Field<int>(0);
                ViewBag.khid = khid;
                ViewBag.khud = khud;
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["TaiKhoanId"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.khid = khid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoTienGuiNganHang";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }

        kt: Session["KhachHangId"] = khid;
            Session["TaiKhoanId"] = taikhoanid;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec SoQuyTienMat @taikhoan_id = " + taikhoanid + ", @tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //SCTTV
        public ActionResult SoCtThanhToanNgBan(FormCollection form, KH_TKModel model)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            int khid = 1549;
            string khud = "BORO";
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                taikhoanud = int.Parse(model.TaiKhoanModel.Id);
                khud = model.KHachHangModel.Id;
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '" + taikhoanud + "'";
                string sql2 = "select khachhang_id from KhachHang where KhachHang_ud = '" + khud + "'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                DataTable tempdt2 = knA00.ExecuteQuery(sql2, null);
                if (tempdt2.Rows.Count > 0)
                {
                    khid = tempdt2.Rows[0].Field<int>(0);
                }
                else khid = 1550;
                ViewBag.khid = khid;
                ViewBag.khud = khud;
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["TaiKhoanId"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.khid = khid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoTienGuiNganHang";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }

        kt: Session["KhachHangId"] = khid;
            Session["TaiKhoanId"] = taikhoanid;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec SoCtThanhToanNgBan @khachhang_id = '"+khid+"', @taikhoan_id = " + taikhoanid + ", @tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View(); 
        }
        //BKPN
        public ActionResult BangKePhieuNhap(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            ////Neu duoc goi lan dau thi chuyen den NgayBaoCao
            //if (form["fromDate"] == null || form["toDate"] == null)
            //{
            //    Session["ViewName"] = "SoTienGuiNganHang";
            //    return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            //}

        kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec BangKePhieuNhapPreview @TuNgay= '" + fromDate.ToString("MM/dd/yyyy") + "', @DenNgay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //BKHDDV
        public ActionResult BangKeHDDV(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }

        kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec BangKeHoaDonMuaHangPreview @TuNgay= '" + fromDate.ToString("MM/dd/yyyy") + "', @DenNgay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //HNN2CT
        public ActionResult HangNhapNhom2CT(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            string LoaiPn = "";
            string MauBc = "";
            string nhomTheo = "";
            string ctTheo = "";
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                LoaiPn = form["LoaiPn"];
                MauBc = form["MauBc"];
                nhomTheo = form["nhomTheo"];
                ctTheo = form["ctTheo"];
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }

        kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec BaoCaoHangNhapNhomCtPreview @LoaiBC=4, @TuNgay= '" + fromDate.ToString("MM/dd/yyyy") + "', @DenNgay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //SNKMH
        public ActionResult SoNhatKyMuaHang(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            string TkNo = "";
            string TkCo = "";
            string tkNo_id = "";
            string tkCo_id = "";
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy", null);
                TkNo = form["TkNo"];
                TkCo = form["TkCo"];
                
                tkNo_id = dsTkId(TkNo);
                tkCo_id = dsTkId(TkCo);
                ViewBag.TkNo = tkNo_id;
                ViewBag.TkCo = tkCo_id;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                tkCo_id = (string)Session["TkCo"];
                tkNo_id = (string)Session["TkNo"];
                ViewBag.TkNo = tkNo_id;
                ViewBag.TkCo = tkCo_id;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }

        kt: Session["TkNo"] = tkNo_id;
            Session["TkCo"] = tkCo_id;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");
            string sqlQuery = "exec SoNhatKyMuaHangPreview @TuNgay= '" + fromDate.ToString("MM/dd/yyyy") + "', @DenNgay='" + toDate.ToString("MM/dd/yyyy") + "', @TkNo= '"+tkNo_id+"', @TkCo = '"+tkCo_id+"'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //SCTMTK
        public ActionResult SoChiTietTaiKhoan(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                taikhoanud = int.Parse(taiKhoan.Id);
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '"+taikhoanud+"'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["TaiKhoanId"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoChiTietTaiKhoan";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }

        kt: Session["TaiKhoanId"] = taikhoanid;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec SoQuyTienMat @taikhoan_id = "+taikhoanid+", @tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //STHCT
        public ActionResult SoTongHopChuT(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                taikhoanud = int.Parse(taiKhoan.Id);
                string sql = "select taikhoan_id from TaiKhoan where TaiKhoan_ud = '" + taikhoanud + "'";
                DataTable tempdt = knA00.ExecuteQuery(sql, null);
                taikhoanid = tempdt.Rows[0].Field<int>(0);
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.taiKhoanUd = taikhoanud;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                taikhoanid = (int)Session["taikhoanid"];
                taikhoanud = (int)Session["taikhoanud"];
                ViewBag.taikhoanid = taikhoanid;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "SoTongHopChuT";
                return RedirectToAction("NgayBaoCaoSoQuy", "Home");
            }

        kt: Session["taikhoanid"] = taikhoanid;
            Session["taikhoanud"] = taikhoanud;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            string sqlQuery = "exec TongHopSoQuyTienMat @taikhoan_id = " + taikhoanid + ", @tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //oTHHNM
        public ActionResult TongHopHangNhapMua(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            string LoaiPn = "";
            string MauBc = "";

            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                LoaiPn = form["LoaiPn"];
                MauBc = form["MauBc"];
                if (LoaiPn == null || MauBc == null)
                {
                    LoaiPn = "1";
                    MauBc= "1";
                }    
                ViewBag.LoaiPn = LoaiPn;
                ViewBag.MauBc = MauBc;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                LoaiPn = (string)Session["LoaiPn"];
                MauBc = (string)Session["MauBc"];
                if (LoaiPn == null || MauBc == null)
                {
                    LoaiPn = "1";
                    MauBc = "1";
                }
                ViewBag.LoaiPn = LoaiPn;
                ViewBag.MauBc = MauBc;
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                Session["ViewName"] = "TongHopHangNhapMua";
                return RedirectToAction("NgayBaoCaoTongHopHangNhapMua", "Home");
            }
        kt: Session["LoaiPn"] = LoaiPn;
            Session["MauBc"] = MauBc;
            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

         string sqlQuery = "exec TongHopHangNhapMuaPreview @tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @denngay='" + toDate.ToString("MM/dd/yyyy") + "'";

            DataTable dt = knBoroWeb.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        public JsonResult GetItemName(int id)
        {
            var item = db.TaiKhoan.FirstOrDefault(i => i.TaiKhoanUd == id.ToString());
            if (item != null)
            {
                return Json(new { name = item.TaiKhoanNm }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { name = "Không tìm thấy" }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetKHName(string id)
        {
            var item = db.KhachHang.FirstOrDefault(i => i.KhachHangUd == id);
            if (item != null)
            {
                return Json(new { name = item.KhachHangNm }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { name = "Không tìm thấy" }, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCNName(string id)
        {
            var item = db.ChiNhanh.FirstOrDefault(i => i.ChiNhanhUd == id);
            if (item != null)
            {
                return Json(new { name = item.ChiNhanhNm }, JsonRequestBehavior.AllowGet);
            }
            return Json(new { name = "Không tìm thấy" }, JsonRequestBehavior.AllowGet);
        }
        //Phieu nhap
        public ActionResult PhieuNhap(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                string name = "PhieuNhap";
                Session["ViewName"] = name;
                return RedirectToAction("NgayBaoCao", "Home", new { name = name });
            }

        kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            var pt = db.PhieuNhap.OrderBy(x => x.Id).Where(x => x.NgayLap > fromDate && x.NgayLap < toDate);
            return View(pt.Take(10).ToList());
        }
        //Phieu xuat noi bo
        public ActionResult PhieuXuatKhoNoiBo(FormCollection form)
        {

            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact(form["fromDate"], "dd/MM/yyyy",null);
                toDate = DateTime.ParseExact(form["toDate"], "dd/MM/yyyy",null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.ParseExact((string)Session["fromDate"], "dd/MM/yyyy", null);
                toDate = DateTime.ParseExact((string)Session["toDate"], "dd/MM/yyyy", null);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            //Neu duoc goi lan dau thi chuyen den NgayBaoCao
            if (form["fromDate"] == null || form["toDate"] == null)
            {
                string name = "PhieuXuatKhoNoiBo";
                Session["ViewName"] = name;
                return RedirectToAction("NgayBaoCao", "Home", new { name = name });
            }

        kt: Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

            var pt = db.PhieuXuatKho.OrderBy(x => x.Id).Where(x => x.NgayLap > fromDate && x.NgayLap < toDate);
            return View(pt.Take(10).ToList());
        }
        //Danh muc khach hang
        public ActionResult DanhMucKhachHang()
        {
            var kh = db.KhachHang.OrderBy(x => x.Id);
            return View(kh.Take(10).ToList());
        }
        //Danh muc vat tu
        public ActionResult DanhMucVatTu()
        {
            var vt = db.VatTu.OrderBy(x => x.Id);
            return View(vt.Take(10).ToList());
        }
        //VIEW DANH SACH - END
        public string dsTkId(string Tk_ud)
        {
            string Tk_id = "";
            List<string> ds = Tk_ud.Split(',').ToList();
            ds.RemoveAll(x => x == "");
            List<string> ds_id = new List<string>();
            for (int i = 0; i < ds.Count; i++)
            {
                ds[i] = ds[i].Trim();
                SqlParameter[] taikhoan_udPara = new SqlParameter[1];
                taikhoan_udPara[0] = new SqlParameter("taikhoan_ud", ds[i]);
                DataTable dt = knA00.ExecuteQuery("Select taikhoan_id from taikhoan where taikhoan_id = (select taikhoan_id from taikhoan where taikhoan_ud= @taikhoan_ud)" +
                    "or taikhoanparent_id = (select taikhoan_id from taikhoan where taikhoan_ud= @taikhoan_ud)", taikhoan_udPara);
                foreach (DataRow dr in dt.Rows)
                {
                    ds_id.Add(dr["taikhoan_id"].ToString());
                }
            }

            Tk_id = String.Join(",", ds_id);
            return Tk_id;
        }
    }
}