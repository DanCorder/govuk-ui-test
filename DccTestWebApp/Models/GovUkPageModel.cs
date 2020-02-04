using GovUkDesignSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DccTestWebApp.Models
{
    public class GovUkPageModel : GovUkViewModel
    {
        public GovUkAddressExperimental Address { get; set; } = new GovUkAddressExperimental();
    }
}
