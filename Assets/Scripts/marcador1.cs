using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class marcador1 : MonoBehaviour {

	private int goles = 0;
	Text texto; 

	void Start(){
		texto = GetComponent<Text> ();
	}

	public void suma_goles(int cantidad){
		goles = goles + cantidad; //monedas += cantidad;
		if (goles < 0) {
			goles = 0;
		}
		texto.text = goles.ToString ();
	}

	public void resetear(){
		goles = 0;
		texto.text = goles.ToString ();
	}
}
