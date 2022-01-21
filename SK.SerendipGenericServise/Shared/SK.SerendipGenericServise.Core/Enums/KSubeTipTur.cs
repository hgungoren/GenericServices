using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericServise.Core.Enums
{
    public enum KSubeTipTur
    {
        [Display(Name = "Standart")]
        Standart = 1,

        [Display(Name = "Nokta")]
        Nokta = 2,

        [Display(Name = "Acente")]
        Acente = 3,

        [Display(Name = "Operasyon")]
        Operasyon = 4,

        [Display(Name = "Mobile")]
        Mobile = 5
    }
}
