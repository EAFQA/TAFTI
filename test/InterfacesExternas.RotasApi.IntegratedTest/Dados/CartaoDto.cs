namespace MyCompany.MyProject.IntegratedTest.Dados
{
    public class CartaoDto
    {
        public int CodigoCanal { get; set; }
        public int CodigoCliente { get; set; }
        public string Apelido { get; set; }
        public string NomeImpresso { get; set; }
        public string NumeroCartao { get; set; }
        public string DataValidade { get; set; }
        public string CodigoSeguranca { get; set; }
        public bool ValidarCartao { get; set; }
    }
}
