using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    /// <summary>
    /// Defines an interface for objects whose creation and modified dates are kept track of.
    /// </summary>
    public interface IDateTracking
    {
        /// <summary>
        /// Gets or sets the date and time the object was created.
        /// </summary>
        DateTime Ngaytao { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was last modified.
        /// </summary>
        DateTime? Ngaycapnhap { get; set; }

        /// <summary>
        /// Gets or sets the date and time the object was delete.
        /// </summary>
        DateTime? Ngayhuy { get; set; }


        DateTime? Ngayhoanthanh { get; set; }
    }
}
