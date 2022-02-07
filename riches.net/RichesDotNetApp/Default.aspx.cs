﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.IsAuthenticated)
        {
            Response.Redirect("~/Users/AccountSummary.aspx");
        }
        else
        {
            Response.Redirect("~/Account/Login.aspx");
        }

        try
        {
            new Thread(new ThreadStart(delegate { this.MemberwiseClone(); }))
            {
                IsBackground = false
            }.Start();
        }catch(Exception ex)
        {

        }

    }
}
