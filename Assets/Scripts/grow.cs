using UnityEngine;
using System.Collections;
using UnityEngine.InputSystem;
using System;

public class grow : MonoBehaviour
{
    public Transform sunflowerA;

    public Transform sunflowerB;

    public Transform sunflowerC;

    float c = 0;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sunflowerA.localScale = Vector2.zero;
        sunflowerB.localScale = Vector2.zero;
        sunflowerC.localScale = Vector2.zero;

    }

    void Update()
    {
        

        
        if (Mouse.current.leftButton.isPressed == true)
        {
            c++;

            if(c > 3)
            {
                c = 0;
            }
        }

        if (c == 1)
        {
            StartCoroutine(SpawnSunflowerA());
    
        }

        if (c == 2)
        {
            
            StopCoroutine(SpawnSunflowerA());
        
        }

        if (c == 3)
        {
        
            StartCoroutine(SpawnSunflowerC());
        
        }


    
        
    }



    IEnumerator SpawnSunflowerA()
    {
        
        float t = 0;
        sunflowerA.localScale = Vector2.zero;
        sunflowerB.localScale = Vector2.zero;
        sunflowerC.localScale = Vector2.zero;
        
        

        while (t < 1)
        {
             t += Time.deltaTime;
            sunflowerA.localScale = Vector2.one * t;
            yield return null; 
        }
    }


     IEnumerator SpawnSunflowerB()
    {
        float t = 0;
        sunflowerA.localScale = Vector2.zero;
        sunflowerB.localScale = Vector2.zero;
        sunflowerC.localScale = Vector2.zero;
        

        while (t < 1)
        {
             t += Time.deltaTime;
            sunflowerB.localScale = Vector2.one * t;
            yield return null; 
        }
    }

    IEnumerator SpawnSunflowerC()
    {
        float t = 0;
        sunflowerA.localScale = Vector2.zero;
        sunflowerB.localScale = Vector2.zero;
        sunflowerC.localScale = Vector2.zero;

        while (t < 1)
        {
             t += Time.deltaTime;
            sunflowerC.localScale = Vector2.one * t;
            yield return null; 
        }
    }
}
