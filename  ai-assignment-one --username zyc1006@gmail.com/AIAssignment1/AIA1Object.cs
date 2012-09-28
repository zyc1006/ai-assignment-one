using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1
{
    public class AIA1Object
    {
        private static Dictionary<string, AIA1Object> byName = new Dictionary<string, AIA1Object>();
        private static Dictionary<string, AIA1Object> byAbbr = new Dictionary<string, AIA1Object>();

        public string Name { get; private set; }
        public string Abbr { get; private set; }

        public AIA1Object(string name, string abbr)
        {
            Name = name;
            Abbr = abbr;

            byName.Add(Name, this);
            byAbbr.Add(Abbr, this);
        }

        public static AIA1Object getByName(string name)
        {
            try
            {
                return byName[name];
            }catch(Exception){
                return null;
            }
        }

        public static AIA1Object getByAbbr(string abbr)
        {
            try
            {
                return byAbbr[abbr];
            }catch(Exception){
                return null;
            }
        }
    }
}
