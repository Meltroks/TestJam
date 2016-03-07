using UnityEngine;
using System.Collections;

public class ActionController : MonoBehaviour {
	public virtual void getHit(float h){}
	public virtual void makeHit(){}
    public virtual void getItem(Item item) { }
    public virtual void grabAmmy(ActionController ammyActCont) { }
    public virtual void setTime(float time){}
    public virtual float getTime() { return 0; }
}
