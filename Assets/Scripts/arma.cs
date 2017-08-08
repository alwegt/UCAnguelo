using System.Xml;
using System.Xml.Serialization;

public class arma
{
	[XmlAttribute("nombre")]
	public string nombre;
	public string tipo;
	public int bonvida;
	public int bonener;
	public int boncaos;
	public int bonata;
	public int bondef;
	public int bonvel;
	public int bonsue;

	public string Nombre{
		get{return nombre;}
	}

	public string Tipo{
		get{return tipo;}
	}
	
	public int Bonvida{
		set{bonvida = value;}
		get{return bonvida;}
	}

	public int Bonenergia{
		set{bonener = value;}
		get{return bonener;}
	}

	public int Boncaos{
		set{boncaos = value;}
		get{return boncaos;}
	}

	public int Bonataque{
		set{bonata = value;}
		get{return bonata;}
	}

	public int Bondefensa{
		set{bondef = value;}
		get{return bondef;}
	}

	public int Bonvelocidad{
		set{bonvel = value;}
		get{return bonvel;}
	}

	public int Bonsuerte{
		set{bonsue = value;}
		get{return bonsue;}
	}
}