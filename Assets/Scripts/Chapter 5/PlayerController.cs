using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ���{�����t���̃X�N���v�g�̐���
public float speed = 10f;

�v���C���̈ړ����x��ݒ肵�܂��B�Ⴆ�΁A10f�Ƃ���ƁA������10�̃X�s�[�h�œ����܂��B
void Update()

Update���\�b�h�́A�Q�[���̃t���[�����ƂɌĂяo����܂��B�܂�A1�b�Ԃɉ�������s����܂��B
float moveHorizontal = Input.GetAxis("Horizontal");

Input.GetAxis("Horizontal")�́A�L�[�{�[�h�̍��E�̖��L�[��A��D�L�[�̓��͂��擾���܂��B�Ⴆ�΁A�E���L�[��������1�A�����L�[��������-1�̒l��Ԃ��܂��B
float moveVertical = Input.GetAxis("Vertical");

Input.GetAxis("Vertical")�́A�L�[�{�[�h�̏㉺�̖��L�[��W��S�L�[�̓��͂��擾���܂��B�Ⴆ�΁A����L�[��������1�A�����L�[��������-1�̒l��Ԃ��܂��B
Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

Vector3��3�����̃x�N�g���i�����j��\���܂��B�����ł́A�������iX���j�Əc�����iZ���j�̓��͂��g���āA�v���C���̈ړ����������߂Ă��܂��B
transform.Translate(movement * speed * Time.deltaTime);

transform.Translate�́A�I�u�W�F�N�g���w�肵�������Ɉړ������郁�\�b�h�ł��Bmovement�̕����ɁAspeed�̑����ŁATime.deltaTime�i1�t���[���̎��ԁj���|���Ĉړ����܂��B
 */

public class PlayerController : MonoBehaviour
{
    // �v���C���̈ړ����x��ݒ肵�܂�
    public float speed = 10f;

    void Update()
    {
        // �������̓��͂��擾���܂��i���L�[�̍��E��A��D�L�[�j
        float moveHorizontal = Input.GetAxis("Horizontal");
        // �c�����̓��͂��擾���܂��i���L�[�̏㉺��W��S�L�[�j
        float moveVertical = Input.GetAxis("Vertical");

        // �ړ�������������߂܂��B�������̓��͂Əc�����̓��͂��g���܂��B
        //x,y,z�̏�
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        // �v���C�����ړ������܂��B
        // movement�̕�����speed�̑����ŁA���Ԃɍ��킹�Ĉړ����܂��B
        transform.Translate(movement * speed * Time.deltaTime);
    }
}

