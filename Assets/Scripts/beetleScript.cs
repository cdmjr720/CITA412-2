using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script created in order to create and return beetle IDs in order to destroy GameObjects

public class beetleScript : MonoBehaviour
{
    //variable for beetleID
    [SerializeField] int beetleID;

    //method to create beetle ID
    public void CreateID(int id)
    {
        beetleID = id;
    }

    //method to return beetle ID
    public int GetBeetleID()
    {
        return beetleID;
    }
}
