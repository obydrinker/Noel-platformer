using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySawMovement : MonoBehaviour
{
    private float rotationspeed = 180;

    private void Update()
    {
        //Sätter en rotation i Z-axeln beroende på variabeln (rotationspeed).
        transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
    }
}
