using UnityEngine;
public class Karakter 
{
	private string name;
	private int health;
	private int damage;

	public string Name 
	{ get 
		{ return name;
		} set 
		{ name = value;
}
} 
 public int Health 
{ get 
	{ return health ;
	}
	set 
		{ health = value ;
		}
	}
	public int Damage 
	{ get 
		{ return damage; 
		} set 
		{ damage = value ;
		}
	}
	public void Moveleft() 
	{ 
		Debug.Log (" Gerak ke kiri ");
	}
	public void Moveright()

	{ Debug.Log (" Gerak ke Kanan ");
	}
	public void Jump ()

	{ 
		Debug.Log ("Loncat");
	}
	public void attack()
	{ 
		Debug.Log (" Serang ");
	}
}