using UnityEngine;
using System.Collections;

public class enemyMovementScript : MonoBehaviour {

    float enemySpeed = 0.03f;
    float enemyYposition;
    float enemyXposition;
    Vector3 enemyMovement = new Vector3();
    float randomSpawnLocation;// = Random.Range(0f, 1f);
    public GameObject enemy;
    // Use this for initialization
    void Start ()
    {
        //respawn();
       
        //enemyMovement = new Vector3(Random.Range(-2f, 2f), 10, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        enemyMovement -= new Vector3(0, 1 * enemySpeed, 0);
        this.transform.position = enemyMovement;
	}
    void OnCollisionEnter2D(Collision2D other)
    {
        
        if(other.gameObject.tag == "player")
        {
            Debug.Log("kut2d");
            //enemyMovement += new Vector3(0, 3.78f, 0);
            respawn();
        }
    }

    void respawn()
    {
        randomSpawnLocation = Random.Range(0f, 1f);
        if (randomSpawnLocation <= 0.33)
        {
            enemyMovement = new Vector3(-2, 5, 0);
            Debug.Log("waeta");
            Instantiate(enemy, enemyMovement, Quaternion.identity);
        }
        if (randomSpawnLocation >= 0.33 && randomSpawnLocation <= 0.66)
        {
            enemyMovement = new Vector3(0, 5, 0);
            Instantiate(enemy, enemyMovement, Quaternion.identity);
        }
        if (randomSpawnLocation >= 0.66)
        {
            enemyMovement = new Vector3(2, 5, 0);
            Instantiate(enemy, enemyMovement, Quaternion.identity);
        }
        


    }

    void Update()
    {
        if(this.transform.position.y <= -5.55f)
        {
            respawn();
        }
    }
}
