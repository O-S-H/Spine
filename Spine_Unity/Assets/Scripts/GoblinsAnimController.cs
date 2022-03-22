using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;  //������ ����� ���� ���̺귯�� ����Ʈ


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



        //�ִϸ��̼� ����
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
