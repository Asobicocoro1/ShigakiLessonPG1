using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 `summary`�^�O�́A���C#��XML�h�L�������e�[�V�����R�����g�̈ꕔ�Ƃ��Ďg�p����܂��B����ɂ��A�N���X�A���\�b�h�A�v���p�e�B�A���̑��̃����o�[�̊T�v���L�q���邱�Ƃ��ł��܂��BVisual Studio�ł́A�����̃R�����g���g�p���āA�C���e���Z���X��R�[�h�̕⊮�@�\�ł̃w���v��񋟂��܂��B

### C#�ɂ�����XML�h�L�������e�[�V�����R�����g�̎g�p���@

1. **�N���X�̃h�L�������e�[�V����**
   ```csharp
   /// <summary>
   /// �����ExampleClass�̐����ł��B
   /// ���̃N���X�́A��{�I�ȋ@�\��񋟂��܂��B
   /// </summary>
   public class ExampleClass
   {
       // �N���X�̃����o�[
   }
   ```

2. **���\�b�h�̃h�L�������e�[�V����**
   ```csharp
   public class ExampleClass
   {
       /// <summary>
       /// �����Add���\�b�h�̐����ł��B
       /// 2�̐��������Z���܂��B
       /// </summary>
       /// <param name="a">�ŏ��̐���</param>
       /// <param name="b">2�Ԗڂ̐���</param>
       /// <returns>2�̐����̍��v</returns>
       public int Add(int a, int b)
       {
           return a + b;
       }
   }
   ```

3. **�v���p�e�B�̃h�L�������e�[�V����**
   ```csharp
   public class ExampleClass
   {
       private int _value;

       /// <summary>
       /// �����Value�v���p�e�B�̐����ł��B
       /// �l���擾�܂��͐ݒ肵�܂��B
       /// </summary>
       public int Value
       {
           get { return _value; }
           set { _value = value; }
       }
   }
   ```

4. **�R���X�g���N�^�̃h�L�������e�[�V����**
   ```csharp
   public class ExampleClass
   {
       /// <summary>
       /// �����ExampleClass�̃R���X�g���N�^�̐����ł��B
       /// �����l��ݒ肵�܂��B
       /// </summary>
       public ExampleClass()
       {
           // �R���X�g���N�^�̓��e
       }
   }
   ```

### Visual Studio�ł̃T�|�[�g
Visual Studio�ł́A`///`����͂���ƁA�����I��XML�h�L�������e�[�V�����R�����g�̃e���v���[�g����������܂��B����ɂ��A�����I�ɃR�����g��ǉ��ł��܂��B

### XML�h�L�������e�[�V�����R�����g�̗v�f
- `<summary>`�F�����o�[�̊T�v���L�q���܂��B
- `<param>`�F���\�b�h�̈������L�q���܂��B
- `<returns>`�F���\�b�h�̖߂�l���L�q���܂��B
- `<remarks>`�F�ǉ��̏ڍ׏��⒍�ӓ_���L�q���܂��B
- `<example>`�F�g�p���񋟂��܂��B
- `<exception>`�F���\�b�h���X���[����\���̂����O���L�q���܂��B

�����̃R�����g�́AVisual Studio�̃C���e���Z���X�Ŏ����I�ɕ\������邽�߁A�R�[�h�̗����Ɨ��p���e�ՂɂȂ�܂��B�h�L�������e�[�V�����R�����g��K�؂Ɏg�p���邱�ƂŁA�R�[�h�̃����e�i���X���Ɖǐ����啝�Ɍ��サ�܂��B
 */
public class HowtouseXMLdocumentationcommentsin : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// �����ExampleClass�̐����ł��B
    /// ���̃N���X�͊�{�I�ȋ@�\��񋟂��܂��B
    /// </summary>
    public class ExampleClass
    {
        /// <summary>
        /// �����Add���\�b�h�̐����ł��B
        /// 2�̐��������Z���܂��B
        /// </summary>
        /// <param name="a">�ŏ��̐���</param>
        /// <param name="b">2�Ԗڂ̐���</param>
        /// <returns>2�̐����̍��v</returns>
        public int Add(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// �����Value�v���p�e�B�̐����ł��B
        /// �l���擾�܂��͐ݒ肵�܂��B
        /// </summary>
        public int Value { get; set; }
    }

}
