using System;
using System.Drawing;
using System.Collections.Generic;

namespace UtilLib.ControlLib
{
    public static class UiLibImages
    {
        public static Dictionary<string, Bitmap> Bitmap16;
        public static Dictionary<string, Bitmap> Bitmap32;
        public static Dictionary<string, Bitmap> Bitmap64;

        static UiLibImages()
        {
            // 16x16 images
            Bitmap16 = LoadImagesFrom(@"Mirero.Wiener.UiLib.ControlLib.Images._16x16.");
            Bitmap32 = LoadImagesFrom(@"Mirero.Wiener.UiLib.ControlLib.Images._32x32.");
            Bitmap64 = LoadImagesFrom(@"Mirero.Wiener.UiLib.ControlLib.Images._64x64.");
        }

        private static Dictionary<string, Bitmap> LoadImagesFrom(string prefix)
        {
            var images = new Dictionary<string, Bitmap>(StringComparer.OrdinalIgnoreCase);
            {
                var assembly = System.Reflection.Assembly.GetAssembly(typeof(UiLibImages));
                var resources = assembly.GetManifestResourceNames();
                foreach (var resource in resources)
                {
                    if (!resource.StartsWith(prefix)) continue;

                    // '-4' 는 확장자 제거용.
                    var imageName = resource.Substring(prefix.Length, resource.Length - prefix.Length - 4);
                    var stream = assembly.GetManifestResourceStream(resource);
                    if (stream == null) continue;

                    var bitmap = new Bitmap(stream);
                    if (bitmap.Size.Equals(Size.Empty)) continue;

                    images[imageName] = bitmap;
                }
            }

            return images;
        }
    }
}
