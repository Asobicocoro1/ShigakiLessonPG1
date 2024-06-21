using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// �v���C���[�̓�����Ǘ�����X�N���v�g�B�I�[�g�����A�X���[���[�V�����A�i���A��Q���j��Ȃǂ̏������s���܂��B
/// </summary>
public class CoinController : MonoBehaviour
{
    public float autoRunSpeed = 5f; // �v���C���[�̃I�[�g�������x
    public float increasedSpeed = 8f; // ���x�������̑��x
    private bool isSlowMotion = false; // �X���[���[�V���������ǂ����̃t���O
    private Vector3 targetPosition; // �v���C���[�̃^�[�Q�b�g�ʒu
    private int evolutionStage = 0; // �v���C���[�̐i���X�e�[�W
    public Slider timingSlider; // �^�C�~���O�X���C�_�[
    private float sliderValue = 0.5f; // �X���C�_�[�̒l
    private bool isSliderIncreasing = true; // �X���C�_�[�̒l�������������������̃t���O

    void Update()
    {
        if (isSlowMotion)
        {
            HandleSlowMotion();
        }
        else
        {
            transform.Translate(Vector3.right * autoRunSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (isSlowMotion)
            {
                EndSlowMotion();
            }
            else
            {
                StartSlowMotion();
            }
        }

        if (!isSlowMotion && Vector3.Distance(transform.position, targetPosition) > 0.1f)
        {
            Vector3 direction = (targetPosition - transform.position).normalized;
            transform.Translate(direction * autoRunSpeed * Time.deltaTime);
        }
    }

    /// <summary>
    /// �X���[���[�V�������̏������s�����\�b�h�B
    /// </summary>
    void HandleSlowMotion()
    {
        // �X���C�_�[�̒l���X�V
        if (isSliderIncreasing)
        {
            sliderValue += Time.deltaTime * 0.5f;
            if (sliderValue >= 1f)
            {
                sliderValue = 1f;
                isSliderIncreasing = false;
            }
        }
        else
        {
            sliderValue -= Time.deltaTime * 0.5f;
            if (sliderValue <= 0f)
            {
                sliderValue = 0f;
                isSliderIncreasing = true;
            }
        }

        timingSlider.value = sliderValue;
    }

    /// <summary>
    /// �X���[���[�V�������J�n���郁�\�b�h�B
    /// </summary>
    void StartSlowMotion()
    {
        isSlowMotion = true;
        timingSlider.gameObject.SetActive(true);
        sliderValue = 0.5f;
        isSliderIncreasing = true;
    }

    /// <summary>
    /// �X���[���[�V�������I�����郁�\�b�h�B
    /// </summary>
    void EndSlowMotion()
    {
        isSlowMotion = false;
        timingSlider.gameObject.SetActive(false);

        // �p�[�t�F�N�g�^�C�~���O�̔���
        if (sliderValue >= 0.48f && sliderValue <= 0.52f)
        {
            autoRunSpeed = increasedSpeed;
        }
        else
        {
            autoRunSpeed = 5f;
        }

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPosition = new Vector3(mousePosition.x, mousePosition.y, transform.position.z);
    }

    /// <summary>
    /// �v���C���[��i�������郁�\�b�h�B
    /// </summary>
    public void Evolve()
    {
        if (evolutionStage < 3)
        {
            evolutionStage++;
            // �i�����̏�����ǉ�
            Debug.Log("Player evolved to stage " + evolutionStage);
        }
    }

    /// <summary>
    /// �v���C���[�̐i���X�e�[�W���擾���郁�\�b�h�B
    /// </summary>
    /// <returns>�v���C���[�̐i���X�e�[�W</returns>
    public int GetEvolutionStage()
    {
        return evolutionStage;
    }

    /// <summary>
    /// �R���C�_�[�ɏՓ˂������̏������s�����\�b�h�B
    /// </summary>
    /// <param name="collision">�Փ˂����R���C�_�[</param>
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ObstacleA") && GetEvolutionStage() >= 1)
        {
            Destroy(collision.gameObject);
            GameController.instance.AddScore(10);
            GameController.instance.PlaySFX(GameController.instance.obstacleDestroyClip);
        }
        else if (collision.gameObject.CompareTag("ObstacleB") && GetEvolutionStage() >= 2)
        {
            Destroy(collision.gameObject);
            GameController.instance.AddScore(20);
            GameController.instance.PlaySFX(GameController.instance.obstacleDestroyClip);
        }
        else if (collision.gameObject.CompareTag("ObstacleC"))
        {
            GameController.instance.GameOver();
        }
        else if (collision.gameObject.CompareTag("GoalLine"))
        {
            GameController.instance.NextStage();
        }
        else if (collision.gameObject.CompareTag("Item"))
        {
            Evolve();
            Destroy(collision.gameObject);
        }
    }
}


