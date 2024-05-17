using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Roulette : MonoBehaviour
{
    // �j�̃I�u�W�F�N�g
    public GameObject needle;

    // �e�L�X�g�I�u�W�F�N�g
    public Text resultText;

    // ���[���b�g�̉�]���x
    private float rotationSpeed = 50.0f;

    // ���[���b�g�̉�]�p�x
    private float rotationAngle = 0.0f;

    // ���[���b�g�̒�~�t���O
    private bool isStopped = false;

    // Start() �֐�
    void Start()
    {
        // �ŏ��ɐj�������_���Ȋp�x�ɉ�]������
        needle.transform.Rotate(0.0f, 0.0f, Random.Range(0.0f, 360.0f));
    }

    // Update() �֐�
    void Update()
    {
        // ���[���b�g����]���Ă��Ȃ��ꍇ�͏������X�L�b�v
        if (isStopped)
        {
            return;
        }

        // �j����]������
        needle.transform.Rotate(0.0f, 0.0f, rotationSpeed * Time.deltaTime);

        // ���[���b�g�̉�]�p�x���X�V����
        rotationAngle += rotationSpeed * Time.deltaTime;

        // ���[���b�g�̉�]���~����^�C�~���O�����m����
        if (rotationAngle >= 3600.0f)
        {
            // ���[���b�g�̉�]���~����
            rotationSpeed = 0.0f;

            // ��~�����ꏊ�������_���Ɍ��肷��
            int result = Random.Range(0, 36);

            // ���ʂ��e�L�X�g�ɕ\������
            resultText.text = "���ʁF" + result.ToString();

            // ���[���b�g�̒�~�t���O�𗧂Ă�
            isStopped = true;
        }
    }
}

