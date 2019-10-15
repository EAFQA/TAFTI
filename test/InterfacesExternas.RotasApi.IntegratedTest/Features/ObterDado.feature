Funcionalidade: Obter lista de dados
	Testes integrados da funcionalidade obter dados

Esquema do Cenario: Obter Dado
	Dado que o host é 'https://dev.pinbank.com.br/'
	E o endpoint é 'Services/api/token'
	E o método http é 'POST'
	E o header precisa de grantType
	E o usuário é 'Yj3b0CsopkBR'
	E a senha é 'umo1LNtje0Edx1Xv'
	E obter o token
	E adicionar o token na requisição
	E a origem da requisição é '5'
	E o tipo do conteúdo é 'application/json'
	E o número do cartão é <Cartao>
	E o endpoint é 'Services/api/Transacoes/IncluirCartao'
	Quando executar a requisição
	Entao A resposta será <CodigoDeResposta>

	Exemplos:
		| Cartao           | CodigoDeResposta |
		| 5140848436700316 | 200              |