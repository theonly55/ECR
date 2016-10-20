using UnityEngine;
using System.Collections;

public class blink : MonoBehaviour {
    public GameObject closedeyescat;
    bool blinking;
	// Use this for initialization

        void OnEnable()
    {
        blinking = true;
    }
	void Start () {
        closedeyescat.SetActive(false);
	}
	IEnumerator waitToBlink()
    {
        blinking = false;
        yield return new WaitForSeconds(5.0f);
        closedeyescat.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        closedeyescat.SetActive(false);
        blinking = true;

    }
    // Update is called once per frame
    void Update ()
    {
        if (blinking == true)
        {
            StartCoroutine(waitToBlink());
        }
	}
}
