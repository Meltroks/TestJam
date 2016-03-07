using UnityEngine;
using System.Collections;

public class PlayerInteractController : MonoBehaviour {
    public ActionController actCont;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.GetComponent<Item>() != null)
        {
            actCont.getItem(col.GetComponent<Item>());
        }
    }
}
