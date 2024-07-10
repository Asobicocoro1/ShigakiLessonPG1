using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class JGGenericButtonController : MonoBehaviour
{
    public UnityEvent onClick;

    void Start()
    {
        // �{�^���̎Q�Ƃ��擾���A�N���b�N�C�x���g�Ƀ��X�i�[��ǉ�
        GetComponent<Button>().onClick.AddListener(OnButtonClick);
    }

    void OnButtonClick()
    {
        if (onClick != null)
        {
            onClick.Invoke(); // UnityEvent�ɓo�^���ꂽ�֐����Ăяo��
        }
    }
}
