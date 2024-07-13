using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawning : MonoBehaviour
{
    private int count = 0;
    bool startcount = false;
    public GameObject prefabToSpawn; // Reference to the prefab to be instantiated
    public Transform spawnLocation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (startcount)
        {
            count++;
            Debug.Log(count);
            if(count>500)
            {
                Instantiate(prefabToSpawn, spawnLocation.position, spawnLocation.rotation);
                count = 0;
                startcount = false;
            }
        
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        startcount = true;
    }
}
