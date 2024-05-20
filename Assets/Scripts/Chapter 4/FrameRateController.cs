using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 スクリプトの説明
public int targetFrameRate = 60;:

固定するフレームレートを設定します。この例では60FPSに設定していますが、必要に応じて他の値に変更できます。
void Start():

ゲームの開始時に一度だけ呼び出されます。
ここで Application.targetFrameRate を設定して、フレームレートを指定した値に固定します。
void Update():

毎フレーム呼び出されます。
もし Application.targetFrameRate が targetFrameRate と異なる場合、再度設定し直します。
これは保険として、フレームレートが何らかの理由で変更された場合に対応するためです。
 */


public class FrameRateController : MonoBehaviour
{
    // フレームレートを固定する値
    public int targetFrameRate = 60;

    void Start()
    {
        // フレームレートを指定した値に固定
        Application.targetFrameRate = targetFrameRate;
    }

    void Update()
    {
        // フレームレートを指定した値に固定
        if (Application.targetFrameRate != targetFrameRate)
        {
            Application.targetFrameRate = targetFrameRate;
        }
    }
}

