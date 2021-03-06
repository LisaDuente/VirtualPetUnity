using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSaveScript : MonoBehaviour
{
    public StatusScript status;
    public PetMovement move;
    public ChoosingSprite sprite;
    public DecorButton decorButton;


   private void OnApplicationQuit() {
       SaveSystem.SavePet(status, sprite, move, decorButton);
   }

   public void savePetAnytime(){
        SaveSystem.SavePet(status, sprite, move, decorButton);
   }

   public void loadPetAnytime(){
        PetData data = SaveSystem.loadPet();

        status.hungry = data.hungryPoints;
        status.hungerBar.setHunger(status.hungry);
        status.clean = data.cleanPoints;
        status.cleanBar.setClean(status.clean);
        status.happy = data.happyPoints;
        status.happyBar.setHappy(status.happy);
        status.money = data.amountCoins;
        status.coins.changeText(status.money.ToString());

        status.petState = (StatusScript.PetState) System.Enum.Parse(typeof(StatusScript.PetState),data.petState);
        sprite.bodyArrayPosition = data.body; 
        sprite.setBodyController();
        sprite.headArrayPosition = data.head;
        sprite.setHeadController();
        sprite.faceArrayPosition = data.face;
        sprite.setFaceController();
        //says it doestn have an controller
        sprite.sleepingAnimation = data.sleepingAnimationBed;
        sprite.animator.SetBool("isSleeping",sprite.sleepingAnimation);

        Vector3 position;
        position.x = data.position[0];
        position.y= data.position[1];
        position.z = data.position[2];
        move.transform.position = position;
        //why isnt this working?
        
        decorButton.currentWallpaper =data.wallpaperBed;
   }



   private void Start() {
      loadPetAnytime();
   }

   void Awake(){
       loadPetAnytime();
   }
}
