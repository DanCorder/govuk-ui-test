using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DccTestWebApp.Models
{
    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Binder validated int", NameWithinSentence = "binder validated int")]
        public int? BinderValidatedInt { get; set; }

        [GovUkValidateRequired(ErrorMessageIfMissing = "Enter a custom validated ID")]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Custom validated ID", NameWithinSentence = "custom validated ID")]
        public int? CustomValidatedId { get; set; }

        public string Street { get; set; }
        public string PostCode { get; set; }

        [Required]
        public DccAddressChild Child { get; set; } = new DccAddressChild();
    }

    public class DccAddressChild
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDisplayNameForErrors(NameAtStartOfSentence = "Child int", NameWithinSentence = "child int")]
        public int? ChildInt { get; set; }
    }
}
