using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    public Gear[] inventory;
    public int size;


	// Use this for initialization
	void Start () {
        size = 12;
        inventory = new Gear[size];
	}

    // Update is called once per frame
    void Update() {

    }
    public void AddItemToInventory(Gear item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if(inventory[i].GetID() == 0)
            {
                inventory[i] = item;
            }
        }
    }
    public void RemoveItemFromInventory(Gear item)
    {
        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i].GetID() == item.GetID())
            {
                inventory[i].SetID(0);
            }
        }
    }
}
