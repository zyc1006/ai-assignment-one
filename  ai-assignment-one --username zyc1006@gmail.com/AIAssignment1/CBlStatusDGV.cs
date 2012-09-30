using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1
{
    class CBlStatusDGV
    {
        private String strHours = "";

        public String Hours
        {
            get { return strHours; }
            set { strHours = value; }
        }
        private String strBlig = "";

        public String Bligs
        {
            get { return strBlig; }
            set { strBlig = value; }
        }
        private String strBligeeNormmal = "";

        public String BligeesNormmal
        {
            get { return strBligeeNormmal; }
            set { strBligeeNormmal = value; }
        }
        private String strBligeeFast = "";

        public String BligeesFast
        {
            get { return strBligeeFast; }
            set { strBligeeFast = value; }
        }
        public CBlStatusDGV (String Hours, String Blig, String BligeeNormal, String BligeeFast)
        {
            strHours = Hours;
            strBlig = Blig;
            strBligeeNormmal = BligeeNormal;
            strBligeeFast = BligeeFast;
        }
    }
}
