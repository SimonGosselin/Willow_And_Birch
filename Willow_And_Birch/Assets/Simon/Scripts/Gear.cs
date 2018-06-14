using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gear : MonoBehaviour {

    int value;
    int gearID;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetValue()
    {
        return value;
    }
    public void SetValue(int _value)
    {
        value = _value;
    }
    public int GetID()
    {
        return gearID;
    }
    public void SetID(int _ID)
    {
        gearID = _ID;
    }
}
