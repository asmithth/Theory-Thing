using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAction : GenerateMethod
{
    [SerializeField] private GameObject cube;
    private Vector3 spawnPos = new Vector3(-3, 5, -3);
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Generate(cube, spawnPos);
        }
    }
}
