using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorData: MonoBehaviour
{
  public Color value;

  public void ChangeImageColor(Image imageObj)
  {
      imageObj.color = value;
  }

  public void ChangeMeshRenderColor(MeshRenderer meshObj)
  {
      meshObj.material.color = value;
  }

  public void ChangeSpriteRenderColor(SpriteRenderer spriteObj)
  {
      spriteObj.color = value;
  }
}
