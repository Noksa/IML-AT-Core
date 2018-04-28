﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace SpecFlowTests
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Тестирование входов")]
    public partial class ТестированиеВходовFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "LoginTests.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru"), "Тестирование входов", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
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
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 3
#line 4
       testRunner.Given("Запускается браузер \"Chrome\" и открывается страница \"http://iml.ru\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Дано ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Негативные проверки входа")]
        [NUnit.Framework.CategoryAttribute("BadLogins")]
        public virtual void НегативныеПроверкиВхода()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Негативные проверки входа", new string[] {
                        "BadLogins"});
#line 7
this.ScenarioSetup(scenarioInfo);
#line 3
this.FeatureBackground();
#line 8
       testRunner.Then("открывается страница \"Главная\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line 9
       testRunner.And("пользователь (нажимает кнопку) \"Войти\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 10
       testRunner.Then("открывается страница \"Авторизация\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line 11
       testRunner.And("пользователь (заполняет поле) \"Логин\" значением \"Хэй бэби\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 12
       testRunner.And("пользователь (заполняет поле) \"Пароль\" значением \"Лэтс мув\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 13
       testRunner.And("пользователь (нажимает кнопку) \"Войти\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line 14
       testRunner.Then("пользователь (проверяет значение элемента) \"Текст ошибки\" со значением \"Не верный" +
                    " логин или пароль!\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion