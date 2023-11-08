using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IResult
    {
        bool Success { get; } //yaptığın işlem başarılı mı
        string Message { get; } //işlem sonucu mesajı gönder
    }
}
