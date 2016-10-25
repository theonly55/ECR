using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

    public int speed = 5;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        this.GetComponent<Rigidbody>().AddForce(speed*Time.deltaTime, 0, 0, ForceMode.Force);
        
	
	}

    void OnTriggerEnter(Collider Col)
    {
        Debug.Log("hello");

        if (Col.gameObject.tag == "Pre_1")
        {
            prefab1.transform.position = prefab3.transform.GetChild(2).gameObject.transform.position;
            Debug.Log("hello1");
        }

        if (Col.gameObject.tag == "Pre_2")
        {
            prefab2.transform.position = prefab1.transform.GetChild(2).gameObject.transform.position;
            Debug.Log("hello2");

        }

        if (Col.gameObject.tag == "Pre_3")
        {
            prefab3.transform.position = prefab2.transform.GetChild(2).gameObject.transform.position;
            Debug.Log("hello2");

        }
    }
}
