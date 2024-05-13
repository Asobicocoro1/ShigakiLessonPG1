using System.Collections;
using System.Collections.Generic; // ���X�g���g�����߂ɕK�v
using UnityEngine;

/*
 ���
���X�g�̍쐬�FList<string> pets = new List<string>(); �ŐV�������X�g�����܂��B���̃��X�g�͕������ۑ����邽�߂̂��̂ł��B
�ǉ��Fpets.Add("����"); �̂悤�� .Add ���\�b�h���g���ă��X�g�ɐV�����A�C�e����ǉ����܂��B
�\���Fforeach ���[�v���g���ă��X�g�̒��g��������o���A�\�����܂��B
�폜�Fpets.Remove("�Ƃ�"); �Ń��X�g�������̃A�C�e�����폜���܂��B
���̂悤�Ƀ��X�g���g���ƁA�f�[�^�̊Ǘ����ƂĂ��֗��ɂȂ�܂��B
�܂��A���X�g�͒��ɂ����f�[�^�������Ă��A�ȒP�Ɉ������Ƃ��ł���̂ŁA��������̃f�[�^��ۑ����Ă����̂ɍœK�ł��B
�v���O���~���O�Ń��X�g�����Ɏg�����Ƃ��ł���΁A���낢��ȏ����ȒP�ɐ����ł���悤�ɂȂ�܂���B
 */

public class PetListExample : MonoBehaviour
{
    void Start()
    {
        // �V�������X�g�����
        List<string> pets = new List<string>();

        // ���X�g�Ƀy�b�g�̖��O��ǉ�����
        pets.Add("����");
        pets.Add("�˂�");
        pets.Add("�Ƃ�");

        // ���X�g����y�b�g�̖��O������\������
        foreach (string pet in pets)
        {
            Debug.Log(pet);
        }

        // ���X�g����u�Ƃ�v���폜����
        pets.Remove("�Ƃ�");

        // �u�Ƃ�v���폜������̃��X�g�̓��e��\������
        foreach (string pet in pets)
        {
            Debug.Log(pet);
        }
    }
}
