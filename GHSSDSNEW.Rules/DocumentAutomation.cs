using System;
using System.Reflection.Metadata;
using NRules.Fluent;
using NRules.Fluent.Dsl;
using GHSSDSNEW.Shared.Entities;
using GHSSDSNEW.Shared.Entities.Documents;
using GHSSDSNEW.Rules;


namespace GHSSDSNEW.Rules
{
    public class DocumentAutomation : Rule
    {
        XRules.Actions.UNDToEPAR action = new XRules.Actions.UNDToEPAR();

        //  if the un number (UND) is present then 
        //  update the registriion number (EPAR) to the UND value with 'test' suffixed
        public override void Define()
        {            

            /* Shared.Entities.Documents.Document doc = null;
             Subsection subsect = null;

              When()
                  .Match(() => subsect)
                  .Or(s => s.Exists<Subsection>(ss => ss.DataCode == "UND" && ss.Value.Trim().Length > 0));
              Then()
                  .Do(ctx => Console.WriteLine("called rule"))
                  .Do(ctx => action.UpdateSubsection(doc,subsect, "EPAR")); */

            When()
              .Equals(true);
            Then()
                .Do(ctx => Console.WriteLine("called rule"));
               // .Do(ctx => action.UpdateSubsection(doc, subsect, "EPAR"));


        }
    }
}
