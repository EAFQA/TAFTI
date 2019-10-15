namespace MyCompany.MyProject.IntegratedTest.Dados
{
    public class IncluirCartaoDto
    {
        public IncluirCartaoDto()
        {
            Data = new CartaoDto();
        }

        public CartaoDto Data { get; set; }
    }
}