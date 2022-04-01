using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckIfFileWasCompiledInDebugOrRelease
{
    class AssemblyBuildModeChecker
    {

        /// <summary>
        /// Writes file build mode to console.
        /// </summary>
        /// <param name="file"></param>
        public void CheckFileBuildMode(string file)
        {
            if (isAssemblyDebugBuild(file))
            {
                Console.WriteLine(String.Format("{0} seems to be a debug build", file));
            }
            else
            {
                Console.WriteLine(String.Format("{0} seems to be a release build", file));
            }
        }

        private bool isAssemblyDebugBuild(string filename)
        {
            return isAssemblyDebugBuild(System.Reflection.Assembly.LoadFile(filename));
        }

        private bool isAssemblyDebugBuild(System.Reflection.Assembly assemb)
        {
            bool retVal = false;
            foreach (object att in assemb.GetCustomAttributes(false))
            {
                if (att.GetType() == System.Type.GetType("System.Diagnostics.DebuggableAttribute"))
                {
                    retVal = ((System.Diagnostics.DebuggableAttribute)att).IsJITTrackingEnabled;
                }
            }
            return retVal;
        }
    }
}
