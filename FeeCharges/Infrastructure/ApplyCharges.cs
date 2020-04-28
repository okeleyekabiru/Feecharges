using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FeeCharges.Models;


namespace FeeCharges.infrastructure
{
  public  class ApplyCharges
    {
   
      

        public static double AmountToPay(FeesCharges fees, double amount)
        {
            // return amount to be charged

            if (fees == null)
            {
                return default;
            }
             
             double feeToPay = 0;
            foreach (var elem in fees.Fees)
            {
                if (amount >= elem.MinAmount && amount <= elem.MaxAmount)
                {
                    feeToPay = elem.FeeAmount;
            
                }
            
            
            
            }
            
            
            
            return feeToPay;
        }

      
        }
    }

