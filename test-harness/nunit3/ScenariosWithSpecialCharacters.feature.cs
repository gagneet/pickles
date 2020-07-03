﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Pickles.TestHarness.nunit3
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Scenarios With Special Characters")]
    public partial class ScenariosWithSpecialCharactersFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "ScenariosWithSpecialCharacters.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Scenarios With Special Characters", "Here we demonstrate usage of special characters in scenario names", ProgrammingLanguage.CSharp, ((string[])(null)));
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
#line 4
#line 5
  testRunner.Given("the calculator has clean memory", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario with parentheses, hyphen and comma (10-20, 30-40)")]
        public virtual void ThisIsAScenarioWithParenthesesHyphenAndComma10_2030_40()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario with parentheses, hyphen and comma (10-20, 30-40)", ((string[])(null)));
#line 7
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 8
  testRunner.Given("I have entered 50 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
  testRunner.And("I have entered 70 into the calculator", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
  testRunner.When("I press add", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
  testRunner.Then("the result should be 120 on the screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario outline with parentheses, hyphen and comma (10-20, 30-40)")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        public virtual void ThisIsAScenarioOutlineWithParenthesesHyphenAndComma10_2030_40(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline with parentheses, hyphen and comma (10-20, 30-40)", exampleTags);
#line 14
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 15
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This scenario contains examples with Regex-special characters")]
        [NUnit.Framework.TestCaseAttribute("**", null)]
        [NUnit.Framework.TestCaseAttribute("++", null)]
        [NUnit.Framework.TestCaseAttribute(".*", null)]
        [NUnit.Framework.TestCaseAttribute("[]", null)]
        [NUnit.Framework.TestCaseAttribute("{}", null)]
        [NUnit.Framework.TestCaseAttribute("()", null)]
        [NUnit.Framework.TestCaseAttribute("^.*(?<foo>BAR)\\s[^0-9]{3,4}A+$", null)]
        public virtual void ThisScenarioContainsExamplesWithRegex_SpecialCharacters(string regex, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This scenario contains examples with Regex-special characters", exampleTags);
#line 21
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 22
  testRunner.When(string.Format("I have special characters for regexes in the value, for example a \'{0}\'", regex), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 23
  testRunner.Then("the scenario will \'PASS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario outline with german umlauts äöüß ÄÖÜ")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        public virtual void ThisIsAScenarioOutlineWithGermanUmlautsAouBAOU(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline with german umlauts äöüß ÄÖÜ", exampleTags);
#line 35
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 36
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario outline with ampersand &")]
        [NUnit.Framework.TestCaseAttribute("pass_1", null)]
        public virtual void ThisIsAScenarioOutlineWithAmpersand(string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario outline with ampersand &", exampleTags);
#line 42
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 43
  testRunner.Then(string.Format("the scenario will \'{0}\'", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario with danish characters æøå ÆØÅ")]
        public virtual void ThisIsAScenarioWithDanishCharactersAEoaAEOA()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario with danish characters æøå ÆØÅ", ((string[])(null)));
#line 49
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 50
  testRunner.Then("passing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("This is a scenario with spanish characters ñáéíóú")]
        public virtual void ThisIsAScenarioWithSpanishCharactersNaeiou()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("This is a scenario with spanish characters ñáéíóú", ((string[])(null)));
#line 52
this.ScenarioSetup(scenarioInfo);
#line 4
this.FeatureBackground();
#line 53
  testRunner.Then("passing step", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
