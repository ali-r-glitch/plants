using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redclover : MonoBehaviour
{
    // Start is called before the first frame update
   
    
    
    public float heat = 20;
    game gam;
    clicks cl;
    bool onawake = true;
    stats stat;


    // Start is called before the first frame update
    void Start()
    {

        GameObject statManagerObject = GameObject.Find("Gamemanager");
        gam = statManagerObject.GetComponent<game>();
        stat = this.gameObject.GetComponent<stats>();
        cl = this.gameObject.GetComponent<clicks>();

    }
    private void FixedUpdate()
    {
        if(onawake && !cl.canBePicked)
        {
            heatadd();
            onawake = false;
        }
        if (gam.temperature <= 30f)
        {
            stat.health -= 0.1f * gam.multiplier;
        }
    }

    public void heatadd()
    {
        gam.soil += heat;
    }

}
