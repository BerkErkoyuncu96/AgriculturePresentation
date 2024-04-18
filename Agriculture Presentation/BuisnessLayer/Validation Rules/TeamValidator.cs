using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Validation_Rules
{
    public class TeamValidator : AbstractValidator<Team>
    {
        public TeamValidator()
        {
            RuleFor(x => x.PersonName).NotEmpty().WithMessage("İsim boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Görev alanı boş geçilemez.");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Görsel yolu boş geçilemez.");
            RuleFor(x => x.PersonName).MinimumLength(5).WithMessage("Personel ismi en az 3 karakter olmalıdır.");
            RuleFor(x => x.PersonName).MaximumLength(100).WithMessage("Maximum isim uzunluğu 100 karakteri geçmemelidir.");
            RuleFor(x => x.Title).MinimumLength(5).WithMessage("Görev adı en az 5 karakterden oluşmaladır.");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Görev adı maximum 150 karakterden oluşmaldır.");
        }
    }
}
