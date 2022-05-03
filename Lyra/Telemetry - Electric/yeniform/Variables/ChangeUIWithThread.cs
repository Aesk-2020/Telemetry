using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Telemetri.NewForms;

namespace Telemetri.Variables
{
    public class ChangeUIWithThread
    {
        public Thread UIThread = new Thread(threadson);
        public static void threadson()
        {
            while (true)
            {
                AFront.AccessFront.Invoke();
                Thread.Sleep(100);
            }
        }
    }
}
