using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    public GameObject item;

    
    // Start is called before the first frame update
    
    // Update is called once per frame
    void Update()
    {
       
        if(Input.GetMouseButtonDown(1)==true)
        {
            item.transform.Rotate(0.0f, 90.0f, 0.0f, Space.Self);
        }
        
    }
}
