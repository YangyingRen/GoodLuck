using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Opendoor1 : MonoBehaviour
{
    public Animator Open;
    public GameObject[] Button;
    public TextMesh FloorNumber;
    public TextMesh[] SelectedNumber;
    public int i;
    public bool Actived;
    public Collider Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        int len=Button.Length;
        for(i=0;i<len;i++){
        if(Button[i].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[i].text){
                 Open.SetBool("Open" ,true);
                 Button[i].tag="Button";
                
            }
        }
        }

        if(Actived==true){
            Open.SetBool("Open",false);
            
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
       
         

        

