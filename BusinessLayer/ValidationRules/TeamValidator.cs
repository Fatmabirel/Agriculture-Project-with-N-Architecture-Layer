using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {

            RuleFor(x=> x.PersonName).NotEmpty().WithMessage(x => ValidatorOptions.Global.LanguageManager.GetString("NotEmptyValidator",new CultureInfo("tr")));

            RuleFor(x=> x.PersonName).MaximumLength(50).WithMessage("Ad soyad maximum 50 karakter olabilir");
            RuleFor(x=> x.PersonName).MinimumLength(5).WithMessage("Ad soyad minumum 5 karakter olabilir");

            RuleFor(x=> x.Title).NotEmpty().WithMessage("Görev kısmı boş olamaz");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlıkmaximum 50 karakter olabilir");
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Başlık minumum 3 karakter olabilir");

            RuleFor(x=> x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş olamaz");
        }
    }
}

