namespace HotelAPI.Application.Helpers
{
    public static class FileHelper 
    {
        public static string SavePhotoToFtp(byte[] imageBytes, string name, FileType fileExtension)
        {

            try
            {
                string ftpPath = @"D:\AppImages"; //WebConfigurationManager.AppSettings["PhPersonPhotoPath"];
                string fileName = $"{name}.{GetFileType(fileExtension)}";
                string filePath = $"{ftpPath}/{fileName}";
                File.WriteAllBytes(filePath, imageBytes);
                return fileName;
            }
            catch (Exception ex)
            {
                string message = ex.Message;
                return null;
            }
        }

        
        private static string GetFileType(FileType fileExtension)
        {
            switch (fileExtension)
            {
                case FileType.JPEG:
                    fileExtension = FileType.JPEG;
                    break;
                case FileType.DOCX:
                    fileExtension = FileType.DOCX;
                    break;
                case FileType.PDF:
                    fileExtension = FileType.PDF;
                    break;
            }

            return fileExtension.ToString();
        }
        public static byte[] GetPhoto(string FileNameFromDb)
        {
            byte[] image = null;
            try
            {
                if (!string.IsNullOrEmpty(FileNameFromDb))
                {
                    string fileExtension = "jpeg";
                    string ftpPath = @"D:\AppImages"; 
                    string fullFilePath = Path.Combine(ftpPath, FileNameFromDb.ToUpper());
                    image = File.ReadAllBytes(fullFilePath);
                }
                else
                {
                    // physicalPersonPhoto = NoImage;
                }
                return image;
            }
            catch (Exception ex)
            {
                //string message = ex.Message;
                //physicalPersonPhoto = NoImage;
                return image;
            }
        }
    }
}
