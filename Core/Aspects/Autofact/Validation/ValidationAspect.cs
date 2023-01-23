using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Aspects.Autofact.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            // defensive coding 
            // Yolladığımız sınıf tipinin IValidator olup olmadığını kontrol eder. 

            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir doğrulama sınfı değildir.");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // ProductValidator bir IValidatordür.ProductValidatorın bir instanceını oluştur.
            var validator = (IValidator)Activator.CreateInstance(_validatorType);

            //ProductValidatordan baseType olan AbstractValidatora geç ordan var olan generic tiplerden 1. tipi al
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            
            //invocation Aspect methodunun(Örnek Add methodu) argumentlerine bak ve onları validate et.
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
