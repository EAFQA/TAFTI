// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.0.0.0
//      SpecFlow Generator Version:3.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MyCompany.MyProject.IntegratedTest.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class ObterListaDeDadosFeature : Xunit.IClassFixture<ObterListaDeDadosFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Xunit.Abstractions.ITestOutputHelper _testOutputHelper;
        
#line 1 "ObterDado.feature"
#line hidden
        
        public ObterListaDeDadosFeature(ObterListaDeDadosFeature.FixtureData fixtureData, Xunit.Abstractions.ITestOutputHelper testOutputHelper)
        {
            this._testOutputHelper = testOutputHelper;
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("pt-BR"), "Obter lista de dados", "\tTestes integrados da funcionalidade obter dados", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Xunit.Abstractions.ITestOutputHelper>(_testOutputHelper);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.TheoryAttribute(DisplayName="Obter Dado")]
        [Xunit.TraitAttribute("FeatureTitle", "Obter lista de dados")]
        [Xunit.TraitAttribute("Description", "Obter Dado")]
        [Xunit.InlineDataAttribute("5140848436700316", "200", new string[0])]
        public virtual void ObterDado(string cartao, string codigoDeResposta, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Obter Dado", null, exampleTags);
#line 4
this.ScenarioInitialize(scenarioInfo);
            this.ScenarioStart();
#line 5
 testRunner.Given("que o host é \'https://dev.pinbank.com.br/\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Dado ");
#line 6
 testRunner.And("o endpoint é \'Services/api/token\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 7
 testRunner.And("o método http é \'POST\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 8
 testRunner.And("o header precisa de grantType", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 9
 testRunner.And("o usuário é \'Yj3b0CsopkBR\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 10
 testRunner.And("a senha é \'umo1LNtje0Edx1Xv\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 11
 testRunner.And("obter o token", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 12
 testRunner.And("adicionar o token na requisição", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 13
 testRunner.And("a origem da requisição é \'5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 14
 testRunner.And("o tipo do conteúdo é \'application/json\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 15
 testRunner.And(string.Format("o número do cartão é {0}", cartao), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 16
 testRunner.And("o endpoint é \'Services/api/Transacoes/IncluirCartao\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "E ");
#line 17
 testRunner.When("executar a requisição", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Quando ");
#line 18
 testRunner.Then(string.Format("A resposta será {0}", codigoDeResposta), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Entao ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.0.0.0")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                ObterListaDeDadosFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                ObterListaDeDadosFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
