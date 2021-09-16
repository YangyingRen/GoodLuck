using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIScript : MonoBehaviour
{

    public GameObject MapPanel;
    public GameObject QuestPanel;
    public Image TimeCounter;
    public GameObject Button;
    public GameObject EndGame;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if(TimeCounter.fillAmount!=0){
     TimeCounter.fillAmount-=Time.deltaTime*0.01f;
     
     }
     else{
         EndGame.SetActive(true);
     
     }
        
    }

    public void CheckMap(){
        MapPanel.SetActive(true);   
        Time.timeScale=0f; 
    }
    public void CloseMap(){
        MapPanel.SetActive(false);
        Time.timeScale=1f;
    }
    public void CheckQuest(){
        QuestPanel.SetActive(true);
        Time.timeScale=0f;
    }
    public void CloseQuest(){
        QuestPanel.SetActive(false);
        Time.timeScale=1f;
    }
    public void Restart(){
        Application.LoadLevel(0);
    }
}
