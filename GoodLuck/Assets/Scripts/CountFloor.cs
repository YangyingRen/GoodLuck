using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountFloor : MonoBehaviour
{

    public float selectedFloor =0;
    public float nowFloor=0;
    public float moveSpeed;
    public TextMesh FloorNumber;
    public GameObject[] Floor;
    public TextMesh[] Number;
    public TextMesh[] SelectedNumber;
    public int i;
    public Material DefaultMaterial;
    public GameObject SelectedFloor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (selectedFloor==0){

            SelectingFloor();

        }
        else if((int)nowFloor<(selectedFloor+1)){

              nowFloor+=Time.deltaTime*moveSpeed;
              int FloorNum=(int)nowFloor;
              FloorNumber.text=FloorNum.ToString();
        }
        else if((int)nowFloor>(selectedFloor-1)){

              nowFloor-=Time.deltaTime*moveSpeed;
              int FloorNum=(int)nowFloor;
              FloorNumber.text=FloorNum.ToString();
        }

        if((int)nowFloor==(int)selectedFloor){
            selectedFloor=0;
            SelectedFloor.GetComponent<Renderer>().material=DefaultMaterial;
            
        }
        
    }

    void SelectingFloor(){

        int len=Number.Length;
        int j=0;

        for(i=0;i<len;i++){

            if(Floor[i].tag=="SelectedButton"){
                
               // while(j<=len){
                    //if(SelectedNumber[j]==null){
                      //  SelectedNumber[j]=Number[i];
                      //  break;
                   // }
                   // else{
                    //    j+=1;
                    //}
                    
               // }
                SelectedNumber[0]=Number[i];
                SelectedFloor=Floor[i];
                
                selectedFloor=int.Parse(SelectedNumber[0].text);
            }
        }
        
       

    }
}
