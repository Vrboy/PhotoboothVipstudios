using System;
using System.Drawing;
using System.IO;

namespace PhotoboothVipstudios.Services
{
    public static class CameraService
    {
        public static Image CaptureDummy()
        {
            try
            {
                string baseDir = AppContext.BaseDirectory;
                string imagePath = Path.Combine(
                    baseDir,
                    "Assets",
                    "Dummy Photo.jpg"
                );

                if (!File.Exists(imagePath))
                    throw new FileNotFoundException("Dummy photo not found", imagePath);

                return Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                throw new Exception("Camera Error\n\n" + ex.Message);
            }
        }
    }
}
