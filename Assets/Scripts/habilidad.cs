using System.Xml;
using System.Xml.Serialization;

public class habilidad
{
	[XmlAttribute("nombre")]
	public string nombre;
	public string tipo;
	public int coste;
	public int nivel;

	public string Nombre{
		set{nombre=value;}
		get{return nombre;}
	}

	public string Tipo{
		set{tipo=value;}
		get{return tipo;}
	}

	public int Coste{
		set{coste=value;}
		get{return coste;}
	}

	public int Nivel{
		set{nivel=value;}
		get{return nivel;}
	}
} 