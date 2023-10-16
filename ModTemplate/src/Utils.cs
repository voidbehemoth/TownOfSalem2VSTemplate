using System;

namespace $safeprojectname$.Utils
{
    public class Logger
    {
        public static void Log(string message)
        {
            Console.WriteLine("[" + $projectname$.ModInfo.PLUGIN_GUID + "] " + message);
        }
    }
}
