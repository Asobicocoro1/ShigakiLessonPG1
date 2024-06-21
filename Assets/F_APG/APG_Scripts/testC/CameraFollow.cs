using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // �J�������ǐՂ���^�[�Q�b�g�i�v���C���[�j
    public float xOffset = 5f;  // X���̃I�t�Z�b�g
    public float yOffset = 0f;  // Y���̃I�t�Z�b�g
    public float minY = -4f;    // �J������Y���W�̍ŏ��l
    public float maxY = 4f;     // �J������Y���W�̍ő�l
    public float smoothSpeed = 1f; // �J�����̒Ǐ]���x

    void LateUpdate()
    {
        if (player != null)
        {
            // �v���C���[�̈ʒu���擾
            Vector3 targetPosition = player.position;

            // �J�����̐V����X���W���v���C���[��X���W�ɃI�t�Z�b�g�������Đݒ�
            float newX = targetPosition.x + xOffset;

            // �J�����̐V����Y���W���v���C���[��Y���W�ɃI�t�Z�b�g�������Đݒ�
            float newY = Mathf.Clamp(targetPosition.y + yOffset, minY, maxY);

            // �J�����̐V�����ʒu���v�Z
            Vector3 newPosition = new Vector3(newX, newY, transform.position.z);

            // �J�����̈ʒu�����炩�Ɉړ�
            transform.position = Vector3.Lerp(transform.position, newPosition, smoothSpeed);
        }
    }
}
