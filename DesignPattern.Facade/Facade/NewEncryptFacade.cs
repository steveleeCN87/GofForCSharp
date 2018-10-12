using DesignPattern.Facade.Subsystem;

namespace DesignPattern.Facade.Facade
{
    public class NewEncryptFacade : AbstractEncryptFacade
    {
        private FileReader reader;
        private NewCipherMachine cipher;
        private FileWriter writer;

        public NewEncryptFacade()
        {
            reader = new FileReader();
            cipher = new NewCipherMachine();
            writer = new FileWriter();
        }

        public override void FileEncrypt(string fileNameSrc, string fileNameDes)
        {
            string plainStr = reader.Read(fileNameSrc);
            string encryptedStr = cipher.Encrypt(plainStr);
            writer.Write(encryptedStr, fileNameDes);
        }
    }
}
