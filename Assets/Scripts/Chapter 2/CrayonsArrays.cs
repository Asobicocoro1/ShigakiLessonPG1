using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ���̃v���O�����ł́A5�F�̃N�������𔠁i�z��j�ɓ���āA���ꂼ��̃N��������������Ă����܂��B
crayons.Length �͔z��̒����A�܂�N�������̐��������Ă���܂��B
for���[�v���g���āA���̒��̃N��������������o���āA���Ԗڂɂǂ�ȐF�����邩���m�F���Ă��܂��B

�z����g�������b�g
�z����g���ƁA������ނ̂�������̃f�[�^���ȒP�ɊǗ��ł��܂��B
�Ⴆ�΁A�N���X�̑S���̃e�X�g�̓_����A���C�ɓ���̃A�j���̃��X�g�ȂǁA�����悤�Ȃ��̂��܂Ƃ߂Ă����̂ɕ֗��ł��B
����ɁA���Ԗڂɉ������邩���ȒP�ɒm�邱�Ƃ��ł���̂ŁA���������Ɍ������܂��B

���̂悤�ɔz����g�����ƂŁA�v���O���~���O�������Ɗy�����A���ɗ����̂ɂȂ�܂��B���낢��ȃf�[�^��z��ɓ���ĊǗ����Ă݂�Ƃ����ł��傤�I


���L�̔z��ł́A��x�쐬����Ƃ��̃T�C�Y��ύX���邱�Ƃ͂ł��܂���B
�܂�A�z��ɐV�����v�f��ǉ�������A�v�f���폜�����肷�邱�Ƃ͒��ړI�ɂ͂ł��Ȃ��̂ł��B
�������A�V�����v�f��ǉ��������ꍇ��A�v�f���폜�������ꍇ�ɂ́A�V�����z����쐬���āA���̗v�f��V�����z��ɃR�s�[����K�v������܂��B
�ǉ��폜�Ȃ�List���g���܂��傤

 */

public class CrayonsArrays : MonoBehaviour
{

// Start is called before the first frame update
    void Start()
    {
        // 5�F�̃N��������z��ō��
        string[] crayons = new string[5];  // �ustring�v�͕����̃f�[�^��ۑ�����Ƃ����Ӗ�
        crayons[0] = "��";  // 0�Ԗڂ̈ʒu�Ɂu�ԁv������
        crayons[1] = "��";  // 1�Ԗڂ̈ʒu�Ɂu�v������
        crayons[2] = "��";  // 2�Ԗڂ̈ʒu�Ɂu�΁v������
        crayons[3] = "��";  // 3�Ԗڂ̈ʒu�Ɂu���v������
        crayons[4] = "��";  // 4�Ԗڂ̈ʒu�Ɂu���v
        
        // �z��̒��g���m�F����
        for (int i = 0; i < crayons.Length; i++)
        {
            Debug.Log("�N��������" + (i + 1) + "�Ԗڂ̐F��" + crayons[i] + "�ł��B");
        }
    }

}
