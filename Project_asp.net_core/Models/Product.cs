using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_asp.net_core.Models
{
    public class Product
    {
        // các thuộc tính sản phẩm;
        [Key]
        public int Id { get; set; }
        public string  Name { get; set; }
        public  string Description { get; set; }//MÔ tả 
        public string ImageUrl { get; set; }// Hình
        public decimal Price { get; set; }
        public int Quantity { get; set; }// Số lượng

                                         //khai báo mối kết hợp 1-n
        [ForeignKey("Category")]// Khóa ngoại 
        public int CategoryId { get; set; }
        public virtual Category Category { set; get; } //khai báo mối kết hợp 1 - nhiều

    }
}
