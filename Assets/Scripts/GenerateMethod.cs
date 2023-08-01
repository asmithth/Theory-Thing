using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMethod : MonoBehaviour
{
    public virtual void Generate(GameObject copy, Vector3 spawnPos, Quaternion Rotation)
    {
        //ENCAPSULATION
        Rotation = Quaternion.identity;
        //I don't know how much of a good encapsulation this gives, but every time child classes call this method...
        //...and try to alter Rotation, this line reverts it back to .identity);
        Instantiate(copy, spawnPos, Rotation);
    }
}
