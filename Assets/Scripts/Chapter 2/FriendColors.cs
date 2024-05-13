using System.Collections;
using System.Collections.Generic; // �������g�����߂ɕK�v
using UnityEngine;

/*
 ���
!���̎����͕�����̃L�[�ƒl�������܂��B!
�����̍쐬�FDictionary<string, string> favoriteColors = new Dictionary<string, string>(); �ŐV�������������܂��B
�ǉ��F.Add ���\�b�h���g���āA�F�B�̖��O���L�[�Ƃ��āA����ɑΉ�����D���ȐF��l�Ƃ��Ēǉ����܂��B
�擾�FfavoriteColors["�n��"] �̂悤�ɁA�L�[���w�肵�Ă��̒l���擾���܂��B
�폜�F.Remove ���\�b�h���g���ē���̃L�[�i�����ł́u���~�v�j�Ƃ��̒l����������폜���܂��B
���e�̊m�F�Fforeach ���[�v���g���Ď����̒��̂��ׂẴL�[�ƒl��\�����܂��B

entry�̎g����
foreach���[�v���g���Ď����̒��g��������Ă����Ƃ��ɁAKeyValuePair<TKey, TValue>�^�̕ϐ��Ƃ���entry���g���܂��B
����ɂ���āA�e�G���g���̃L�[�ƒl�ɃA�N�Z�X���邱�Ƃ��ł��܂��B

�����͏��𐮗����Ă��΂₭�A�N�Z�X����̂ɂƂĂ��֗��ł��B�L�[��m���Ă���΁A���̃L�[�Ɋ֘A������������Ɍ����邱�Ƃ��ł���̂ŁA
�v���O���~���O�ŏ����Ǘ�����Ƃ��ɖ𗧂��܂���B
 */

public class FriendColors : MonoBehaviour
{
    void Start()
    {
        // �V�������������
        Dictionary<string, string> favoriteColors = new Dictionary<string, string>();

        // �����ɗF�B�̖��O�ƍD���ȐF��ǉ�����
        favoriteColors.Add("�n��", "��");
        favoriteColors.Add("���~", "�s���N");
        favoriteColors.Add("�g��", "��");

        // �n���̍D���ȐF��\������
        Debug.Log("�n���̍D���ȐF�� " + favoriteColors["�n��"] + " �ł��B");

        // ���~�̍D���ȐF����������폜����
        favoriteColors.Remove("���~");

        // �����̓��e���m�F����
        foreach (KeyValuePair<string, string> entry in favoriteColors)
        {
            Debug.Log(entry.Key + "�̍D���ȐF�� " + entry.Value + " �ł��B");
        }
    }
}
