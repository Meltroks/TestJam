using UnityEngine;
using System.Collections;

public class PlayerInventoryController : MonoBehaviour {
    public Item[] items;
    public int[] cols;
    public GuiController gCont;
    void Start()
    {
        gCont.showItems(items, cols);
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
