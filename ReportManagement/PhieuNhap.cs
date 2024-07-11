//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class PhieuNhap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhap()
        {
            this.HoaDonGTGT1 = new HashSet<HoaDonGTGT>();
            this.HoaDonMuaHang = new HashSet<HoaDonMuaHang>();
            this.PhanBoChietKhauThuongMai = new HashSet<PhanBoChietKhauThuongMai>();
            this.PhanBoChiPhi = new HashSet<PhanBoChiPhi>();
            this.PhanBoThueNk = new HashSet<PhanBoThueNk>();
            this.PhieuNhapCT = new HashSet<PhieuNhapCT>();
            this.SoCai = new HashSet<SoCai>();
        }
    
        public int Id { get; set; }
        public string LoaiPhieu { get; set; }
        public Nullable<int> ChiNhanhId { get; set; }
        public Nullable<int> KhachHangId { get; set; }
        public string NguoiGiaoHang { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> GhiCoTk { get; set; }
        public string Sopn { get; set; }
        public string QuyenSo { get; set; }
        public Nullable<System.DateTime> NgayHt { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public Nullable<int> NgoaiTeId { get; set; }
        public Nullable<decimal> TiGia { get; set; }
        public Nullable<bool> IsNhapGiaTb { get; set; }
        public Nullable<int> PhieuNhapMId { get; set; }
        public Nullable<System.DateTime> NgayLapM { get; set; }
        public string SoHd { get; set; }
        public string SoSeri { get; set; }
        public Nullable<System.DateTime> NgayHd { get; set; }
        public Nullable<int> BoPhanId { get; set; }
        public string GhiChu { get; set; }
        public string NhomHang { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
        public Nullable<decimal> TienVon { get; set; }
        public Nullable<decimal> TienVonVND { get; set; }
        public Nullable<decimal> TienHang { get; set; }
        public Nullable<decimal> TienHangVND { get; set; }
        public Nullable<decimal> ChiPhi { get; set; }
        public Nullable<decimal> ChiPhiVND { get; set; }
        public Nullable<decimal> TongTienHangCp { get; set; }
        public Nullable<decimal> TongTienHangCpVND { get; set; }
        public Nullable<decimal> TienChietKhau { get; set; }
        public Nullable<decimal> TienChietKhauVND { get; set; }
        public Nullable<decimal> GiamGia1 { get; set; }
        public Nullable<decimal> GiamGia1VND { get; set; }
        public Nullable<decimal> GiamGia2 { get; set; }
        public Nullable<decimal> GiamGia2VND { get; set; }
        public Nullable<decimal> ThueVat { get; set; }
        public Nullable<decimal> ThueVatVND { get; set; }
        public Nullable<decimal> ThueNk { get; set; }
        public Nullable<decimal> ThueNkVND { get; set; }
        public Nullable<decimal> TongTien { get; set; }
        public Nullable<decimal> TongTienVND { get; set; }
        public Nullable<int> ThueSuatId { get; set; }
        public Nullable<decimal> ThueSuat { get; set; }
        public Nullable<decimal> ChietKhau { get; set; }
        public Nullable<bool> IsChiPhiTinhThue { get; set; }
        public Nullable<int> HoaDonGTGT { get; set; }
        public Nullable<int> TkThueNk { get; set; }
        public Nullable<int> TkThueVat { get; set; }
        public Nullable<int> TkThueVatDu { get; set; }
        public Nullable<int> TkGiamGia1 { get; set; }
        public Nullable<int> TkGiamGia2 { get; set; }
        public Nullable<int> HanTT { get; set; }
        public Nullable<bool> IsSuaTtThue { get; set; }
        public Nullable<bool> IsSuaTienThue { get; set; }
        public Nullable<bool> IsSuaTkThue { get; set; }
        public Nullable<decimal> TienHd { get; set; }
        public Nullable<decimal> TienHdVND { get; set; }
        public Nullable<decimal> TienPhaiTt { get; set; }
        public Nullable<decimal> TienPhaiTtVND { get; set; }
        public Nullable<decimal> ConPhaiTt { get; set; }
        public Nullable<decimal> ConPhaiTtVND { get; set; }
        public Nullable<decimal> TienTt { get; set; }
        public Nullable<decimal> TienTtVND { get; set; }
        public Nullable<bool> IsTatToan { get; set; }
        public Nullable<bool> IsChon { get; set; }
        public Nullable<bool> IsSuaHD { get; set; }
        public Nullable<int> MauHDId { get; set; }
        public string MauHDUd { get; set; }
        public string KyHieuMauHD { get; set; }
        public Nullable<bool> IsSuaTien { get; set; }
        public string DiaChi { get; set; }
        public string MaSoThue { get; set; }
        public Nullable<int> MauBC { get; set; }
        public Nullable<int> LoaiThueId { get; set; }
        public Nullable<bool> IsPostSC { get; set; }
        public string ChungTuChiPhi { get; set; }
        public Nullable<decimal> ChietKhauVND { get; set; }
        public Nullable<int> PhuongPhapChietKhau { get; set; }
        public string ConnectAE { get; set; }
        public Nullable<decimal> ChietKhauDaBan { get; set; }
        public Nullable<decimal> ChietKhauDaBanVND { get; set; }
        public Nullable<decimal> ChietKhauDungDePhanBo { get; set; }
        public Nullable<decimal> ChietKhauDungDePhanBoVND { get; set; }
        public Nullable<int> TkChietKhau { get; set; }
        public Nullable<bool> IsTaoTuDongToanBoDienGiai { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonGTGT> HoaDonGTGT1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonMuaHang> HoaDonMuaHang { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanBoChietKhauThuongMai> PhanBoChietKhauThuongMai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanBoChiPhi> PhanBoChiPhi { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhanBoThueNk> PhanBoThueNk { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuNhapCT> PhieuNhapCT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoCai> SoCai { get; set; }


    }
}