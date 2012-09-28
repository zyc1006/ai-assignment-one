using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AIAssignment1
{
    class CStateInfo
    {
        private Int32 iSpunkeesAvailable = 0;
        private Int32 iPlinksAvailable = 0;
        private Int32 iWorkbenchesAvailable = 0;
        private Int32 iSpunks = 0;
        private Int32 iUnservicedPlonks = 0;
        private Int32 iServicedPlonks = 0;
        private Int32 iBligeesAvailable = 0;
        private Int32 iBligsAvailable = 0;
        private Int32 iUnservicedBligs = 0;
        private Int32 iTimesMakeSpunks = 0;
        private Int32 iTimesFindPlonks = 0;
        private Int32 iTimesServePlonks = 0;
        private Int32 iBligTotal = 0;


        private ArrayList listBligStatus = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private ArrayList listFastBligeeStatus = new ArrayList() { 0, 0, 0 };
        private ArrayList listNormalBligeeStatus = new ArrayList() { 0, 0, 0, 0, 0 };

        public ArrayList listHistoryBlig = new ArrayList();
        public ArrayList listHistoryNormalBligee = new ArrayList();
        public ArrayList listHistoryFastBligee = new ArrayList();

        public Int32 IBligTotal
        {
            get { return iBligTotal; }
            set { iBligTotal = value; }
        }
        
        public System.Int32 ITimesMakeSpunks
        {
            get { return iTimesMakeSpunks; }
            set { iTimesMakeSpunks = value; }
        }
        public System.Int32 ITimesServePlonks
        {
            get { return iTimesServePlonks; }
            set { iTimesServePlonks = value; }
        }
        public System.Int32 ITimesFindPlonks
        {
            get { return iTimesFindPlonks; }
            set { iTimesFindPlonks = value; }
        }
        

        public Int32 IBligsAvailable
        {
            get { return iBligsAvailable; }
            set { iBligsAvailable = value; }
        }
        public System.Int32 IUnservicedBligs
        {
            get { return iUnservicedBligs; }
            set { iUnservicedBligs = value; }
        }

        public ArrayList ListNormalBligeeStatus
        {
            get { return listNormalBligeeStatus; }
            set { listNormalBligeeStatus = value; }
        }

        public Int32 IBligeesAvailable
        {
            get { return iBligeesAvailable; }
            set { iBligeesAvailable = value; }
        }

        public ArrayList ListFastBligeeStatus
        {
            get { return listFastBligeeStatus; }
            set { listFastBligeeStatus = value; }
        }
        

        public Int32 IUnservicedPlonks
        {
            get { return iUnservicedPlonks; }
            set { iUnservicedPlonks = value; }
        }
        public Int32 IServicedPlonks
        {
            get { return iServicedPlonks; }
            set { iServicedPlonks = value; }
        }

        public Int32 ISpunks
        {
            get { return iSpunks; }
            set { iSpunks = value; }
        }
        
        public Int32 ISpunkeesAvailable
        {
            get { return iSpunkeesAvailable; }
            set { iSpunkeesAvailable = value; }
        }
       

        public Int32 IPlinksAvailable
        {
            get { return iPlinksAvailable; }
            set { iPlinksAvailable = value; }
        }
       

        public Int32 IWorkbenchesAvailable 
        {
            get { return iWorkbenchesAvailable; }
            set { iWorkbenchesAvailable = value; }
        }

       

        public ArrayList ListBligStatus
        {
            get { return listBligStatus; }
            set { listBligStatus = value; }
        }
        

       

       
    }
}
