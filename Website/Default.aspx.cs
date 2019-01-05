using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Inner")
        {

            DataView mydata = (DataView)SqlDataSource3.Select(DataSourceSelectArguments.Empty);
            GridView3.DataSource = mydata;
            GridView3.AutoGenerateColumns = true;
            GridView3.DataBind();




        }else if (DropDownList1.SelectedValue == "Left")
        {

            DataView mydata = (DataView)SqlDataSource4.Select(DataSourceSelectArguments.Empty);
            GridView3.DataSource = mydata;
            GridView3.AutoGenerateColumns = true;
            GridView3.DataBind();

        }
        else if (DropDownList1.SelectedValue == "Right")
        {

            DataView mydata = (DataView)SqlDataSource5.Select(DataSourceSelectArguments.Empty);
            GridView3.DataSource = mydata;
            GridView3.AutoGenerateColumns = true;
            GridView3.DataBind();

        }
        else
        {

            DataView mydata = (DataView)SqlDataSource6.Select(DataSourceSelectArguments.Empty);
            GridView3.DataSource = mydata;
            GridView3.AutoGenerateColumns = true;
            GridView3.DataBind();

        }
    }
}