using UnityEngine;
using System.Collections;

public class AmmyController : MonoBehaviour {
	public Ammy cAmmy,sAmmy;
	public float ammyLife;

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
		cAmmy = am;
		ammyLife = am.lifes;
	}
}
