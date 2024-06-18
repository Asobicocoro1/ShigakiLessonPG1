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
    public TimingGauge timingGauge; // ゲージの参照を追加

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
                // ゲージタイミングフェーズに移動
                isTimingPhase = true;
                isAutoRunning = false; // オートランをオフにする
                rb.velocity = Vector2.zero; // スロー状態にする
                timingGauge.StartTiming(); // ゲージタイミング開始
            }
            else
            {
                // ゲージタイミングフェーズ終了
                isTimingPhase = false;
                timingGauge.StopTiming(); // ゲージタイミング終了

                // マウスカーソルの位置を取得
                Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                mousePosition.z = 0;

                // プレイヤーからマウスカーソルへの方向を計算
                direction = (mousePosition - transform.position).normalized;

                float scaleMultiplier = 1 + timingGauge.GetFillAmount() * (maxScale - 1);
                transform.localScale = initialScale * scaleMultiplier;
                rb.AddForce(direction * moveSpeed * scaleMultiplier, ForceMode2D.Impulse);
            }
        }

        if (isTimingPhase)
        {
            // ゲージタイミングフェーズ中はスロー状態
            float scaleMultiplier = 1 + timingGauge.GetFillAmount() * (maxScale - 1);
            transform.localScale = initialScale * scaleMultiplier;
            rb.velocity = direction * slowSpeed;
        }
        else if (isAutoRunning)
        {
            // オートランが有効な場合に右に自動で移動
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // 何かに接触したときにオートランを再開する
        if (!isAutoRunning)
        {
            isAutoRunning = true;
        }
    }
}






