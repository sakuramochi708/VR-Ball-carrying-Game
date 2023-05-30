using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class World1_ClearPanel : MonoBehaviour
{
  //Inspectorでキャラクターとゴールオブジェクトの指定を出来る様にします。
  public GameObject chara;
  // public GameObject gameclea;
  [SerializeField] private GameObject world1_PausePanel;


  private void OnTriggerEnter(Collider other)
  {
    Debug.Log("OnTriggerEnter ClearPanel");
    //もしゴールオブジェクトのコライダーに接触した時の処理。
    if (other.name == chara.name)
    {
      Debug.Log("if");
      //ゲームクリアテキストを表示させてキャラクターを非表示にします。
      // gameclea.GetComponent<Text>();
      world1_PausePanel.SetActive(true);
      // chara.SetActive(false);

    }
  }

}