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
    
    public partial class t訂單
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public t訂單()
        {
            this.t訂單明細 = new HashSet<t訂單明細>();
        }
    
        public int f訂單單號ID { get; set; }
        public Nullable<int> f店家ID { get; set; }
        public string f訂購人 { get; set; }
        public string f連絡電話 { get; set; }
        public string f寄送地址 { get; set; }
        public string f訂購人信箱 { get; set; }
        public string f訂購日期 { get; set; }
        public string f訂單需求 { get; set; }
        public string f訂單備註 { get; set; }
        public Nullable<decimal> f訂單總金額 { get; set; }
        public string f付款方式 { get; set; }
        public string f付款狀態 { get; set; }
        public string f配送狀態 { get; set; }
        public string f訂單狀態 { get; set; }
        public string f訂單QRCode圖片路徑 { get; set; }
        public string f對外訂單單號 { get; set; }
    
        public virtual t店家 t店家 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<t訂單明細> t訂單明細 { get; set; }
    }
}
