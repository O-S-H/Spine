using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Spine;
using Spine.Unity;

public class AlienAnimController : MonoBehaviour
{
    private SkeletonAnimation skeletonAnimation;  //��������

    //01: �ִϸ��̼� ������
    private void Start()
    {
        //skeletonAnimation = GetComponent<SkeletonAnimation>();
        //�ִϸ��̼��� ����Ǵ� �ӵ��� ������ 'Ÿ�� �������� �̿��Ͽ� �ڵ�󿡼� �����Ҽ� �ִ�.
        //�⺻�� 1.0 ==100% 2��= 2.0==200% 
        //skeletonAnimation.state.TimeScale = 0.1f;
        //SetAnimation(�ε���,�ִϸ��̼��̸�, �ִϸ��̼� �ݺ�)
        //skeletonAnimation.state.SetAnimation(0, "run", true);// 0�� ����Ʈ?
        skeletonAnimation = GetComponent<SkeletonAnimation>();
        //Get: ��������
        // Add: ���� &���� �ִϸ��̼� ���!
        skeletonAnimation.state.AddAnimation(0, "run", false, 0);//������ 0 �����ð�
        skeletonAnimation.state.AddAnimation(0, "jump", false, 0);
        skeletonAnimation.state.AddAnimation(0, "hit", false, 1); //�������� ��Ʈ�� �Ѿ���� 1�ʰ� ����
        skeletonAnimation.state.AddAnimation(0, "death", false, 1);//������ �Ѿ���� 2�ʰ� ����
        //�ݺ��ϰ� ������ �ݺ���

        // Update is called once per frame
        void Update()
        {

        }
    }
}

