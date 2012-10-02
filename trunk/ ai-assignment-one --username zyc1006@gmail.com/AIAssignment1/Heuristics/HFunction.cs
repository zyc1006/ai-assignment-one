using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;


namespace AIAssignment1
{
    class HFunction    {
        
        public HFunction(CStateInfo cStateInfo)
        {
        
         //Calculate number of actions
 //Servicing Plonks
 int nSP = (1000-cStateInfo.IServicedPlonks)/5;
 //Finding Plonks
 int nFP = (1000- cStateInfo.IServicedPlonks - cStateInfo.IUnservicedPlonks )/10;
 //Servicing Bligs
 int Bh = 0;
 foreach(TB){
 Bh = Bh + TB[i];}
 int nSB = (nSP-Bh)/8;
 //Making Spunks
 int nMS = (20nSP+10nFP+20nSB- cStateInfo.ISpunks )/50;

 //Calculate TW-hours
 int TWh = (nMS + 2nSB+nSP)/ cStateInfo.IWorkbenchesAvailable ;
 //and Plink-hours
 int EPh = (nSP+nFP)/ cStateInfo.IPlinksAvailable ;
  if(EPh > TWh){return EPh;}
  return TWh;
 }
       
       
       
    }
}



Hide details 

Change log
r10 by zyc1006@gmail.com on Yesterday (25 hours ago)   Diff 
1.Bugs fixed on BligeesGo to: 	 

Double click a line to add a comment

Older revisions
 r9 by zyc1006@gmail.com on Yesterday (27 hours ago)   Diff 
 r8 by zyc1006@gmail.com on Sep 30 (2 days ago)   Diff 
 r5 by zyc1006@gmail.com on Sep 28 (4 days ago)   Diff 
All revisions of this file 

File info
Size: 11496 bytes, 230 lines
View raw file
