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
		if(col.GetComponent<ActionController>()!=null){
			if(col.GetComponent<ActionController>() != actCont){
				inside = true;
				coled = col.GetComponent<ActionController>();
			}
		}	
	}
	void OnTriggerExit2D(Collider2D col){
		inside = false;
		coled = null;
	}
}
