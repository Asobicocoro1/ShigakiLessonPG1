using System.Collections;
using System.Collections.Generic; // �X�^�b�N���g�����߂ɕK�v
using UnityEngine;
/*
 * C#�̕W�����C�u�����ł���System.Collections.Generic���O��Ԃɂ���Stack<T>�N���X���񋟂��郁�\�b�h
 * UnityEngine���񋟂�����̂�ق��̒񋟂��郁�\�b�h���������񂠂�܂��B
 * 
���
�X�^�b�N�̍쐬�Fnew Stack<string>() �ŐV�����X�^�b�N�����܂��B����ŕ������ۑ��ł���X�^�b�N���ł��܂����B
�v�b�V������Fbooks.Push("�{1"); �̂悤�ɂ��āA�X�^�b�N�ɐV�����{��ǉ����܂��B
              ���̑���ŃX�^�b�N�̈�ԏ�ɐV�����A�C�e�����ςݏd�Ȃ�܂��B
�|�b�v����Fbooks.Pop(); ���g���āA�X�^�b�N�̈�ԏ�̃A�C�e�������o���܂��B
            ���̑���ōŌ�ɒǉ����ꂽ�A�C�e�������o����A�X�^�b�N����폜����܂��B
�X�^�b�N�̏�Ԋm�F�Fbooks.Count �ŃX�^�b�N���̃A�C�e�������m�F���Abooks.Peek() �Ŏ��Ɏ��o�����A�C�e�������������邱�Ƃ��ł��܂��B

�X�^�b�N�́A�ォ����ꂽ���̂��Ɏ��o���Ƃ��������������Ă��邽�߁A�t���Ńf�[�^�����������Ƃ���A
�Ō�ɒǉ����ꂽ���̂ɂ����ɃA�N�Z�X�������Ƃ��ɔ��ɕ֗��ł��B

*/

public class StackExample : MonoBehaviour
{
    void Start()
    {
        Stack<string> books = new Stack<string>(); // �V�����X�^�b�N�����

        // �X�^�b�N�ɖ{���v�b�V������
        books.Push("�{1");
        books.Push("�{2");
        books.Push("�{3");

        // �X�^�b�N����{���|�b�v����
        Debug.Log(books.Pop()); // "�{3"���\�������
        Debug.Log(books.Pop()); // "�{2"���\�������

        // �X�^�b�N�Ɏc���Ă���{���m�F
        Debug.Log("�X�^�b�N�ɂ� " + books.Count + " ���̖{���c���Ă��܂��B");
        Debug.Log("���Ɏ��o�����{�� " + books.Peek() + " �ł��B"); // "�{1"���\�������
    }
}

