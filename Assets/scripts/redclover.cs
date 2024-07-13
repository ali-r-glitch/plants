using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redclover : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float health = 20;
    public float soil = 30;
    game gam;
    clicks cl;
    bool onawake = true;


    // Start is called before the first frame update
    void Start()
    {

        GameObject statManagerObject = GameObject.Find("Gamemanager");
        gam = statManagerObject.GetComponent<game>();
        cl = this.gameObject.GetComponent<clicks>();

    }
    private void FixedUpdate()
    {
        if(onawake && !cl.canBePicked)
        {
            heatadd();
        }
        if (gam.temperature <= 30f)
        {
            health -= 0.1f * gam.multiplier;
        }
    }

    public void heatadd()
    {
        gam.soil += health;
    }

}
