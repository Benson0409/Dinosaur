using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class score : MonoBehaviour
{
    public float a;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale!=0)
         {
            a = a + 0.15f;
            GetComponent<Text>().text = "" + (int)a;
            
        }
    }
}
