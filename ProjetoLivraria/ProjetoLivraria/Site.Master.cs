﻿using ProjetoLivraria.Controller;
using ProjetoLivraria.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjetoLivraria
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ScriptManager.RegisterClientScriptInclude(this, this.GetType(), "Livraria", @"\Scripts\Livraria.js");
        }
    }
}