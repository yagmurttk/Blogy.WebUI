using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BusinessLayer.ValidationRules.CategoryValidation
{
    public class UpdateCategoryValidation:AbstractValidator<Category>
    {
        public UpdateCategoryValidation()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori adını boş geçemezsiniz").MaximumLength(30).WithMessage("Lütfen Kategori adını en fazla 30 karakter olarak giriniz").Equal("a").WithMessage("KLütfen ategori adına a harfi ekleyiniz");
            
        }
    }
}
