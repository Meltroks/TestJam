using UnityEngine;
using System.Collections;

public class PlayerInventoryController : MonoBehaviour {
    public Item[] items;
    public int[] cols;
    public float[] sTimes;
    public bool[] usings;
    public GuiController gCont;
    public StatsController stCont;
    void Start()
    {
        gCont.showItems(items, cols);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (cols[0] > 0)
            {
                TimeController.main.setTime(TimeController.main.getTime() * items[0].timeC);
                stCont.power += items[0].powerC;
                cols[0]--;
                usings[0] = true;
                sTimes[0] = Time.time;
            }
        }

        for(int x = 0; x < items.Length; x++)
        {
            if (usings[x] == true)
            {
                if(Time.time - sTimes[x] > 5)
                {
                    usings[x] = false;
                    if(items[x].timeC!=0)TimeController.main.setTime(TimeController.main.getTime() / items[x].timeC);
                    stCont.power -= items[x].powerC;
                }
            }
        }
    }
    public void putItem(Item item)
    {
        gCont.showItems(items, cols);
        for(int i = 0; i < items.Length; i++)
        {
            if (item.name == items[i].name && item.texture == items[i].texture)
            {
                cols[i]++;
            }
        }
    }
}
