using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;
using Util;

namespace UI.Web1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {

        public int SelectedID2
        {
            get
            {
                return (int)ddl0.SelectedIndex;
            }

        }
        public int SelectedID3
        {
            get
            {
                return (int)ddl1.SelectedIndex;
            }

        }
        public int SelectedID4
        {
            get
            {
                return (int)ddl2.SelectedIndex;
            }

        }
        public int SelectedID1
        {
            get
            {  return (int)ddl.SelectedIndex;                
            }
           
        }

    }
}