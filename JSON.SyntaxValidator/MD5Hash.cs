using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace JSON.SyntaxValidator
{
    public class MD5Hash {

        public byte [] Buffer;

        public MD5Hash(byte [] buffer) {

            this.Buffer = buffer;
        }
        public override bool Equals(object obj) {
        
            if(obj is MD5Hash) {

                var o = obj as MD5Hash;

                if(o.Buffer.Length == this.Buffer.Length) {

                    for(var i=0; i<this.Buffer.Length; i++)
                        if(this.Buffer[i] != o.Buffer[i])
                            return false;
                    return true;
                }
            }
            return false;
        }
        public override int GetHashCode()
        {
            return this.Buffer.GetHashCode();
        }

        public static MD5Hash Make(string text) {
          
            MD5 md5           = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(text);
            byte[] hashBuffer = md5.ComputeHash(inputBytes);
            return new MD5Hash(hashBuffer);
        }
    }
}
