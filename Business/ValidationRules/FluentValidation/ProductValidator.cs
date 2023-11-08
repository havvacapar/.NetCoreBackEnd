using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MinimumLength(2).WithMessage("ürün adı 2 haneden fazla olmalı"); //productname min. 2 karakter olmalı
            RuleFor(p => p.ProductName).NotEmpty();
            RuleFor(p => p.UnitPrice).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThan(0);
            //RuleFor(p => p.ProductName).Must(StartWithA).WithMessage("ürünler A harfi ile başlamalı"); //kendi kodumuzu metot halinde oluşturduk
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(10).When(p => p.CategoryId == 1);
            //ürünün fiyatı en az olsun ama ürünün kategori id'si 1'e eşit ise
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
