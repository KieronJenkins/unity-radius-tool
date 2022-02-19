using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRadius : MonoBehaviour
{
  [Range(1f, 100f)]
  public float objectRadius = 1f;
  public Color color = Color.red; 

  private void OnEnable()
  {
    OnDrawGizmosSelected();
  }

  private void OnDrawGizmosSelected()
  {
    Gizmos.color = color;
    Gizmos.DrawWireSphere(transform.position, objectRadius);
  }
}
