using System;
using System.Collections.Generic;
using ABI_RC.Core.Util.AssetFiltering;

using HarmonyLib;

using MelonLoader;

using MPUIKIT;
namespace MPUIWhitelist
{

    public static class ModBuildInfo
    {
        public const string Name = "MPUIWhitelist";
        public const string Author = "Shin";
        public const string Version = "1.0.0";
        public const string DownloadLink = "none";
        public const string Description = "This mod allows you to use MPUIKit on props!";

    }
    
    public class MPUIWhitelist : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg(ModBuildInfo.Description);
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            if (buildIndex == -1)
            {
                var whitelist = Traverse.Create(typeof(SharedFilter)).Field<HashSet<Type>>("_spawnableWhitelist").Value;
                try
                {

                    whitelist.Add(typeof(MPImage));
                }
                catch (Exception ex)
                {
                    // SILENCE I DON'T WANT TO HEAR ABOUT YOUR NULL REFERENCE ISSUE!!!
                }
                
            }
        }
    }
}

   
