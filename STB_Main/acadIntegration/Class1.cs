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
            var version = new PromptStringOptions("\nPlease enter the version number: ");
            version.AllowSpaces = false;
            var vResult = doc.Editor.GetString(version).StringResult;
            List<string> sourceFiles = new List<string> { };
            
            sourceFiles.Add(@"Z:\Template\Source Files\Construction - General [24x36].dwg");
            List<string> zones = new List<string> { "fl83-ef", "fl83-wf", "fl83-nf" };

            foreach (string source in sourceFiles)
            {

                
                foreach (string zone in zones)
                {
                    doc = Acad.DocumentManager.Open(source);
                    bool active = doc.IsActive;
                    Acad.SetSystemVariable("cgeocs", zone);
                    DatabaseSummaryInfo info = doc.Database.SummaryInfo;
                    DatabaseSummaryInfoBuilder infoBuilder = new DatabaseSummaryInfoBuilder(info);
                    var custProps = infoBuilder.CustomPropertyTable;
                    if (custProps.Contains("revision"))
                    {
                        custProps["revision"] = vResult;
                    }
                }
            }
        }
    }
}
