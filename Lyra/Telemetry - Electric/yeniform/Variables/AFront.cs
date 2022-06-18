using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telemetri.Variables;

namespace Telemetri.NewForms
{
    public static class AFront
    {
        public static Anasayfa.TriggerFront AccessFront;
        public static ChangeUIWithThread n;
        static int a = 0;
        public static void ThreadStart()
        {
            if(a==0)
            { 
                n = new ChangeUIWithThread();
                n.UIThread.Start();
                a = 1;
            }
        }
        public static void ThreadStop()
        {
            if (a==1)
            {
                n.UIThread.Abort();
                a = 0;
            }
        }
    }
}
