using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{

  public  float  maxhealth,health, damage, picturenum;
    public string effect,name;
    public float height;
    game gam;
    // Start is called before the first frame update
    void Start()
    {
        health = maxhealth;
        GameObject statManagerObject = GameObject.Find("Gamemanager");
        gam = statManagerObject.GetComponent<game>();

    }
   
    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, height, transform.position.z);
        if (health <= 0)
        {
            gam.ego += 30;
            gam.multiplier += 0.5f;
            Destroy(gameObject);


        }
    }
    public void damagetake(int damage)
    {
        health -= damage;
        if(health<=0)
        {
            gam.ego += 30;
            gam.multiplier += 0.5f;
            Destroy(gameObject);
            
            
        }
    }

}
