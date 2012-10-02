using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AIAssignment1
{
    class CStateInfo
    {
        
        public Int32 IBligTotal = 0;
        public Int32 IBligsAvailable = 0;
        public Int32 IBligsUnavailable = 0;
        public Int32 IUnservicedBligs = 0; // Not used anywhere
        public ArrayList ListBligStatus = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        public ArrayList ListBligsUsedLastTime = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        /// <summary>
        /// Records the number of unavailable bligs at current action,
        /// Bligees will not service them until they are added to the list.
        /// </summary>
        public Int32 IBligsUnavailableLastTime = 0;

        public Int32 IBligeesAvailable = 0;
        public ArrayList ListNormalBligeeStatus = new ArrayList() { 0, 0, 0, 0 };
        public ArrayList ListFastBligeeStatus = new ArrayList() { 0, 0 };

        public Int32 IUnservicedPlonks = 0;
        public Int32 IServicedPlonks = 0;

        public Int32 IPlinksAvailable = 0;

        public Int32 ISpunkeesAvailable = 0;

        public Int32 ISpunks = 0;

        public Int32 IWorkbenchesAvailable = 0;

        public Int32 ITimesMakeSpunks = 0;
        public Int32 SBNormalTimes = 0;
        public Int32 SBFastTimes = 0;
        public Int32 ITimesServePlonks = 0;
        public Int32 ITimesFindPlonks = 0;
       
    }
}
