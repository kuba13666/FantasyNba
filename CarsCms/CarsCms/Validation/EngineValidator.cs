using CarsCms.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarsCms.Validation
{
    public class EngineValidator : AbstractValidator<EngineEntity>
    {
        public EngineValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Pole nie moze byc puste");
            RuleFor(x => x.Capacity).GreaterThan(1500).WithMessage("Pojemność musi być wieksza niz 1500");
            RuleFor(x => x.Capacity).LessThan(6000).WithMessage("Pojemność musi być mniejsza niz 6000");
            RuleFor(x => x.Name).Must(name=> PierwszaLitera(name)).WithMessage("Pierwsza litera musi być wielka");
            RuleFor(x => x.Name).Length(3, 16).WithMessage("Dlugosc name musi być większa niż 3 i mniejsza niż 16");
            RuleFor(x => x).Must(x => CorelationBetweenCapacityAndWeight(x)).WithMessage("If capacity between 1598 and 1601 than weight must be over 650");
            RuleFor(x => x).Must(x => CapacityAndName(x)).WithMessage("If Capacity divided by ten is greater than 200, Name cannot be AAA ");
            RuleFor(x => x.Capacity).NotEmpty().WithMessage("Capacity cannot be empty");
        }
        public bool PierwszaLitera(string name)
        {
            if (!String.IsNullOrWhiteSpace(name))
            {
                return char.IsUpper(name[0]);
            }
            return false;
        }
        public bool CorelationBetweenCapacityAndWeight(EngineEntity engine)
        {
            if (engine.Capacity>1598 && engine.Capacity<1601)
            {
                if (engine.Weight>650)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
        public bool CapacityAndName(EngineEntity engine)
        {
            if (engine.Capacity>200 && engine.Name=="AAA")
            {
                return false;
            }
            return true;
        }
    }
}