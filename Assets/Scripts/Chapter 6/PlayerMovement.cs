using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// �v���C���[�̈ړ��ƃW�����v�𐧌䂷��X�N���v�g
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // �v���C���[�̈ړ����x
    public float moveSpeed = 5f;
    // �W�����v�̗�
    public float jumpForce = 5f;
    // Rigidbody2D�R���|�[�l���g�ւ̎Q��
    private Rigidbody2D rb;
    // �v���C���[���n�ʂɐڂ��Ă��邩�ǂ����̃t���O
    private bool isGrounded;

    /// <summary>
    /// �����ݒ���s�����\�b�h
    /// </summary>
    void Start()
    {
        // Rigidbody2D�R���|�[�l���g���擾
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// �t���[�����ƂɌĂяo����郁�\�b�h
    /// </summary>
    void Update()
    {
        // �������͂��擾
        float moveInput = Input.GetAxis("Horizontal");
        // �������͂ɉ����ăv���C���[���ړ�
        rb.velocity = new Vector2(moveInput * moveSpeed, rb.velocity.y);

        // �W�����v���͂����m���A�n�ʂɐڂ��Ă���ꍇ�ɃW�����v
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
    }

    /// <summary>
    /// �I�u�W�F�N�g�����̃R���C�_�ƐڐG�����Ƃ��ɌĂ΂�郁�\�b�h
    /// </summary>
    /// <param name="collision">�ڐG�����R���C�_�̏��</param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ڐG�����I�u�W�F�N�g���uGround�v�^�O�����ꍇ
        if (collision.gameObject.CompareTag("Ground"))
        {
            // �n�ʂɐڂ��Ă���t���O��true�ɐݒ�
            isGrounded = true;
        }
    }

    /// <summary>
    /// �I�u�W�F�N�g�����̃R���C�_���痣�ꂽ�Ƃ��ɌĂ΂�郁�\�b�h
    /// </summary>
    /// <param name="collision">���ꂽ�R���C�_�̏��</param>
    private void OnCollisionExit2D(Collision2D collision)
    {
        // ���ꂽ�I�u�W�F�N�g���uGround�v�^�O�����ꍇ
        if (collision.gameObject.CompareTag("Ground"))
        {
            // �n�ʂɐڂ��Ă���t���O��false�ɐݒ�
            isGrounded = false;
        }
    }
}
