﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.8.0.0
//      SpecFlow Generator Version:1.8.0.0
//      Runtime Version:4.0.30319.239
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pickles.Example.Features._031ScenarioContext
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.8.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Scenario Context features")]
    public partial class ScenarioContextFeaturesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenarioContext.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenario Context features", "In order to show how to use ScenarioContext\r\nAs a SpecFlow evangelist\r\nI want to " +
                    "write some simple scenarios with data in ScenarioContext", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Store and retrive Person Marcus from ScenarioContext")]
        public virtual void StoreAndRetrivePersonMarcusFromScenarioContext()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Store and retrive Person Marcus from ScenarioContext", ((string[])(null)));
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.When("I store a person called Marcus in the Current ScenarioContext");
#line 8
 testRunner.Then("a person called Marcus can easily be retrieved");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Showing information of the scenario")]
        [NUnit.Framework.CategoryAttribute("showUpInScenarioInfo")]
        [NUnit.Framework.CategoryAttribute("andThisToo")]
        public virtual void ShowingInformationOfTheScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Showing information of the scenario", new string[] {
                        "showUpInScenarioInfo",
                        "andThisToo"});
#line 11
this.ScenarioSetup(scenarioInfo);
#line 12
 testRunner.When("I execute any scenario");
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Field",
                        "Value"});
            table1.AddRow(new string[] {
                        "Tags",
                        "showUpInScenarioInfo, andThisToo"});
            table1.AddRow(new string[] {
                        "Title",
                        "Showing information of the scenario"});
#line 13
 testRunner.Then("the ScenarioInfo contains the following information", ((string)(null)), table1);
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Show the type of step we\'re currently on")]
        public virtual void ShowTheTypeOfStepWeReCurrentlyOn()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Show the type of step we\'re currently on", ((string[])(null)));
#line 18
this.ScenarioSetup(scenarioInfo);
#line 19
 testRunner.Given("I have a Given step");
#line 20
  testRunner.And("I have another Given step");
#line 21
 testRunner.When("I have a When step");
#line 22
 testRunner.Then("I have a Then step");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Display error information in AfterScenario")]
        [NUnit.Framework.CategoryAttribute("showingErrorHandling")]
        [NUnit.Framework.IgnoreAttribute()]
        public virtual void DisplayErrorInformationInAfterScenario()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Display error information in AfterScenario", new string[] {
                        "ignore",
                        "showingErrorHandling"});
#line 27
this.ScenarioSetup(scenarioInfo);
#line 28
 testRunner.When("an error occurs in a step");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Pending step")]
        public virtual void PendingStep()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Pending step", ((string[])(null)));
#line 30
this.ScenarioSetup(scenarioInfo);
#line 31
 testRunner.When("I set the ScenarioContext.Current to pending");
#line 32
 testRunner.Then("this step will not even be executed");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
