using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ���̗�ł́AGreet() �Ƃ����֐������܂����B
����́u����ɂ��́I�v�ƌ��������̊ȒP�Ȉ��A������֐��ł��B
Start() �̒��� Greet(); ���Ăяo�����ƂŁA�Q�[�����n�܂�Ǝ����I�Ɉ��A�����܂��B
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

