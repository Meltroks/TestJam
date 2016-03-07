using UnityEngine;
using System.Collections;

public class TimeController : MonoBehaviour {
    public float time;
    public static TimeController main;
    void Start()
    {
        main = this;
    }
    public void setTime(float newTime)
    {
        time = newTime;
        foreach(ActionController act in GameObject.FindObjectsOfType<ActionController>())
        {
            act.setTime(time);
        }
    }
}
