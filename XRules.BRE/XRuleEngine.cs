using System;
using System.IO;
using System.Text.Json;
using GHSSDSNEW.Shared.Entities;
using GHSSDSNEW.Shared.Entities.Documents;

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

		public string Run()
		{

			JsonSerializerOptions options = new JsonSerializerOptions()
			{
				PropertyNameCaseInsensitive = true,
				IgnoreNullValues = true
			};


			string content = File.ReadAllText("test.json");

			Document toDocument = new Document()
			{
				Id = Guid.NewGuid(),
				SDSId = "PS2003",
				SDSName = "PS2003 Name",
				UserId = Guid.NewGuid(),
				OrganizationId = Guid.NewGuid(),
				SDS = JsonSerializer.Deserialize<SDS>(content, options)
			};



			return "true";

		}



    }
}
