﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34011
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace nuserv.UiTests.Repository
{
    using TechTalk.SpecFlow;
    using Autofac;
    using Autofac.Configuration;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Overview")]
    public partial class OverviewFeature
    {
        
        private OpenQA.Selenium.IWebDriver driver;
        
        private IContainer container;
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Overview.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ConfigurationSettingsReader());
            this.container = builder.Build();
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Overview", "In order to manage the nuget repositories I\'ve setup \r\nAs a user\r\nI want to see a" +
                    "n overview of my repositories", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
            try { System.Threading.Thread.Sleep(50); this.driver.Quit(); } catch (System.Exception) {}
            this.driver = null;
            ScenarioContext.Current.Remove("Driver");
            ScenarioContext.Current.Remove("Container");
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
            if(this.driver != null)
                ScenarioContext.Current.Add("Driver", this.driver);
            if(this.container != null)
                ScenarioContext.Current.Add("Container", this.container);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        private void InitializeSelenium(string browser)
        {
            this.driver = this.container.ResolveNamed<OpenQA.Selenium.IWebDriver>(browser);
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Navigate to repository")]
        [NUnit.Framework.TestCaseAttribute("AGrade", Category="AGrade", TestName="NavigateToRepository on AGrade")]
        public virtual void NavigateToRepository(string browser)
        {
            InitializeSelenium(browser);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Navigate to repository", new string[] {
                        "Browser:AGrade"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 8
 testRunner.Given("I navigated to /repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
 testRunner.Then("the browser title should be \"nuserv repositories\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 10
 testRunner.And("the title should be \"repositories\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.And("the lead should be \"manage repositories\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
