using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySawMovement : MonoBehaviour
{
    //Floats är variabler som anges i siffror och till skillnad från int går en float att använda om man vill ha decimaltal.
    //Float går att använda till t ex. deta tillfälle där du vill sätta en hastighet i t ex. en rotation.
    private float rotationspeed = 180;

    private void Update()
    {
        //Sätter en rotation i Z-axeln beroende på variabeln (rotationspeed).
        transform.Rotate(0, 0, rotationspeed * Time.deltaTime);
    }
}
