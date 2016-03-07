using UnityEngine;
using System.Collections;

public class PlayerAttackController : MonoBehaviour {
	public ActionController actCont;
	public ActionController coled;
    public GuiController gCont;
	bool inside;
    float sTIme,hc;
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
                    sTIme = Time.time;
                    StartCoroutine(ch());
                    
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
    IEnumerator ch()
    {
        if(Time.time - sTIme < 10)
        {
            gCont.showSlider(hc);
            if (Input.GetKeyDown(KeyCode.Space)) hc++;
            else hc--;
        }
        else
        {
            gCont.hideSLider();
            actCont.grabAmmy(coled.GetComponent<ActionController>());
            Destroy(coled.gameObject);
        }
        yield return new WaitForSeconds(0.5f);
    }
}
