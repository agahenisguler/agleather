﻿using AgLeather.Shop.Application.Exceptions;
using AgLeather.Shop.Application.Models.RequestModels;
using AgLeather.Shop.Application.Validators;
using ArxOne.MrAdvice.Advice;
using AspectCore.DynamicProxy;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace AgLeather.Shop.Application.Behaviors
{
    public class ValidationBehavior : Attribute, IMethodAdvice
    {
        private readonly Type _validatorType; 

        public ValidationBehavior(Type validatorType)
        {
            _validatorType = validatorType;
        }
      
        public void Advise(MethodAdviceContext context)
        {
            //Metod çalışmadan önce devreye girecek kodlar..

            if (context.Arguments.Any())
            {
                var requestModel = context.Arguments[0];

                var validateMethod = _validatorType.GetMethod("Validate", new Type[] { requestModel.GetType() });

                var validatorInstance = Activator.CreateInstance(_validatorType);

                if (validateMethod != null)
                {
                    var validationResult = (ValidationResult)validateMethod.Invoke(validatorInstance, new object[] { requestModel });
                    if (!validationResult.IsValid)
                    {
                        throw new ValidateException(validationResult);
                    }

                }
            }

           

            context.Proceed(); //Metod tetikleniyor.


            //Metod çalıştıktan sonra devreye girecek kodlar.
        }
    }
}
