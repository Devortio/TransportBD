using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Model;

namespace TransportBD
{
    class Serialization
    {
        public static void Serialize(string filePath,List<ITransport> testList)
        {
            if (File.Exists(filePath)) File.Delete(filePath);

            var formatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fileStream, testList);
                fileStream.Close();
            }
        }

        public static List<ITransport> Deserialize(string filePath) 
        {
            var formatter = new BinaryFormatter();

            using (FileStream fileStream = File.OpenRead(filePath))
            {
                List<ITransport> tesList = (List<ITransport>)formatter.Deserialize(fileStream);               
                return tesList;
            }
        }
    }
}
