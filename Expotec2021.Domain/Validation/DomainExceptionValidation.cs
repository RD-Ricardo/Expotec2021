using System;

namespace Expotec2021.Domain.Validation
{
    public class DomainExceptionValidation  : Exception
    {
        public DomainExceptionValidation(string erro) :  base (erro) 
        {

        }
        public static void ValidationDomain(bool model, string erro)
        {
            if(model)
            {
                throw new DomainExceptionValidation(erro);
            }
        }
        

    }
}