using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ���̃X�N���v�g�ł́Afor ���[�v���g���āu�����S����J�S�ɓ��ꂽ��I�v�Ƃ������b�Z�[�W��5��\�����܂��B
 i < 5 �́Ai ��0����n�܂�5�����̊ԁi�܂�A0, 1, 2, 3, 4 ��5��j���[�v�𑱂���Ƃ����Ӗ��ł��B

�ق��̃p�^�[��
i < 5�F�ui��5�����̊ԁv�J��Ԃ��Ƃ����Ӗ��ł��B�܂�Ai��0, 1, 2, 3, 4�̂Ƃ��ɓ��삵�܂��B
i <= 5�F�ui��5�ȉ��̊ԁv�J��Ԃ��Ƃ����Ӗ��ł��Bi��0, 1, 2, 3, 4, 5�̂Ƃ��ɓ��삵�܂��B
i > 5�F�ui��5���傫���ԁv�J��Ԃ��Ƃ����Ӗ��ł��B�������A��������[�v�̊J�n�����Ɏg���ꍇ�́Ai�̏����l��5���傫���ݒ肷��K�v������܂��B
i >= 5�F�ui��5�ȏ�̊ԁv�J��Ԃ��Ƃ����Ӗ��ł��B���̏������Ai�̏����l��5�ȏ�ɐݒ肷��K�v������܂��B
 */

public class ApplePicker : MonoBehaviour
{
    void Start()
    {
        // 5�̃����S���J�S�ɓ����
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("�����S����J�S�ɓ��ꂽ��I");
        }
    }
}

