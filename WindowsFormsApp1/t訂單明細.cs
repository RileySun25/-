//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    
    public partial class t訂單明細
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t訂單明細()
        {
            this.t換貨 = new HashSet<t換貨>();
        }
    
        public int f訂單明細ID { get; set; }
        public Nullable<int> f訂單單號ID { get; set; }
        public Nullable<int> f產品ID { get; set; }
        public Nullable<int> f訂購數量 { get; set; }
        public Nullable<decimal> f單價 { get; set; }
        public Nullable<decimal> f折扣 { get; set; }
    
        public virtual t訂單 t訂單 { get; set; }
        public virtual t產品 t產品 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t換貨> t換貨 { get; set; }
    }
}
