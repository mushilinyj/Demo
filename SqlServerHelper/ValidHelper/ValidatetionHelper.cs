using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlServerHelper.ValidHelper
{
    public sealed class ValidatetionHelper
    {
        public static ValidResult IsValid(object value)
        {
            var result = new ValidResult();
            try
            {
                var validationContext = new ValidationContext(value);
                var results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(value, validationContext, results, true);
                result.IsVaild = isValid;

                if (!isValid)
                {
                    foreach (var item in results)
                    {
                        result.ErrorMembers.Add(new ErrorMember()
                        {
                            ErrorMessage = item.ErrorMessage,
                            ErrorMemberName = item.MemberNames.FirstOrDefault()
                        });
                    }
                }
            }
            catch (ValidationException ex)
            {
                result.IsVaild = false;
                result.ErrorMembers = new List<ErrorMember>
                {
                    new ErrorMember()
                    {
                        ErrorMessage = ex.Message,
                        ErrorMemberName = "Internal error"
                    }
                };
            }
            return result;
        }

        /// <summary>
        /// DTO 模型校验统一响应信息
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="model"></param>
        /// <returns></returns>
        public static ResponseInfo<ValidResult> GetValidInfo<T>(T model) where T : class
        {
            var result = new ResponseInfo<ValidResult>();
            var validResult = IsValid(model);
            if (!validResult.IsVaild)
            {
                result.Code = 420;
                result.Message = "DTO 模型参数值异常";
                result.Success = false;
                result.Data = validResult;
            }
            else
            {
                result.Code = 200;
                result.Success = true;
                result.Message = "DTO 模型参数值合法";
            }
            return result;
        }

    }

    public class ValidResult
    {
        public ValidResult()
        {
            ErrorMembers = new List<ErrorMember>();
        }
        /// <summary>
        /// 错误成员列表
        /// </summary>
        public List<ErrorMember> ErrorMembers { get; set; }
        /// <summary>
        /// 验证结果
        /// </summary>
        public bool IsVaild { get; set; }
    }
    public class ErrorMember
    {
        /// <summary>
        /// 错误信息
        /// </summary>
        public string ErrorMessage { get; set; }
        /// <summary>
        /// 错误成员名称
        /// </summary>
        public string ErrorMemberName { get; set; }
    }
    public sealed class ResponseInfo<T> where T : class
    {
        /*
         Microsoft.AspNetCore.Http.StatusCodes
         System.Net.HttpStatusCode
         */

        /// <summary>
        /// 响应代码（自定义）
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// 接口状态
        /// </summary>
        public bool Success { get; set; }

        #region 此处可以考虑多语言国际化设计（语言提示代号对照表）
        /// <summary>
        /// 语言对照码，参考：https://blog.csdn.net/shenenhua/article/details/79150053
        /// </summary>
        public string Lang { get; set; } = "zh-cn";

        /// <summary>
        /// 提示信息
        /// </summary>
        public string Message { get; set; } = string.Empty;
        #endregion

        /// <summary>
        /// 数据体
        /// </summary>
        public T Data { get; set; }
    }
}
