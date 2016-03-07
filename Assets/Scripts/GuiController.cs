using UnityEngine;
using System.Collections;

public class GuiController : MonoBehaviour { 
    public float lifes,maxLifes;
    public Ammy cAmmy;
    public Item[] items;
    public int[] cols;
    public GUIStyle st;

    public Texture2D lifeBarTextureBG, lifeBarTexture;

    float sTime = 0;
    float qteP = 50;
    bool showQTE = false;

    public void showLifes(float lifes,float maxLifes)
    {
        this.lifes = lifes;
        this.maxLifes = maxLifes;
    }
    public void showAmmy(Ammy cAmmy)
    {
        this.cAmmy = cAmmy;
    }
    public void showItems(Item[] items,int[] cols)
    {
        this.items = items;
        this.cols = cols;
    }
    public void showSlider(float pos)
    {
        qteP = pos;
        showQTE = true;
    }
    public void hideSLider()
    {
        showQTE = false;
    }
    void OnGUI()
    {
        float s = Screen.height / 150;
        st.normal.background = lifeBarTextureBG;
        GUI.Box(new Rect(0, 0, s * maxLifes, s*10), "");
        GUI.Box(new Rect(0, 0, s * lifes, s * 10), "");

        for(int x = 0; x < cols.Length; x++)
        {
            GUI.Box(new Rect(x* s * 20, Screen.height-s*20, s * 20, s * 20), cols[x]+"");
        }
        if (showQTE)
        {
            GUI.Slider(new Rect(Screen.width/2-s*10, Screen.height / 2 - s * 50, s * 20, s * 100), qteP, 100, 50, 100,null,null,true,0);
        }
    }
    
    


}
