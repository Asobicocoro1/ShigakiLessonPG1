using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*アクセス修飾子
1. public
public 修飾子は、どのクラスからでもアクセス可能なメンバーを定義します。
これは最も制限のないアクセスレベルで、プログラムのどの部分からでも自由にアクセスできます。

2. private
private 修飾子は、そのメンバーが定義されているクラス内からのみアクセス可能であることを指定します。
これは最も制限的なアクセスレベルで、クラスの外部からはそのメンバーへのアクセスが完全に隠されます。

3. protected
protected 修飾子は、そのメンバーが定義されているクラス自身と、そのクラスを継承した派生クラスからアクセス可能であることを指定します。
これはクラスの継承構造内でのみアクセスを許可する中間的なアクセスレベルです。

4. internal
internal 修飾子は、そのメンバーが同一アセンブリ内のどのクラスからもアクセス可能であることを指定します。
これは、同一のプログラムやライブラリ内でのみアクセスを許可するアクセスレベルです。

5. protected internal
protected internal 修飾子は、protected と internal の機能を組み合わせたもので、メンバーが同一アセンブリ内であればどのクラスからでも、
または異なるアセンブリでも派生クラスからのアクセスが可能であることを指定します。

6. private protected
private protected 修飾子は、そのメンバーが定義されたクラス自身および派生クラスからのみ、かつ同一アセンブリ内でのみアクセス可能であることを指定します。
これはprotectedとinternalの制限的なバージョンです。

これらのアクセス修飾子を適切に使用することで、ソフトウェアの安全性、保守性、および拡張性が向上します。各修飾子の選択は、そのメンバーがどのように使われるべきかに基づいて慎重に行うべきです。
*/

public class Accessmodifiers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
