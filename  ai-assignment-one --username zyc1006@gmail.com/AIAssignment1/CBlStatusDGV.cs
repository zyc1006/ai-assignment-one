using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIAssignment1
{
    class CBlStatusDGV
    {
        /// <summary>
        /// To display the "hour" column in the datagridview of blig status.
        /// </summary>
        private String strHours = "";

        public String Hours
        {
            get { return strHours; }
            set { strHours = value; }
        }

        /// <summary>
        /// To display the "Blig" column in the datagridview of blig status.
        /// </summary>
        private String strBlig = "";

        public String Bligs
        {
            get { return strBlig; }
            set { strBlig = value; }
        }

        /// <summary>
        /// To display the "BligeeNormmal" column in the datagridview of blig status.
        /// </summary>
        private String strBligeeNormmal = "";

        public String BligeesNormmal
        {
            get { return strBligeeNormmal; }
            set { strBligeeNormmal = value; }
        }
        private String strBligeeFast = "";

        /// <summary>
        /// To display the "BligeeFast" column in the datagridview of blig status.
        /// </summary>
        public String BligeesFast
        {
            get { return strBligeeFast; }
            set { strBligeeFast = value; }
        }

        /// <summary>
        /// Constructor of CBlStatusDGV
        /// </summary>
        /// <param name="Hours"></param>
        /// <param name="Blig"></param>
        /// <param name="BligeeNormal"></param>
        /// <param name="BligeeFast"></param>
        public CBlStatusDGV (String Hours, String Blig, String BligeeNormal, String BligeeFast)
        {
            strHours = Hours;
            strBlig = Blig;
            strBligeeNormmal = BligeeNormal;
            strBligeeFast = BligeeFast;
        }
    }
}
