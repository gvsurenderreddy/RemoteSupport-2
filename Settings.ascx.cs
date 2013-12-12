using DotNetNuke.Common;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Exceptions;
using DotNetNuke.Web.UI.WebControls;
using System;

namespace LD2.TeamViewer
{
    public partial class Settings : TeamViewerModuleSettingsBase 
    {
        
        public override void LoadSettings()
        {
            try
            {
                fuFile.FilePath = FileName;
                lblFile2.Text = FileLocation;
                if (!IsPostBack)
                {
                    if (Settings.Contains("Email"))
                    {
                        txtEmail2.Text = Settings["Email"].ToString();
                    }

                    if (Settings.Contains("FileLocation"))
                    {
                        FileLocation = Settings["FileLocation"].ToString();
                    }

                    if (Settings.Contains("FileName"))
                    {
                        FileName = Settings["FileName"].ToString();
                    }
                }
            }
            catch (Exception exc)
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }

        public override void UpdateSettings()
        {
            try
            {
                FileLocation = Globals.ApplicationMapPath + "\\Portals\\" + PortalId + "\\" + fuFile.FolderPath + fuFile.FilePath;
                FileName = fuFile.FilePath;
                                
                ModuleController controller = new ModuleController();
                controller.UpdateTabModuleSetting(TabModuleId, "Email", txtEmail2.Text);
                controller.UpdateTabModuleSetting(TabModuleId, "FileLocation", FileLocation);
                controller.UpdateTabModuleSetting(TabModuleId, "FileName", FileName);
            }
            catch (Exception exc)
            {
                Exceptions.ProcessModuleLoadException(this, exc);
            }
        }
    }
}