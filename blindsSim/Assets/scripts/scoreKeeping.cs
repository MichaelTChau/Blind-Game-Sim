using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeping : MonoBehaviour {
    private int score =0 ;

    public GameObject star;
    public GameObject star1;
    public GameObject star2;
    Vector3 unused = new Vector3(-21, 1, 0);
    Vector3 pos1 = new Vector3(-10.5f, 1.9f, 0);
    Vector3 pos2 = new Vector3(-9.7f, 1.9f, 0);
    Vector3 pos3 = new Vector3(-8.9f, 1.9f, 0);

    // Use this for initialization
    void Start () {

		
	}
	
	// Update is called once per frame
	void Update () {
        if(score == 10)
        {
            star.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
            star1.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
            star2.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
        }
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        score++;
        OnGUI();
        
    }
    void OnGUI ()
    {
        GUI.Label(new Rect(200, 100, 200, 200), "Score: " + score);
    }
}
