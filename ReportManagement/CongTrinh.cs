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
    
    public partial class CongTrinh
    {
        public int Id { get; set; }
        public string CongTrinhUd { get; set; }
        public string CongTrinhNm { get; set; }
        public string CongTrinhNm2 { get; set; }
        public Nullable<System.DateTime> NgayBatDau { get; set; }
        public Nullable<System.DateTime> NgayKetThuc { get; set; }
        public Nullable<decimal> DuToan { get; set; }
        public string ChuDauTu { get; set; }
        public string DienGiai { get; set; }
        public Nullable<int> CongTrinhId1 { get; set; }
        public Nullable<bool> IsNghiemThu { get; set; }
        public string DisplayUd { get; set; }
        public Nullable<int> IsCongTrinh { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
    }
}