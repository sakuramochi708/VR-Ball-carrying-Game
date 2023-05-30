using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseUIManager : MonoBehaviour
{
  [SerializeField] GameObject MenuPanel;
  private bool flag_object = false;

  // Start is called before the first frame update
  void Start()
  {
    MenuPanel.gameObject.SetActive(flag_object);
  }

  // Update is called once per frame
  void Update()
  {
    if (OVRInput.GetDown(OVRInput.Button.One))
    {
      flag_object = !flag_object;
      MenuPanel.gameObject.SetActive(flag_object);
    }
  }

  //   public void pushButton()
  //   {
  //     Update();
  //   }
}
