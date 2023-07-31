using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylAction : GenerateMethod
{
    [SerializeField] private GameObject cyl;
    private Vector3 spawnPos = new Vector3(0, 5, -3);
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            Generate(cyl, spawnPos);
        }
    }
}
