﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Linq;

namespace DemoCore.Validatetion
{
    public static class ValidatetionHelper
    {
        public static ValidResult IsValid(object value)
        {
            ValidResult result = new();
            try
            {
                var validationContext = new ValidationContext(value);
                var results = new List<ValidationResult>();
                var isValid = Validator.TryValidateObject(value, validationContext, results, true);

                if (!isValid)
                {
                    result.IsVaild = false;
                    result.ErrorMembers = new List<ErrorMember>();
                    foreach (var item in results)
                    {
                        result.ErrorMembers.Add(new ErrorMember()
                        {
                            ErrorMessage = item.ErrorMessage,
                            ErrorMemberName = item.MemberNames.FirstOrDefault()
                        });
                    }
                }
                else
                {
                    result.IsVaild = true;
                }
            }
            catch (Exception ex)
            {
                result.IsVaild = false;
                result.ErrorMembers = new List<ErrorMember>();
                result.ErrorMembers.Add(new ErrorMember()
                {
                    ErrorMessage = ex.Message,
                    ErrorMemberName = "Internal error"
                });
            }

            return result;
        }
    }
    public class ValidResult
    {
        public List<ErrorMember> ErrorMembers { get; set; }
        public bool IsVaild { get; set; }
    }

    public class ErrorMember
    {
        public string ErrorMessage { get; set; }
        public string ErrorMemberName { get; set; }
    }
}
