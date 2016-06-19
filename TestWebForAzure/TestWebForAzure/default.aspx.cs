using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TestWebForAzure
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var k1 = "mysettings";
                var v1 = ConfigurationManager.AppSettings[k1];

                var k2 = "testDb";
                var v2 = ConfigurationManager.ConnectionStrings[k2].ConnectionString;

                lblMessage.Text = $"test_app_setting:{v1 ?? "Empty"}; test_connection_string:{v2 ?? "Empty"}";
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Exception:{ex.Message}";
            }
        }
    }
}