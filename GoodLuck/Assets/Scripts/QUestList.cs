using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class QUestList : MonoBehaviour
{
    public string[] quest;
    public int[] questFloor;
    public Text questname;
    public TextMesh FloorNumber;
    public GameObject Trigger;
    public int i;
    private int len;
    public int test;
    // Start is called before the first frame update
    void Start()
    {len=quest.Length;
      i=Random.Range(0,len);
     questname.text=quest[i];

    }

    // Update is called once per frame
    void Update()
    {if(Trigger.GetComponent<Opendoor1>().Actived==true){
        if(int.Parse(FloorNumber.text)==questFloor[i]){
            i=Random.Range(0,len);
            questname.text=quest[i];
            test+=1;
            gameObject.GetComponent<UIScript>().TimeCounter.fillAmount+=0.1f;
        }


    }
    

        
    }
    
        
    }

