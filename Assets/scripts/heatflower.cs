using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heatflower : MonoBehaviour
{
    public float heat = 30;
    game gam;
    clicks cl;
    bool onawake = true;
    stats stat;
    // Start is called before the first frame update
    void Start()
    {
        
        GameObject statManagerObject = GameObject.Find("Gamemanager");
        gam = statManagerObject.GetComponent<game>();
        cl = this.gameObject.GetComponent<clicks>();
        stat = this.gameObject.GetComponent<stats>();
    }
    private void FixedUpdate()
    {
        if (onawake && !cl.canBePicked)
        {
            heatadd();
            onawake = false;
        }
        if (gam.soil >= 70f)
        {
            stat.health -= 0.1f * gam.multiplier;
        }
    }

    public void heatadd()
    {
        gam.temperature += heat;
    }
     

}
