using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AppCore.Data.Entities.System
{
    [Table("Timers")]
    public class Timer
    {
        [Key]
        public int Timerid { get; set; }

        public int Thoigiandangxuat { get; set; }

        public byte Trangthai { get; set; }
    }
}
