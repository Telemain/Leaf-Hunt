using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafDelete : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter (Collider collision){
		//print("combat collide");
		if( "Player" == collision.GetComponent<Collider>().gameObject.name){

			Destroy(gameObject);
		}
	}
}
