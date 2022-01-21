using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericServise.Core.Enums
{
    public enum  Month
    {

        [Display(Name = "Ocak"   )] Ocak       = 1,
        [Display(Name = "Şubat"  )] Şubat      = 2,
        [Display(Name = "Mart"   )] Mart       = 3,
        [Display(Name = "Nisan"  )] Nisan      = 4,
        [Display(Name = "Mayıs"  )] Mayıs      = 5,
        [Display(Name = "Haziran")] Haziran    = 6,
        [Display(Name = "Temmuz" )] Temmuz     = 7,
        [Display(Name = "Ağustos")] Ağustos    = 8,
        [Display(Name = "Eylül"  )] Eylül      = 9,
        [Display(Name = "Ekim"   )] Ekim       = 10,
        [Display(Name = "Kasım"  )] Kasım      = 11,
        [Display(Name = "Aralık" )] Aralık     = 12,
       

    }
}
