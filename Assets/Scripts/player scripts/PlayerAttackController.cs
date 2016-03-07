using UnityEngine;
using System.Collections;

public class PlayerAttackController : MonoBehaviour {
	public ActionController actCont;
	public ActionController coled;
    public GuiController gCont;
	bool inside;
    public float sTIme,hc;

    
	public void makeHit(float h){
		if(Input.GetKeyDown(KeyCode.P)){
			if(inside){
				if(coled!=null){
					coled.getHit(h);
					actCont.makeHit();
				}
			}
		}
        if (Input.GetKeyDown(KeyCode.O))
        {
            if (inside)
            {
                if (coled != null)
                {
                    if(coled.GetComponent<EnemyActionController>()!=null){
                        hc = 50;
                        sTIme = Time.time;
                        StartCoroutine(ch(coled.GetComponent<EnemyActionController>()));
                    }
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
    IEnumerator ch(EnemyActionController enAct)
    {
        if(Time.time - sTIme < 10)
        {
            gCont.showSlider(hc);
            if (Input.GetKeyDown(KeyCode.Space)) hc=(hc+5)%100;
            else hc-=1;
            if(hc<0) hc = 0;
            yield return new WaitForSeconds(0.01f);
            StartCoroutine(ch(enAct));
        }
        else
        {
            gCont.hideSLider();
            actCont.getHit(Mathf.Abs(hc-50));
            actCont.grabAmmy(enAct);
            Destroy(enAct.gameObject);
        }
    }
}
