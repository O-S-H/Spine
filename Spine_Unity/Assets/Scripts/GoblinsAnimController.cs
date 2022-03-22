using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;  //스파인 사용을 위한 라이브러리 임포트


public class GoblinsAnimController : MonoBehaviour

{
    private SkeletonAnimation skeletonAnimation;

    private bool isOnClick = false;
    
    void Start()
    {
        
        
        skeletonAnimation = GetComponent<SkeletonAnimation>();

        skeletonAnimation.skeleton.SetSkin("goblin"); //
        skeletonAnimation.skeleton.SetSlotsToSetupPose();
        skeletonAnimation.skeleton.SetAttachment("left-hand-item", "spear");



        //애니메이션 지정
        skeletonAnimation.state.SetAnimation(0, "walk", true);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isOnClick)
            {
                 
                skeletonAnimation.skeleton.SetSkin("goblingirl");
                skeletonAnimation.skeleton.SetSlotsToSetupPose();
                 
                skeletonAnimation.skeleton.SetAttachment("left-hand-item", "dagger");
                skeletonAnimation.skeleton.SetAttachment("right-hand-item", null);
                
                
                isOnClick = true;


            }
            else
            {
                skeletonAnimation.skeleton.SetSkin("goblin"); //
                skeletonAnimation.skeleton.SetSlotsToSetupPose();
                
                
                isOnClick = false;
            }

        }
        
    }
   

}
