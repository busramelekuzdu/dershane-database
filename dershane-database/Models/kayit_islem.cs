//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dershane_database.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class kayit_islem
    {
        public int ID { get; set; }
        public string ogrenci_isim { get; set; }
        public string ogrenci_soyisim { get; set; }
        public string ogrenci_numara { get; set; }
        public string ogrenci_tc_no { get; set; }
        public string adres { get; set; }
        public string veli_isim { get; set; }
        public string veli_soyisim { get; set; }
        public string veli_numara { get; set; }
        public string veli_tc_no { get; set; }
        public string kayit_tarihi { get; set; }
        public string cinsiyet { get; set; }
    }
}
