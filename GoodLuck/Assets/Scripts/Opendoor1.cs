using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Opendoor1 : MonoBehaviour
{
    public Animator Open;
    public Animator NPC;
    public GameObject[] Button;
    public TextMesh FloorNumber;
    public TextMesh[] SelectedNumber;
    public int i;
    public int j=0;
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
                 if(j==0){
                     NPC.SetBool("Animation1",true);
                     NPC.SetBool("Animation2",false);
                     j=1;
                 }
                 else{
                     NPC.SetBool("Animation1",false);
                     NPC.SetBool("Animation2",true);
                     j=0;


                 }
                 
                
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
       
         

        

