using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCloaker
{
    internal class Variables
    {

        public string toCipher { get; set; }
        public List<string> cipherArray { get; set; }

        public byte[] base64byte { get; set; }
        public string[] ciphered { get; set; }
        public string FileName { get; set; }
        public string HWID { get; set; }
        public string FillerPath { get; set; }
        public string DefillerPath { get; set; }
        public string CiphersEncryptionKey{get; set;}
    }
}
