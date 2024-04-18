using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Validation_Rules
{
    public class ImageValidator : AbstractValidator<Image>
    {
        public ImageValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama boş geçilemez!");
            RuleFor(x => x.ImageURL).NotEmpty().WithMessage("Görsel yolunu boş geçemezsiniz!");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Başlık en az 5 karakterden oluşmalıdır.");
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık en fazla 50 karakter oluşabilir.");
            RuleFor(x => x.Description).MinimumLength(30).WithMessage("Açıklama alanı daha uzun olmalıdır.");
            RuleFor(x => x.Description).MaximumLength(250).WithMessage("Maximum açıklama uzunluğu sınırını aştınız.");
        }
    }
}
