using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace AUMaps.AUMaps.CustomOption
{
    public static class CustomOptions
    {
        public static string cs(Color c, string s)
        {
            return string.Format("<color=#{0:X2}{1:X2}{2:X2}{3:X2}>{4}</color>", ToByte(c.r), ToByte(c.g), ToByte(c.b), ToByte(c.a), ModTranslation.getString(s));
        }


        public static byte ToByte(float f)
        {
            f = Mathf.Clamp01(f);
            return (byte)(f * 255);
        }
        public static void Load()
        {

        }
    }
}
