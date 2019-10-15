using MyCompany.MyProject.IntegratedTest.Dados;
using TechTalk.SpecFlow;

namespace MyCompany.MyProject.IntegratedTest.Steps
{
    public sealed class CartaoSteps 
    {
        private IncluirCartaoDto _incluirCartaoDto;

        [Given(@"o número do cartão é (.*)")]
        public void DadoONumeroDoCartaoE(string numeroCartao)
        {
            _incluirCartaoDto.Data = new CartaoDto
            {
                CodigoCanal = 47,
                CodigoCliente = 7309,
                Apelido = "Ainda",
                NomeImpresso = "Menor Q 20", //nomeImpresso.Length > 20 ? nomeImpresso.Substring(0, 19) : nomeImpresso,
                NumeroCartao = numeroCartao,
                DataValidade = "202201",
                CodigoSeguranca = "1234",
                ValidarCartao = false
            };
        }
    }
}
