using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    public string selectableTag="Button";
    public Material selectMaterial;
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
                selectionRenderer.material=selectMaterial;
                selection.tag="SelectedButton";
            
                
               } 
            }
               }
            }
            
           
            
    }
}
