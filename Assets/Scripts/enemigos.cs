using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
 
 [XmlRoot("datosEnemigos")]
 public class Enemigos
 {
 	[XmlArray("Enemigos"),XmlArrayItem("enemigo")]
 	public enemigo[] enemigos;
 
 	public void Save(string path)
 	{
 		var serializer = new XmlSerializer(typeof(Enemigos));
 		using(var stream = new FileStream(path, FileMode.Create))
 		{
 			serializer.Serialize(stream, this);
 		}
 	}
 
 	public static Enemigos Load(string path)
 	{
 		var serializer = new XmlSerializer(typeof(Enemigos));
 		using(var stream = new FileStream(path, FileMode.Open))
 		{
 			return serializer.Deserialize(stream) as Enemigos;
 		}
 	}
 
         //Loads the xml directly from the given string. Useful in combination with www.text.
         public static Enemigos LoadFromText(string text) 
 	{
 		var serializer = new XmlSerializer(typeof(Enemigos));
 		return serializer.Deserialize(new StringReader(text)) as Enemigos;
 	}
 }