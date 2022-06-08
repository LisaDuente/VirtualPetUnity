using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
   private void Awake()
     {
         int destroyableObjects = FindObjectsOfType<DontDestroy>().Length;
 
         if (destroyableObjects != 1)
         {
             Destroy(this.gameObject);
         }
 
         else
         {
             DontDestroyOnLoad(gameObject);
         }
     }
}
