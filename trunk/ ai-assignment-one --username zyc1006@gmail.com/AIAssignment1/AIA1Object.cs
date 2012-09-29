using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1
{
    /**
     * <summary>
     * Basic class that can be extended to match any class of objects in the problem domain model.
     * </summary>
     */
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

            AIA1Object t;

            if (byName.TryGetValue(name, out t) || byAbbr.TryGetValue(abbr, out t))
            {
                throw new Exception("An error occured while creating a new AIA1Object: An AIA1Object with the given name ("+name+") or abbreviation ("+abbr+") already exists.");
            }

            byName.Add(Name, this);
            byAbbr.Add(Abbr, this);
        }

        /**
         * <summary>
         * Returns the AIA1Object with the given name, or null if no such object exists.
         * </summary>
         */
        public static AIA1Object getByName(string name)
        {
            try
            {
                return byName[name];
            }catch(Exception){
                return null;
            }
        }

        /**
         * <summary>
         * Returns the AIA1Object with the given abbreviation, or null if no such object exists.
         * </summary>
         */
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
