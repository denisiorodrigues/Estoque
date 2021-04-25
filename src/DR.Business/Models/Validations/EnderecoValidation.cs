using FluentValidation;

namespace DR.Business.Models.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        private readonly string CampoObrigatorioMensagem = "O campo {PropertyName} precisa ser fornecido";
        private readonly string TamanhoMaximoMensagem = "O campo {PropertyName} precisa ter {MaxLength} caracteres";
        private readonly string TamanhoMaxEMinMensagem = "O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres";

        public EnderecoValidation()
        {
            RuleFor(e => e.Logradouro)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 200).WithMessage(TamanhoMaxEMinMensagem);

            RuleFor(e => e.Bairro)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 100).WithMessage(TamanhoMaxEMinMensagem);

            RuleFor(e => e.Cep)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(8).WithMessage(TamanhoMaximoMensagem);

            RuleFor(e => e.Cidade)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 100).WithMessage(TamanhoMaxEMinMensagem);

            RuleFor(e => e.Estado)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 50).WithMessage(TamanhoMaxEMinMensagem);

            RuleFor(e => e.Numero)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 50).WithMessage(TamanhoMaxEMinMensagem);
        }
    }
}