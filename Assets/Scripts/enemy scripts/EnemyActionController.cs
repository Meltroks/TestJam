using UnityEngine;
using System.Collections;

public class EnemyActionController : ActionController {
	public bool active;
	public StatsController statsCont;
	public AmmyController ammyCont;
	public EnemyAttackController attCont;
	public EnemyMovingController movCont;
    public Ammy myAmmy;

    public float time;

    public override void setTime(float time)
    {
        this.time = time;
    }
    public override float getTime()
    {
        return time;
    }

    public override void getHit(float h){
		statsCont.hurt(h);
	}
	public override void makeHit(){
		//some shit later
	}
	void Update(){
		if(statsCont.getLifes()<=0){
			active = false;
			die();
		}
		if(active){
			attCont.makeHit(ammyCont.getH()*statsCont.getPower());
			movCont.move();
		}
	}
	void die(){
		Debug.Log("i die!");
        Destroy(transform.gameObject);
	}
}
