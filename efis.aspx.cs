using System;
using System.Data;
using System.Data.SqlClient;

// Test this out hello
namespace avSim
{
    public partial class EFISAdapter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // This is different
   		    sender = e;
        }
    }
}
