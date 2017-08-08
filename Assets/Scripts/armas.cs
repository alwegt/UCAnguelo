using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
 
 [XmlRoot("datosarmas")]
 public class Armas
 {
 	[XmlArray("armas"),XmlArrayItem("arma")]
 	public arma[] armas;
 
 	public void Save(string path)
 	{
 		var serializer = new XmlSerializer(typeof(Armas));
 		using(var stream = new FileStream(path, FileMode.Create))
 		{
 			serializer.Serialize(stream, this);
 		}
 	}
 
 	public static Armas Load(string path)
 	{
 		var serializer = new XmlSerializer(typeof(Armas));
 		using(var stream = new FileStream(path, FileMode.Open))
 		{
 			return serializer.Deserialize(stream) as Armas;
 		}
 	}
 
         //Loads the xml directly from the given string. Useful in combination with www.text.
         public static Armas LoadFromText(string text) 
 	{
 		var serializer = new XmlSerializer(typeof(Armas));
 		return serializer.Deserialize(new StringReader(text)) as Armas;
 	}
 }