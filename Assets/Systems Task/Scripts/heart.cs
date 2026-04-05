using System.Collections;
using UnityEngine;

public class heart : MonoBehaviour
{

    public Transform hearts; 

    public SpriteRenderer NPC;

    Coroutine heartCoroutine; 
    Coroutine givingCoroutine;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Setting the size to zero so it is unseen at the start
        hearts.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Function to give the npc the heart, which will stop depending on the player's position
    public void GiveHeart()
    {
        
    
         if (NPC.bounds.Contains(transform.position) == true)
        {
            StopCoroutine(givingCoroutine);
            StopCoroutine(heartCoroutine);
        }

        givingCoroutine = StartCoroutine(HeartSpawn());

    }

    //function to set the size of the heart back when player is out of bounds
    public void Small()
    {
        hearts.localScale = Vector2.zero;
    }

    //coroutine for the heart to grow bigger  
    IEnumerator HeartSpawn()
    {
        Debug.Log("heart start");
        float t = 0; 
        hearts.localScale = Vector2.zero;
        
        while(t < 1)
        {
            t += Time.deltaTime;
            hearts.localScale = Vector2.one * t * 2;
            yield return null;

        }
        Debug.Log("heart given");

        
    }

    IEnumerator spawning()
    {
        yield return heartCoroutine = StartCoroutine(HeartSpawn());
    }
}
