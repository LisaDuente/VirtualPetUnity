using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorScript : MonoBehaviour
{
    public bool inBedroom;

    public GameObject pet;

    public GameSaveScript saver;
    

  public void changeScenes(){
      if(inBedroom){
          //SceneManager.LoadScene(1);
          saver.savePetAnytime();
          SceneManager.LoadScene(1);
         
          //DontDestroyOnLoad(pet);
          inBedroom = false;
      }else if(inBedroom == false){
        SceneManager.LoadScene(0);  
        inBedroom = true;
      }
  }
}
