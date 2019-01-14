using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class points : MonoBehaviour
{
    //static=Det gäller för allt som har scriptet.
    public static int score;
    public int amount = 1;

    private float spinspeed = 180;
    private void Update()
    {
        //sätter en rotation runt Y-axeln.
        transform.Rotate(0, spinspeed * Time.deltaTime, 0);

    }
    //Om triggern kolliderar sker...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om en kollision med tagen "player" händer...
        if (collision.tag == "Player")
        {
            //Ett poäng läggs till i score
            points.score += amount;
            //Objektet (coin) förstörs/försvinner.
            Destroy(gameObject);
        }
    }
}
