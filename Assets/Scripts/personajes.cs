using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
 
 [XmlRoot("datosPersonajes")]
 public class Personajes
 {
 	[XmlArray("Personajes"),XmlArrayItem("personaje")]
 	public personaje[] personajes;
 
 	public void Save(string path)
 	{
 		var serializer = new XmlSerializer(typeof(Personajes));
 		using(var stream = new FileStream(path, FileMode.Create))
 		{
 			serializer.Serialize(stream, this);
 		}
 	}
 
 	public static Personajes Load(string path)
 	{
 		var serializer = new XmlSerializer(typeof(Personajes));
 		using(var stream = new FileStream(path, FileMode.Open))
 		{
 			return serializer.Deserialize(stream) as Personajes;
 		}
 	}
 
         //Loads the xml directly from the given string. Useful in combination with www.text.
         public static Personajes LoadFromText(string text) 
 	{
 		var serializer = new XmlSerializer(typeof(Personajes));
 		return serializer.Deserialize(new StringReader(text)) as Personajes;
 	}
 }