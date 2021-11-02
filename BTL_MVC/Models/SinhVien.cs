using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BTL_MVC.Models
{
    [Table("SinhVien")]
    public class SinhVien
    {
        [Key]
        public string MaSV { get; set; }


        public string TenSV { get; set; }
        public string NamSinh { get; set; }
        public string Lop { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
    }
}