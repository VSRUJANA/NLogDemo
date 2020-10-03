using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace NLogDemo
{
    public class AddNumber
    {
        NLog nLog = new NLog();
        public int Sum(int FirstNumber, int SecondNumber)
        {
            int result = FirstNumber + SecondNumber;
            if (FirstNumber == 0 || SecondNumber == 0)
            {
                nLog.LogDebug("Debug Unsuccessful : Sum()");
                nLog.LogError("Input numbers can not be zero");
                nLog.LogWarn("First and Second number shouldnot be equal to 0");
            }
            else
            {
                nLog.LogDebug("Debug Successful : Sum()");
            }
            nLog.LogInfo("Sum method passed, Result = " + result);
            return result;
        }
    }
}
