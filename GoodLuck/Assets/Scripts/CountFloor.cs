using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountFloor : MonoBehaviour
{

    public float selectedFloor =0;
    public float nowFloor;
    public float moveSpeed;
    public TextMesh FloorNumber;
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
         
              FloorNumber.text=nowFloor.ToString();
        }
        
    }

    void SelectingFloor(){

    }
}
