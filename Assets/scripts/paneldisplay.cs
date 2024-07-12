using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class paneldisplay : MonoBehaviour
{
    public TextMeshProUGUI name, damage, health, effect;
    private int h,d,p;
    private string e,n;
   public bool display=false;
    // Start is called before the first frame update
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(display)
        {
            damage.text = d.ToString();
            health.text = h.ToString();
            effect.text = e.ToString();
            name.text = n;
        }
       
       
    }
    public void setdisplay (int health, int damage, int picturenum, string effect,string name )
      {
        h = health;
        d = damage;
        p = picturenum;
        e = effect;
        n = name;
      }
}
