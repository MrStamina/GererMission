using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GérerMission.Utilitaires
{
    public class Affichage
    {


        //public static bool EnableTrueOrFalse(bool enable, Control Ctrl)
        //{
        //    foreach (Control ct in Ctrl.Controls)
        //    {
        //        if (ct.HasChildren)
        //            EnableTrueOrFalse(enable, ct);
        //        else if (!(ct is Label))
        //            ct.Enabled = enable;
        //        else if (!(ct is Button))
        //            ct.Enabled = enable;
        //    }
        //    return true;

        //}

        public static bool TestLogin(string message1, string message2)
        {
            if (message1 == message2)
                return true;
            else
                return false;
        }
    }
}