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
    
    public partial class PhieuKeToan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhieuKeToan()
        {
            this.HoaDonGTGT = new HashSet<HoaDonGTGT>();
            this.PhieuKeToanCt = new HashSet<PhieuKeToanCt>();
            this.SoCai = new HashSet<SoCai>();
        }
    
        public int Id { get; set; }
        public string LoaiPhieu { get; set; }
        public Nullable<int> ChiNhanhId { get; set; }
        public Nullable<System.DateTime> NgayHt { get; set; }
        public Nullable<System.DateTime> NgayCt { get; set; }
        public string SoCt { get; set; }
        public string QuyenSo { get; set; }
        public Nullable<int> NgoaiTeId { get; set; }
        public Nullable<decimal> TyGia { get; set; }
        public Nullable<decimal> PsNo { get; set; }
        public Nullable<decimal> PsNoVND { get; set; }
        public Nullable<decimal> PsCo { get; set; }
        public Nullable<decimal> PsCoVND { get; set; }
        public Nullable<int> RefId { get; set; }
        public Nullable<bool> IsSuaTien { get; set; }
        public Nullable<bool> IsPostSC { get; set; }
        public Nullable<bool> IsNghiemThu { get; set; }
        public System.DateTime CreationTime { get; set; }
        public Nullable<System.Guid> CreatorId { get; set; }
        public Nullable<System.DateTime> LastModificationTime { get; set; }
        public Nullable<System.Guid> LastModifierId { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<System.Guid> DeleterId { get; set; }
        public Nullable<System.DateTime> DeletionTime { get; set; }
        public string DienGiai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HoaDonGTGT> HoaDonGTGT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhieuKeToanCt> PhieuKeToanCt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SoCai> SoCai { get; set; }
    }
}