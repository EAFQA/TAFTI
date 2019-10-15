using BoDi;
using MyCompany.MyProject.IntegratedTest.Dados;
using RestSharp;
using System;
using System.Net;
using TechTalk.SpecFlow;
using Xunit;

namespace InterfacesExternas.RotasApi.IntegratedTest.Steps
{
    [Binding]
    public sealed class BaseSteps
    {
        private IncluirCartaoDto _incluirCartaoDto;
        private IRestClient _restClient;
        private IRestRequest _restRequest;
        private IRestResponse _restResponse;
        private readonly IObjectContainer _objectContainer;
        private string _token = null;

        public BaseSteps(IObjectContainer objectContainer) => _objectContainer = objectContainer;

        [BeforeScenario]
        public void Setup()
        {
            _incluirCartaoDto = new IncluirCartaoDto();
            _restClient = new RestClient();
            _restRequest = new RestRequest();
            _restResponse = new RestResponse();
            _objectContainer.RegisterInstanceAs(_restClient);
            _objectContainer.RegisterInstanceAs(_restRequest);
            _objectContainer.RegisterInstanceAs(_restResponse);
        }

        [Given(@"que o host é '(.*)'")]
        public void InserirHost(string uri) => _restClient.BaseUrl = new Uri(uri);

        [Given(@"o header precisa de grantType")]
        public void DadoOHeaderPrecisaDeGrantType() => _restRequest.AddParameter("grant_type", "password");

        [Given(@"o usuário é '(.*)'")]
        public void DadoOUsuarioE(string usuario) => _restRequest.AddParameter("username", usuario);

        [Given(@"a senha é '(.*)'")]
        public void DadoASenhaE(string senha) => _restRequest.AddParameter("password", senha);

        [Given(@"que o token seja (.*)")]
        public void DadoQueTokenEh(string token) => _restClient.AddDefaultHeader("Authorization", $"Bearer {token}");

        [Given(@"o endpoint é '(.*)'")]
        public void DadoQueAUrlDoEndpointEh(string endpoint) => _restRequest.Resource = endpoint;

        [Given(@"obter o token")]
        public void DadoObterOToken()
        {
            var response = _restClient.Execute<TokenDto>(_restRequest);
            _token = $"bearer {response.Data.AccessToken}";
        }

        [Given(@"adicionar o token na requisição")]
        public void DadoAdicionarOTokenNaRequisicao() => _restClient.AddDefaultHeader("Authorization", _token);

        [Given(@"a origem da requisição é '(.*)'")]
        public void DadoAOrigemDaRequisicaoE(string origem) => _restRequest.AddParameter("RequestOrigin", origem);

        [Given(@"o tipo do conteúdo é '(.*)'")]
        public void DadoOTipoDoConteudoE(string tipoConteudo) => _restRequest.AddParameter("Content-Type", tipoConteudo);


        [Given(@"o método http é '(.*)'")]
        public void DadoOMetodoHttpEh(string metodo)
        {
            switch (metodo?.ToUpper())
            {
                case "GET": _restRequest.Method = Method.GET; break;
                case "POST": _restRequest.Method = Method.POST; break;
                case "PUT": _restRequest.Method = Method.PUT; break;
                case "DELETE": _restRequest.Method = Method.DELETE; break;
                case "PATCH": _restRequest.Method = Method.PATCH; break;
                default: Assert.False(true, "Método Http não suportado."); break;
            }
        }

        [When(@"executar a requisição")]
        public void QuandoExecutarARequisicao()
        {
            ExecutarRequisicao(_incluirCartaoDto);
        }

        [Then(@"A resposta será (.*)")]
        public void ARespostaSera(HttpStatusCode codigoDeResposta) => Assert.Equal(codigoDeResposta, _restResponse.StatusCode);

        private void ExecutarRequisicao<T>(T requestBody)
        {
            if (_restRequest.Method != Method.GET)
            {
                _restRequest.RequestFormat = DataFormat.Json;
                _restRequest.AddJsonBody(requestBody);
            }
            _restRequest.AddHeader("UserName", "Yj3b0CsopkBR");
            //_restRequest.AddHeader("RequestOrigin", "5");

            _restResponse = _restClient.Execute(_restRequest);
        }

        //Cartão steps
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