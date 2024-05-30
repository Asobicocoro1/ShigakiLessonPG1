using UnityEngine;
using UnityEngine.UI;

/*


日本語解説
public Slider hpSlider;

これは、画面に表示されるHPゲージです。Sliderコンポーネントを使って、HPを表示します。
public void UpdateHP(float newHP)

これは、HPゲージを更新するためのメソッドです。新しいHPの値を受け取り、それをHPゲージに反映させます。
hpSlider.value = newHP;

これは、HPゲージの値を新しいHPの値に設定します。これにより、プレイヤーのHPが減ったり増えたりしたときに、画面のHPゲージが正しく表示されるようになります。
 */


public class GameManager_2 : MonoBehaviour
{
    public Slider hpSlider; // HPを表示するスライダー

    public void UpdateHP(float newHP)
    {
        hpSlider.value = newHP; // HPゲージを更新
    }
}