using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beetleScript : MonoBehaviour
{
    [SerializeField] int beetleID;

    public void CreateID(int id)
    {
        beetleID = id;
    }

    public int GetBeetleID()
    {
        return beetleID;
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
