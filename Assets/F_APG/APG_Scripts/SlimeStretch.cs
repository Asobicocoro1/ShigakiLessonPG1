using UnityEngine;

public class SlimeStretch : MonoBehaviour
{
    public float stretchMultiplier = 3.0f;  // 伸びる量を調整するための倍率
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
        // 引っ張りの開始
        if (Input.GetKeyDown(KeyCode.S))
        {
            startPoint = transform.position;
            isPulling = true;
        }

        // 引っ張りの方向と終点を計算
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

            // スライムの伸びる動作と回転
            if (endPoint != startPoint)
            {
                Vector3 direction = endPoint - startPoint;
                float distance = direction.magnitude;
                Vector3 stretchScale = originalScale;

                // スケールの調整
                if (horizontal && !vertical) // 水平方向に引っ張られている場合
                {
                    stretchScale.x += distance * stretchMultiplier;
                }
                else if (vertical && !horizontal) // 垂直方向に引っ張られている場合
                {
                    stretchScale.y += distance * stretchMultiplier;
                }
                else // 斜めに引っ張られている場合
                {
                    stretchScale.x -= distance * stretchMultiplier * 0.5f; // 横を縮める
                    stretchScale.y += distance * stretchMultiplier; // 縦を伸ばす

                    // 引っ張り方向に合わせて回転
                    float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                    transform.rotation = Quaternion.Euler(0, 0, angle);
                }

                // スライムのスケールを変更
                transform.localScale = stretchScale;

                // スライムの位置を調整
                transform.position = startPoint + direction / 2;
            }
        }

        // 引っ張りの解放
        if (Input.GetKeyUp(KeyCode.S))
        {
            transform.localScale = originalScale;  // スライムのスケールを元に戻す
            transform.rotation = originalRotation;  // スライムの回転を元に戻す
            transform.position = startPoint;  // スライムのポジションを元に戻す
            isPulling = false;
        }
    }
}
