using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Latihan3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		int c = Jumlah (60, 40);
		Debug.Log ("Hasil Jumlah a dan b adalah" + c);

	}
	
	// Update is called once per frame
	void Update () {
	}
	/// <summary>
	/// Merupakan fungsi penjumlahan dari 2 input angka
	/// </summary>
	/// <param name="a">The alpha component.</param>
	/// <param name="b">The blue component.</param>
	int Jumlah(int a , int b )
	{ 
		return a + b;
	}
}
