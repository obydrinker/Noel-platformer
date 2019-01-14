using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySawMovement : MonoBehaviour
{
    public float rotationspeed = 180;

    private void Update()
    {
        //Sätter en rotation i Z-axeln.
        transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
    }
}
