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
    
    public partial class SoCai
    {
        public int Id { get; set; }
        public Nullable<int> PhieuNhapId { get; set; }
        public Nullable<int> PhieuXuatId { get; set; }
        public Nullable<int> PhieuThuId { get; set; }
        public Nullable<int> PhieuChiId { get; set; }
        public Nullable<int> PhieuNhapKhoId { get; set; }
        public Nullable<int> PhieuXuatKhoId { get; set; }
        public Nullable<int> PhieuXuatDcKhoId { get; set; }
        public Nullable<int> PhieuKeToanId { get; set; }
        public string KHTSCDId { get; set; }
        public Nullable<int> DuDauKyTkId { get; set; }
        public Nullable<int> ButToanKcId { get; set; }
        public Nullable<int> ButToanPbId { get; set; }
        public Nullable<int> ButToanCLTGId { get; set; }
        public string MaNk { get; set; }
        public Nullable<int> MaGd { get; set; }
        public Nullable<System.DateTime> NgayHt { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string SoCt { get; set; }
        public string SoDh { get; set; }
        public string SoLo { get; set; }
        public string PhieuUd { get; set; }
        public Nullable<System.DateTime> NgayLo { get; set; }
        public Nullable<int> KhachHangId { get; set; }
        public string DienGiai { get; set; }
        public string NhomDinhKhoan { get; set; }
        public Nullable<int> Tk { get; set; }
        public Nullable<int> TkDoiUng { get; set; }
        public Nullable<decimal> PhatSinhNo { get; set; }
        public Nullable<decimal> PhatSinhCo { get; set; }
        public Nullable<int> NgoaiTeId { get; set; }
        public Nullable<decimal> TyGia { get; set; }
        public Nullable<decimal> TyGiaHt { get; set; }
        public Nullable<decimal> TyGiaHt2 { get; set; }
        public Nullable<decimal> PhatSinhNoVND { get; set; }
        public Nullable<decimal> PhatSinhCoVND { get; set; }
        public Nullable<int> Nxt { get; set; }
        public Nullable<int> VuViecId { get; set; }
        public Nullable<int> MaPhiId { get; set; }
        public Nullable<int> MaTD01 { get; set; }
        public Nullable<int> MaTD02 { get; set; }
        public Nullable<int> MaTD03 { get; set; }
        public Nullable<int> ChiNhanhId { get; set; }
        public Nullable<int> MaTd { get; set; }
        public Nullable<int> MaKu { get; set; }
        public string SoHd { get; set; }
        public string SoSeri { get; set; }
        public Nullable<System.DateTime> NgayHd { get; set; }
        public string SoCTGS { get; set; }
        public Nullable<System.DateTime> NgayCTGS { get; set; }
        public string SoQuyen { get; set; }
        public string Phieu_ud { get; set; }
        public Nullable<int> BoPhanHTId { get; set; }
        public Nullable<int> VatTuId { get; set; }
        public Nullable<int> DieuChinhThueTNDNId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public Nullable<int> PhieuNhapKhoNoiBoId { get; set; }
    
        public virtual PhieuChi PhieuChi { get; set; }
        public virtual PhieuKeToan PhieuKeToan { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual PhieuNhapKho PhieuNhapKho { get; set; }
        public virtual PhieuThu PhieuThu { get; set; }
        public virtual PhieuXuatDcKho PhieuXuatDcKho { get; set; }
        public virtual PhieuXuatKho PhieuXuatKho { get; set; }
    }
}