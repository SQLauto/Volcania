﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Acura_Pages_Acura_RL : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }
    protected void Button6_Click(object sender, EventArgs e)
    {

        Session["a"] = Label1.Text;
        Session["a1"] = Label2.Text;
        Response.Redirect("http://localhost:49347/volcania/Booking.aspx");
    }
    protected void Button5_Click(object sender, EventArgs e)
    {

        Session["a"] = Label1.Text;
        Session["a1"] = Label2.Text;
        Response.Redirect("http://localhost:49347/volcania/Customize.aspx");
    }



    protected void Button9_Click(object sender, EventArgs e)
    {
        string s;
        s = "<object style='height: 400px; width: 600px' ><param name='movie' value=''/><embed src='' width='600' height='400'></embed></object>";
        Literal1.Text = s;
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Panel14.BackImageUrl = "http://localhost:49347/volcania/Acura-Images/RLalbertawhitepearl.jpg";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Panel14.BackImageUrl = "http://localhost:49347/volcania/Acura-Images/RLcrystalblackpearl.jpg";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel14.BackImageUrl = "http://localhost:49347/volcania/Acura-Images/RLforgedsilvermetallic.jpg";
    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        Panel14.BackImageUrl = "http://localhost:49347/volcania/Acura-Images/RLgraphitelustermetallic.jpg";
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Panel14.BackImageUrl = "http://localhost:49347/volcania/Acura-Images/RLplatinumfrostmetallic.jpg";
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        Panel14.BackImageUrl = "http://localhost:49347/volcania/Acura-Images/RLpomegranatepearl.jpg";
    }
}