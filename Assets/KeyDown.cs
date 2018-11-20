using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyDown : MonoBehaviour {

    public string SeName = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void KeyTauch()
    {
        Debug.Log("最初");

        if (tag == "Key_G2")
        {   
            SeName = "G2";
            Debug.Log("次G2");
        }
        if (tag == "Key_G2S")
        {
            SeName = "G2S";
            Debug.Log("次G2S");
        }

    }
}
