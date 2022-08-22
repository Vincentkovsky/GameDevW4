using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{

    private int i;
    public Renderer rend;
    private int random;
    public GameObject redObj;

    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        random = Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(rend.name+":"+i);
        if(rend.tag == "Red" && i == 100){
            redObj = GameObject.Find("RedPrefab(Clone)");
            redObj.SetActive(false);
        }
        if(rend.tag == "Blue" && i == random){
            rend.enabled = false;
        }
    }
}
