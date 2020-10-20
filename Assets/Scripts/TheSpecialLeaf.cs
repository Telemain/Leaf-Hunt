using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

public class TheSpecialLeaf : MonoBehaviour
{
    public GameObject theSpecial;
    GameObject[] leaves;
    public Material golden;
    public static TheSpecialLeaf instance;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;

        leaves = GameObject.FindGameObjectsWithTag("Ground");

        foreach (GameObject leaf in leaves)
        {
            //Instantiate(respawnPrefab, respawn.transform.position, respawn.transform.rotation);

        }
        StartCoroutine(specialnator());
    }

    // Update is called once per frame
    IEnumerator specialnator()
    {
        while(true){
            yield return new WaitForSeconds(2);
            if( null == theSpecial ){
                theSpecial = leaves[Random.Range(1,leaves.Length-1)];
                theSpecial.GetComponent<Renderer>().material = golden;
                //Light lightComp = theSpecial.AddComponent<HDAdditionalLightData>();
                Light lightComp = theSpecial.AddComponent<Light>();
                theSpecial.AddComponent<SelfDestruct>();
                theSpecial.GetComponent<Light>().range = 50f;
            }
            yield return null;
        }
    }

    IEnumerator firefly(){
        while( true ){
            yield return new WaitForSeconds(10);
            if( 60000 > theSpecial.GetComponent<Light>().intensity && null == theSpecial ){
                theSpecial.GetComponent<Light>().intensity = theSpecial.GetComponent<Light>().intensity * 10f;
            }
        }
    }
}
