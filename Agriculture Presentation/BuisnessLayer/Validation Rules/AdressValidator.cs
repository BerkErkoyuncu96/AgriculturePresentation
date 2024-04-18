using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer.Validation_Rules
{
    public class AdressValidator : AbstractValidator<Adress>
    {
        public AdressValidator()
        {
            RuleFor(x => x.Description1).NotEmpty().WithMessage("Açıklama 1 boş geçilemez");
            RuleFor(x => x.Description2).NotEmpty().WithMessage("Açıklama 2 boş geçilemez");
            RuleFor(x => x.Description3).NotEmpty().WithMessage("Açıklama 3 boş geçilemez");
            RuleFor(x => x.Description4).NotEmpty().WithMessage("Açıklama 4 boş geçilemez");
            RuleFor(x => x.Map).NotEmpty().WithMessage("Harita bilgisi boş geçilemez");
            RuleFor(x => x.Description1).MaximumLength(100).WithMessage("Açıklama 1 için en fazla 100 karakter girebilirsiniz.");
            RuleFor(x => x.Description2).MaximumLength(100).WithMessage("Açıklama 2 için en fazla 100 karakter girebilirsiniz.");
            RuleFor(x => x.Description3).MaximumLength(100).WithMessage("Açıklama 3 için en fazla 100 karakter girebilirsiniz.");
            RuleFor(x => x.Description4).MaximumLength(100).WithMessage("Açıklama 4 için en fazla 100 karakter girebilirsiniz.");
        }
    }
}
