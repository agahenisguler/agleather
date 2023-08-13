using AgLeather.Shop.Application.Exceptions;
using AgLeather.Shop.Application.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;
using System.ComponentModel;

namespace AgLeather.APİ.Filters
{
    public class ExceptionHandlerFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {

            var result = new Result<dynamic>() { Success = false };


            if (context.Exception is NotFoundException notFoundException)
            {
                result.Errors = new List<string> { notFoundException.Message };
            }
            else if(context.Exception is ValidateException validationException)
            {
                result.Errors.AddRange(validationException.ErrorMessages);
            }
            else
            {
                result.Errors = new List<string> { context.Exception.InnerException !=null ? context.Exception.InnerException.Message :
                   context.Exception.Message };
            }
           

            context.Result = new JsonResult(result);
            context.HttpContext.Response.StatusCode = 400;

            context.ExceptionHandled = true;
        }
    }
}
