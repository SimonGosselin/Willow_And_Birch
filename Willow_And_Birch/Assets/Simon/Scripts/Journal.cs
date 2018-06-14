using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Journal : MonoBehaviour {

    public Quest[] quests;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if you recieve a reward, check to see if it fulfills a quest
        //if it does, call complete quest, else do nothing


	}
    
    public void AddQuest(Quest newQuest)
    {
        for (int i = 0; i < quests.Length; i++)
        {
            if (quests[i].GetQuestID() == 0)
                quests[i] = newQuest;
        }
    }
    public void CompleteQuest(Quest completedQuest)
    {

    }
    public void FailQuest()
    {

    }
}
