using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenThiNgoc_36.Models
{
    [Table("TinhThanhs")]
    public class TinhThanh
    {
        [Key, DatabaseGenerated (DatabaseGeneratedOption.Identity)]

        public int MaTinhThanh { get; set; }
        public String TenTinhThanh { get; set; }
    }
}