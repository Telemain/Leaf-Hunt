using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour
{
    GameObject Score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter(Collision collision) {

        if("Player" == collision.gameObject.name ){

            Score = PlayerMovement.instance.Score;
            Score.GetComponent<TMPro.TextMeshProUGUI>().text = (int.Parse(Score.GetComponent<TMPro.TextMeshProUGUI>().text) + 1).ToString();
            Destroy(gameObject);
        }
    }
}
