using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayerPlusPlus.Core
{
    public class UiHelper
    {
        public static bool IsInRunTime
        {
            get
            {
                if (System.Reflection.Assembly.GetExecutingAssembly().Location.Contains("VisualStudio"))
                {
                    return false;
                }
                return true;
            }
        }
    }
}
