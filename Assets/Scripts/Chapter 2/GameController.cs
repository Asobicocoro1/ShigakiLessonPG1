using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ���̗�ł́AGreet() �Ƃ����֐������܂����B
����́u����ɂ��́I�v�ƌ��������̊ȒP�Ȉ��A������֐��ł��B
Start() �̒��� Greet(); ���Ăяo�����ƂŁA�Q�[�����n�܂�Ǝ����I�Ɉ��A�����܂��B

�������Ԃ�l���Ȃ����\�b�h
�������Ԃ�l���Ȃ����\�b�h�́A���������̍�Ƃ����邾���ŁA�O���牽�������󂯎�炸�i�����Ȃ��j�A��Ƃ̌��ʂ��O�ɏo���Ȃ��i�Ԃ�l�Ȃ��j���\�b�h�ł��B
 */

public class GameController : MonoBehaviour
{
    void Start()
    {
        // �֐����g���āu����ɂ��́I�v�ƈ��A����
        Greet();
    }

    // Greet�֐�: ���A������
    void Greet()
    {
        Debug.Log("����ɂ��́I");
    }
}

