using System.Xml;
using System.Xml.Serialization;

public class enemigo : personaje
{
	public int exp;

	public int Experiencia{
		set{exp=value;}
		get{return exp;}
	}
}