using DR.Business.Models;
using FluentValidation;
using FluentValidation.Results;

namespace DR.Business.Services
{
    public abstract class BaseServices
    {
        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            //Propagar moanesagem de erro até a camada de aprensentação
        }

        protected bool ExecutarValidacao<TV, TE>(TV validacao, TE entidade) where TV : AbstractValidator<TE>  where TE : Entity
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return true;
        }
    }
}