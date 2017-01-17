using System;
using System.IO;
using System.Security.Cryptography;

namespace CryptoManager
{
    public class AesCrypto
    {
        byte[] _key;
        byte[] _iv;

        public AesCrypto() {}

        public AesCrypto(byte[] key, byte[] iv)
        {
            _key = key;
            _iv = iv;
        }

        //---------------------------------
        // AES Encrypt Method
        //---------------------------------
        public byte[] Encrypt(string text)
        {
            return _encrypt(text);
        }

        //---------------------------------
        // AES Encrypt Method
        //---------------------------------
        public byte[] Encrypt(string text, byte[] key, byte[] iv)
        {
            _key = key;
            _iv = iv;
            return _encrypt(text);
        }

        //---------------------------------
        // AES Dectypt Method
        //---------------------------------
        public string Dectypt(byte[] text)
        {
            return _dectypt(text);
        }

        //---------------------------------
        // AES Dectypt Method
        //---------------------------------
        public string Dectypt(byte[] text, byte[] key, byte[] iv)
        {
            _key = key;
            _iv = iv;
            return _dectypt(text);
        }

        //---------------------------------
        // AES Encrypt Main Method
        //---------------------------------
        private byte[] _encrypt(string text)
        {
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException("text");
            if (_key == null || _key.Length <= 0)
                throw new ArgumentNullException("key");
            if (_iv == null || _iv.Length <= 0)
                throw new ArgumentNullException("iv");
            byte[] encrypted;

            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, aes.CreateEncryptor(aes.Key, aes.IV), CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(text);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }
            return encrypted;
        }

        //---------------------------------
        // AES Dectypt Main Method
        //---------------------------------
        private string _dectypt(byte[] text)
        {
            if (text == null || text.Length <= 0)
                throw new ArgumentNullException("text");
            if (_key == null || _key.Length <= 0)
                throw new ArgumentNullException("key");
            if (_iv == null || _iv.Length <= 0)
                throw new ArgumentNullException("iv");
            string plaintext;

            using (Aes aes = Aes.Create())
            {
                aes.Key = _key;
                aes.IV = _iv;

                using (var msDecrypt = new MemoryStream(text))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, aes.CreateDecryptor(aes.Key, aes.IV), CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return plaintext;
        }
    }
}
