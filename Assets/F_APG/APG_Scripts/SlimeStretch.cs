using UnityEngine;

public class SlimeStretch : MonoBehaviour
{
    public float stretchMultiplier = 3.0f;  // �L�т�ʂ𒲐����邽�߂̔{��
    private Vector3 startPoint;
    private Vector3 endPoint;
    private bool isPulling = false;
    private Vector3 originalScale;
    private Quaternion originalRotation;

    void Start()
    {
        originalScale = transform.localScale;
        originalRotation = transform.rotation;
    }

    void Update()
    {
        // ��������̊J�n
        if (Input.GetKeyDown(KeyCode.S))
        {
            startPoint = transform.position;
            isPulling = true;
        }

        // ��������̕����ƏI�_���v�Z
        if (isPulling)
        {
            endPoint = startPoint;
            bool horizontal = false;
            bool vertical = false;

            if (Input.GetKey(KeyCode.W))
            {
                endPoint += Vector3.up;
                vertical = true;
            }
            if (Input.GetKey(KeyCode.A))
            {
                endPoint += Vector3.left;
                horizontal = true;
            }
            if (Input.GetKey(KeyCode.X))
            {
                endPoint += Vector3.down;
                vertical = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                endPoint += Vector3.right;
                horizontal = true;
            }

            // �X���C���̐L�т铮��Ɖ�]
            if (endPoint != startPoint)
            {
                Vector3 direction = endPoint - startPoint;
                float distance = direction.magnitude;
                Vector3 stretchScale = originalScale;

                // �X�P�[���̒���
                if (horizontal && !vertical) // ���������Ɉ��������Ă���ꍇ
                {
                    stretchScale.x += distance * stretchMultiplier;
                }
                else if (vertical && !horizontal) // ���������Ɉ��������Ă���ꍇ
                {
                    stretchScale.y += distance * stretchMultiplier;
                }
                else // �΂߂Ɉ��������Ă���ꍇ
                {
                    stretchScale.x -= distance * stretchMultiplier * 0.5f; // �����k�߂�
                    stretchScale.y += distance * stretchMultiplier; // �c��L�΂�

                    // ������������ɍ��킹�ĉ�]
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.Euler(0, 0, angle);
                }

                // �X���C���̃X�P�[����ύX
                transform.localScale = stretchScale;

                // �X���C���̈ʒu�𒲐�
                transform.position = startPoint + direction / 2;
            }
        }

        // ��������̉��
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = originalScale;  // �X���C���̃X�P�[�������ɖ߂�
            transform.rotation = originalRotation;  // �X���C���̉�]�����ɖ߂�
            transform.position = startPoint;  // �X���C���̃|�W�V���������ɖ߂�
            isPulling = false;
        }
    }
}
