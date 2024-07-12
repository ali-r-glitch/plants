using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{

    public int maxhealth,health, damage, picturenum;
    public string effect,name;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }
   
    // Update is called once per frame
    void Update()
    {
        
    }
    public void damagetake(int damage)
    {
        health -= damage;
        if(health<=0)
        {
            Destroy(gameObject);
        }
    }

}
