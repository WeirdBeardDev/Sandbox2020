using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpawner : MonoBehaviour
{
    #region MonoBehavioiurs
    void Start()
    {
        List<Objective> goals = new List<Objective>(5);
        for (int i = 0; i < 5; i++)
        {
            goals.Add(ObjectiveFactory.CreateGoal(i + 1));
            Debug.Log($"Goal {i + 1} - {goals[i].Description}");
        }
    }
    #endregion MonoBehavioiurs
}
