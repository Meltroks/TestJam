using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxLifes,lifes;
	public float speed;

	void Start () {
		
	}

	void Update () {
		//moving shit
		move();
		
	}
	void move(){
		transform.Translate(transform.right*Input.GetAxis("Horizontal")*speed*Time.deltaTime + transform.up*Input.GetAxis("Vertical")*speed*Time.deltaTime);
	}
}
