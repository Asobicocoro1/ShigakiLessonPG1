using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 1. �ϐ��ƃf�[�^�^
�ϐ��́A�f�[�^��ۑ����邽�߂̔��̂悤�Ȃ��̂ł��B
�Ⴆ�΁A���Ȃ��̖��O��A�����Ă��邨�َq�̐��Ȃǂ��L�^���邽�߂Ɏg���܂��B
�f�[�^�^�́A���̔����ǂ�Ȏ�ނ̂��̂������邩�������Ă���܂��B
���Ƃ��΁A�u���v�����锠��A�u�����v�����锠������܂��B

2. �����������
������Ƃ́A���������񂾂��̂ł��B���O��A�D���ȐH�ו��̖��O�ȂǁA���t���v���O�������Ŏg�������Ƃ���string�^�̕ϐ����g���܂��B

3�ϐ��ɕۑ����ꂽ�f�[�^���g���āA�����Z������Z�Ȃǂ̌v�Z���s�����Ƃ��ł��܂��B3

int�͐�����ۑ����邽�߂̃f�[�^�^�ł��B
string�͕����╶�͂�ۑ����邽�߂̃f�[�^�^�ł��B

�����̊�{�I�ȊT�O�������ł���΁A�v���O���~���O�ł��낢��Ȃ��Ƃ��ł���悤�ɂȂ�܂��B
�ϐ����g���ď���ۑ�������A���̏����g���Čv�Z��������A���������������肷�邱�Ƃ��A�v���O���~���O�Ŋy�����V�ԑ����ł��I

��ʂ�̌v�Z�p�^�[��
���Z�i�����Z�j�A���Z�i�����Z�j�A��Z�i�|���Z�j�A���Z�i����Z�j�Ȃǂ̊�{�I�ȉ��Z�ƁA���̑��̉��Z�q�ɂ��Ă��������܂��B

�C���N�������g�ƃf�N�������g
�C���N�������g�i++�j�́A�ϐ��̒l��1���₷����ł��B�f�N�������g�i--�j�́A�ϐ��̒l��1���炷����ł��B
 */


public class Operation : MonoBehaviour
{
    private int age = 10;  // �uint�v�͐��������锠�A�uage�v�͕ϐ����A10�͓���鐔
    private string nameimg = "�n��";  // �ustring�v�͕��������锠�A�uname�v�͕ϐ����A"�n��"�͓���镶��
    // Start is called before the first frame update
    void Start()
    {
        

        //�����ł́AfavoriteFood�Ƃ����ϐ���"�A�C�X�N���[��"�Ƃ����������ۑ����A�����\�����Ă��܂��B
        string favoriteFood = "�A�C�X�N���[��";
        Debug.Log("���̍D���ȐH�ו��� " + favoriteFood + " �ł��B");

        //apples��oranges�ɂ��ꂼ�ꐔ�������Ă��āAtotalFruits�ł͂����𑫂��Z���Ă��܂��B
        int apples = 5;
        int oranges = 3;
        int totalFruits = apples + oranges;
        Debug.Log("�ʕ��̍��v�� " + totalFruits + " �ł��B");

        int sum = 5 + 3; // 5��3�𑫂�
        Debug.Log("���v: " + sum); // �o��: ���v: 8

        int difference = 10 - 6; // 10����6������
        Debug.Log("��: " + difference); // �o��: ��: 4

        int product = 4 * 2; // 4��2���|����
        Debug.Log("��: " + product); // �o��: ��: 8

        int quotient = 20 / 5; // 20��5�Ŋ���
        Debug.Log("��: " + quotient); // �o��: ��: 4

        int remainder = 7 % 3; // 7��3�Ŋ������]��
        Debug.Log("�]��: " + remainder); // �o��: �]��: 1

        int number = 10;
        number++; // number��1�𑫂�
        Debug.Log("�C���N�������g��: " + number); // �o��: �C���N�������g��: 11

        number--; // number����1������
        Debug.Log("�f�N�������g��: " + number); // �o��: �f�N�������g��: 10

    }
    //�����̉��Z�q���g���āA�v���O�������Ő��l���v�Z������A�f�[�^�𑀍삵���肷�邱�Ƃ��ł��܂��B
    //����ɂ��A�v���O��������蓮�I�ŗL�p�Ȃ��̂ɂȂ�܂��B
    //���w���ł��A�����̊�{�I�ȉ��Z�������ł���΁A�v���O���~���O�ŗV�тȂ���w�Ԃ��Ƃ��y�����Ȃ�ł��傤�I
    // Update is called once per frame
    

}
