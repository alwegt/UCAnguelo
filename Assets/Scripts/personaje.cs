using System.Xml;
using System.Xml.Serialization;
using System;

public class personaje
{
	[XmlAttribute("nombre")]
	public string nombre; 
	public int vidamax; 
	public int enermax;
	public int caosmax;
	public int ataque;
	public int defensa;
	public int velocidad;
	public int suerte;
	private int vida=0;
	private int energia=0;
	private int caos=0;

	private int iniciar{
		set{
			vida = vidamax;
			energia = enermax;
		}
	}

	public string Nombre{
		set{nombre=value;}
		get{return nombre;}
	}

	public int VidaMax{
		set{vidamax = value;}
		get{return vidamax;}
	}

	public int EnerMax{
		set{enermax = value;}
		get{return enermax;}
	}

	public int CaosMax{
		set{caosmax = value;}
		get{return caosmax;}
	}
	public int Vida{
		set{
			vida = value;
			if(vida>=vidamax){vida=vidamax;}
			if(vida <=0){vida=0;}
		}
		get{return vida;}
	}

	public int Energia{
		set{
			energia = value;
			if(energia>=enermax){energia=enermax;}
			if(energia <=0){energia=0;}
		}
		get{return energia;}
	}

	public int Caos{
		set{
			caos = value;
			if(caos>=caosmax){caos=caosmax;}
			if(caos<=0){caos=0;}
		}
		get{return caos;}
	}

	public int Ataque{
		set{ataque = value;}
		get{return ataque;}
	}

	public int Defensa{
		set{defensa = value;}
		get{return defensa;}
	}

	public int Velocidad{
		set{velocidad = value;}
		get{return velocidad;}
	}

	public int Suerte{
		set{suerte = value;}
		get{return suerte;}
	}
	public void Armar(arma arma)
	{
			this.Vida+=arma.Bonvida;
			this.Energia+=arma.Bonenergia;
			this.Caos+=arma.Boncaos;
			this.VidaMax+=arma.Bonvida;
			this.EnerMax+=arma.Bonenergia;
			this.CaosMax+=arma.Boncaos;
			this.Ataque+=arma.Bonataque;
			this.Defensa+=arma.Bondefensa;
			this.Velocidad+=arma.Bonvelocidad;
			this.Suerte+=arma.Bonsuerte;
	}

	public void Desarmar(arma arma)
	{
			this.Vida-=arma.Bonvida;
			this.Energia-=arma.Bonenergia;
			this.Caos-=arma.Boncaos;
			this.VidaMax-=arma.Bonvida;
			this.EnerMax-=arma.Bonenergia;
			this.CaosMax-=arma.Boncaos;
			this.Ataque-=arma.Bonataque;
			this.Defensa-=arma.Bondefensa;
			this.Velocidad-=arma.Bonvelocidad;
			this.Suerte-=arma.Bonsuerte;
	}

	public int Atacar()
	{
		Random pruebavel = new Random();
		Random pruebasue = new Random();
		Random final = new Random();
		int atk = this.Ataque + (this.Velocidad*(pruebavel.Next(0,11)))+(this.Suerte*(pruebasue.Next(0,11)));
		return final.Next(atk-5,atk+6);
	}

	public int Defender()
	{
		Random pruebavel = new Random();
		Random pruebasue = new Random();
		Random final = new Random();
		int def = this.Defensa + (this.Velocidad*(pruebavel.Next(0,11)))+(this.Suerte*(pruebasue.Next(0,11)));
		return final.Next(def-5,def+6);
	}

	public bool EstaVivo()
	{
		if(Vida==0)
			return false;
		return true;

	}

}