﻿using SML;

namespace $safeprojectname$
{
    [Mod.SalemMod]
    public class Main
    {
        public static void Start()
    {
            $projectname$.Utils.Logger.Log(ModInfo.PLUGIN_NAME + " has loaded!");
        }
    }


    public static class ModInfo
    {
        public const string PLUGIN_GUID = "$safeprojectname$";

        public const string PLUGIN_NAME = "$projectname$";

        public const string PLUGIN_VERSION = "1.0.0";
    }
}