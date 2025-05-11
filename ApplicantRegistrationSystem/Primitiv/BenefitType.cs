using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicantRegistrationSystem.Primitiv
{
    public enum BenefitType
    {
        None = 0,               // Без льгот
        Orphan = 1,             // Сирота
        Disabled = 2,           // Инвалид
        LargeFamily = 3,        // Из многодетной семьи
        CombatantFamily = 4,    // Семья военнослужащего
        Other = 99              // Другая льгота
    }
}
