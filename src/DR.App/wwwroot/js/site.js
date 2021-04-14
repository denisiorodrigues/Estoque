function AjaxModal()
{
    $(document).ready(function () {
        $(function () {
            $.ajaxSetup({ cache: false });
            $("a[data-modal]").on('click', function (e) {
                $("#myModalContent").load(this.href, function () {
                    $("#myModal").modal({
                        keyboard : true
                    }, 'show');

                    bindForm(this);
                });

                return false;
            });
        });

        function bindForm(dialog) {
            $('form', dialog).submit(function () {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function (result) {
                        if (result.success) {
                            $('#myModal').modal('hide');
                            $('#EnderecoTarget').load(result.url);
                        } else {
                            $('#myModalContent').html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });
}

function BuscaCEP() {
    $(document).ready(function () {
        function limpa_fomulario_cep() {
            //Limmpa os fomrulários do cep
            $("#Endereco_Logradouro").val('');
            $("#Endereco_Bairro").val('');
            $("#Endereco_Cidade").val('');
            $("#Endereco_Estado").val('');
        }

        //Quando o campo cep muda o foco
        $("#Endereco_Cep").blur(function () {
            //Nova variável cep somente com dígitos
            var cep = $(this).val().replace(/\D/g, '');

            //Verifica se o campo cep tem valor informado
            if (cep != "") {
                //Expressão regular para validar o cep
                var validaCep = /^[0-9]{8}$/;

                //valida o formato do ceo
                if (validaCep.test(cep)) {
                    //Preenche os campos com "..." (reticencias) enquanto consulta o web service
                    $("#Endereco_Logradouro").val("...");
                    $("#Endereco_Bairro").val("...");
                    $("#Endereco_Cidade").val("...");
                    $("#Endereco_Estado").val("...");

                    //Consulta o webservice viacep.com.br
                    $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?",
                        function (dados) {
                            if (!("erro" in dados)) {
                                //Atualiza os campso com os valores da consulta.
                                $("#Endereco_Logradouro").val(dados.logradouro);
                                $("#Endereco_Bairro").val(dados.bairro);
                                $("#Endereco_Cidade").val(dados.localidade);
                                $("#Endereco_Estado").val(dados.uf);
                            } else {
                                //CEP pesquisado não foi encontrado
                                limpa_fomulario_cep();
                                alert("Formato de CEP inválido");
                            }
                        });
                } else {
                    //cep sem valor, limpa o formulário.
                    limpa_fomulario_cep();
                }
            }
        });
    });
}