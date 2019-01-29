using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEventReceiver : MonoBehaviour {


    public void OnButtonPressed()
    {
        Debug.Log("Yay. Button pressed...");
    }

    public void OnButtonDown ()
    {
        Debug.Log("Yay. Button pressed down...");
    }
    public void OnButtonUp ()
    {
        Debug.Log("Yay. Button up...");
    }
}
