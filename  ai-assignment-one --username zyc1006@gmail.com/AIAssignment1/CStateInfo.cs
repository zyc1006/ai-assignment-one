using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Reflection;

namespace AIAssignment1
{
    class CStateInfo
    {
        /// <summary>
        /// Total number of bligs in the problem domain.
        /// </summary>
        public Int32 IBligTotal = 0;
        /// <summary>
        /// Number of bligs currently available for actions.
        /// </summary>
        public Int32 IBligsAvailable = 0;
        /// <summary>
        /// Number of busy bligs.
        /// </summary>
        public Int32 IBligsUnavailable = 0;
        /// <summary>
        /// Number of unserviced bligs. 
        /// </summary>
        public Int32 IUnservicedBligs = 0; // Not used anywhere
        /// <summary>
        /// Listing of all available bligs according to how how many hours
        /// they have left before they need to be serviced.
        /// </summary>
        public ArrayList ListBligStatus = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        /// <summary>
        /// ?
        /// </summary>
        public ArrayList ListBligsUsedLastTime = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        /// <summary>
        /// Records the number of unavailable bligs at current action,
        /// Bligees will not service them until they are added to the list.
        /// </summary>
        public Int32 IBligsUnavailableLastTime = 0;

        /// <summary>
        /// Number of Bligs to be serviced. It will decrease after each SBF action.
        /// It is used for SBN action.
        public Int32 IBligsToBeServiced = 0;
        /// </summary>
        /// <summary>
        /// Number of bligees available for maintenance.
        /// </summary>
        public Int32 IBligeesAvailable = 0;
        /// <summary>
        /// Listing, according to the number of hours left,
        /// of bligees performing normal blig maintenance.
        /// </summary>
        public ArrayList ListNormalBligeeStatus = new ArrayList() { 0, 0, 0, 0 };
        /// <summary>
        /// Listing, according to the number of hours left,
        /// of bligees performing quick blig maintenance.
        /// </summary>
        public ArrayList ListFastBligeeStatus = new ArrayList() { 0, 0 };

        /// <summary>
        /// Number of unserviced plonks.
        /// </summary>
        public Int32 IUnservicedPlonks = 0;
        /// <summary>
        /// Number of serviced plonks.
        /// </summary>
        public Int32 IServicedPlonks = 0;

        /// <summary>
        /// Number of available plinks.
        /// </summary>
        public Int32 IPlinksAvailable = 0;

        /// <summary>
        /// Number of available spunks.
        /// </summary>
        public Int32 ISpunks = 0;

        /// <summary>
        /// Number of available spunkees.
        /// </summary>
        public Int32 ISpunkeesAvailable = 0;
        
        /// <summary>
        /// Number of available workbenches.
        /// </summary>
        public Int32 IWorkbenchesAvailable = 0;

        /// <summary>
        /// Number of "Make spunk" actions performed to reach
        /// this state from the previous one.
        /// </summary>
        public Int32 ITimesMakeSpunks = 0;
        /// <summary>
        /// Number of "Service blig" actions performed to
        /// reach this state from the previous one.
        /// </summary>
        public Int32 SBNormalTimes = 0;
        /// <summary>
        /// Number of "Quick service blig" actions performed to
        /// reach this state from the previous one.
        /// </summary>
        public Int32 SBFastTimes = 0;
        /// <summary>
        /// Number of "Find plonk" actions performed to
        /// reach this state from the previous one.
        /// </summary>
        public Int32 ITimesFindPlonks = 0;
        /// <summary>
        /// Number of "Service plonk" actions performed to
        /// reach this state from the previous one.
        /// </summary>
        public Int32 ITimesServePlonks = 0;
        /// <summary>
        /// Total number of nServiced plonk
        /// </summary>
        public Int32 ITotalUnservicedPlonks = 0;

        /// <summary>
        /// Total number of bligs under serving
        /// </summary>
        public Int32 IBligsUnderServing = 0;

        /// <summary>
        /// Copies this object.
        /// </summary>
        /// <returns>A shallow copy of this object.</returns>
        public CStateInfo copy()
        {
            CStateInfo copy = new CStateInfo();
            foreach (FieldInfo fi in this.GetType().GetFields())
            {
                fi.SetValue(copy, fi.GetValue(this));
            }
            return copy;
        }

    }
}
