using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiNgoc_36.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        public String MaNhanVien { get; set; }
        public String TenNhanVien { get; set; }
        public int MaTinhThanh { get; set; }
    }
}