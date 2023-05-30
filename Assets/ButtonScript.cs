using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
  [SerializeField]
  private string dstWorld;

  // ボタンが押された場合、今回呼び出される関数
  public void OnClick()
  {
    Debug.Log("押された!");  // ログを出力
    ChangeScene();
  }

  void ChangeScene()
  {
    SceneManager.LoadScene(dstWorld);
  }
}
