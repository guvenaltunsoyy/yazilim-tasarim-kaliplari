using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrototypePattern
{
    [Serializable]
    public abstract class IPrototypePattern<T>
    {
        // Shallow copy
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        // Deep Copy
        public T DeepCopy()
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            T copy = (T)formatter.Deserialize(stream);
            stream.Close();
            return copy;
        }
    }
}
