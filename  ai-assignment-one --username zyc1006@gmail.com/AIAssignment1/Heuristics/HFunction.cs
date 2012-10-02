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
 int NSP = (1000-cStateInfo.IServicedPlonks)/5;
 //Finding Plonks
 int NFP = (1000- cStateInfo.IServicedPlonks - cStateInfo.IUnservicedPlonks )/10;
 //Servicing Bligs
 int Bh = 0;
 foreach(TB){
 Bh = Bh + TB[i];}
 int NSB = (NSP-Bh)/8;
 //Making Spunks
 int NMS = (20*NSP+10*NFP+20*NSB- cStateInfo.ISpunks )/50;

 //Calculate TW-hours
 int TWh = (NMS + 2*NSB+NSP)/ cStateInfo.IWorkbenchesAvailable ;
 //and Plink-hours
 int EPh = (NSP+NFP)/ cStateInfo.IPlinksAvailable ;
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
