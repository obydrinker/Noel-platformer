using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetSpriteInvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        //Gör att spriterenderern på spriten med detta script sätts till false vilket gör att den inte syns när spelet är igång. 
        GetComponent<SpriteRenderer>().enabled = false;
    }



}
