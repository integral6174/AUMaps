using System.Text.RegularExpressions;
using BepInEx;
using BepInEx.Configuration;
using BepInEx.IL2CPP;
using System;
using HarmonyLib;
using System.Collections.Generic;
using UnityEngine;
using Hazel;
using System.Linq;

namespace AUMaps
{
    [BepInPlugin(PluginGuid, "AU Maps", PluginVersion)]
    [BepInProcess("Among Us.exe")]
    public class main : BasePlugin
    {
        public const string PluginGuid = "com.mod.aumaps";
        public const string PluginVersion = "1.0.0";
        public Harmony Harmony { get; } = new Harmony(PluginGuid);
        public override void Load()
        {
            Harmony.PatchAll();
        }
    }
}
