using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMvc.Models.Entities
{
    // Chỉ định tên của table
    [Table("SinhVien")]

    public class Student
    {
        [Key]
        public string StudentID { get; set; }
        public string FullName { get; set; }
    }
}