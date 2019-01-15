using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float rotationspeed = 5;
    public GameObject bullet;
    public Transform spawnPoint;
   

    public float bulletSpeed = 10;

    // Update is called once per frame
    void Update()
    {
        GunMovement();
        FireGun();
        
    }

    void GunMovement()
    {
        //Om tangenten som står (B) trycks ner sker...
        if (Input.GetKey(KeyCode.B))
        {
            //sätts en positiv (höger) rotation i Z-axeln beroende av variabeln rotationspeed
            transform.Rotate(0f, 0f, rotationspeed);

        }
        //Om tangenten som står (M) trycks ner sker...
        if (Input.GetKey(KeyCode.M))
        {
            //sätts en negativ rotation (vänster) i Z-Axeln beroende av variabeln rotationspeed
            transform.Rotate(0f, 0f, -rotationspeed);
        }
        //Om tangenten som står (D) trycks ner sker...
        if (Input.GetKeyDown(KeyCode.D))
        {
            //Scalen (på spriten då det är granadelauncherns sprite som har detta script är det den som förendras) transormeras till de följande värdena som är positiva (alltså blir spriten riktad åt höger)
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            //Rotationen på spriten transformeras också (vinkeln) till quaternion identity = ingen rotation 
            transform.rotation = Quaternion.identity;
        }
        //Om tangenten som står (A) trycks ner sker...
        if (Input.GetKeyDown(KeyCode.A))
        {
            //Exakt samma som om D-tangenten trycks ner fast värdena är negativa alltså blir spriten riktad åt vänster.
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            transform.rotation = Quaternion.identity;
        }
    }
    void FireGun()
    {
        //om tangenten som trycks ner (N) sker...
        if (Input.GetKeyDown(KeyCode.N))
        {
            //Skapar en ny bullet vid den satta spwnpointen
            GameObject newbullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            //Om skalan (localScale) är större än 0 sker...
            if (transform.localScale.x > 0)
            {
                //Jag kommer åt bulletens rigidbody velocity och kan sätta en hasighet åt höger beroende av variabeln bulletspeed 
            newbullet.GetComponent<Rigidbody2D>().velocity = (newbullet.transform.right * bulletSpeed);

            }
            //Om skalan (localScale) är mindre än 0 sker istället...
            else if ( transform.localScale.x < 0)
            {
                //samma sak fast åt vänster med en hastighet beroende på bulletSpeed variabeln
                newbullet.GetComponent<Rigidbody2D>().velocity = (-newbullet.transform.right * bulletSpeed);
            }


            

        }
        
    }
   






}
