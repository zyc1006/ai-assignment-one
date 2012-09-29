using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1.Basics
{
    /**
     * <summary>
     * Describes a task in the problem domain model, in terms of duration and required resources.
     * </summary>
     */
    public class Task : AIA1Object
    {
        private ResourceQty[] resQty;

        public int Duration { get; private set; }
        public List<ResourceQty> PrereqResources {
            get
            {
                List<ResourceQty> r = new List<ResourceQty>();
                for (int i = 0; i < resQty.Length; i++)
                {
                    r.Add(resQty[i]);
                }
                return r;
            }
            private set
            {
                ResourceQty[] r = new ResourceQty[value.Count];

                int i = 0;
                foreach (ResourceQty rq in value)
                {
                    r[i] = rq;
                    i++;
                }
                resQty = r;

            }
        }

        /**
         * <summary>
         * Creates a new task with the given duration and required resource quantities.
         * </summary>
         */
        public Task(string name, string abbr, int duration, ResourceQty[] resources) : base(name, abbr)
        {
            Duration = duration;
            resQty = resources;
        }

        /**
         * <summary>
         * Returns the task with the given name, or null if no such task exists.
         * </summary>
         */
        public static new Task getByName(string name)
        {
            AIA1Object r = AIA1Object.getByAbbr(name);
            if (r is Task)
                return (Task)r;
            else
                return null;
        }

        /**
         * <summary>
         * Returns the task with the given abbreviation, or null if no such task exists.
         * </summary>
         */
        public static new Task getByAbbr(string abbr)
        {
            AIA1Object r = AIA1Object.getByAbbr(abbr);
            if (r is Task)
                return (Task)r;
            else
                return null;
        }

        /**
         * <summary>
         * Initializes a standard set of tasks.
         * </summary>
         */
        public static void initStandardSet()
        {
            new Task("Make Spunks", "MS", 1,
                new ResourceQty[] {
                    new ResourceQty(Resource.getByAbbr("ESp"), 1),
                    new ResourceQty(Resource.getByAbbr("TW"), 1)
                });
            new Task("Service Blig", "SB", 4,
                new ResourceQty[] {
                    new ResourceQty(Resource.getByAbbr("TUB"), 1),
                    new ResourceQty(Resource.getByAbbr("EB"), 1),
                    new ResourceQty(Resource.getByAbbr("TW"), 1),
                    new ResourceQty(Resource.getByAbbr("RS"), 20)
                });
            new Task("Service Blig Quickly", "QSB", 2,
                new ResourceQty[] {
                    new ResourceQty(Resource.getByAbbr("TUB"), 1),
                    new ResourceQty(Resource.getByAbbr("EB"), 2),
                    new ResourceQty(Resource.getByAbbr("TW"), 1),
                    new ResourceQty(Resource.getByAbbr("RS"), 40)
                });
            new Task("Find Plonks", "FP", 1,
                new ResourceQty[] {
                    new ResourceQty(Resource.getByAbbr("EP"), 1),
                    new ResourceQty(Resource.getByAbbr("RS"), 10)
                });
            new Task("Service Plonks", "SP", 1,
                new ResourceQty[] {
                    new ResourceQty(Resource.getByAbbr("EP"), 1),
                    new ResourceQty(Resource.getByAbbr("TSB"), 1),
                    new ResourceQty(Resource.getByAbbr("TW"), 1),
                    new ResourceQty(Resource.getByAbbr("RS"), 20),
                    new ResourceQty(Resource.getByAbbr("RUP"), 5)

                });
        }
    }
}
