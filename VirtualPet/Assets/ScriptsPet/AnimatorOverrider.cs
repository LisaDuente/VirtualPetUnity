using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//took away namespace monobehavoiurs

    public class AnimatorOverrider : MonoBehaviour
{
   public Animator _animator;
    

    public void setAnimation(AnimatorOverrideController overrideController){
        _animator.runtimeAnimatorController = overrideController;
    }
}


