using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 ### AudioSource�̃C���X�y�N�^�[�̏ڍ�

AudioSource�́AUnity�ŉ���炷���߂̃R���|�[�l���g�ł��B�ȉ��ɁAAudioSource�̃C���X�y�N�^�[�̊e���ڂ����w���ɂ��킩��悤�ɐ������܂��B

#### 1. **AudioClip (�I�[�f�B�I�N���b�v)**
- **����**: �Đ����鉹�̃t�@�C���ł��B
- **�g����**: ���ʉ��≹�y�̃t�@�C���i��: `car_horn.wav`�j�������Ƀh���b�O���h���b�v���܂��B

#### 2. **Output (�o��)**
- **����**: �����ǂ̃I�[�f�B�I�~�L�T�[�O���[�v�ɏo�͂��邩��ݒ肵�܂��B�ʏ�͉����ݒ肵�Ȃ��Ă����v�ł��B
- **�g����**: �����ݒ肵�Ȃ��ꍇ�A�f�t�H���g�̐ݒ肪�g�p����܂��B

#### 3. **Mute (�~���[�g)**
- **����**: �����ꎞ�I�ɏ����i�~���[�g����j���߂̐ݒ�ł��B
- **�g����**: �`�F�b�N������Ɖ��������܂��B�`�F�b�N���O���Ɖ�����܂��B

#### 4. **Bypass Effects (�G�t�F�N�g���o�C�p�X)**
- **����**: �I�[�f�B�I�~�L�T�[�̃G�t�F�N�g�𖳎�����ݒ�ł��B�ʏ�̓`�F�b�N�����܂���B
- **�g����**: �ʏ�͐ݒ肵�Ȃ��Ă����v�ł��B

#### 5. **Bypass Listener Effects (���X�i�[�G�t�F�N�g���o�C�p�X)**
- **����**: �I�[�f�B�I���X�i�[�̃G�t�F�N�g�𖳎�����ݒ�ł��B�ʏ�̓`�F�b�N�����܂���B
- **�g����**: �ʏ�͐ݒ肵�Ȃ��Ă����v�ł��B

#### 6. **Bypass Reverb Zones (���o�[�u�]�[�����o�C�p�X)**
- **����**: ���o�[�u�i�����j�̌��ʂ𖳎�����ݒ�ł��B�ʏ�̓`�F�b�N�����܂���B
- **�g����**: �ʏ�͐ݒ肵�Ȃ��Ă����v�ł��B

#### 7. **Play On Awake (�ڊo�߂����ɍĐ�)**
- **����**: �Q�[�����n�܂������Ɏ����I�ɉ����Đ�����ݒ�ł��B
- **�g����**: �`�F�b�N������ƁA�Q�[�����n�܂�Ƃ����ɉ�����܂��B�K�v�ɉ����Đݒ肵�܂��B

#### 8. **Loop (���[�v)**
- **����**: �����J��Ԃ��Đ�����ݒ�ł��B
- **�g����**: �`�F�b�N������ƁA�����J��Ԃ���܂��B�Ⴆ�΁A�w�i���y�������Ɨ����ꍇ�Ɏg���܂��B

#### 9. **Priority (�D��x)**
- **����**: ���̗D��x��ݒ肵�܂��B�l���Ⴂ�قǗD��x�������Ȃ�܂��B
- **�g����**: �ʏ�̓f�t�H���g�̒l�ő��v�ł��B�����̉����d�Ȃ�ꍇ�ɁA�ǂ̉���D��I�ɍĐ����邩�����߂܂��B

#### 10. **Volume (����)**
- **����**: ���̑傫����ݒ肵�܂��B
- **�g����**: �X���C�_�[�𓮂����ĉ��ʂ𒲐����܂��B1���ő剹�ʂŁA0�������ł��B

#### 11. **Pitch (�s�b�`)**
- **����**: ���̍�����ݒ肵�܂��B
- **�g����**: �X���C�_�[�𓮂����ĉ��̍����𒲐����܂��B1���ʏ�̍����ŁA0.5�ɂ���Ɖ����Ⴍ�Ȃ�A2�ɂ���Ɖ��������Ȃ�܂��B

#### 12. **Stereo Pan (�X�e���I�p��)**
- **����**: ���̍��E�̃o�����X��ݒ肵�܂��B
- **�g����**: �X���C�_�[�𓮂����ĉ��̍��E�̃o�����X�𒲐����܂��B-1�ō����̂݁A1�ŉE���̂݁A0�Œ����ł��B

#### 13. **Spatial Blend (��ԃu�����h)**
- **����**: ����3D���ʂ̋�����ݒ肵�܂��B
- **�g����**: �X���C�_�[�𓮂����Đݒ肵�܂��B0��2D�i��Ɉ��̉��ʁj�A1��3D�i�����ɉ����ĉ��ʂ��ς��j�ł��B

#### 14. **Reverb Zone Mix (���o�[�u�]�[���~�b�N�X)**
- **����**: ���o�[�u�]�[�����ł̉��̔������ݒ肵�܂��B
- **�g����**: �X���C�_�[�𓮂����Ĕ����̋����𒲐����܂��B�ʏ�̓f�t�H���g�̂܂܂ő��v�ł��B

### AudioListener�̃C���X�y�N�^�[�̏ڍ�

AudioListener�́AUnity�ŉ��𕷂����߂̃R���|�[�l���g�ł��B�Q�[�����̃J������v���C���[�ɃA�^�b�`���āA�Q�[�����̉��𕷂��������ʂ����܂��B�ȉ��ɁAAudioListener�̃C���X�y�N�^�[�̊e���ڂ����w���ɂ��킩��悤�ɐ������܂��B

#### AudioListener�̃C���X�y�N�^�[�̍���

AudioListener�̃C���X�y�N�^�[�́A���ɃV���v���ŁA�ݒ荀�ڂ����Ȃ��ł��B��{�I�ɂ́A�Q�[�����ŉ��𕷂����߂̎��̂悤�Ȗ��������܂��B

#### 1. **Enabled (�L��)**
- **����**: AudioListener��L���܂��͖����ɂ��܂��B
- **�g����**: �`�F�b�N�������AudioListener���L���ɂȂ�A�Q�[�����̉��𕷂����Ƃ��ł��܂��B�`�F�b�N���O���Ɩ����ɂȂ�܂��B


----------------------------------------------------


#### ��{�I�Ȏg����

- **����**: AudioListener�́A�ʏ�1�̃Q�[���I�u�W�F�N�g�i�ʏ�̓��C���J�����j�ɃA�^�b�`����܂��B
- **�g����**: ���C���J������AudioListener�R���|�[�l���g���f�t�H���g�ŃA�^�b�`����Ă��܂��B���ʂȐݒ肪�K�v�Ȃ��ꍇ���قƂ�ǂł��B

### AudioListener�̏ڍא���

#### AudioListener�̖���
- **���𕷂�**: AudioListener�́A�Q�[�����̂��ׂẲ������W���A������v���C���[�ɓ͂���������ʂ����܂��B����͐l�Ԃ̎��ɑ������܂��B

#### AudioListener�̔z�u
- **�ʏ�̔z�u**: AudioListener�́A�ʏ탁�C���J�����ɃA�^�b�`����܂��B����ɂ��A�J�������ړ�����ƁA���̕����������J�����̈ʒu�ɉ����ĕς��܂��B
- **����Ȕz�u**: ����̃V�[����Q�[���v���C�̗v���ɉ����āA�v���C���[�̃I�u�W�F�N�g�ɃA�^�b�`���邱�Ƃ�����܂��B

#### ������AudioListener�̒��ӓ_
- **����**: �V�[�����ɕ�����AudioListener�����݂���ƌx�����\������܂��BUnity�ł͒ʏ�A�V�[����1��AudioListener�����K�v����܂���B
- **�Ώ��@**: ������AudioListener������ꍇ�A�s�v��AudioListener�R���|�[�l���g�𖳌��ɂ��邩�폜���܂��B

### AudioListener�̐ݒ��

1. **AudioListener�̊m�F**
   - ���C���J������I�����A�C���X�y�N�^�[�E�B���h�E��AudioListener�R���|�[�l���g���A�^�b�`����Ă��邩�m�F���܂��B

2. **AudioListener�̗L����/������**
   - �C���X�y�N�^�[�E�B���h�E��AudioListener�R���|�[�l���g�́uEnabled�v�`�F�b�N�{�b�N�X���I���ɂ��ėL���ɂ��A�I�t�ɂ��Ė����ɂ��܂��B

### ���ۂ̎g����

- **�Q�[���J�n���̐ݒ�**:
  ```csharp
  using UnityEngine;

  public class GameSetup : MonoBehaviour
  {
      void Start()
      {
          // ���C���J������AudioListener���A�^�b�`����Ă��邩�m�F
          Camera mainCamera = Camera.main;
          AudioListener audioListener = mainCamera.GetComponent<AudioListener>();
          if (audioListener != null)
          {
              Debug.Log("AudioListener is enabled on the main camera.");
          }
          else
          {
              Debug.LogError("AudioListener is missing on the main camera!");
          }
      }
  }
  ```

### �܂Ƃ�

AudioListener�́A�Q�[�����ŉ��𕷂����߂̏d�v�ȃR���|�[�l���g�ł��B
�ʏ�A���C���J�����ɃA�^�b�`����Ă���A���ʂȐݒ肪�K�v�Ȃ��ꍇ���قƂ�ǂł��B
�Q�[�����ŉ����ǂ̂悤�ɕ������邩�𐧌䂷�邽�߂ɁA1�̃V�[����1��AudioListener�������Ƃ���������܂��B
����ɂ��A�Q�[���̉����̌�����т��ĊǗ�����܂��B


AudioListener��AudioSource�ȊO�ɂ��AUnity�ŉ������ʂ≹�y�������ۂɖ𗧂�v�ȃR���|�[�l���g��@�\������܂��B
�ȉ��ɁA�����̃R���|�[�l���g�Ƃ��̎g�����ɂ��Đ������܂��B

### ��v�ȃI�[�f�B�I�֘A�R���|�[�l���g�Ƌ@�\

#### 1. AudioClip (�I�[�f�B�I�N���b�v)
- **����**: AudioClip�́A���y����ʉ��Ȃǂ̉����f�[�^��ێ����邽�߂̃R���|�[�l���g�ł��B
- **�g����**: AudioClip�́AAudioSource�R���|�[�l���g�ɐݒ肵�Ďg�p���܂��B
�����t�@�C���i��: `.wav`, `.mp3`�j���v���W�F�N�g�ɃC���|�[�g����ƁAAudioClip�Ƃ��Ďg�p�ł��܂��B

#### 2. Audio Mixer (�I�[�f�B�I�~�L�T�[)
- **����**: Audio Mixer�́A�����̃I�[�f�B�I�\�[�X���܂Ƃ߂ă~�b�N�X���A���ʂ�G�t�F�N�g�𐧌䂷�邽�߂̃R���|�[�l���g�ł��B
- **�g����**: �I�[�f�B�I�~�L�T�[���g�p����ƁA�Q�[�����̉��̃o�����X�𒲐����A�G�t�F�N�g��ǉ����邱�Ƃ��ł��܂��B
�Ⴆ�΁A�w�i���y�ƌ��ʉ��̉��ʃo�����X�𒲐����邱�Ƃ��ł��܂��B

#### 3. Audio Reverb Zone (�I�[�f�B�I���o�[�u�]�[��)
- **����**: Audio Reverb Zone�́A����̃G���A���ł̉��̔����i���o�[�u�j���V�~�����[�g���邽�߂̃R���|�[�l���g�ł��B
- **�g����**: ���o�[�u�]�[����z�u����ƁA���̃]�[�����ōĐ�����鉹���������ĕ������܂��B
�Ⴆ�΁A���A���̉������ʂ��V�~�����[�g����ꍇ�Ɏg�p���܂��B

#### 4. Audio Low Pass Filter (�I�[�f�B�I���[�p�X�t�B���^�[)
- **����**: Audio Low Pass Filter�́A����g���݂̂�ʉ߂�����t�B���^�[�ŁA�����g���̉����J�b�g���邽�߂̃R���|�[�l���g�ł��B
- **�g����**: ������g�p���āA�����ǂ��Q����ʉ߂���ۂɉ������ς����ʂ��V�~�����[�g���܂��B

#### 5. Audio High Pass Filter (�I�[�f�B�I�n�C�p�X�t�B���^�[)
- **����**: Audio High Pass Filter�́A�����g���݂̂�ʉ߂�����t�B���^�[�ŁA����g���̉����J�b�g���邽�߂̃R���|�[�l���g�ł��B
- **�g����**: ������g�p���āA����̌��ʉ�������������A�����𒲐������肷�邱�Ƃ��ł��܂��B

### �e�R���|�[�l���g�̏ڍׂȎg����

#### AudioClip�̎g����

1. **�����t�@�C���̃C���|�[�g**:
   - �v���W�F�N�g�E�B���h�E�ɉ����t�@�C���i��: `background_music.mp3`�j���h���b�O���h���b�v���܂��B
   - �C���|�[�g���ꂽ�����t�@�C���́A�����I��AudioClip�Ƃ��ĔF������܂��B

2. **AudioSource�ւ̐ݒ�**:
   - �q�G�����L�[�E�B���h�E�ŃI�[�f�B�I���Đ�����I�u�W�F�N�g��I�����A�C���X�y�N�^�[�E�B���h�E��AudioSource�R���|�[�l���g��ǉ����܂��B
   - AudioSource�R���|�[�l���g��AudioClip�t�B�[���h�ɁA�C���|�[�g���������t�@�C�����h���b�O���h���b�v���܂��B

#### Audio Mixer�̎g����

1. **�I�[�f�B�I�~�L�T�[�̍쐬**:
   - ���j���[����uAssets�v > �uCreate�v > �uAudio Mixer�v��I�����āA�V�����I�[�f�B�I�~�L�T�[���쐬���܂��B

2. **�O���[�v�̐ݒ�**:
   - �쐬�����I�[�f�B�I�~�L�T�[���_�u���N���b�N���āA�I�[�f�B�I�~�L�T�[�E�B���h�E���J���܂��B
   - �uMaster�v�O���[�v�̉��ɐV�����O���[�v��ǉ����āA���ʂ�G�t�F�N�g�𒲐����܂��B

3. **AudioSource�Ƃ̃����N**:
   - �q�G�����L�[�E�B���h�E�ŃI�[�f�B�I���Đ�����I�u�W�F�N�g��I�����A
�C���X�y�N�^�[�E�B���h�E��AudioSource�R���|�[�l���g��Output�t�B�[���h�ɃI�[�f�B�I�~�L�T�[�O���[�v���h���b�O���h���b�v���܂��B

#### Audio Reverb Zone�̎g����

1. **���o�[�u�]�[���̒ǉ�**:
   - �q�G�����L�[�E�B���h�E�ŉE�N���b�N���A�uAudio�v > �uAudio Reverb Zone�v��I�����܂��B
   - �V�������o�[�u�]�[�����쐬����܂��B

2. **���o�[�u�]�[���̐ݒ�**:
   - �C���X�y�N�^�[�E�B���h�E�ŁA���o�[�u�]�[���̃v���p�e�B�𒲐����܂��B
   - Min Distance��Max Distance�t�B�[���h���g���āA���o�[�u���ʂ͈̔͂�ݒ肵�܂��B

#### Audio Low Pass Filter�̎g����

1. **���[�p�X�t�B���^�[�̒ǉ�**:
   - �q�G�����L�[�E�B���h�E�ŃI�[�f�B�I���Đ�����I�u�W�F�N�g��I�����A�C���X�y�N�^�[�E�B���h�E�ŁuAdd Component�v���N���b�N���܂��B
   - �uAudio Low Pass Filter�v���������Ēǉ����܂��B

2. **�t�B���^�[�̐ݒ�**:
   - �J�b�g�I�t���g���𒲐����āA����g���݂̂�ʉ߂����܂��B

#### Audio High Pass Filter�̎g����

1. **�n�C�p�X�t�B���^�[�̒ǉ�**:
   - �q�G�����L�[�E�B���h�E�ŃI�[�f�B�I���Đ�����I�u�W�F�N�g��I�����A�C���X�y�N�^�[�E�B���h�E�ŁuAdd Component�v���N���b�N���܂��B
   - �uAudio High Pass Filter�v���������Ēǉ����܂��B

2. **�t�B���^�[�̐ݒ�**:
   - �J�b�g�I�t���g���𒲐����āA�����g���݂̂�ʉ߂����܂��B

### �܂Ƃ�

AudioListener��AudioSource�ɉ����āAAudioClip�AAudio Mixer�AAudio Reverb Zone�AAudio Low Pass Filter�AAudio High Pass Filter�Ȃǂ̃R���|�[�l���g���g�p���邱�ƂŁAUnity�̉����̌���L���ɂ��邱�Ƃ��ł��܂��B�����̃R���|�[�l���g��K�؂Ɋ��p���āA�Q�[���̉��������ʓI�ɊǗ����A�v���C���[�Ƀ��A���Ŗ��͓I�ȉ����̌���񋟂��܂��傤�B



 */

public class Guide_Audio : MonoBehaviour
{
 
}
