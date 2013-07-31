using System;
using System.Collections.Generic;
using System.Linq;

//Autodesk dependancies
using Autodesk.AutoCAD.ApplicationServices;
using Autodesk.AutoCAD.DatabaseServices;
using Autodesk.AutoCAD.Runtime;


namespace TreeEase
{
    static class TreeEase
    {

        //Program Constants          //Program Version no.
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [CommandMethod("TreeEase")]
        static void TreeEase()
        {
            //Collect references to the current document, and its corresponding database
            Document acDoc = Application.DocumentManager.MdiActiveDocument;
            Database acCurDb = acDoc.Database;

            acDoc.Editor.WriteMessage("==Opening EasyTree v" + TreeEaseGlobal.__verison);


        }
    }
}
