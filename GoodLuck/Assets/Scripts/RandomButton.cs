using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomButton : MonoBehaviour
{
    public Renderer Env;
    public Material Open;
    public GameObject[] Button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {int len=Button.Length;
    if(Env.material=Open){
        for(int i=0;i<len;i++){
            if(Button[i].tag!="SelectedButton"){
                
            }
        }
    }

        
    }
}
