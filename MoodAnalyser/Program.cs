using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Mood
    {
        public String message;
        public Mood(String message)
        {

            this.message = message;
        }
        // uc1

        //public String AnalyseMood()
        //{

        //    if (this.message.Contains("sad"))
        //    {
        //        return "SAD";
        //    }
        //    else
        //    {
        //        return "HAPPY";
        //    }
        //}


        // uc2
        public String AnalyseMood()
        {
            try
            {
                if (this.message.Contains("sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                return "Happy";
            }
        }


    }
}
