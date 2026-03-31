using NUnit.Framework;
using UnityEngine;
using UnityEngine.Events;


public class Campfire : MonoBehaviour
{

    public SpriteRenderer logs; 

    public bool nearFire = false; 
    public UnityEvent OnHeat; 
    public UnityEvent NotHeat; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(logs.bounds.Contains(transform.position) == true)
        {
            if (nearFire == true)
            {
                
            }
            else
            {
                OnHeat.Invoke();
                nearFire = true;
            }
        }
        else
        {
            if(nearFire == true)
            {
                NotHeat.Invoke();
                nearFire = false;
            }
            else
            {
                
            }
        }
        
        
    }
    


}
