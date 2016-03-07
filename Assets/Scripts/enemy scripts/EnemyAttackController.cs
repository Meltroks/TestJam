using UnityEngine;
using System.Collections;

public class EnemyAttackController : MonoBehaviour {
	public ActionController actCont;
	public ActionController coled;
	public float attackCoolDown;
	float lTime;
	bool inside;

	public void makeHit(float h){
		if(inside){
			if(coled!=null && Time.time - lTime>=attackCoolDown){
				coled.getHit(h);
				actCont.makeHit();
				lTime = Time.time;
			}
		}
	}

	void OnTriggerStay2D(Collider2D col){
		if(col.GetComponent<PlayerActionController>()!=null){
			if(col.GetComponent<PlayerActionController>() != actCont){
				inside = true;
				coled = col.GetComponent<PlayerActionController>();
			}
		}	
	}
	void OnTriggerExit2D(Collider2D col){
		inside = false;
		coled = null;
	}
}
