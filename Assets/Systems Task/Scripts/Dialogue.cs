
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    public SpriteRenderer NPC; 

    public bool nearNPC = false;

    public UnityEvent OnSpeak;

    public UnityEvent NotSpeak; 

 


   
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    
    }

    // Update is called once per frame
    void Update()
    {
        if(NPC.bounds.Contains(transform.position) == true)
        {
            if (nearNPC == true)
            {
                
            }
            else
            {
                OnSpeak.Invoke(); 
                nearNPC = true; 
            }
        }
        else
        {
            if (nearNPC == true)
            {
                NotSpeak.Invoke();
                nearNPC = false;
            }
            else
            {
                
            }
        }
    }


}
