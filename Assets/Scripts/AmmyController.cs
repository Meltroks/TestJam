using UnityEngine;
using System.Collections;

public class AmmyController : MonoBehaviour {
	public Ammy cAmmy,sAmmy;
	public float ammyLife;
    public GuiController gCont;

	void Awake(){
		setAmmy(sAmmy);
	}

	void Update(){
		if(ammyLife<=0){
			ammyLife=0;
			cAmmy = null;
		}
	}

	public void hurtAmmy(float h){
		ammyLife-=h;
	}
	public float getH(){
		return (cAmmy!=null?cAmmy.hurtC:0);
	}
	public void setAmmy(Ammy am){
        if (gCont != null)  gCont.showAmmy(am);
        if (am != null)
        {
            cAmmy = am;
            ammyLife = am.lifes;
        }
	}
}
