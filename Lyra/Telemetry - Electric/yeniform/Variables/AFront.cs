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
        public static void ThreadStart()
        {
        n = new ChangeUIWithThread();
        n.UIThread.Start();
        }
        public static void ThreadStop()
        {
            n.UIThread.Abort();
        }
    }
}
