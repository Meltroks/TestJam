using UnityEngine;
using System.Collections;

public class StatsController : MonoBehaviour {
	public float lifes;
	public float getLifes(){return lifes;}
	public void hurt(float h){lifes-=h;}
	void Update(){
		if(lifes<=0){
			lifes=0;
		}
	}
}
