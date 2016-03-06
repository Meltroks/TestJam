using UnityEngine;
using System.Collections;

public class EnemyActionController : ActionController {
	public bool active;
	public StatsController statsCont;
	public AmmyController ammyCont;
	public EnemyAttackController attCont;
	public EnemyMovingController movCont;

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
			attCont.makeHit(ammyCont.getH());
			movCont.move();
		}
	}
	void die(){
		Debug.Log("i die!");
		gameObject.SetActive(false);
	}
}
