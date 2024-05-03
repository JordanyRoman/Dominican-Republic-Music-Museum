using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoInteraction : MonoBehaviour
{
    public GameObject player;
    public GameObject UiObject;
    public GameObject InfoObject;
    private VideoPlayer vid;
    // Start is called before the first frame update
    void Start()
    {
        UiObject.SetActive(false);
        InfoObject.SetActive(false);
        vid = player.GetComponent<VideoPlayer>();
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
            //if p is clicked play video
            if(vid.isPlaying == false && Input.GetKey("p")){
                vid.Play();
            }else if(vid.isPlaying == true && Input.GetKey("q")){
            //if q is clicked pause video
                vid.Pause();
            }
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
