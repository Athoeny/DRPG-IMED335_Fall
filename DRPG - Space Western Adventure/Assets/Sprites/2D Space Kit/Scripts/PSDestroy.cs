using UnityEngine;
using System.Collections;

public class PSDestroy : MonoBehaviour {

    // Use this for initialization
    [System.Obsolete]
    void Start () {
		Destroy(gameObject, GetComponent<ParticleSystem>().duration);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
