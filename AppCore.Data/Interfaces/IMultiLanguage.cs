using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
