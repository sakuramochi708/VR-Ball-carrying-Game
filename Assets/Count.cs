using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Count : MonoBehaviour
{
  public Text label;
  private int count;

  void Start()
  {
    count = 0;
    UpdateLabel();
  }

  public void Click()
  {
    count++;
    UpdateLabel();
  }
  void UpdateLabel()
  {
    label.text = count + "回";
  }
}