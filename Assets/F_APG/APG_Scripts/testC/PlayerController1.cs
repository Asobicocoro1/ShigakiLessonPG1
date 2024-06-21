using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController1 : MonoBehaviour
{
    public float autoRunSpeed = 5f;
    public float increasedSpeed = 8f;
    private bool isSlowMotion = false;
    private Vector3 targetPosition;
    private int evolutionStage = 0;
    public Slider timingSlider;
    private float sliderValue = 0.5f;
    private bool isSliderIncreasing = true;

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

    void HandleSlowMotion()
    {
        // スライダーの値を更新
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

    void StartSlowMotion()
    {
        isSlowMotion = true;
        timingSlider.gameObject.SetActive(true);
        sliderValue = 0.5f;
        isSliderIncreasing = true;
    }

    void EndSlowMotion()
    {
        isSlowMotion = false;
        timingSlider.gameObject.SetActive(false);

        // パーフェクトタイミングの判定
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

    public void Evolve()
    {
        if (evolutionStage < 3)
        {
            evolutionStage++;
            // 進化時の処理を追加
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ObstacleA") && evolutionStage >= 1)
        {
            Destroy(collision.gameObject);
            GameController.instance.AddScore(10);
        }
        else if (collision.gameObject.CompareTag("ObstacleB") && evolutionStage >= 2)
        {
            Destroy(collision.gameObject);
            GameController.instance.AddScore(20);
        }
        else if (collision.gameObject.CompareTag("ObstacleC"))
        {
            GameController.instance.GameOver();
        }
    }
}









