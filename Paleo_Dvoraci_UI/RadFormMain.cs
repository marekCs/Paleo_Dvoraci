using Paleo_ClassLibrary.Data;
using Paleo_ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace Paleo_Dvoraci_UI
{
    public partial class RadFormMain : Telerik.WinControls.UI.RadForm
    {
        public RadFormMain()
        {
            InitializeComponent();
        }

        private void tabPageUsers_Enter(object sender, EventArgs e)
        {
            using (MySqlConnect data = new MySqlConnect())
            {
                var users = data.GetOsoby(new User { });

                if (users.Count > 0)
                {
                    radGridViewUsers.DataSource = users;
                }
            }
        }
    }
}
