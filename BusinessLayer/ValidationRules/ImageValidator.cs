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
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator() 
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık kısmı boş olamaz");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Başlık maximum 20 karakter olabilir");
            RuleFor(x => x.Title).MinimumLength(8).WithMessage("Başlık minumum 8 karakter olabilir");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama kısmı boş olamaz");
            RuleFor(x => x.Description).MaximumLength(50).WithMessage("Açıklama maximum 50 karakter olabilir");
            RuleFor(x => x.Description).MinimumLength(20).WithMessage("Açıklama minumum 20 karakter olabilir");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş olamaz");
        }
    }
}
