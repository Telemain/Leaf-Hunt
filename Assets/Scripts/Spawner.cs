using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Base location
    public int xCenter = 0;
    public int yCenter = 100;
    public int zCenter = 0;
    public int width = 19;

    public float interval = 0.0001f;

    //adjustments
    float xPosRand = 0;
    float zPosRand = 0;
    float yRotRand = 0;

    public Transform prefab;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnArmy());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawnArmy(){

		while(true){

            yield return new WaitForSeconds( interval );
            xPosRand = Random.Range(-width, width);
            zPosRand = Random.Range(-width, width);
            yRotRand = Random.Range(0, 360);

			Instantiate(prefab, new Vector3(zCenter + zPosRand, yCenter, xCenter + xPosRand), Quaternion.Euler(0, yRotRand, 0) );
		}
        yield return null;
	}
}
