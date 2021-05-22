using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text myscoretext;
    public Text mytargetscoretext;

    public Text timertext;

    
    private int scorenum;
    private int tscorenum;

    float starttime =0f;
    float currenttime =0f;

    void Start()
    {
        starttime=currenttime;
        scorenum=0;
        tscorenum=50;
        myscoretext.text= "Score : " +scorenum;
        mytargetscoretext.text= "Target : " +tscorenum;
        
    }

     void Update(){

         //currenttime -= 1 * Time.deltaTime ;
         timertext.text= "Timer: "+currenttime;
     }



    void OnTriggerEnter2D(Collider2D Coin) {

		if (Coin.tag == "BinkCoin") {

            scorenum++;
			Destroy (Coin.gameObject);
            myscoretext.text = "Score " + scorenum;	
		}
        if (Coin.tag == "GreenCoin") {

            scorenum--;
			Destroy (Coin.gameObject);
            myscoretext.text = "Score " + scorenum;	
		}


	}

    // Update is called once per frame
    
}
