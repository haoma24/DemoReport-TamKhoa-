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
    
    public partial class PhanBoChiPhi
    {
        public int Id { get; set; }
        public Nullable<int> PhieuNhapId { get; set; }
        public Nullable<int> VatTuId { get; set; }
        public Nullable<int> KhoId { get; set; }
        public Nullable<decimal> TienHang { get; set; }
        public Nullable<decimal> TienHangVND { get; set; }
        public Nullable<decimal> ChiPhi { get; set; }
        public Nullable<decimal> ChiPhiVND { get; set; }
        public Nullable<int> TkNo { get; set; }
        public Nullable<int> PhieuNhapCtId { get; set; }
        public Nullable<int> MaPhiId { get; set; }
        public Nullable<int> VuViecId { get; set; }
        public Nullable<int> MaTD01 { get; set; }
        public Nullable<int> MaTD02 { get; set; }
        public Nullable<int> MaTD03 { get; set; }
        public Nullable<int> DieuChinhThueTNDNId { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
