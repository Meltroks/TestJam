using UnityEngine;
using System.Collections;

public class EnemyMovingController : MonoBehaviour {
	public float speed;
	public Transform[] mPoints;
	bool moving;
	int i;
	Transform cPoint;

	void Update(){
		cPoint = mPoints[i];
		if(moving){
			if(transform.position!=cPoint.position){
				transform.position = Vector3.MoveTowards(transform.position,cPoint.position,speed*Time.deltaTime);
			}
			else{
				i = (i+1)%mPoints.Length;
			}
		}
		moving = false;
	}

	public void move(){
		moving=true;
	}
}
