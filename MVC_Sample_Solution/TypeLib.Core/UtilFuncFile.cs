using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TypeLib.Core
{
    public static class UtilFuncFile
    {
        #region Directory Exist Check & Create
        public static bool CheckDirectory(String dirURL)
        {
            //Regex driveCheck = new Regex(@"^[a-zA-Z]:\\$");
            //if (!driveCheck.IsMatch(dirURL.Substring(0, 3)))
            //{
            //    return false;
            //}
            //string strTheseAreInvalidFileNameChars = new string(Path.GetInvalidPathChars());
            //strTheseAreInvalidFileNameChars += @":/?*" + "\"";
            //Regex containsABadCharacter = new Regex("[" + Regex.Escape(strTheseAreInvalidFileNameChars) + "]");
            //if (containsABadCharacter.IsMatch(dirURL.Substring(3, dirURL.Length - 3)))
            //{
            //    return false;
            //}

            DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath(dirURL));
            if (!dir.Exists)
                dir.Create();

            return true;
        }
        #endregion

        #region Directory Exist Check & Delete
        public static bool DeleteDirectory(String dirURL)
        {
            try
            {
                DirectoryInfo dir = new DirectoryInfo(Path.GetFullPath(dirURL));
                if (dir.Exists)
                    dir.Delete(true);
            }
            catch
            {
                return false;
            }

            return true;
        }
        #endregion

        #region XML Write

        #region static void ToXML(Type objType, object obj, string fileName)
        public static void ToXML(Type objType, object obj, string fileName)
        {
            DataContractSerializer serializer = new DataContractSerializer(objType);
            System.IO.StreamWriter sw = null;
            try
            {
                // ensure directory exists.
                string dir = System.IO.Path.GetDirectoryName(fileName);
                CheckDirectory(dir);

                // serialize.
                sw = new System.IO.StreamWriter(fileName);
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    sw = null;
                    writer.Formatting = Formatting.Indented;
                    serializer.WriteObject(writer, obj);
                    writer.Flush();
                }
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                }
            }
        }
        #endregion

        #region static void ToXmlFile<T>(this T obj, string fileName)
        public static void ToXmlFile<T>(this T obj, string fileName)
        {
            ToXML(typeof(T), obj, fileName);
        }
        #endregion

        #region static string ToXMLString(Type objType, object obj)
        public static string ToXMLString(Type objType, object obj)
        {
            DataContractSerializer serializer = new DataContractSerializer(objType);
            System.IO.StringWriter sw = null;
            StringBuilder sb = new StringBuilder();
            try
            {
                sw = new System.IO.StringWriter(sb);
                using (XmlTextWriter writer = new XmlTextWriter(sw))
                {
                    sw = null;
                    writer.Formatting = Formatting.Indented;
                    serializer.WriteObject(writer, obj);
                    writer.Flush();
                }

                return sb.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                if (sw != null)
                {
                    sw.Dispose();
                }
            }
        }
        #endregion

        #region static string XmlStringFrom(object obj)
        public static string XmlStringFrom(object obj)
        {
            return ToXMLString(obj.GetType(), obj);
        }
        #endregion

        #region static string ToXmlString<T>(this T obj)
        public static string ToXmlString<T>(this T obj)
        {
            return ToXMLString(typeof(T), obj);
        }
        #endregion

        #endregion

        #region XML Read

        #region static object FromXML(Type objType, string fileName)
        public static object FromXML(Type objType, string fileName)
        {
            DataContractSerializer deserializer = new DataContractSerializer(objType);
            System.IO.StreamReader sr = null;

            try
            {
                sr = new System.IO.StreamReader(fileName);
                using (XmlTextReader reader = new XmlTextReader(sr))
                {
                    sr = null;
                    return deserializer.ReadObject(reader);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Dispose();
                }
            }
        }
        #endregion

        #region static T ObjectFromXmlFile<T>(string filePath)
        public static T ObjectFromXmlFile<T>(string filePath)
        {
            return (T)FromXML(typeof(T), filePath);
        }
        #endregion

        #region static object FromXMLString(Type objType, string inXmlString)
        public static object FromXMLString(Type objType, string inXmlString)
        {
            DataContractSerializer deserializer = new DataContractSerializer(objType);
            System.IO.StringReader sr = null;
            try
            {
                sr = new System.IO.StringReader(inXmlString);
                using (XmlTextReader reader = new XmlTextReader(sr))
                {
                    sr = null;
                    return deserializer.ReadObject(reader);
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (sr != null)
                {
                    sr.Dispose();
                }
            }
        }
        #endregion

        #region static T ObjectFromXmlString<T>(string xmlString)
        public static T ObjectFromXmlString<T>(string xmlString)
        {
            return (T)FromXMLString(typeof(T), xmlString);
        }
        #endregion

        #endregion
    }
}
