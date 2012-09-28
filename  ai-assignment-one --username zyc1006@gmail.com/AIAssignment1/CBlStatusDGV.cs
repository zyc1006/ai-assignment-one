using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1
{
    class CBlStatusDGV
    {
        private String strHours = "";

        public String StrHours
        {
            get { return strHours; }
            set { strHours = value; }
        }
        private String strBlig = "";

        public String StrBlig
        {
            get { return strBlig; }
            set { strBlig = value; }
        }
        private String strBligeeNormmal = "";

        public String StrBligeeNormmal
        {
            get { return strBligeeNormmal; }
            set { strBligeeNormmal = value; }
        }
        private String strBligeeFast = "";

        public String StrBligeeFast
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
