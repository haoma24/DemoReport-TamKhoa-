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
    
    public partial class PhieuNhapKhoCt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuNhapKhoCt()
        {
            this.TheKho = new HashSet<TheKho>();
        }
    
        public int Id { get; set; }
        public Nullable<int> PhieuNhapKhoId { get; set; }
        public Nullable<int> VatTuId { get; set; }
        public Nullable<int> KhoId { get; set; }
        public Nullable<System.DateTime> NgayLo { get; set; }
        public string SoLo { get; set; }
        public Nullable<decimal> SoLuong { get; set; }
        public Nullable<decimal> TonKho { get; set; }
        public Nullable<decimal> Gia { get; set; }
        public Nullable<decimal> GiaVND { get; set; }
        public Nullable<decimal> Tien { get; set; }
        public Nullable<decimal> TienVND { get; set; }
        public Nullable<int> GhiNoTK { get; set; }
        public Nullable<int> GhiCoTK { get; set; }
        public Nullable<int> MaPhiId { get; set; }
        public Nullable<int> VuViecId { get; set; }
        public Nullable<int> BoPhanHTId { get; set; }
        public Nullable<int> VatTuId1 { get; set; }
        public Nullable<int> MaTD01 { get; set; }
        public Nullable<System.DateTime> NgayTD01 { get; set; }
        public Nullable<decimal> SoLuongTD01 { get; set; }
        public string GhiChuTD01 { get; set; }
        public Nullable<int> MaTD02 { get; set; }
        public Nullable<System.DateTime> NgayTD02 { get; set; }
        public Nullable<decimal> SoLuongTD02 { get; set; }
        public string GhiChuTD02 { get; set; }
        public Nullable<int> MaTD03 { get; set; }
        public Nullable<System.DateTime> NgayTD03 { get; set; }
        public Nullable<decimal> SoLuongTD03 { get; set; }
        public string GhiChuTD03 { get; set; }
        public Nullable<int> DieuChinhThueTNDNId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
    
        public virtual PhieuNhapKho PhieuNhapKho { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheKho> TheKho { get; set; }
    }
}
