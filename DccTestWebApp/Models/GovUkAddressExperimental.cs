using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;

namespace DccTestWebApp.Models
{
    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Test mandatory int", NameWithinSentence = "test mandatory int")]
        public int MandatoryInt { get; set; }
        public int? ID { get; set; }
        public string Street { get; set; }
        public string PostCode { get; set; }
    }
}
