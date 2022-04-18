using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float movenmentSpeed;
    public float starPosition;
    public float endPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per   frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - movenmentSpeed * Time.deltaTime, transform.position.y);
    
        if(transform.position.x<=endPosition)
        {
            if(gameObject.tag=="cactus")
            {
                Destroy(gameObject);
            }
            else
            {
                transform.position = new Vector2(starPosition, transform.position.y);
            }
        }
    }

}
