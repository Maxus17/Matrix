using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
  public int scenceNumber;

  public void Transition()
  {
    SceneManager.LoadScene(scenceNumber);
  }
}
