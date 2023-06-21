using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManningEquation
{
    class Formula
    {
        //formüller burada tutulur 
        float RhCalculate;

        //Rh formulu.
        public float RhFormul(float A,float P)
        {
            RhCalculate = A / P;
            return RhCalculate;


        }
        float Rh,Ssquare, VCalculate;
        //V formulu.
        public float VFormul(float S,float N)
        {
            //Rh üssü 2/3'ü ,Rh üssü 0.6666666667 şeklinde girdim.
            Rh = (float)Math.Pow(RhCalculate, 0.6666666667);
            //S'in kökü hesaplanıyor.
            Ssquare = (float)Math.Sqrt(S);
            VCalculate = (Rh * Ssquare) / N;
            return VCalculate;


        }
        //Q formulu.
        public float QFormul(float A,float V)
        {
            return (A * V);
        }

    }
}
