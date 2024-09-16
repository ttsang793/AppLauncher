using System.Drawing;
using System.Drawing.Text;

namespace DTO
{
    public class CusFont
    {
        private static PrivateFontCollection customFont = new PrivateFontCollection();

        private static void AddFonts()
        {
            customFont.AddFontFile(@"font\Dosis-VariableFont_wght.ttf");
            customFont.AddFontFile(@"font\Bevan-Regular.ttf");
            customFont.AddFontFile(@"font\BarlowSemiCondensed-Bold.ttf");
        }

        public static FontFamily Font(string fontName)
        {
            AddFonts();
            foreach (FontFamily f in customFont.Families)
                if (f.Name.Contains(fontName)) return f;
            return null;
        }
    }
}
