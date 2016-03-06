using UnityEngine;
using System.Collections;

public class PlayerMovingController : MonoBehaviour {
	public float speed;
	public GameObject attackCol;

	public void move(){
		Vector2 velDir = new Vector2 (Input.GetAxis ("Horizontal") * speed, Input.GetAxis ("Vertical") * speed);
		if(attackCol!=null && (Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.S)||Input.GetKey(KeyCode.W)))
			attackCol.transform.localPosition = new Vector2(
				(Input.GetKey(KeyCode.A)?-1:0) + (Input.GetKey(KeyCode.D)?1:0),
				(Input.GetKey(KeyCode.S)?-1:0) + (Input.GetKey(KeyCode.W)?1:0)
			);
		GetComponent<Rigidbody2D>().velocity = velDir;
	}
}
