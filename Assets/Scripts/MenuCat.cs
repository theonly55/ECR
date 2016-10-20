using UnityEngine;
using System.Collections;

public class MenuCat : MonoBehaviour {
    public GameObject spawn1;
    public GameObject spawn2;
    private int spawner;
    public float timer = 0.0f;
    public float force = 2.0f;
    public GameObject wheelRight;
    public GameObject wheelLeft;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (timer <= Time.time)
        {
            
            timer = Time.time + 4.0f;
            spawner = Random.Range(1, 3);
            Spawn();
          

        }
        if(spawner == 1)
        {
            wheelLeft.transform.Rotate(Vector3.forward * 90);
            wheelRight.transform.Rotate(Vector3.forward * 90);
            this.GetComponent<Rigidbody2D>().AddForce(-Vector2.right * force);
            
        }

        else if(spawner == 2)
        {
            wheelLeft.transform.Rotate(Vector3.forward * 90);
            wheelRight.transform.Rotate(Vector3.forward * 90);
            this.GetComponent<Rigidbody2D>().AddForce(Vector2.right * force);

        }
    }

    void Spawn()
    {

        Debug.Log(spawner);
        if(spawner == 1)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            this.gameObject.transform.position = spawn1.transform.position;
            this.gameObject.transform.rotation = spawn1.transform.rotation;
          

        }

        else if(spawner == 2)
        {
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            this.gameObject.transform.position = spawn2.transform.position;
            this.gameObject.transform.rotation = spawn2.transform.rotation;
            this.transform.Rotate(0, -180, 0);


        }
    }
}
