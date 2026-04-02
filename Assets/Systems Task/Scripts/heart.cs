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
        hearts.localScale = Vector2.zero;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveHeart()
    {
    
         if (NPC.bounds.Contains(transform.position) == true)
        {
            StopCoroutine(givingCoroutine);
        }

        givingCoroutine = StartCoroutine(HeartSpawn());
    }

    IEnumerator HeartSpawn()
    {
        Debug.Log("heart start");
        float t = 0; 
        hearts.localScale = Vector2.zero;
        
        while(t < 1)
        {
            t += Time.deltaTime;
            hearts.localScale = Vector2.one * t;
            yield return null;

        }
        Debug.Log("heart given");

        
    }

    IEnumerator spawning()
    {
        yield return heartCoroutine = StartCoroutine(HeartSpawn());
    }
}
