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
    
    public partial class QuyenSo
    {
        public int Id { get; set; }
        public string MaCt { get; set; }
        public string SoQuyen { get; set; }
        public Nullable<int> SoCtHienTai { get; set; }
        public Nullable<int> SoKyTu0 { get; set; }
        public string SoCtPrefix { get; set; }
        public string SoCtSuffix { get; set; }
        public Nullable<bool> IsUser { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
    }
}