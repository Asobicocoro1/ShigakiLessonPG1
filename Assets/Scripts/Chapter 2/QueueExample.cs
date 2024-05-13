using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ���
�L���[�̍쐬�Fnew Queue<int>() �ŐV�����L���[�����܂��B���̃L���[�͐�����ۑ��ł��܂��B
�G���L���[����Fnumbers.Enqueue(1); �̂悤�ɂ��āA�L���[�̖����ɐV����������ǉ����܂��B
�f�L���[����Fnumbers.Dequeue(); ���g���āA�L���[�̐擪�̐��������o���܂��B
              ���̑���Ő�ɒǉ����ꂽ���������o����A�L���[����폜����܂��B
�L���[�̏�Ԋm�F�Fnumbers.Count �ŃL���[���̃A�C�e�������m�F���Anumbers.Peek() �Ŏ��Ɏ��o�����A�C�e�������������邱�Ƃ��ł��܂��B

�L���[�́A���Ԃɏ��������ׂ��^�X�N��f�[�^������ꍇ�ɔ��ɖ𗧂��܂��B���̐�����o���̐������A����̃V�i���I�Ŕ��ɕ֗��ȊǗ����@��񋟂��܂��B
 */

public class QueueExample : MonoBehaviour
{
    void Start()
    {
        Queue<int> numbers = new Queue<int>(); // �V�����L���[�����

        // �L���[�ɐ������G���L���[����
        numbers.Enqueue(1);
        numbers.Enqueue(2);
        numbers.Enqueue(3);

        // �L���[���琔�����f�L���[����
        Debug.Log(numbers.Dequeue()); // 1���\�������
        Debug.Log(numbers.Dequeue()); // 2���\�������

        // �L���[�Ɏc���Ă��鐔�����m�F
        Debug.Log("�L���[�ɂ� " + numbers.Count + " �̐������c���Ă��܂��B");
        Debug.Log("���Ɏ��o����鐔���� " + numbers.Peek() + " �ł��B"); // 3���\�������
    }
}

