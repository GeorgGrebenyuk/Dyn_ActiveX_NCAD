#region
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using dr = Autodesk.DesignScript.Runtime;

using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;
using System.Runtime.InteropServices.ComTypes;
using Microsoft.Win32;

#endregion

namespace DynNCXLib
{
    
    /// <summary>
    /// Root clas for wotk with AutoCAD application's instance. An instance of the AutoCAD application
    /// </summary>
    public class AcadApplication
    {
        public nanoCAD.Application _i;
        /// <summary>
        /// Use AcadApplicationVersions to get progID data
        /// </summary>
        /// <param name="progID"></param>
        public AcadApplication(string progID)
        {
            var check_app = Marshal.GetActiveObject(progID) as nanoCAD.Application;
            if (check_app != null) this._i = check_app;
        }
        /// <summary>
        /// Get acad instance from latest installed version on PC (Non-recommended for use in public-sharing scripts)
        /// </summary>
        public AcadApplication()
        {
            var check_app = Marshal.GetActiveObject("nanoCAD.Application") as nanoCAD.Application;
            if (check_app != null) this._i = check_app;
        }

        /// <summary>
        /// Get ProgID identificators for nanoCAD
        /// </summary>
        /// <returns></returns>
        [dr.MultiReturn(new [] { "nanoCAD 3.5", "nanoCAD 9", "nanoCAD Plus 10", "nanoCAD Plus 11", "nanoCAD Plus 12", "nanoCAD Plus 21", "nanoCAD 22", "nanoCAD 23", "nanoCAD 24.0", "nanoCAD 24.1" })]
        public static Dictionary<string, string> AcadApplicationVersions() => new Dictionary<string, string>()
        {
            {"nanoCAD 3.5","nanoCAD.Application.3.5"  },
            {"nanoCAD 9","nanoCAD.Application.9.0"  },
            {"nanoCAD Plus 10","nanoCAD.Application.10.0"  },
            {"nanoCAD Plus 11","nanoCAD.Application.11.0"  },
            {"nanoCAD Plus 12","nanoCAD.Application.12.0"  },
            {"nanoCAD Plus 21","nanoCAD.Application.21.0"  },
            {"nanoCAD 22","nanoCADx64.Application.22.0"  },
            {"nanoCAD 23","nanoCADx64.Application.23.0"  },
            //{"nanoCAD 23.1","nanoCADx64.Application.23.0"  },
            {"nanoCAD 24.0","nanoCADx64.Application.24.0"  },
            {"nanoCAD 24.1","nanoCADx64.Application.24.1"  }
        };

        /// <summary>
        /// Updates the object to the drawing screen
        /// </summary>
        public void Update()
        {
            this._i.Update();
        }

        /// <summary>
        /// Gets the text that the user sees displayed for the application or a menu item
        /// </summary>
        public string Caption => this._i.Caption;

        /// <summary>
        /// The Documents collection for the current AutoCAD session
        /// </summary>
        /// <returns></returns>
        public List<AcadDocument> Documents()
        {
            var docs_row = this._i.Documents;
            List<AcadDocument> docs = new List<AcadDocument>();
            for (int i = 0; i < docs_row.Count; i++)
            {
                docs.Add(new AcadDocument(docs_row[i]));
            }
            return docs;

        }
        /// <summary>
        /// Get active drawing if it exists
        /// </summary>
        public AcadDocument ActiveDocument => new AcadDocument(this._i.ActiveDocument);
        public void Set_ActiveDocument(AcadDocument AcadDocument) => this._i.ActiveDocument = AcadDocument._i;
        #region getting_processes_ROT
        //https://stackoverflow.com/questions/7736280/marshal-getactiveobject-throws-mk-e-unavailable-exception-in-c-sharp
        /// <summary>
        /// Get COM processes ID
        /// </summary>
        /// <returns></returns>
        public static List<string> GetCOMProcesses()
        {
            StringBuilder SB = new StringBuilder();
            List<string> processes = new List<string>();
            foreach (var moniker in EnumRunningObjects())
            {
                List<string> t1 = GetMonikerString(moniker).Split('\t').ToList();
                processes = processes.Concat(t1).ToList();
            }
            return processes;
        }
        private const int S_OK = 0x00000000;

        [DllImport("ole32.dll")]
        private static extern int GetRunningObjectTable(uint reserved, out IRunningObjectTable pprot);

        [DllImport("ole32.dll")]
        private static extern int CreateBindCtx(uint reserved, out IBindCtx ppbc);

        private static void OleCheck(string message, int result)
        {
            if (result != S_OK)
                throw new COMException(message, result);
        }

        private static System.Collections.Generic.IEnumerable<IMoniker> EnumRunningObjects()
        {
            IRunningObjectTable objTbl;
            OleCheck("GetRunningObjectTable failed", GetRunningObjectTable(0, out objTbl));
            IEnumMoniker enumMoniker;
            IMoniker[] monikers = new IMoniker[1];
            objTbl.EnumRunning(out enumMoniker);
            enumMoniker.Reset();
            while (enumMoniker.Next(1, monikers, IntPtr.Zero) == S_OK)
            {
                yield return monikers[0];
            }
        }

        private static bool TryGetCLSIDFromDisplayName(string displayName, out string clsid)
        {
            var bBracket = displayName.IndexOf("{");
            var eBracket = displayName.IndexOf("}");
            if ((bBracket > 0) && (eBracket > 0) && (eBracket > bBracket))
            {
                clsid = displayName.Substring(bBracket, eBracket - bBracket + 1);
                return true;
            }
            else
            {
                clsid = string.Empty;
                return false;
            }
        }

        private static string ReadSubKeyValue(string keyName, RegistryKey key)
        {
            var subKey = key.OpenSubKey(keyName);
            if (subKey != null)
            {
                using (subKey)
                {
                    var value = subKey.GetValue("");
                    return value == null ? string.Empty : value.ToString();
                }
            }
            return string.Empty;
        }

        private static string GetMonikerString(IMoniker moniker)
        {
            IBindCtx ctx;
            OleCheck("CreateBindCtx failed", CreateBindCtx(0, out ctx));
            var sb = new StringBuilder();
            string displayName;
            moniker.GetDisplayName(ctx, null, out displayName);
            sb.Append(displayName);
            sb.Append('\t');
            string clsid;
            if (TryGetCLSIDFromDisplayName(displayName, out clsid))
            {
                var regClass = Registry.ClassesRoot.OpenSubKey("\\CLSID\\" + clsid);
                if (regClass != null)
                {
                    using (regClass)
                    {
                        sb.Append(regClass.GetValue(""));
                        sb.Append('\t');
                        sb.Append(ReadSubKeyValue("ProgID", regClass));
                        sb.Append('\t');
                        sb.Append(ReadSubKeyValue("LocalServer32", regClass));
                    }
                }
            }
            return sb.ToString();
        }
        #endregion
    }

}