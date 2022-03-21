using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class AlienAnimController : MonoBehaviour
{
    private SkeletonAnimation skeletonAnimation;  //참조변수

    //01: 애니메이션 적용방식
    private void Start()
    {
        //skeletonAnimation = GetComponent<SkeletonAnimation>();
        //애니메이션이 재생되는 속도의 조절은 '타임 스케일을 이용하여 코드상에서 제어할수 있다.
        //기본값 1.0 ==100% 2배= 2.0==200% 
        //skeletonAnimation.state.TimeScale = 0.1f;
        //SetAnimation(인덱스,애니메이션이름, 애니메이션 반복)
        //skeletonAnimation.state.SetAnimation(0, "run", true);// 0을 디폴트?
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        //Get: 단일적인
        // Add: 연속 &연결 애니메이션 사용!
        skeletonAnimation.state.AddAnimation(0, "run", false, 0);//마지막 0 지연시간
        skeletonAnimation.state.AddAnimation(0, "jump", false, 0);
        skeletonAnimation.state.AddAnimation(0, "hit", false, 1); //점프에서 히트로 넘어가지전 1초간 지연
        skeletonAnimation.state.AddAnimation(0, "death", false, 1);//런으로 넘어가기전 2초간 지연
        //반복하고 싶으면 반복값

        // Update is called once per frame
        void Update()
        {

        }
    }
}

