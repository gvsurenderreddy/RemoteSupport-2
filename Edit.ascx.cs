using System;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Common;

namespace LD2.TeamViewer
{
    public partial class Edit : TeamViewerModuleBase 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtEmail2.Text = Email;
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Email = txtEmail2.Text;

            if (fuFile.HasFile)
            {
                FileLocation = Globals.ApplicationMapPath + "\\DesktopModules\\TeamViewer\\" + fuFile.FileName;
                FileName = fuFile.FileName;
                fuFile.SaveAs(FileLocation);
            }
            else
            {
                DotNetNuke.UI.Skins.Skin.AddModuleMessage(this, "Error1", DotNetNuke.UI.Skins.Controls.ModuleMessage.ModuleMessageType.RedError);
            }
            
            Response.Redirect(Globals.NavigateURL());
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect(Globals.NavigateURL());
        }
    }
}