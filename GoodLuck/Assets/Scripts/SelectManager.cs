using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectManager : MonoBehaviour
{
    public int test;
    public string selectableTag="Button";
    private Transform _selection;
    public Material selectMaterial;
    public Material defaultMaterial;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(_selection!=null){
            if(_selection.CompareTag(selectableTag)){
            var selectionRenderer=_selection.GetComponent<Renderer>();
            selectionRenderer.material=defaultMaterial;
            _selection=null;
            }
        }
        
        var ray=Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag)){
            var selectionRenderer=selection.GetComponent<Renderer>();
            if(selectionRenderer!=null){
                
                selectionRenderer.material=selectMaterial;
                } 
               _selection=selection;
               }
            }
           
            }


        }
    