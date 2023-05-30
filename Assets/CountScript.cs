using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountScript : MonoBehaviour
{
  public Text countText;
  private int count = 0;
  private bool buttonDownFlag = false;
  private float timeleft = 0.04f;

  void Update()
  {
    if (buttonDownFlag) //buttonDownFlagがtrueの時
    {
      Debug.Log("Hold");

      timeleft -= Time.deltaTime;
      if (timeleft <= 0.0)
      {
        timeleft = 0.04f; //1秒間に+25したい＝1/25秒毎に+1
        count++;
        countText.text = count.ToString();
      }
    }
  }

  //ボタンを押した時の処理
  public void OnButtonDown()
  {
    Debug.Log("Down");
    buttonDownFlag = true;
  }

  //ボタンを離した時の処理
  public void OnButtonUp()
  {
    Debug.Log("Up");
    buttonDownFlag = false;
  }
}