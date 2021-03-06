﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.18052
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Duffer.Tests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("\'Model\' nodes")]
    public partial class ModelNodesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Models.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "\'Model\' nodes", "In order to create useful IDTF files\r\nI want to be able to write out Model defini" +
                    "tionss", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("scene with one model")]
        public virtual void SceneWithOneModel()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scene with one model", ((string[])(null)));
#line 5
this.ScenarioSetup(scenarioInfo);
#line 6
 testRunner.Given("I have a new current scene", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 7
 testRunner.And("the current scene contains a model named \"Box01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 8
 testRunner.And("the model named \"Box01\" has a parent called \"Parent1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.And("the model named \"Box01\" has a resource called \"BoxModel\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.And("the parent named \"Parent1\" has an identity transform matrix", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 11
 testRunner.When("I export the current scene to a file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then("the contents of the current file should be", @"FILE_FORMAT ""IDTF""
FORMAT_VERSION 100

NODE ""MODEL"" {
	NODE_NAME ""Box01""
	PARENT_LIST {
		PARENT_COUNT 1
		PARENT 0 {
			PARENT_NAME ""Parent1""
			PARENT_TM {
				1.000000 0.000000 0.000000 0.000000
				0.000000 1.000000 0.000000 0.000000
				0.000000 0.000000 1.000000 0.000000
				0.000000 0.000000 0.000000 1.000000
			}
		}
	}
	RESOURCE_NAME ""BoxModel""
}
", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("scene with one model visible fomr both sides")]
        public virtual void SceneWithOneModelVisibleFomrBothSides()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scene with one model visible fomr both sides", ((string[])(null)));
#line 36
this.ScenarioSetup(scenarioInfo);
#line 37
 testRunner.Given("I have a new current scene", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 38
 testRunner.And("the current scene contains a model named \"Box01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.And("the model named \"Box01\" is visible from both sides", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 40
 testRunner.And("the model named \"Box01\" has a parent called \"Parent1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
 testRunner.And("the model named \"Box01\" has a resource called \"BoxModel\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
 testRunner.And("the parent named \"Parent1\" has an identity transform matrix", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
 testRunner.When("I export the current scene to a file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.Then("the contents of the current file should be", @"FILE_FORMAT ""IDTF""
FORMAT_VERSION 100

NODE ""MODEL"" {
	NODE_NAME ""Box01""
	PARENT_LIST {
		PARENT_COUNT 1
		PARENT 0 {
			PARENT_NAME ""Parent1""
			PARENT_TM {
				1.000000 0.000000 0.000000 0.000000
				0.000000 1.000000 0.000000 0.000000
				0.000000 0.000000 1.000000 0.000000
				0.000000 0.000000 0.000000 1.000000
			}
		}
	}
	RESOURCE_NAME ""BoxModel""
	MODEL_VISIBILITY ""BOTH""
}
", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("scene with two model nodes")]
        public virtual void SceneWithTwoModelNodes()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("scene with two model nodes", ((string[])(null)));
#line 69
this.ScenarioSetup(scenarioInfo);
#line 70
 testRunner.Given("I have a new current scene", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 71
 testRunner.And("the current scene contains a model named \"Box01\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 72
 testRunner.And("the model named \"Box01\" has a parent called \"Parent1\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
 testRunner.And("the model named \"Box01\" has a resource called \"BoxModel\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.And("the parent named \"Parent1\" has an identity transform matrix", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 75
 testRunner.And("the current scene contains a model named \"Box02\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 76
 testRunner.And("the model named \"Box02\" has a parent called \"Box_Group\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 77
 testRunner.And("the model named \"Box02\" has a resource called \"LightBoxModel\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("the parent named \"Box_Group\" has an translation only transform matrix of \"25\", \"2" +
                    "6, \"27\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.When("I export the current scene to a file", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("the contents of the current file should be", @"FILE_FORMAT ""IDTF""
FORMAT_VERSION 100

NODE ""MODEL"" {
	NODE_NAME ""Box01""
	PARENT_LIST {
		PARENT_COUNT 1
		PARENT 0 {
			PARENT_NAME ""Parent1""
			PARENT_TM {
				1.000000 0.000000 0.000000 0.000000
				0.000000 1.000000 0.000000 0.000000
				0.000000 0.000000 1.000000 0.000000
				0.000000 0.000000 0.000000 1.000000
			}
		}
	}
	RESOURCE_NAME ""BoxModel""
}

NODE ""MODEL"" {
	NODE_NAME ""Box02""
	PARENT_LIST {
		PARENT_COUNT 1
		PARENT 0 {
			PARENT_NAME ""Box_Group""
			PARENT_TM {
				1.000000 0.000000 0.000000 0.000000
				0.000000 1.000000 0.000000 0.000000
				0.000000 0.000000 1.000000 0.000000
				25.000000 26.000000 27.000000 1.000000
			}
		}
	}
	RESOURCE_NAME ""LightBoxModel""
}
", ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
