using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //içerisinde hem işlem hem mesaj hemde data vericek.. IResult içerisinde de hem mesaj hemde işlem sonucu var (DRY)
    {
        T Data { get; } //data için sonucu (result'ı) burada get ederiz..
    }
}
