using UnityEngine;
using System.Collections;

public class PlayerActionController : ActionController {
	public bool active;
	public PlayerMovingController movCont;
	public PlayerAttackController attCont;
	public StatsController statsCont;
	public AmmyController ammyCont;

	public override void getHit(float h){
		statsCont.hurt(h);
		Debug.Log("got hit "+h);
	}
	public override void makeHit(){
		Debug.Log("you made hit ");
		ammyCont.hurtAmmy(ammyCont.getH());
	}
	void Update(){
		if(statsCont.getLifes()<=0){
			active = false;
		}
		if(active){
			attCont.makeHit(ammyCont.getH());
			movCont.move();
		}
	}
}
