using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMethod : MonoBehaviour
{
    //protected GameObject copy;
    public virtual void Generate(GameObject copy, Vector3 spawnPos)
    {
        Instantiate(copy, spawnPos, Quaternion.identity);
    }
}
