using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{

  public  float  maxhealth,health, damage, picturenum;
    public string effect,name;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
    }
   
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
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
