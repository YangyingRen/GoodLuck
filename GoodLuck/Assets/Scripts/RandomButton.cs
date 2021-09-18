using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButton : MonoBehaviour
{
    public GameObject[] Button;
    public int[] SelectFloor;
    public Material SelectedMaterial;
    public int i=0;
    public int s=0;
    public bool Actived;
    public bool isDone=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {int len=Button.Length;
  
    if(GameObject.Find("Elevator").GetComponent<CountFloor>().enabled==false){
          if(!isDone){
            for(i=0;i<(len-7);i++){
            int j=Random.Range(-1,2);
            if(j==1){
                int n=Random.Range(0,8);
              Button[n].tag="SelectedButton";
              if(Button[n].tag=="SelectedButton"){
                 Button[n].GetComponent<MeshRenderer>().material=SelectedMaterial;
                 s+=1;
                 isDone=true;
              }
            }}
                
            }
        
        }
        else{
            i=0;
            s=0;
            isDone=false;
        
        }
        }
        
        
    }

  