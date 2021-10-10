namespace Common.HttpClinet
{
    public class FileInfoDto
    {
        public FileInfoDto(byte[] file, string fileName, string contentType, string filePropertyName)
        {
            File = file;
            FileName = fileName;
            ContentType = contentType;
            FilePropertyName = filePropertyName;
        }

        public byte[] File { get; }
        public string FileName { get; }
        public string ContentType { get; }
        public string FilePropertyName { get; }
    }
}
