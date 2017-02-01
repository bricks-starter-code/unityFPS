using UnityEngine;
using System.Collections;

public class FPSAddOn : MonoBehaviour
{

    public GameObject bullet;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetMouseButtonDown(0))
	    {
	        Fire();
	    }



    }

    private void Fire()
    {

        Camera characterCamera = this.gameObject.GetComponentInChildren<Camera>();

        Transform bulletRef = (Transform)Instantiate(bullet, characterCamera.transform.position + characterCamera.transform.forward, new Quaternion());
        bulletRef.gameObject.GetComponent<Rigidbody>().AddForce( characterCamera.transform.forward * 1000);


        Destroy(bulletRef.gameObject, 2);

    }
}
