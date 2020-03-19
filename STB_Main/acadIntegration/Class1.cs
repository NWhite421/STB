using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.EditorInput;
using Acad = Autodesk.AutoCAD.ApplicationServices.Application;

namespace acadIntegration
{
    public class Templates
    {
        [CommandMethod("PublishTemplates")]
        public void PublishTemplateFiles()
        {
            var doc = Acad.DocumentManager.MdiActiveDocument;
            var ed = doc.Editor;
            var version = new PromptStringOptions("\nPlease enter the revision number: ");
            version.AllowSpaces = false;
            var vResult = doc.Editor.GetString(version).StringResult;
            if (!int.TryParse(vResult, out int revisionN))
            {
                doc.Editor.WriteMessage("Version is not a number, please try again.\n");
                PublishTemplateFiles();
                return;
            }
            List<string> sourceFiles = new List<string> { };
            
            sourceFiles.Add(@"Z:\Template\Source Files\Construction - General [24x36].dwg");
            List<string> zones = new List<string> { "fl83-ef", "fl83-wf", "fl83-nf" };

            foreach (string source in sourceFiles)
            {
                ed.WriteMessage("\nFile: " + source);
                foreach (string zone in zones)
                {
                    doc = Acad.DocumentManager.Open(source); 
                    ed = doc.Editor;
                    bool active = doc.IsActive;
                    Acad.SetSystemVariable("cgeocs", zone);
                    DatabaseSummaryInfo info = doc.Database.SummaryInfo;
                    DatabaseSummaryInfoBuilder infoBuilder = new DatabaseSummaryInfoBuilder(info);
                    var custProps = infoBuilder.CustomPropertyTable;
                    if (custProps.Contains("revision"))
                    {
                        custProps["revision"] = vResult;
                    }
                    //doc.CloseAndSave(source)
                }
            }
        }

        private void SetCoordinateZone(string zone)
        {
            Acad.SetSystemVariable("cgeocs", zone);
        }

        [CommandMethod("SetEastZone")]
        public void SetEastZone()
        {
            SetCoordinateZone("fl83-ef");
        }

        [CommandMethod("SetWestZone")]
        public void SetWestZone()
        {
            SetCoordinateZone("fl83-wf");
        }

        [CommandMethod("SetNorthZone")]
        public void SetNorthZone()
        {
            SetCoordinateZone("fl83-nf");
        }
    }
}
