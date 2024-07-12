using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redclover : MonoBehaviour
{
    // Start is called before the first frame update
   
    public float health = 20;
    public float soil = 30;
    game gam;

    // Start is called before the first frame update
    void Start()
    {

        GameObject statManagerObject = GameObject.Find("Gamemanager");
        gam = statManagerObject.GetComponent<game>();

    }

    public void heatadd()
    {
        gam.soil += health;
    }

}
