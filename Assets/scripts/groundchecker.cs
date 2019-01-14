using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundchecker : MonoBehaviour
{
    public int isGrounded;
    //När triggern kolliderar händer...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //... att variabeln = true
        isGrounded++;
    }
    // När triggern inte är i kontakt med något (inte kolliderar) händer...
    private void OnTriggerExit2D(Collider2D collision)
    {
        //... att variabeln = false. 
        isGrounded--;
    }

}
