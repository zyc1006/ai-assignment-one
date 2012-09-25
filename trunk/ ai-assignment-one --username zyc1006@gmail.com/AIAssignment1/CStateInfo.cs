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
        private Int32 iWorkbenchesAvaible = 0;
        private Int32 iSpunks = 0;
        private Int32 iUnservicedPlonks = 0;
        private Int32 iServicedPlonks = 0;
        private ArrayList listBligStatus = new ArrayList();
        private ArrayList listBligeeStatus = new ArrayList();

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
       

        public Int32 IWorkbenchesAvaible 
        {
            get { return iWorkbenchesAvaible; }
            set { iWorkbenchesAvaible = value; }
        }

       

        public ArrayList ListBligStatus
        {
            get { return listBligStatus; }
            set { listBligStatus = value; }
        }
        

        public ArrayList ListBligeeStatus
        {
            get { return listBligeeStatus; }
            set { listBligeeStatus = value; }
        }

       
    }
}
