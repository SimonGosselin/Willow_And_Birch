using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Gear {

    int turnCount;
    float restore;
    bool used;

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
    public int GetTurnCount()
    {
        return turnCount;
    }
    public void SetTurnCount(int _timer)
    {
        turnCount = _timer;
    }
    public float GetRestoreValue()
    {
        return restore;
    }
    public void SetRestoreValue(float _restoreValue)
    {
        restore = _restoreValue;
    }
    public bool GetState()
    {
        return used;
    }
    public void SetState(bool _state)
    {
        used = _state;
    }
    public void UseItem(ConsumeType potion)
    {
        //Consume Item
        //Update Player character's values based on which potion
        switch(potion)
        {
            case ConsumeType.HP:
                break;
            case ConsumeType.PP:
                break;
            case ConsumeType.ATTACK:
                break;
            case ConsumeType.DEFENSE:
                break;
            case ConsumeType.cureSLEEP:
                break;
            case ConsumeType.curePARALYSIS:
                break;
            case ConsumeType.cureBURN:
                break;
            case ConsumeType.cureFREEZE:
                break;
            case ConsumeType.cureSLOW:
                break;
            case ConsumeType.cureCONFUSION:
                break;
        }
    }
}
