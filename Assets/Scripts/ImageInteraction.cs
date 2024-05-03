using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageInteraction : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject InfoObject;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
        InfoObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other){
        //Enable Canvas with interactions
        if(other.tag == "Player"){
            UiObject.SetActive(true);
        }
    }

    void OnTriggerStay(Collider other){
        //It waits for input
        if(UiObject == true){
            if(Input.GetKey("i")){
            //if i is clicked give info canvas
                InfoObject.SetActive(true);
                UiObject.SetActive(false);
            }
        }
        if(InfoObject == true && Input.GetKey("c")){
                InfoObject.SetActive(false);
                UiObject.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other){
        //The canvas goes away
        if(InfoObject == true){
            InfoObject.SetActive(false);
        }
        UiObject.SetActive(false);


    }
}
