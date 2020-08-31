using System;
using System.Collections.Generic;
using System.Text;

namespace funkcje
{
    class Kappa
    {
        public double kappa(double lambdaL, double lambdaS,double aL,double time)
        {
            //double temp = Math.Sqrt(Math.PI) * (lambdaL - lambdaS) / (2 * aL * Math.Sqrt(time));
            //double temp = SpecialFunction.gamma(0.2) * (lambdaL - lambdaS) / (5 * aL * Math.Pow(time,0.2));
            //double temp = Math.Sqrt(Math.PI) * (lambdaL - lambdaS) / (2 * aL * Math.Sqrt(time));
            double temp = (-2 * Math.Sqrt(Math.PI) * (Math.Sqrt(4 - time) + 2 * time - 8)) / (Math.Acosh(2/(Math.Sqrt(4-time))));
            return temp;

        }
        
        
      
    }
}
