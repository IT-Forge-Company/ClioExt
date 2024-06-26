﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace clio.ApiTest.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("SysSetting")]
    public partial class SysSettingFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
#line 1 "SysSetting.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "SysSetting", "Clio can perform INSERT, READ, UPDATE operations on Creatio System settings.\r\n***" +
                    "Further read***: **[SysSetting Documentation](https://github.com/Advance-Technol" +
                    "ogies-Foundation/clio?tab=readme-ov-file#system-settings)**", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("User can UPSERT sys-setting and read its value")]
        [NUnit.Framework.CategoryAttribute("SysSetting")]
        [NUnit.Framework.CategoryAttribute("UPSERT")]
        [NUnit.Framework.TestCaseAttribute("Text", "ClioText", "ClioTextValue", "ClioTextValue", "Text", null)]
        [NUnit.Framework.TestCaseAttribute("", "ClioText", "", "", "Text", null)]
        [NUnit.Framework.TestCaseAttribute("ShortText", "ClioShortText", "ClioShortTextValue", "ClioShortTextValue", "ShortText", null)]
        [NUnit.Framework.TestCaseAttribute("MediumText", "ClioMediumText", "ClioMediumTextValue", "ClioMediumTextValue", "MediumText", null)]
        [NUnit.Framework.TestCaseAttribute("LongText", "ClioLongText", "ClioLongTextValue", "ClioLongTextValue", "LongText", null)]
        [NUnit.Framework.TestCaseAttribute("SecureText", "ClioSecureText", "ClioSecureTextValue", "ClioSecureTextValue", "SecureText", null)]
        [NUnit.Framework.TestCaseAttribute("MaxSizeText", "ClioMaxSizeText", "ClioMaxSizeTextValue", "ClioMaxSizeTextValue", "MaxSizeText", null)]
        [NUnit.Framework.TestCaseAttribute("Boolean", "ClioBooleanOne", "True", "True", "Boolean", null)]
        [NUnit.Framework.TestCaseAttribute("Boolean", "ClioBooleanTwo", "true", "True", "Boolean", null)]
        [NUnit.Framework.TestCaseAttribute("Boolean", "ClioBooleanThree", "False", "False", "Boolean", null)]
        [NUnit.Framework.TestCaseAttribute("Boolean", "ClioBooleanFour", "false", "False", "Boolean", null)]
        [NUnit.Framework.TestCaseAttribute("DateTime", "ClioDateTime", "\"21-Jan-2024 18:00\"", "21-Jan-2024 18:00:00", "DateTime", null)]
        [NUnit.Framework.TestCaseAttribute("Date", "ClioDate", "21-Jan-2024", "21-Jan-2024", "Date", null)]
        [NUnit.Framework.TestCaseAttribute("Time", "ClioTime", "18:00", "18:00:00", "Time", null)]
        [NUnit.Framework.TestCaseAttribute("Integer", "ClioInteger", "10", "10", "Integer", null)]
        [NUnit.Framework.TestCaseAttribute("Currency", "ClioCurrency", "11.50", "11.50", "Money", null)]
        [NUnit.Framework.TestCaseAttribute("Decimal", "ClioDecimal", "12.50", "12.50", "Float", null)]
        public void UserCanUPSERTSys_SettingAndReadItsValue(string valueNameType, string sysSettingName, string sysSettingValue, string expectedValue, string expectedValueNameType, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SysSetting",
                    "UPSERT"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("valueNameType", valueNameType);
            argumentsOfScenario.Add("sysSettingName", sysSettingName);
            argumentsOfScenario.Add("sysSettingValue", sysSettingValue);
            argumentsOfScenario.Add("expectedValue", expectedValue);
            argumentsOfScenario.Add("expectedValueNameType", expectedValueNameType);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("User can UPSERT sys-setting and read its value", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
 this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
  testRunner.When(string.Format("command is run with \"set-syssetting\" \"{0} {1} {2}\"", sysSettingName, sysSettingValue, valueNameType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
  testRunner.Then(string.Format("SysSetting exists in Creatio with \"{0}\" \"{1}\"", sysSettingName, expectedValueNameType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 9
  testRunner.When(string.Format("command is run with \"set-syssetting\" \"{0} --GET\"", sysSettingName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
  testRunner.Then(string.Format("the output should be [INF] - SysSetting \"{0}\" : \"{1}\"", sysSettingName, expectedValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
