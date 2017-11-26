using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldCounter : MonoBehaviour {

    public int gold = 0;
    public Text text_gold;

	// Use this for initialization
	void Start () {
        StartCoroutine( StartGoldCount() );
        // gold initialize
        gold = int.Parse(text_gold.text); // str to int
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // coroutine func
    IEnumerator StartGoldCount () {
        while(true) {
            yield return new WaitForSecondsRealtime(1f);    // rest per 1sec
            gold++;
            text_gold.text = gold.ToString();
        }
    }
}
