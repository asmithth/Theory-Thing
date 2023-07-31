using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereAction : GenerateMethod
{
    [SerializeField] private GameObject sphere;
    private Vector3 spawnPos = new Vector3(3, 5, -3);
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            Generate(sphere, spawnPos);
        }
    }
}
