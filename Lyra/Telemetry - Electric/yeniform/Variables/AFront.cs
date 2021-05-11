using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telemetri.NewForms
{
    public static class AFront
    {
        public static Anasayfa.TriggerFront AccessFront;
        public static void ChangeUI()
        {
            AccessFront.Invoke();
        }
    }
}
