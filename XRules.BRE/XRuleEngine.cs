using System;


namespace XRules.BRE
{
    public class XRuleEngine
    {
		private readonly string assemblyName;
		public XRuleEngine(string _assemblyName)
		{
			assemblyName = _assemblyName;
		}

		public XRuleEngine()
		{
			assemblyName = string.Empty;
		}

		public bool TestIt()
		{
			return true;
		}

		public void Run()
		{

		}



    }
}
