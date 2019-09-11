using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;

namespace DataCollectorV3.Entities.Concrete.Appearance
{
    public class CustomColorPalette
    {
        #region Fields

        private byte[] _rgb;

        #endregion

        #region Methods

        public IReadOnlyList<Color> GetRandomSingleTonePalette(params double[] rates)
        {
            CreateRgbChannels();
            return rates.Select(GetColorTone).ToList();
        }

        private void CreateRgbChannels()
        {
            var rnd = new Random();
            byte x = 0, y = 200, z = (byte) rnd.Next(200);
            byte[] xyz = {x, y, z};
            _rgb = xyz.OrderBy(n => rnd.Next()).ToArray();
        }

        private Color GetColorTone(double rate)
        {
            rate /= 100;
            return Color.FromArgb((byte) (_rgb[0] * rate), (byte) (_rgb[1] * rate), (byte) (_rgb[2] * rate));
        }

        #endregion
    }
}