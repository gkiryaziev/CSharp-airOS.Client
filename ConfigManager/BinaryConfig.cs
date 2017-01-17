using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ConfigManager
{
    public class BinaryConfig
    {
        private BinaryFormatter formatter = new BinaryFormatter();

        private string _file;

        public BinaryConfig() {}

        public BinaryConfig(string file)
        {
            _file = file;
        }

        //---------------------------------
        // Write data to file
        //---------------------------------
        public void Write(object model)
        {
            _write(model);
        }

        //---------------------------------
        // Write data to file
        //---------------------------------
        public void Write(object model, string file)
        {
            _file = file;
            _write(model);
        }

        //---------------------------------
        // Read data from file
        //---------------------------------
        public object Read()
        {
            return _read();
        }

        //---------------------------------
        // Read data from file
        //---------------------------------
        public object Read(string file)
        {
            _file = file;
            return _read();
        }

        //---------------------------------
        // Read data from file Main
        //---------------------------------
        private object _read()
        {
            if (_file == null || _file.Length <= 0)
                throw new ArgumentNullException("file");

            using (FileStream fs = new FileStream(_file, FileMode.OpenOrCreate))
            {
                return formatter.Deserialize(fs);
            }
        }

        //---------------------------------
        // Write data to file Main
        //---------------------------------
        private void _write(object model)
        {
            if (_file == null || _file.Length <= 0)
                throw new ArgumentNullException("file");

            using (FileStream fs = new FileStream(_file, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, model);
            }
        }
    }
}
