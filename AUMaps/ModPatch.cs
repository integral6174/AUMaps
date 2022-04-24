using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace AUMaps.AUMaps
{
    class ModPatch
    {

        [HarmonyPatch(typeof(MainMenuManager), nameof(MainMenuManager.Start))]
        private static class LogoPatch
        {
            static void Postfix(PingTracker __instance)
            {
                DestroyableSingleton<ModManager>.Instance.ShowModStamp();
            }
        }
    }
}
