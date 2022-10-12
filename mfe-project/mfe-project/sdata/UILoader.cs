using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using mfe_project.gui;

namespace mfe_project.sdata
{
    public class UILoader
    {
        public static bool isAboutOpen = false;

        public bool aboutControl(bool _is) {
            About form = new About();

            if (_is == false)
            { 
                form.Show();
                return true;
            }
            else {
                form.Hide();
                return false;
            }
        }
    }
}
