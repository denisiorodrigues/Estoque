using FluentValidation;

namespace DR.Business.Models.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        private readonly string CampoObrigatorioMensagem = "O campo {PropertyName} precisa ser fornecido";
        private readonly string TamanhoMaxEMinMensagem = "O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres";

        public ProdutoValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 200).WithMessage(TamanhoMaxEMinMensagem);

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage(CampoObrigatorioMensagem)
                .Length(2, 1000).WithMessage(TamanhoMaxEMinMensagem);

            RuleFor(c => c.Valor)
                .GreaterThan(0).WithMessage("O campo {PropertyName} precisa ser maior que {ComparisonValue}");
        }
    }
}