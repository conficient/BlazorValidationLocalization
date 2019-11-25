using FluentValidation;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorValidationLocalization
{
    public class ProductViewModelValidator : AbstractValidator<ProductViewModel>
    {
        public ProductViewModelValidator()
        {
            
            RuleFor(vm => vm.ProductCode).NotEmpty();
        }

        /// <summary>
        /// Set the language used
        /// </summary>
        /// <param name="language">language code, eg. 'en', 'fr' or 'ar'</param>
        public static void SetLanguage(string language)
        {
            ValidatorOptions.LanguageManager.Culture = new CultureInfo(language);
        }
    }
}
