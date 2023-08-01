using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CubeAction : GenerateMethod
{
    [SerializeField] private GameObject cube;
    private Vector3 spawnPos = new Vector3(-3, 5, -3);

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            Quaternion Rotation = new Quaternion(-1, 1, 1, 0);
            //this var tries to override parent rotation, which should not happen (for encapsulation example in parent method);

            //INHERITANCE //ABSTRACTION //POLYMORPHISM
            Generate(cube, spawnPos, Rotation);
            // 1) uses parent-class method "Generate" to instantiate a shape;
            // 2) also abstraction, as all the necessary actions happen within the parent-method, not within the child one;
            // 3) also polymorphism, as the instantiate coords (spawnPos), and GameObject (here, cube)...
            // ...are designated in child classes, not in the parent one;
        }
    }
}
