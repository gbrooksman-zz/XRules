using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GHSSDSNEW.Shared.Entities.Documents;

namespace XRules.Actions
{
    public class DocumentActions
    {
        public DocumentActions()
        {

        } 
        
        public Document UpdateSubsection(Document doc, string dataCode, string newValue)
        {
            List<Subsection> subsections = new List<Subsection>();

            doc.SDS.Sections.ForEach(sect => { subsections.AddRange(sect.Subsections);});

            Subsection subsection = subsections.Where(s => s.DataCode.ToLower() == dataCode.ToLower()).FirstOrDefault();

            if (subsection != null)
            {
                subsection.Value = newValue;
            }

            return doc;

        }


    }
}
