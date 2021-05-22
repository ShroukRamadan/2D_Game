using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rondomobjects : MonoBehaviour
{
    public GameObject coin;
    float rondomx;
    Vector2 wheretoswapn;
    public float swapnrate= 2f;
    public float nextspwn=0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       if (Time.time > nextspwn)
       {
           nextspwn = Time.time + swapnrate ;
           rondomx = Random.Range(-8.4f,8.4f);
           wheretoswapn = new Vector2 (rondomx , transform.position.y);
            Instantiate (coin,wheretoswapn , Quaternion.identity) ;

       } 
    }
}
