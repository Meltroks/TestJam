using UnityEngine;
using System.Collections;

public class EnemyMovingController : MonoBehaviour {
	public float speed;
	public Transform[] mPoints;
	bool moving;
	int i;
	Transform cPoint;
    public ActionController actCol;


	void Update(){
		cPoint = mPoints[i];
		if(moving){
			if(transform.position.x!=cPoint.position.x){
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(cPoint.position.x, transform.position.y, 0), speed * Time.deltaTime * actCol.getTime());
			}
            else if (transform.position.y != cPoint.position.y)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, cPoint.position.y, 0), speed * Time.deltaTime * actCol.getTime());
            }
            else
            {
				i = (i+1)%mPoints.Length;
			}
		}
		moving = false;
	}

	public void move(){
		moving=true;
	}
}
