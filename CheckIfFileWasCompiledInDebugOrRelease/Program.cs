using System;

namespace CheckIfFileWasCompiledInDebugOrRelease
{
    class Program
    {
        static void Main(string[] args)
        {                

            var fileName = @"C:\Users\ochiab\Downloads\92769101_07Feb2022_KittingStation_StaticRunCode\BSC\Application\HMI\HMI.exe";

            var fileBuildChecker = new AssemblyBuildModeChecker();

            fileBuildChecker.CheckFileBuildMode(fileName);
        }
    }
}
