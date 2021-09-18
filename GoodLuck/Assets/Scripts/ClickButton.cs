using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickButton : MonoBehaviour
{
    public string selectableTag="Button";
    public Material selectMaterial;
    public Transform[] Floor;
    public Transform targetFloor;
    public int targetNumber;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag)){
            var selectionRenderer=selection.GetComponent<Renderer>();
            if(selectionRenderer!=null){
                if(Input.GetMouseButtonDown(0)){
                selection.tag="SelectedButton";
                 if(selection.tag=="SelectedButton"){
                selectionRenderer.material=selectMaterial;
               }
                targetFloor=selection;
                int len=Floor.Length;
                for(int i=0;i<len;i++){
                    if(Floor[i]==targetFloor){
                        targetNumber=i+1;
                    }
                }
            
                
               } 
            }
               }

              
            }
            
           
            
    }
}
