using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Environment : MonoBehaviour
{
    public bool Actived;
    public Renderer Env;
    public Material Ongoing;
    public Material Arrived;
    public Collider Target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Actived==true){

            Env.material=Ongoing;
            GameObject.Find("Elevator").GetComponent<CountFloor>().enabled=true;
            GameObject.Find("b7").GetComponent<ClickButton>().enabled=true;

        }
        else{
            Env.material=Arrived;
            GameObject.Find("Elevator").GetComponent<CountFloor>().enabled=false;
            GameObject.Find("b7").GetComponent<ClickButton>().enabled=false;

        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
            if(other==Target){
            Actived=true;
    }
        
    }
    private void OnTriggerExit(Collider other)
    {
            if(other==Target){
            Actived=false;
    }
        
    }
}
