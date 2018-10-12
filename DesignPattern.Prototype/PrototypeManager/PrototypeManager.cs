using System.Collections.Generic;

namespace DesignPattern.Prototype.PrototypeManager
{
    public class PrototypeManager
    {
        private Dictionary<string, OfficeDocument> dictOD = new Dictionary<string, OfficeDocument>();

        public static PrototypeManager GetInstance()
        {
            return Nested.instance;
        }

        class Nested
        {
            static Nested() { }
            internal static readonly PrototypeManager instance = new PrototypeManager();
        }

        private PrototypeManager()
        {
            dictOD.Add("FAR", new FAR());
            dictOD.Add("SRS", new SRS());
        }

        public void AddOfficeDocument(string key, OfficeDocument doc)
        {
            dictOD.Add(key, doc);
        }

        public OfficeDocument GetOfficeDocumentByKey(string key)
        {
            key = key.ToUpper();
            if (!dictOD.ContainsKey(key))
            {
                return null;
            }

            return dictOD[key].Clone();
        }
    }
}
