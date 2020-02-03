using AppCore.Infrastructure.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Trangthai { set; get; }
    }
}
