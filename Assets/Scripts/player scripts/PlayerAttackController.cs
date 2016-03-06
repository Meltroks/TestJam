using UnityEngine;
using System.Collections;

public class PlayerAttackController : MonoBehaviour {
	public ActionController actCont;
	public ActionController coled;
	bool inside;

	public void makeHit(float h){
		if(Input.GetKeyDown(KeyCode.P)){
			if(inside){
				if(coled!=null){
					coled.getHit(h);
					actCont.makeHit();
				}
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
