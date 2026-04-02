
using UnityEngine;

public class Options : MonoBehaviour
{
    public Sprite dialogue1; 
    public Sprite dialogue2; 
    public Sprite dialogue3; 

    public Player playerScript;

    public SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void display()
    {
        if (playerScript.freezeValue > 15)
        {
            spriteRenderer.sprite = dialogue1;
        }
        else if (playerScript.freezeValue > 7)
        {
            spriteRenderer.sprite = dialogue2;
        }
        else
        {
            spriteRenderer.sprite = dialogue3;
        }
    }
}
