using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.DataBinding;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DccTestWebApp.Models
{
    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDataBindingIntErrorText(ErrorMessageIfMissing = "Enter a binder validated int", NameAtStartOfSentence = "Binder validated int")]
        public int? BinderValidatedInt { get; set; }

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDataBindingStringErrorText(ErrorMessageIfMissing = "Enter a binder validated string")]
        public string BinderValidatedString { get; set; }

        [Required]
        public DccAddressChild Child { get; set; } = new DccAddressChild();
    }

    public class DccAddressChild
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDataBindingIntErrorText(ErrorMessageIfMissing = "Enter a child int", NameAtStartOfSentence = "Child int")]
        public int? ChildInt { get; set; }

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDataBindingStringErrorText(ErrorMessageIfMissing = "Enter a child string")]
        public string ChildString { get; set; }
    }
}
