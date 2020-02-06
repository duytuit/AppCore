using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models.Systems.Sys001s.Dtos
{
    public class ChangePassWord
    {
        public string IdUser { get; set; }
        public string passwordOld { get; set; }
        public string PasswordNew { get; set; }
    }
}
