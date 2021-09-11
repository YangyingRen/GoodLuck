using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenDoor : MonoBehaviour
{
    public Animator Open;
    public GameObject[] Button;
    public TextMesh FloorNumber;
    public TextMesh[] SelectedNumber;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        int len=Button.Length;
        if(Button[0].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[0].text){
                 Open.SetBool("Open" ,true);
                 Button[0].tag="Button";
            }
        }
       else if(Button[1].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[1].text){
                 Open.SetBool("Open" ,true);
                 Button[1].tag="Button";
            }
        }
         else if(Button[2].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[2].text){
                 Open.SetBool("Open" ,true);
                 Button[2].tag="Button";
            }
        }
         else if(Button[3].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[3].text){
                 Open.SetBool("Open" ,true);
                 Button[3].tag="Button";
            }
        }
         else if(Button[4].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[4].text){
                 Open.SetBool("Open" ,true);
                 Button[4].tag="Button";
            }
        }
         else if(Button[5].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[5].text){
                 Open.SetBool("Open" ,true);
                 Button[5].tag="Button";
            }
        }
         else if(Button[6].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[6].text){
                 Open.SetBool("Open" ,true);
                 Button[6].tag="Button";
            }
        }
         else if(Button[7].tag=="SelectedButton"){
            if(FloorNumber.text==SelectedNumber[7].text){
                 Open.SetBool("Open" ,true);
                 Button[7].tag="Button";
                 i=1;
            }
        }
         

        }

        
    }

