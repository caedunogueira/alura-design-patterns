using System.IO;
using System.Xml.Serialization;

namespace DesignPatterns2.Cap8
{
    public class GeradorDeXml<T>
    {
        public string GeraXml(T instance)
        {
            var serializer = new XmlSerializer(instance.GetType());
            using var writer = new StringWriter();
            serializer.Serialize(writer, instance);

            return writer.ToString();
        }
    }
}
