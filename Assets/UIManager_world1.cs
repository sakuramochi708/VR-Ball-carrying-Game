using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager_world1 : MonoBehaviour
{
  [SerializeField] GameObject World1_PausePanel;
  // private bool flag_object = false;a
  // public GameObject ball;
  // public GameObject CPane;


  // Start is called before the first frame update
  void Start()
  {
    // flag_object = false;a
    // World1_PausePanel.gameObject.SetActive(false);
  }

  // Update is called once per frame
  void Update()
  {
    if (OVRInput.GetDown(OVRInput.Button.One))
    {
      // flag_object = !flag_object;a
      World1_PausePanel.SetActive(!World1_PausePanel.activeInHierarchy);
    }

    if (OVRInput.GetDown(OVRInput.Button.Three))
    {
      pushResetButton();
    }

    // if (CPane.name == ball.name)
    // {
    //   OnTriggerEnter();
    // }
  }


  public void pushReturnButton()
  {
    SceneManager.LoadScene("TitleScene");
  }

  public void pushResetButton()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);

  }

  // private void OnTriggerEnter()
  // {
  //   //もしゴールオブジェクトのコライダーに接触した時の処理。

  //   //ゲームクリアテキストを表示させてキャラクターを非表示にします。
  //   //   gameclea.GetComponent<Text>();
  //   World1_PausePanel.gameObject.SetActive(true);


  // }
}
