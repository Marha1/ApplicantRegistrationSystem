using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.Primitiv
{
    public static class BenefitTypeExtensions
    {
        public static string ToRussianString(this BenefitType type)
        {
            return type switch
            {
                BenefitType.None => "Без льгот",
                BenefitType.Orphan => "Сирота",
                BenefitType.Disabled => "Инвалид",
                BenefitType.LargeFamily => "Многодетная семья",
                BenefitType.CombatantFamily => "Семья военнослужащего",
                BenefitType.Other => "Другая льгота",
                _ => type.ToString()
            };
        }
    }
}
