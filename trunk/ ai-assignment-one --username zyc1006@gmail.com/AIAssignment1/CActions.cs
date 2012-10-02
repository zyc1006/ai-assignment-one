using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace AIAssignment1
{
    class CActions
    {
        
        public CActions(CStateInfo cStateInfo)
        {
            mStateInfo = cStateInfo;
        }
        private static CStateInfo mStateInfo = null;
        private static Int32 MAKE_SPUNKS_SPEED = 50;
        private static Int32 FIND_PLONKS_SPEED = 10;
        private static Int32 SERVE_PLONKS_SPEED = 5;
        private static Int32 SPUNKS_CONSUMED_FOR_FINDING_PLONKS = 10;
        private static Int32 SPUNKS_CONSUMED_FOR_SERVING_PLONGKS = 20;
        private static Int32 SPUNKS_CONSUMED_FOR_NORMAL_SERVING_BLIGS = 20;
        private static Int32 SPUNKS_CONSUMED_FOR_FAST_SERVING_BLIGS = 40;
        private static Int32 UNS_PLONKS_CONSUMED_FOR_SEVING_PLONKS = 5;
        

        public void nextAction()
        {
            recoverResources(mStateInfo);
            servePlonks(mStateInfo, whetherServePlonks(mStateInfo));
            findPlonks(mStateInfo, whetherFindPlonks(mStateInfo));
            serveBligsFast(mStateInfo, whetherServeBligsFast(mStateInfo));
            serveBligsNormal(mStateInfo, whetherServeBligsNormal(mStateInfo));
            makeSpunks(mStateInfo, whetherMakeSpunks(mStateInfo));
        }
        Int32 whetherMakeSpunks(CStateInfo cStateInfo)
        {
            cStateInfo.ITimesMakeSpunks = Math.Min(cStateInfo.IWorkbenchesAvailable,
                                                   cStateInfo.ISpunkeesAvailable);
           // cStateInfo.IWorkbenchesAvailable -= cStateInfo.ITimesMakeSpunks;
           // cStateInfo.MStimes = cStateInfo.ITimesMakeSpunks;
            return cStateInfo.ITimesMakeSpunks;
        }
        Int32 whetherServeBligsNormal(CStateInfo cStateInfo)
        {
            Int32 BligeesLimit = (Int32)(cStateInfo.IBligeesAvailable);
            Int32 SpunksLimit = (Int32)(cStateInfo.ISpunks / SPUNKS_CONSUMED_FOR_NORMAL_SERVING_BLIGS);
            Int32 tempMin1 = Math.Min(BligeesLimit, SpunksLimit);
            Int32 tempMin2 = Math.Min((Int32)cStateInfo.IBligsToBeServiced, cStateInfo.IWorkbenchesAvailable);
            cStateInfo.SBNormalTimes = Math.Min(tempMin1, tempMin2);
            cStateInfo.IBligsUnderServing += cStateInfo.SBNormalTimes;
            cStateInfo.IBligsUnavailable -= cStateInfo.SBNormalTimes;
            return cStateInfo.SBNormalTimes;

        }
        Int32 whetherServeBligsFast(CStateInfo cStateInfo)
        {
           
            Int32 BligeesLimit = (Int32)(cStateInfo.IBligeesAvailable / 2);
            Int32 SpunksLimit = (Int32)(cStateInfo.ISpunks / SPUNKS_CONSUMED_FOR_FAST_SERVING_BLIGS);
            Int32 tempMin1 = Math.Min(BligeesLimit, SpunksLimit);
            Int32 tempMin2 = Math.Min((Int32)cStateInfo.IBligTotal - cStateInfo.IBligsUnderServing - cStateInfo.IBligsAvailable, cStateInfo.IWorkbenchesAvailable);
            cStateInfo.SBFastTimes = Math.Min(tempMin1, tempMin2);
            cStateInfo.IBligsToBeServiced = cStateInfo.IBligTotal - cStateInfo.IBligsUnderServing - cStateInfo.IBligsAvailable;
            cStateInfo.IBligsUnavailable -= cStateInfo.SBFastTimes;
            cStateInfo.IBligsUnderServing += cStateInfo.SBFastTimes;
            cStateInfo.IBligsToBeServiced -= cStateInfo.SBFastTimes;
            return cStateInfo.SBFastTimes;
        }
        Int32 whetherServePlonks(CStateInfo cStateInfo)
        {
            Int32 SpunksLimit = (Int32)(cStateInfo.ISpunks / SPUNKS_CONSUMED_FOR_SERVING_PLONGKS);
            Int32 UnsPlonksLimit = (Int32)(cStateInfo.IUnservicedPlonks / UNS_PLONKS_CONSUMED_FOR_SEVING_PLONKS);

            Int32 tempMin1 = Math.Min(SpunksLimit, UnsPlonksLimit);
            Int32 tempMin2 = Math.Min(cStateInfo.IPlinksAvailable, cStateInfo.IWorkbenchesAvailable);
            Int32 tempMin3 = Math.Min(tempMin1, tempMin2);
            cStateInfo.ITimesServePlonks = Math.Min(tempMin3, cStateInfo.IBligsAvailable);
            return cStateInfo.ITimesServePlonks;

        }
        Int32 whetherFindPlonks(CStateInfo cStateInfo)
        {
            //1000 unserviced plonks
//             if (cStateInfo.ITotalUnservicedPlonks >= 1000)
//             {
//                 return 0;
//             }
            Int32 SpunksLimit = (Int32)(cStateInfo.ISpunks / SPUNKS_CONSUMED_FOR_FINDING_PLONKS);
            cStateInfo.ITimesFindPlonks = Math.Min(SpunksLimit, cStateInfo.IPlinksAvailable);
         //   cStateInfo.IPlinksAvailable -= cStateInfo.ITimesFindPlonks;
            return cStateInfo.ITimesFindPlonks;
        }
        void makeSpunks(CStateInfo cStateInfo, Int32 iTimes)
        {
            cStateInfo.ISpunks += MAKE_SPUNKS_SPEED * iTimes;
            cStateInfo.IWorkbenchesAvailable -= iTimes;
            cStateInfo.ISpunkeesAvailable -= iTimes;
        }
        void serveBligsNormal(CStateInfo cStateInfo, Int32 iTimes)
        {
            cStateInfo.ListNormalBligeeStatus.Insert(0, iTimes);
            //recover for immediate display
            if ((Int32)cStateInfo.ListNormalBligeeStatus[3] != 0)
            {
                cStateInfo.IBligsUnderServing -= (Int32)cStateInfo.ListNormalBligeeStatus[3];
                cStateInfo.IBligsAvailable += (Int32)cStateInfo.ListNormalBligeeStatus[3];
                cStateInfo.ListBligStatus[8] = (Int32)cStateInfo.ListBligStatus[8] - (Int32)(cStateInfo.ListNormalBligeeStatus[3]);
                cStateInfo.ListBligStatus[0] = (Int32)cStateInfo.ListBligStatus[0] + (Int32)(cStateInfo.ListNormalBligeeStatus[3]);
            }
            //resources consumed
            if (iTimes != 0)
            {
                cStateInfo.IBligeesAvailable -= iTimes;
                cStateInfo.IWorkbenchesAvailable -= iTimes;
                cStateInfo.ISpunks -= SPUNKS_CONSUMED_FOR_NORMAL_SERVING_BLIGS * iTimes;
                
            }
           
            
        }
        void serveBligsFast(CStateInfo cStateInfo, Int32 iTimes)
        {
            cStateInfo.ListFastBligeeStatus.Insert(0, iTimes * 2);
            //recover for immediate display
            if ((Int32)cStateInfo.ListFastBligeeStatus[1] != 0)
            {
                cStateInfo.IBligsUnderServing -= (Int32)((Int32)cStateInfo.ListFastBligeeStatus[1] * 0.5);
                cStateInfo.IBligsAvailable += (Int32)((Int32)cStateInfo.ListFastBligeeStatus[1] * 0.5);
                cStateInfo.ListBligStatus[8] = (Int32)cStateInfo.ListBligStatus[8] - (Int32)((Int32)(cStateInfo.ListFastBligeeStatus[1]) * 0.5);
                cStateInfo.ListBligStatus[0] = (Int32)cStateInfo.ListBligStatus[0] + (Int32)((Int32)(cStateInfo.ListFastBligeeStatus[1]) * 0.5);
            }
            //resources consumed

            if (iTimes != 0)
            {
                cStateInfo.IBligeesAvailable -= iTimes * 2;
                cStateInfo.IWorkbenchesAvailable -= iTimes;
                cStateInfo.ISpunks -= SPUNKS_CONSUMED_FOR_FAST_SERVING_BLIGS * iTimes;
                
            }
           
        }
        void findPlonks(CStateInfo cStateInfo, Int32 iTimes)
        {
            if (iTimes != 0)
            {
                cStateInfo.IUnservicedPlonks += FIND_PLONKS_SPEED * iTimes;
                cStateInfo.ISpunks -= SPUNKS_CONSUMED_FOR_FINDING_PLONKS * iTimes;
                cStateInfo.IPlinksAvailable -= iTimes;
                cStateInfo.ITotalUnservicedPlonks += FIND_PLONKS_SPEED * iTimes;
            }
           
        }
        void servePlonks(CStateInfo cStateInfo, Int32 iTimes)
        {
            if (iTimes != 0)
            {
                cStateInfo.IServicedPlonks += SERVE_PLONKS_SPEED * iTimes;
                cStateInfo.IUnservicedPlonks -= UNS_PLONKS_CONSUMED_FOR_SEVING_PLONKS * iTimes;
                cStateInfo.IPlinksAvailable -= iTimes;
                cStateInfo.IWorkbenchesAvailable -= iTimes;
                cStateInfo.ISpunks -= SPUNKS_CONSUMED_FOR_SERVING_PLONGKS * iTimes;

                //codes for bligs
                for (Int32 i = 0; i < cStateInfo.ListBligStatus.Count - 1 && iTimes != 0; i++)
                {
                    if ((Int32)cStateInfo.ListBligStatus[i] != 0)
                    {
                        if ((Int32)cStateInfo.ListBligStatus[i] >= iTimes)
                        {
                            cStateInfo.ListBligStatus[i] = (Int32)cStateInfo.ListBligStatus[i] - iTimes;
                            cStateInfo.ListBligStatus[i + 1] = (Int32)cStateInfo.ListBligStatus[i + 1] + iTimes;
                            if (i == cStateInfo.ListBligStatus.Count - 2)
                            {
                                cStateInfo.IBligsUnavailableLastTime += iTimes;
                            }
                            iTimes = 0;
                        }
                        else
                        {

                        //    cStateInfo.ListBligStatus[i + 1] = (Int32)cStateInfo.ListBligStatus[i + 1] + (Int32)cStateInfo.ListBligStatus[i];
                            cStateInfo.ListBligsUsedLastTime[i + 1] = (Int32)cStateInfo.ListBligStatus[i];
                            if (i == cStateInfo.ListBligStatus.Count - 2)
                            {
                                cStateInfo.IBligsUnavailableLastTime += (Int32)cStateInfo.ListBligStatus[i];
                            }
                            iTimes -= (Int32)cStateInfo.ListBligStatus[i];
                            cStateInfo.ListBligStatus[i] = 0;
                        }
                    }
                    
                }
                for (Int32 i = 0; i < cStateInfo.ListBligsUsedLastTime.Count; i++ )
                {
                    cStateInfo.ListBligStatus[i] = (Int32)cStateInfo.ListBligStatus[i]+(Int32)cStateInfo.ListBligsUsedLastTime[i];
                }
                cStateInfo.ListBligsUsedLastTime = new ArrayList() { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                //cStateInfo.IBligsUnavailableLastTime = (Int32)cStateInfo.ListBligStatus[8];
                
            }
           
           
        }
        void recoverResources(CStateInfo cStateInfo)
        {
            //last time unavailable bligs
            cStateInfo.IBligsUnavailable += cStateInfo.IBligsUnavailableLastTime;
            cStateInfo.IBligsUnavailableLastTime = 0;
            cStateInfo.IBligsAvailable = cStateInfo.IBligTotal - cStateInfo.IBligsUnavailable - cStateInfo.IBligsUnderServing;
            //other resources
            cStateInfo.ISpunkeesAvailable += cStateInfo.ITimesMakeSpunks;
            cStateInfo.IWorkbenchesAvailable += cStateInfo.ITimesMakeSpunks;
            cStateInfo.IPlinksAvailable += cStateInfo.ITimesFindPlonks;
            cStateInfo.IPlinksAvailable += cStateInfo.ITimesServePlonks;
            cStateInfo.IWorkbenchesAvailable += cStateInfo.ITimesServePlonks;
            //Normal
            cStateInfo.IWorkbenchesAvailable += (Int32)cStateInfo.ListNormalBligeeStatus[3];
            cStateInfo.IBligeesAvailable += (Int32)cStateInfo.ListNormalBligeeStatus[3];
  //          cStateInfo.IBligsAvailable += (Int32)cStateInfo.ListNormalBligeeStatus[4];
  //          cStateInfo.ListBligStatus[8] = (Int32)cStateInfo.ListBligStatus[8] - (Int32)cStateInfo.ListNormalBligeeStatus[4];
            if (cStateInfo.ListNormalBligeeStatus.Count == 5)
            {
                cStateInfo.ListNormalBligeeStatus.RemoveAt(4);
            }
            //Fast
            cStateInfo.IWorkbenchesAvailable += (Int32)((Int32)cStateInfo.ListFastBligeeStatus[1] * 0.5);
            cStateInfo.IBligeesAvailable += (Int32)cStateInfo.ListFastBligeeStatus[1];
  //          cStateInfo.IBligsAvailable += (Int32)((Int32)cStateInfo.ListFastBligeeStatus[2] * 0.5);
  //          cStateInfo.ListBligStatus[8] = (Int32)cStateInfo.ListBligStatus[8] -(Int32)((Int32)(cStateInfo.ListFastBligeeStatus[2]) * 0.5);
            if (cStateInfo.ListFastBligeeStatus.Count == 3)
            {
                cStateInfo.ListFastBligeeStatus.RemoveAt(2);
            }

            
        }
       
       
    }
}
