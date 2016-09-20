using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movement : MonoBehaviour {

    int speed = 2;
    Vector3 linksRechts = new Vector3();

    public Text scoreText;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("right"))
        {
            linksRechts += new Vector3(1 * speed, 0, 0);
            this.transform.position = linksRechts;
        }
        if (Input.GetKeyDown("left"))
        {
            linksRechts -= new Vector3(1 * speed, 0, 0);
            this.transform.position = linksRechts;
        }
    }
}
