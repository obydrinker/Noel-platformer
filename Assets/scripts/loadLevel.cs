using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    public int minimumScoreNeeded = 0;
    public string sceneToLoad;

    //När triggern kolliderar händer...
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Bara om det är en kollision med tagen "player" och dina poäng är mer eller = minimumscoreneeded sker...
        if (collision.tag == "Player" && points.score >= minimumScoreNeeded)
        {
            //...poängen sätts till 0 och "SceneToLoad" laddas om (eftersom att sceneToLoad är public så laddas scenen som står på flaggan i inspectorn(målet) om).
            points.score = 0;
            SceneManager.LoadScene(sceneToLoad);
        }
    }



}
