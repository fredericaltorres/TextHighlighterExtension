using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Reflection; 
using System.IO.Compression;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using DynamicSugar;
using System.Drawing;
using System.Windows.Media.Imaging;
using System.Windows.Forms;

namespace Util {

    public class MultiValue { 

        List<object> _values;

        public MultiValue(){

            _values = new List<object>();
        }
        public MultiValue Add(object i) { 

            this._values.Add(i);
            return this;
        }
        public T Value<T>() { 

            T i = (T)this._values[0];
            this._values.RemoveAt(0);
            return i;
        }
        public int Count {
            get { 
                return this._values.Count;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class UtilException: System.Exception {

       public UtilException(string message): base(message){
       
       }
    }

    public class Utility {

        public class ListView {

            public static System.Windows.Forms.TreeNode AddNode(System.Windows.Forms.TreeNodeCollection parentNodes, string text, int imageIndex, object tag)
            {
                System.Windows.Forms.TreeNode n = parentNodes.Add(text);
                n.ImageIndex            = imageIndex;
                n.SelectedImageIndex    = imageIndex;
                n.Tag                   = tag;
                return n;
            }
            public static System.Windows.Forms.ListViewItem GetListViewItem(string text, System.Windows.Forms.ListView lv, int colIndex) {

                foreach(var i in lv.Items) {
                    var lvi   = i as System.Windows.Forms.ListViewItem;
                    var text2 = lvi.SubItems[colIndex].Text;
                    if(text2 == text)
                        return lvi;
                }
                return null;
            }
        }
                        
        public static string Localize(bool b) {

            return b ? "Yes" : "No";
        }

        public static bool MsgBoxYesNo(string message)
        {
            return System.Windows.Forms.MessageBox.Show(message, "TextHighlighterExtension", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        public static void MsgBox(string message, System.Exception ex)
        {
            MsgBox("{0}\n{1}".format(message, ex.ToString()));
        }

        public static void MsgBox(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK);
        }

        public static void MsgBoxError(string message)
        {
            System.Windows.Forms.MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static Image GetImage(string fileName)
        {
            var p = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var f = @"{0}\{1}".format(p, fileName);
            if (System.IO.File.Exists(f))
                return Bitmap.FromFile(f);
            return null;
        }

        public static System.Windows.Media.ImageSource GetBitmapImage(string fileName)
        {
            System.Windows.Media.ImageSource i = new BitmapImage(new Uri("images/{0}".format(fileName), UriKind.Relative));
            var w = i.Width;
            return i;
        }
        public static bool IsInt(string v){ 

            int i=0;
            return int.TryParse(v, out i);
        }
        public static string GetFQNPathForImage(string fileName) { 
            
            var p = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            return String.Format(@"{0}\Images\{1}", p, fileName);
        }   
        public static MultiValue SplitDomainUserName(string domainBackSlashUserName) {

            if (domainBackSlashUserName.Contains("\\")) { 

                string [] v = domainBackSlashUserName.Split('\\');
                MultiValue values = new MultiValue();
                values.Add(v[0]);
                values.Add(v[1]);
                return values;
            }
            throw new UtilException(String.Format("Invalid domain\\username string '{0}'", domainBackSlashUserName));
        }

        //
        // http://www.7-zip.org/download.html
        // http://www.eggheadcafe.com/tutorials/aspnet/064b41e4-60bc-4d35-9136-368603bcc27a/7zip-lzma-inmemory-com.aspx
        // 
        #if LZMA

            public static string ZipBase64(string s) { 

                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, s);
                byte[] inbyt = ms.ToArray();
                byte[] b = SevenZip.Compression.LZMA.SevenZipHelper.Compress(inbyt);
                string ZippedBased64 = Convert.ToBase64String(b);
                return ZippedBased64;
            }
            public static string UnZipBase64(string s) {

                byte[] bytCook = Convert.FromBase64String(s);
                byte[] outByt = SevenZip.Compression.LZMA.SevenZipHelper.Decompress(bytCook);
                MemoryStream outMs = new MemoryStream(outByt);
                outMs.Seek(0, 0);
                BinaryFormatter bf = new BinaryFormatter();                
                string retval = (string)bf.Deserialize(outMs, null);
                return retval;
            }

        #else


            public static string ZipBase64(string s) { 

                BinaryFormatter bf = new BinaryFormatter();
                MemoryStream ms = new MemoryStream();
                bf.Serialize(ms, s);
                byte[] inbyt = ms.ToArray();
                System.IO.MemoryStream objStream = new MemoryStream();
                System.IO.Compression.DeflateStream objZS = new System.IO.Compression.DeflateStream(objStream, System.IO.Compression.CompressionMode.Compress);
                objZS.Write(inbyt, 0, inbyt.Length);
                objZS.Flush();
                objZS.Close();
                byte[] b = objStream.ToArray();
                string ZippedBased64 = Convert.ToBase64String(b);
                return ZippedBased64;
            }
            public static string UnZipBase64(string s) {

                byte[] bytCook = Convert.FromBase64String(s);
                MemoryStream inMs = new MemoryStream(bytCook);
                inMs.Seek(0, 0);
                DeflateStream zipStream = new DeflateStream(inMs, CompressionMode.Decompress, true);
                byte[] outByt = __UnZipBase64_ReadFullStream(zipStream);
                zipStream.Flush();
                zipStream.Close();
                MemoryStream outMs = new MemoryStream(outByt);
                outMs.Seek(0, 0);
                BinaryFormatter bf = new BinaryFormatter();                
                string retval = (string)bf.Deserialize(outMs, null);
                return retval;
            }
        #endif

        private static byte[] __UnZipBase64_ReadFullStream(Stream stream)
        {
            byte[] buffer = new byte[32768];
            using (MemoryStream ms = new MemoryStream())
            {
                while (true)
                {
                    int read = stream.Read(buffer, 0, buffer.Length);
                    if (read <= 0)
                        return ms.ToArray();
                    ms.Write(buffer, 0, read);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool IsOdd(int i) {

            return ! IsEven(i);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool IsEven(int i) { 

            return i % 2 == 0;
        }

        public static string ToString(object o, string propertiesCsv){

            System.Text.StringBuilder b = new StringBuilder(1024);

            foreach(string n in propertiesCsv.Split(',')){

                if(PropertyExist(o,n)){

                    object v = GetProperty(o,n);
                    if(v==null){ v = "null"; }
                    if(v==DBNull.Value){ v = "DBNull"; }
                    b.AppendFormat("{0}={1},", n,v);
                }
            }
            string s = b.ToString();
            return Utility.RemoveLastCharIf(s,',');
        }

        public static bool PropertyExist(object o, string propertyName){
            try{
			    object oValue =	o.GetType().InvokeMember(propertyName,
					    BindingFlags.Instance	|
					    BindingFlags.Public		|
					    BindingFlags.NonPublic	|
					    BindingFlags.GetField	|
					    BindingFlags.GetProperty|
					    BindingFlags.IgnoreCase ,
					    null,o,null);
			    return true;
            }
            catch{
                return false;
            }
		}
		public static object GetProperty(object o, string propertyName){
            try{
			    object oValue =	o.GetType().InvokeMember(propertyName,
					    BindingFlags.Instance	|
					    BindingFlags.Public		|
					    BindingFlags.NonPublic	|
					    BindingFlags.GetField	|
					    BindingFlags.GetProperty|
					    BindingFlags.IgnoreCase ,
					    null,o,null);
			    return oValue;
            }
            catch{
                return null;
            }
		}

        public static List<string> MakeListString(string text, char separator) {

            List<string> l = new List<string>();

            string [] defines = text.Split(separator);

            foreach(string s in defines)
                l.Add(s);

            return l;
        }
        
        public static List<string> MakeListString(params string[] defines) {

            List<string> l = new List<string>();
            foreach(string s in defines)
                l.Add(s);

            return l;
        }
       
        public static System.Collections.ArrayList StringListToArrayList(List<string> l) { 

            System.Collections.ArrayList a = new System.Collections.ArrayList();

            l.ForEach( s => a.Add(s) );

            return  a;
        }
       
        public static string ToCSVSingleQuoted(List<string> l) { 

            System.Text.StringBuilder b = new StringBuilder(1024);

            foreach (string s in l) { 

                b.AppendFormat("'{0}',",s.Replace("'","\\'"));
            }
            return RemoveLastChar(b.ToString());
        }
        // TODO:Write unit test
        public static string ToCSV(List<string> l) { 

            System.Text.StringBuilder b = new StringBuilder(1024);

            foreach (string s in l) { 

                b.AppendFormat("{0},",s);
            }
            return RemoveLastChar(b.ToString());
        }
        // TODO:Write unit test
        public static string ToCSV(System.Collections.ArrayList l) { 

            System.Text.StringBuilder b = new StringBuilder(1024);

            foreach (string s in l) { 

                b.AppendFormat("{0},",s);
            }
            return RemoveLastChar(b.ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveFirstChar(string s) {

            if (String.IsNullOrEmpty(s)) {

                return s;
            }
            else { 
                return s.Substring(1);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string RemoveFirstCharIf(string s, char c) {

            if (String.IsNullOrEmpty(s)) {

                return s;
            }
            else {
                if (s[0] == c) {

                    return RemoveFirstChar(s);
                }
                else {
                    return s;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public static string RemoveLastCharIf(string s, char c) {

            if (String.IsNullOrEmpty(s)) {

                return s;
            }
            else {
                if (s[s.Length - 1] == c) {

                    return RemoveLastChar(s);
                }
                else {
                    return s;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RemoveLastChar(string s) {

            if (String.IsNullOrEmpty(s)) {

                return s;
            }
            else { 
                return s.Substring(0, s.Length-1);
            }
        }
        public static bool DeleteFile(string fileName){			
			try{				
                if(System.IO.File.Exists(fileName))
                    System.IO.File.Delete(fileName);
                return true;
			}
			catch{
				return false;
			}
		}	
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string LoadFile(string fileName){
			
			StreamReader m_objStreamIn;
			FileStream   m_objFileStream;
			try{				
				m_objFileStream = new FileStream(fileName,FileMode.Open,FileAccess.Read,FileShare.Read);
				m_objStreamIn	= new StreamReader(m_objFileStream);			
				string s = m_objStreamIn.ReadToEnd();
				m_objStreamIn.Close();			
				return s;
			}
			catch{

                throw;
			}
		}
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static string LoadFirstFile(string fileName) {

            StreamReader m_objStreamIn;
            FileStream m_objFileStream;
            try {
                m_objFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
                m_objStreamIn = new StreamReader(m_objFileStream);
                string s = m_objStreamIn.ReadLine();
                m_objStreamIn.Close();
                return s;
            }
            catch {
                 
                throw;
            }
        }	

	    /// <summary>
	    /// 
	    /// </summary>
	    /// <param name="fileName"></param>
	    /// <param name="text"></param>
	    /// <param name="CreateFile"></param>
	    /// <returns></returns>
        public static bool LogFile(string fileName, string text, bool CreateFile){
			
			StreamWriter m_objStreamOut;
			FileStream   m_objFileStream;

			try{
				if(CreateFile){

					try{ System.IO.File.Delete(fileName); }catch{}
					
					m_objFileStream = new FileStream(fileName,FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
					m_objStreamOut	= new StreamWriter(m_objFileStream);
				}
				else{
					m_objFileStream = new FileStream(fileName,FileMode.Append,FileAccess.Write,FileShare.ReadWrite);
					m_objStreamOut	= new StreamWriter(m_objFileStream);
				}
				m_objStreamOut.WriteLine(text);
				m_objStreamOut.Close();			
				return true;
			}
			catch{
				
				return false;
			}
		}	


               /// <summary>
        /// Return if we are running in x86 32b or x64 64 bit
        /// F#522 - FRED - 2010.1.29 - Support for Installation on SQL 2008
        /// </summary>
        /// <returns></returns>
        public static string x86x64() {

            if (IntPtr.Size == 4) {

                return "x86";
            }
            else if (IntPtr.Size == 8) {
                return "x64";
            }
            else  {
                return String.Format("unknown IntPtr.Size:{0}",IntPtr.Size);
            }
        }
        /// <summary>
        /// In v 3.2 this is only used by the unit test
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string ToBase64_UT8Encoding(string s) { 

            return Convert.ToBase64String( ASCIIEncoding.UTF8.GetBytes(s) );
        }
        /// <summary>
        /// This method is used to read base64 string encoded on the client side with JavaScript.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string FromBase64_UT8Encoding(string s) { 
            
            return Encoding.UTF8.GetString(Convert.FromBase64String(s));
        }
    }


}
