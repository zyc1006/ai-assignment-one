using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.TransitionRating
{

    public class Resource : AIA1Object
    {
        public Resource(string name, string abbr) : base(name, abbr) { }

        public static new Resource getByName(string name)
        {
            AIA1Object r = AIA1Object.getByAbbr(name);
            if (r is Resource)
                return (Resource)r;
            else
                return null;
        }

        public static new Resource getByAbbr(string abbr)
        {
            AIA1Object r = AIA1Object.getByAbbr(abbr);
            if (r is Resource)
                return (Resource)r;
            else
                return null;
        }

        public static void initStandardSet()
        {
            new Resource("Spunkee", "ESp");
            new Resource("Bligee", "EB");
            new Resource("Plink", "EP");
            new Resource("Serviced Blig", "TSB");
            new Resource("Unserviced Blig", "TUB");
            new Resource("Workbench", "TW");
            new Resource("Spunks", "RS");
            new Resource("Unserviced Plonk", "RUP");
            new Resource("Serviced Plonk", "RSP");
        }
    }
}
