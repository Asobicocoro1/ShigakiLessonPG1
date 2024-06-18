using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float slowSpeed = 1f;
    public float maxScale = 2f;
    public float scaleSpeed = 1f;
    private Vector3 initialScale;
    private Rigidbody2D rb;
    private bool isTimingPhase = false;
    private bool isAutoRunning = true;
    private Vector3 direction;
    public TimingGauge timingGauge; // �Q�[�W�̎Q�Ƃ�ǉ�

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialScale = transform.localScale;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (!isTimingPhase)
            {
                // �Q�[�W�^�C�~���O�t�F�[�Y�Ɉړ�
                isTimingPhase = true;
                isAutoRunning = false; // �I�[�g�������I�t�ɂ���
                rb.velocity = Vector2.zero; // �X���[��Ԃɂ���
                timingGauge.StartTiming(); // �Q�[�W�^�C�~���O�J�n
            }
            else
            {
                // �Q�[�W�^�C�~���O�t�F�[�Y�I��
                isTimingPhase = false;
                timingGauge.StopTiming(); // �Q�[�W�^�C�~���O�I��

                // �}�E�X�J�[�\���̈ʒu���擾
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = 0;

                // �v���C���[����}�E�X�J�[�\���ւ̕������v�Z
                direction = (mousePosition - transform.position).normalized;

                float scaleMultiplier = 1 + timingGauge.GetFillAmount() * (maxScale - 1);
                transform.localScale = initialScale * scaleMultiplier;
                rb.AddForce(direction * moveSpeed * scaleMultiplier, ForceMode2D.Impulse);
            }
        }

        if (isTimingPhase)
        {
            // �Q�[�W�^�C�~���O�t�F�[�Y���̓X���[���
            float scaleMultiplier = 1 + timingGauge.GetFillAmount() * (maxScale - 1);
            transform.localScale = initialScale * scaleMultiplier;
            rb.velocity = direction * slowSpeed;
        }
        else if (isAutoRunning)
        {
            // �I�[�g�������L���ȏꍇ�ɉE�Ɏ����ňړ�
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // �����ɐڐG�����Ƃ��ɃI�[�g�������ĊJ����
        if (!isAutoRunning)
        {
            isAutoRunning = true;
        }
    }
}






