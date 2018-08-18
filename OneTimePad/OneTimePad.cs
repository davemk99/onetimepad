using System;
using System.Collections.Generic;
using System.Text;

namespace OneTimePad
{
    public static class OneTimePad
    {
        public static byte[] Encrypt(byte[] key, byte[] message)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            if (message == null)
            {
                throw new ArgumentNullException("message");
            }
            if (key.Length != message.Length)
            {
                throw new ArgumentException("Key and message length must be equal");
            }
            return EncryptMessage(key, message);
        }

        private static byte[] EncryptMessage(byte[] key, byte[] message)
        {
            var cipher = new byte[key.Length];
            for (int i = 0; i < cipher.Length; i++)
            {
                cipher[i] = (byte)(key[i] ^ message[i]);
            }
            return cipher;
        }

        public static byte[] Decrypt(byte[] key, byte[] cipher)
        {
            if (key == null)
            {
                throw new ArgumentNullException("key");
            }
            if (cipher == null)
            {
                throw new ArgumentNullException("message");
            }
            if (key.Length != cipher.Length)
            {
                throw new ArgumentException("Key and message length must be equal");
            }
            return DecryptCipher(key, cipher);
        }

        private static byte[] DecryptCipher(byte[] key, byte[] cipher)
        {
            var message = new byte[key.Length];
            for (int i = 0; i < message.Length; i++)
            {
                message[i] = (byte)(key[i] ^ cipher[i]);
            }
            return message;
        }
    }
}