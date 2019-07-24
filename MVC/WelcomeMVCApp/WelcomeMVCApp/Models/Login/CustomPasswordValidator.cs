using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace WelcomeMVCApp.Models.Login
{
    public class CustomPasswordValidator:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            bool validPassword = false;
            string reason = String.Empty;
            //return base.IsValid(value, validationContext);
            string password = value.ToString();
            if (string.IsNullOrEmpty(password) || password.Length < 8)
            {
                reason = "Your new password must be at least 8 characters long. ";
            }
            else {
                Regex reSymbol = new Regex("[^a-zA-Z0-9]");
                if (!reSymbol.IsMatch(password))
                {
                    reason += "Your new password must contain at least 1 symbol character.";
                }
                else
                {
                    validPassword = true;
                }
            }
            if (validPassword)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult(reason);
            }

        }
    }
}