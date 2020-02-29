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
            set
            {
                ddl0.SelectedIndex = value;
            }

        }
        public int SelectedID3
        {
            get
            {
                return (int)ddl1.SelectedIndex;
            }
            set
            {
                ddl1.SelectedIndex = value;
            }

        }
        public int SelectedID4
        {
            get
            {
                return (int)ddl2.SelectedIndex;
            }
            set
            {
                ddl2.SelectedIndex = value;
            }

        }
        public int SelectedID1
        {
            get
            {  return (int)ddl.SelectedIndex;                
            }
            set
            {
                ddl.SelectedIndex = value;
            }

        }

        protected void formPanel_Load(object sender, EventArgs e)
        {

        }
    }
}