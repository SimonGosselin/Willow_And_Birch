using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest : MonoBehaviour {

    Gear[] reward;
    public string description;
    int questID;
    bool completed;
    bool failed;

	// Use this for initialization
	void Start () {
        completed = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public int GetQuestID()
    {
        return questID;
    }
    public void SetQuestID(int _ID)
    {
        questID = _ID;
    }
    public bool GetCompleteState()
    {
        return completed;
    }
    public void SetCompleteState(bool _state)
    {
        completed = _state;
    }
    public Gear[] GetReward()
    {
        return reward;
    }
    public void SetReward(Gear[] _reward)
    {
        reward = _reward;
    }
    public bool GetFailureState()
    {
        return failed;
    }
    public void SetFailureState(bool _state)
    {
        failed = _state;
    }


}
