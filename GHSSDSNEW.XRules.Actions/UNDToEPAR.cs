using System;
using GHSSDSNEW.Shared.Entities.Documents;
using GHSSDSNEW.Shared.Entities;
using System.Collections.Generic;
using System.Linq;

namespace GHSSDSNEW.XRules.Actions
{
    public class UNDToEPAR
    {
        public Document UpdateSubsection(Document doc, Subsection subsect, string targetDataCode)
        {
            List<Subsection> subsections = new List<Subsection>();

            doc.SDS.Sections.ForEach(sect => { subsections.AddRange(sect.Subsections); });

            Subsection subsection = subsections.Where(s => s.DataCode.ToLower() == targetDataCode.ToLower()).FirstOrDefault();

            if (subsection != null)
            {
                subsection.Value = subsect.Value;
            }

            return doc;

        }

    }
}
