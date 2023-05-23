using Business.Concrate;
using CrystalDecisions.CrystalReports.Engine;
using DataAccess.Concrate.EfDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebUI.Pages
{
    public partial class RecipeReport : System.Web.UI.Page
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDAL());
        protected void Page_Load(object sender, EventArgs e)
        {
            //CrystalReport1 crystalReport1 = new CrystalReport1();
            ////crystalReport1.SetDataSource(categoryManager.GetCategories());
            //ReportDocument cryRpt = new ReportDocument();
            //cryRpt.Load(Server.MapPath("CrystalReport1.rpt"));
            //cryRpt.SetDataSource(categoryManager.GetCategories());
            //CrystalReportViewer1.ReportSource = cryRpt;
            //CrystalReportViewer1.Visible = true;
        }
    }
}