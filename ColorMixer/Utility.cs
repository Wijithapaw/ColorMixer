using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorMixer
{
    public static class Utility
    {
        /// <summary>Blends the specified colors together.</summary>
        /// <param name="color">Color to blend onto the background color.</param>
        /// <param name="backColor">Color to blend the other color onto.</param>
        /// <param name="amount">How much of <paramref name="color"/> to keep,
        /// “on top of” <paramref name="backColor"/>.</param>
        /// <returns>The blended colors.</returns>
        public static Color Blend(this Color color, Color backColor, double amount = 0.5)
        {
            byte r = (byte)((color.R * amount) + backColor.R * (1 - amount));
            byte g = (byte)((color.G * amount) + backColor.G * (1 - amount));
            byte b = (byte)((color.B * amount) + backColor.B * (1 - amount));
            return Color.FromArgb(r, g, b);
        }

        public static List<BasicColor> GetColors()
        {
            using (StreamReader r = new StreamReader("colors.json"))
            {
                string json = r.ReadToEnd();
                List<BasicColor> items = JsonConvert.DeserializeObject<List<BasicColor>>(json);
                return items;
            }
        }

        public static string GetSetting(string key, string defaultValue = "")
        {
            string value = ConfigurationManager.AppSettings.Get(key);

            if (string.IsNullOrEmpty(value))
                value = defaultValue;

            return value;
        }

        public static string ConstructFileName(string name, DateTime dt)
        {
            if (string.IsNullOrEmpty(name))
                name = "Design";

            return string.Format("{0}_{1}.jpeg", name, dt.ToString("yyyyMMddHHmm")).Replace(" ", "_");
        }        
    }

    public class BasicColor {

        public string name { get; set; }

        public int r { get; set; }

        public int g { get; set; }

        public int b { get; set; }
    }
}
