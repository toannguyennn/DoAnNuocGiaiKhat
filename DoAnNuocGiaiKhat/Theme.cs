using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Drawing;


namespace DoAnNuocGiaiKhat
{
    public class Theme
    {
        [DllImport("uxtheme.dll", EntryPoint = "#95")]
        private static extern uint GetImmersiveColorFromColorSetEx(uint dwImmersiveColorSet, uint dwImmersiveColorType,
                                                                bool bIgnoreHighContrast, uint dwHighContrastCacheMode);
        [DllImport("uxtheme.dll", EntryPoint = "#96")]
        private static extern uint GetImmersiveColorTypeFromName(IntPtr pName);
        [DllImport("uxtheme.dll", EntryPoint = "#98")]
        private static extern int GetImmersiveUserColorSetPreference(bool bForceCheckRegistry, bool bSkipCheckOnFail);

        public static Color LayMauNhan()
        {
            var MauNDChon = GetImmersiveUserColorSetPreference(false, false);
            var KieuMau = GetImmersiveColorTypeFromName(Marshal.StringToHGlobalUni("ImmersiveStartSelectionBackground"));
            var MauCu = GetImmersiveColorFromColorSetEx((uint)MauNDChon, KieuMau, false, 0);
            return ConvertDWordColorToRGB(MauCu);
        }
        private static Color ConvertDWordColorToRGB(uint colorSetEx)
        {
            byte redColor = (byte)((0x000000FF & colorSetEx) >> 0);
            byte greenColor = (byte)((0x0000FF00 & colorSetEx) >> 8);
            byte blueColor = (byte)((0x00FF0000 & colorSetEx) >> 16);
            //byte alphaColor = (byte)((0xFF000000 & colorSetEx) >> 24);

            return Color.FromArgb(redColor, greenColor, blueColor);
        }
    }



}
