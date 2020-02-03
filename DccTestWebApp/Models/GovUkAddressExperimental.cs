using GovUkDesignSystem;
using GovUkDesignSystem.Attributes;
using GovUkDesignSystem.Attributes.DataBinding;
using GovUkDesignSystem.Attributes.ValidationAttributes;
using GovUkDesignSystem.ModelBinders;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DccTestWebApp.Models
{
    public enum RadioButtonValues
    {
        [GovUkRadioCheckboxLabelText(Text = "Value 1")]
        radioValue1,

        [GovUkRadioCheckboxLabelText(Text = "Value 2")]
        radioValue2,

        [GovUkRadioCheckboxLabelText(Text = "Value 3")]
        radioValue3
    }

    public enum CheckboxValues
    {
        [GovUkRadioCheckboxLabelText(Text = "Value 1")]
        checkboxValue1,

        [GovUkRadioCheckboxLabelText(Text = "Value 2")]
        checkboxValue2,

        [GovUkRadioCheckboxLabelText(Text = "Value 3")]
        checkboxValue3,

        [GovUkRadioCheckboxLabelText(Text = "Value 4")]
        checkboxValue4,

        [GovUkRadioCheckboxLabelText(Text = "Value 5")]
        checkboxValue5
    }

    public class GovUkAddressExperimental : GovUkViewModel //qq:DCC remove inheritance
    {
        [ModelBinder(typeof(GovUkMandatoryIntBinder))]
        [GovUkDataBindingIntErrorText(ErrorMessageIfMissing = "Enter a binder validated int", NameAtStartOfSentence = "Binder validated int")]
        public int? BinderValidatedInt { get; set; }

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDataBindingStringErrorText(ErrorMessageIfMissing = "Enter a binder validated string")]
        public string BinderValidatedString { get; set; }

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDataBindingStringErrorText(ErrorMessageIfMissing = "Enter a binder validated text area string")]
        public string BinderValidatedTextArea { get; set; }

        [Required(ErrorMessage = "Select a binder validated radio option")]
        public RadioButtonValues? BinderValidatedRadio { get; set; }

        [GovUkValidateCheckboxNumberOfResponsesRangeDcc(MinimumSelected = 2, MaximumSelected = 4, ErrorMessageIfNothingSelected = "Select some binder validated checkbox values", PropertyNameForErrorMessage = "binder validated checkbox values")]
        public List<CheckboxValues> BinderValidatedCheckboxes { get; set; } = new List<CheckboxValues>();

        [GovUkValidateCheckboxNumberOfResponsesRange(MinimumSelected = 2, MaximumSelected = 4, ErrorMessageIfNothingSelected = "Select some custom validated checkbox values")]
        public List<CheckboxValues> CustomValidatedCheckboxes { get; set; }

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

        [ModelBinder(typeof(GovUkMandatoryStringBinder))]
        [GovUkDataBindingStringErrorText(ErrorMessageIfMissing = "Enter a child text area string")]
        public string ChildTextArea { get; set; }

        [GovUkValidateCheckboxNumberOfResponsesRangeDcc(MinimumSelected = 2, MaximumSelected = 4, ErrorMessageIfNothingSelected = "Select some child checkbox values", PropertyNameForErrorMessage = "child checkbox values")]
        public List<CheckboxValues> ChildCheckboxes { get; set; } = new List<CheckboxValues>();

        [Required(ErrorMessage = "Select a child radio option")]
        public RadioButtonValues? ChildValidatedRadio { get; set; }
    }
}
