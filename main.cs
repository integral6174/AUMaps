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
    public class AUMapsPlugin : BasePlugin
    {
        public const string PluginGuid = "com.integral1729.aumaps";
        public const string PluginVersion = "1.0.0";
        public static AUMapsPlugin Instance;

        public enum CustomMapNames
        {
            Skeld,
            Mira,
            Polus,
            Dleks,
            Airship,

        }
        public static CustomMapNames ThisMap = CustomMapNames.Skeld;
        public static int optionsPage = 1;
        public Harmony Harmony { get; } = new Harmony(PluginGuid);
        internal static BepInEx.Logging.ManualLogSource Logger;
        public override void Load()
        {
            Instance = this;
            Logger = Log;
            Harmony.PatchAll();
            AUMaps.CustomOption.CustomOptions.Load();
        }
    }
}
