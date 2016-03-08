using UnityEngine;
using System.Collections;

public class StatsController : MonoBehaviour {
	public float lifes,maxLifes;
    public float power;
	public float getLifes(){return lifes;}
    public float getMaxLifes() { return maxLifes; }
    public float getPower() { return power; }
	public void hurt(float h){lifes-=h;}
	void Update(){
		if(lifes<=0){
			lifes=0;
		}
	}
}
