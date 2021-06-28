using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEventMessage : MonoBehaviour
{
    public void PlayerInitial()
    {
        Debug.Log("Initial Position");
    }

    public void PlayerQuarter()
    {
        Debug.Log("1/4 Round Completed");
    }

    public void PlayerHalf()
    {
        Debug.Log("1/2 Round Completed");
    }

    public void PlayerOtherQuarter()
    {
        Debug.Log("3/4 Round Completed");
    }

    public void PlayerFull()
    {
        Debug.Log("Round Completed");
    }
}
