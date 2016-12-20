using UnityEngine;
using System.Collections;

public class Nave : MonoBehaviour {
	private Rigidbody2D rb;
	public float power = 1f;
	public float velocidad = 5f;
	public float salto = 400;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("right")) {
			rb.velocity = new Vector2 (velocidad * power, rb.velocity.y);
		}
		if (Input.GetKeyDown ("left")) {
			rb.velocity = new Vector2 (-velocidad * power, rb.velocity.y);

		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (new Vector2 (0, salto));
		}
	
	}
}
