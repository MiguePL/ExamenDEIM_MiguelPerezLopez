using UnityEngine;
using System.Collections;

public class jugador1 : MonoBehaviour {
	public float velocidad = 5f;
	private Rigidbody2D rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
			rb.velocity = new Vector2 (velocidad, rb.velocity.y);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			rb.velocity = new Vector2 (-velocidad, rb.velocity.y);

		}
		if (Input.GetKey (KeyCode.UpArrow)) {
			rb.velocity = new Vector2 (velocidad, rb.velocity.x);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			rb.velocity = new Vector2 (-velocidad, rb.velocity.x);

		}
	}
}
