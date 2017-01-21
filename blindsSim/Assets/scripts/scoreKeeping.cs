using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeping : MonoBehaviour {
    private int score =0 ;
    public GameObject star;
    public GameObject star1;
    public GameObject star2;
    Vector3 start1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        score++;
        print(score);
        star.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
        star1.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
        star2.GetComponent<Rigidbody2D>().velocity = new Vector3(20, 0, 0);
    }
}
