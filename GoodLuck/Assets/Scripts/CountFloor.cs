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
    public GameObject[] SelectedFloor;
    public TextMesh[] SelectedNumber;
    public int i;
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
        else if(nowFloor<selectedFloor){
              nowFloor+=Time.deltaTime*(selectedFloor/moveSpeed);
              int FloorNum=(int)nowFloor;
              FloorNumber.text=FloorNum.ToString();
        }
        else if(nowFloor>(selectedFloor+1)){
              nowFloor-=Time.deltaTime*(selectedFloor/moveSpeed);
              int FloorNum=(int)nowFloor;
              FloorNumber.text=FloorNum.ToString();
        }

        if((int)nowFloor==(int)selectedFloor){
            selectedFloor=0;
        }
        
    }

    void SelectingFloor(){

        int len=SelectedNumber.Length;

        for(i=0;i<len;i++){

            if(SelectedFloor[i].tag=="SelectedButton"){
                selectedFloor=int.Parse(SelectedNumber[i].text);
            }
        }
        
       

    }
}
