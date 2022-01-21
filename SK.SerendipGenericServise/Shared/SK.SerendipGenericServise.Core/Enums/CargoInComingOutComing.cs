using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SK.SerendipGenericServise.Core.Enums
{
    public enum CargoInComingOutComing
    {
        [Display(Name = "Gelen")] Gelen = 1,
        [Display(Name = "Giden")] Giden = 1,

    }
}
