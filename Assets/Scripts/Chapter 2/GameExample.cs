using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 �ȒP�Ȑ���
�X�^�[�g�ʒu�FVector3(0, 0, 0)�́A�Q�[���̐��E�̒��S�_���Ӗ����܂��B
����̓Q�[���̒n�ʂƓ��������ŁA�܂������O�������Ă����Ԃł��B
�ړI�n�FVector3(10, 5, 0)�́A�X�^�[�g�ʒu����E��10���[�g���A���5���[�g���ړ������ꏊ�������Ă��܂��B
Z�l��0�Ȃ̂ŁA�O��ɂ͓����܂���B
Lerp�֐��F���̊֐��́A�u���`��ԁv�ƌĂ΂�A��̓_�̊Ԃ��Ȃ߂炩�Ɉړ�����Ƃ��Ɏg���܂��B
���̗�ł́A�X�^�[�g�ʒu�ƖړI�n�̂��傤�ǒ��ԓ_�Ƀ{�[�����ړ������܂��B
���̂悤��Vector3���g�����ƂŁA�Q�[���̒��ŕ��̈ʒu�⓮���𐳊m�ɐ���ł��܂��B
�Q�[�������Ƃ��ɁA�ǂ��ɉ���u�����A�ǂ������������l����̂ɂƂĂ��𗧂��܂��B

�v���C���[�̈ړ����@�Ȃǂ̓`���v�^�[�R�ł��܂�����
 */

public class GameExample : MonoBehaviour
{
    void Start()
    {
        // Vector3�����
        Vector3 startPosition = new Vector3(0, 0, 0);  // ����̓Q�[���̐��E�ł̃X�^�[�g�ʒu��\��
        Vector3 endPosition = new Vector3(10, 5, 0);  // ����̓{�[�������ł����ړI�n��\��

        // �{�[�����X�^�[�g�ʒu����ړI�n�֓�����
        transform.position = Vector3.Lerp(startPosition, endPosition, 0.5f);  // Lerp�͓�̏ꏊ�̊Ԃ����炩�Ɉړ�������@�ł�
    }
}

