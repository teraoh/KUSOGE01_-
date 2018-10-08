using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class danbelGenerator : MonoBehaviour {

    public GameObject danbelPrefab;
    public float span = 5.0f;
    public float pitch = 0.95f;
    float delta = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            this.span *= this.pitch;
            GameObject danbel = Instantiate(danbelPrefab) as GameObject;
            int px = Random.Range(-8, 9);
            danbel.transform.position = new Vector3(px, 9, 0);
            float torque = Random.Range(-40,41);
            danbel.GetComponent<Rigidbody2D>().AddTorque(torque);
        }
    }
}
