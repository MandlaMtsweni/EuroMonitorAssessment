using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EuromonitorAssesment
{
    public class Logic
    {
        public int CalcuteDifference(int inputNo)
        {
            int difference = 0;
            int NoLessThan = 5;

            try
            {
                if(inputNo < NoLessThan)
                {
                    difference = NoLessThan - inputNo;
                }                    
                else
                {
                    return inputNo;
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }           

            return  difference;
        }

    }
}
