using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;    // カメラが追跡するターゲット（プレイヤー）
    public float xOffset = 5f;  // X軸のオフセット
    public float yOffset = 0f;  // Y軸のオフセット
    public float minY = -4f;    // カメラのY座標の最小値
    public float maxY = 4f;     // カメラのY座標の最大値
    public float smoothSpeed = 1f; // カメラの追従速度

    void LateUpdate()
    {
        if (player != null)
        {
            // プレイヤーの位置を取得
            Vector3 targetPosition = player.position;

            // カメラの新しいX座標をプレイヤーのX座標にオフセットを加えて設定
            float newX = targetPosition.x + xOffset;

            // カメラの新しいY座標をプレイヤーのY座標にオフセットを加えて設定
            float newY = Mathf.Clamp(targetPosition.y + yOffset, minY, maxY);

            // カメラの新しい位置を計算
            Vector3 newPosition = new Vector3(newX, newY, transform.position.z);

            // カメラの位置を滑らかに移動
            transform.position = Vector3.Lerp(transform.position, newPosition, smoothSpeed);
        }
    }
}
