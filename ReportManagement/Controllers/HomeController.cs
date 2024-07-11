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

namespace ReportManagement.Controllers
{
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
        public ActionResult Index()
        {
            return View();
        }

        //VIEW BAO CAO - BEGIN
        //Phieu thu
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
            
            ViewBag.Name = "PhieuThuTienMat";
            ViewBag.Id = _id;
            return View();
        }
        //Phieu chi
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

            ViewBag.Name = "PhieuChiTienMat";
            ViewBag.Id = _id;
            return View();
        }
        //Khach hang
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

            ViewBag.Name = "DanhMucKhachHang";
            ViewBag.Id = _id;
            return View();
        }
        //Phieu nhap
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

            ViewBag.Name = "PhieuNhapKho";
            ViewBag.Id = _id;
            return View();
        }
        //Phieu xuat
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

            ViewBag.Name = "PhieuXuatNoiBo";
            ViewBag.Id = _id;
            return View();
        }
        //Vat tu
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

            ViewBag.Name = "DanhMucVatTu";
            ViewBag.Id = _id;
            return View();
        }
        public ActionResult BaoCaoSoQuy(FormCollection form)
        {
            ViewBag.FromDate = DateTime.Parse(form["fromDate"]).ToString("MM/dd/yyyy");
            ViewBag.ToDate = DateTime.Parse(form["toDate"]).ToString("MM/dd/yyyy");
            ViewBag.Name = "SoQuyTienMat";
            ViewBag.Taikhoan_id = form["taikhoanid"];
            return View();
        }
        public ActionResult BaoCaoSoQuyTienGuiNganHang(FormCollection form)
        {
            ViewBag.FromDate = DateTime.Parse(form["fromDate"]).ToString("MM/dd/yyyy");
            ViewBag.ToDate = DateTime.Parse(form["toDate"]).ToString("MM/dd/yyyy");
            ViewBag.Name = "SoQuyTienMat";
            ViewBag.Taikhoan_id = form["Id"];
            return View();
        }
        public ActionResult BaoCaoSoQuyTienMat(FormCollection form)
        {
            ViewBag.FromDate = DateTime.Parse(form["fromDate"]).ToString("MM/dd/yyyy");
            ViewBag.ToDate = DateTime.Parse(form["toDate"]).ToString("MM/dd/yyyy");
            ViewBag.Name = "SoQuyTienMatTheoNgay";
            ViewBag.Taikhoan_id = form["taikhoanid"];
            return View();
        }
        public ActionResult BaoCaoSoTongHopChuT(FormCollection form)
        {
            ViewBag.FromDate = DateTime.Parse(form["fromDate"]).ToString("MM/dd/yyyy");
            ViewBag.ToDate = DateTime.Parse(form["toDate"]).ToString("MM/dd/yyyy");
            ViewBag.Name = "SoTongHopChuT";
            ViewBag.Taikhoan_id = form["taikhoanid"];
            return View();
        }
        public ActionResult BaoCaoSoChiTietMotTaiKhoan(FormCollection form)
        {
            ViewBag.FromDate = DateTime.Parse(form["fromDate"]).ToString("MM/dd/yyyy");
            ViewBag.ToDate = DateTime.Parse(form["toDate"]).ToString("MM/dd/yyyy");
            ViewBag.Name = "SoChiTietMotTaiKhoan";
            ViewBag.Taikhoan_id = form["taikhoanid"];
            return View();
        }
        public ActionResult BaoCaoTongHopHangNhapMua(FormCollection form)
        {
            ViewBag.FromDate = DateTime.Parse(form["fromDate"]).ToString("MM/dd/yyyy");
            ViewBag.ToDate = DateTime.Parse(form["toDate"]).ToString("MM/dd/yyyy");
            ViewBag.ReportName = "TongHopHangNhapMuaMau";
            ViewBag.MauBc = form["MauBc"];
            ViewBag.Taikhoan_id = "350";
            return View();
        }
        //VIEW BAO CAO - END

        //Contrller chon ngay
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
        public ActionResult NgayBaoCaoSoQuy(string name)
        {
            SoCai soCai = new SoCai();
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
        public ActionResult NgayBaoCaoSoTienGuiNganHang(string name)
        {
            SoCai soCai = new SoCai();
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
        public ActionResult NgayBaoCaoTongHopHangNhapMua(string name)
        {
            if (name == "" || name == null || name.Contains(" "))
            {
            SoCai soCai = new SoCai();
            ViewBag.TaikhoanID = new SelectList(db.TaiKhoan, "Id", "TaikhoanUd");
            ViewBag.viewName = (string)Session["ViewName"];
            }    
            else ViewBag.viewName = name;

            return View();
        }

        //VIEW DANH SACH - BEGIN
        //Phieu thu
        public ActionResult PhieuThuTienMat(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
        public ActionResult PhieuChiTienMat(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"]!=null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
        //So quy tien mat
        public ActionResult SoQuyTienMat(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;

            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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

            //Viewbag hien thi tren title
            ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
            ViewBag.toDate = toDate.ToString("dd/MM/yyyy");

            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

        kt: string sqlQuery = "exec SoQuyTienMat @taikhoan_id = 350, @tungay= '"+ fromDate.ToString("MM/dd/yyyy")+"', @denngay='"+ toDate.ToString("MM/dd/yyyy")+"'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //So quy tien mat theo ngay
        public ActionResult SoQuyTienMatTheoNgay(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;

            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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

            //Viewbag hien thi tren title
            ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
            ViewBag.toDate = toDate.ToString("dd/MM/yyyy");

            Session["fromDate"] = fromDate.ToString("dd/MM/yyyy");
            Session["toDate"] = toDate.ToString("dd/MM/yyyy");

        kt: string sqlQuery = "exec SoQuyTienMatTheoNgay @taikhoan_id = 350, @_tungay= '" + fromDate.ToString("MM/dd/yyyy") + "', @_denngay='" + toDate.ToString("MM/dd/yyyy") + "'";
            DataTable dt = knA00.ExecuteQuery(sqlQuery, null);
            ViewBag.Datatable = dt;
            return View();
        }
        //So tien gui ngan hang
        public ActionResult SoTienGuiNganHang(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
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
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
        //So chi tiet cua mot tai khoan
        public ActionResult SoChiTietTaiKhoan(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
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
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
        //So tong hop chu T
        public ActionResult SoTongHopChuT(FormCollection form, TaiKhoanModel taiKhoan)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            int taikhoanud = 111;
            int taikhoanid = 350;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
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
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
        //Tong hop hang nhap mua
        public ActionResult TongHopHangNhapMua(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            string LoaiPn = "";
            string MauBc = "";

            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
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
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
        //Phieu nhap
        public ActionResult PhieuNhap(FormCollection form)
        {
            DateTime fromDate = DateTime.Now;
            DateTime toDate = DateTime.Now;
            if (form["fromDate"] != null || form["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
                fromDate = DateTime.Parse(form["fromDate"]);
                toDate = DateTime.Parse(form["toDate"]);
                ViewBag.fromDate = fromDate.ToString("dd/MM/yyyy");
                ViewBag.toDate = toDate.ToString("dd/MM/yyyy");
                goto kt;
            }
            if (Session["fromDate"] != null || Session["toDate"] != null)
            {
                //Sau khi chon ngay bao cao
                fromDate = DateTime.Parse((string)Session["fromDate"]);
                toDate = DateTime.Parse((string)Session["toDate"]);
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
    }
}