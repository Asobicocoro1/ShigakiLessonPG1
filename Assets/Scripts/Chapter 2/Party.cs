using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ����
�f���Q�[�g�ƃC�x���g�̐錾�F����́A�C�x���g���ǂ�ȂƂ��Ɏg���邩�̃��[������镔���ł��B
�C�x���g�̔��΁F����́A���D�����ꂽ�Ƃ����u�j���[�X�v�𑼂̃v���O�����̕����ɓ`���邽�߂ɁA�C�x���g���N���������ł��B
�C�x���g�Ƀ��\�b�h��o�^�F����́A�C�x���g���N�����Ƃ��ɉ������邩���v���O�����ɋ����镔���ł��B
                          �����ł́uAnnounce�v�Ƃ������\�b�h���C�x���g�ɔ������܂��B
�C�x���g�����������Ƃ��Ɏ��s����郁�\�b�h�F���D�����ꂽ�Ƃ��ɁA�u���D������܂����I�F�A�����Ȃ��łˁI�v�ƕ\�����郁�\�b�h�ł��B
���̂悤�ɃC�x���g���g�����ƂŁA�v���O�����̈ꕔ�����̕����Ɂu�������ʂȂ��Ƃ��N��������v�Ƌ����邱�Ƃ��ł��܂��B
����𕷂������̕����́A���߂�ꂽ���������܂��B���ꂪ�v���O���~���O�ł̃C�x���g�̊�{�I�Ȏg�����ł��B
 */

public class Party : MonoBehaviour
{
    // �f���Q�[�g�ƃC�x���g�̐錾
    public delegate void BalloonPoppedAction();
    public event BalloonPoppedAction OnBalloonPopped;

    void Start()
    {
        // �C�x���g�𔭉΂�����i���D�����ꂽ���Ƃ�m�点��j
        if (OnBalloonPopped != null)
        {
            OnBalloonPopped();
        }
    }

    void OnEnable()
    {
        // �C�x���g�Ƀ��\�b�h��o�^
        OnBalloonPopped += Announce;
    }

    void OnDisable()
    {
        // �C�x���g���烁�\�b�h���폜
        OnBalloonPopped -= Announce;
    }

    // �C�x���g�����������Ƃ��Ɏ��s����郁�\�b�h
    void Announce()
    {
        Debug.Log("���D������܂����I�F�A�����Ȃ��łˁI");
    }
}
