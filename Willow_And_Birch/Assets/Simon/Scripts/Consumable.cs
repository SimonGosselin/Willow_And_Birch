using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Gear {

    public float timer;
    public float restore;
    public bool used;

    public enum ConsumeType
    {
        HP,
        PP, 
        ATTACK,
        DEFENSE,
        cureSLEEP,
        curePARALYSIS,
        cureBURN,
        cureFREEZE,
        cureSLOW,
        cureCONFUSION
    }

	// Use this for initialization
	void Start () {
        used = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(used)
        {

        }
	}
}
