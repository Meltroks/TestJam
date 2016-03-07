using UnityEngine;
using System.Collections;

public class PlayerActionController : ActionController {
	public bool active;
	public PlayerMovingController movCont;
	public PlayerAttackController attCont;
    public PlayerInventoryController invCont;
    public StatsController statsCont;
	public AmmyController ammyCont;
    public GuiController gCont;

	public float time;

    public override void setTime(float time){
        this.time = time;
    }
    public override float getTime()
    {
        return time;
    }
    public override void getHit(float h){
		statsCont.hurt(h);
		Debug.Log("got hit "+h);
	}
	public override void makeHit(){
		Debug.Log("you made hit ");
		ammyCont.hurtAmmy(ammyCont.getH());
	}
    public override void getItem(Item item)
    {
        Debug.Log("Got Item "+item.name);
        invCont.putItem(item);
        Destroy(item.gameObject);
    }
    public override void grabAmmy(ActionController ammyActCont)
    {
        if (ammyActCont.gameObject.GetComponent<EnemyActionController>()!=null)
        {
            ammyCont.setAmmy(ammyActCont.gameObject.GetComponent<EnemyActionController>().myAmmy);
        }
    }
    void Update(){
		if(statsCont.getLifes()<=0){
			active = false;
		}
		if(active){
            gCont.showLifes(statsCont.getLifes(),statsCont.getMaxLifes());
			attCont.makeHit(ammyCont.getH()*statsCont.getPower());
			movCont.move();
		}
	}
}
