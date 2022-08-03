using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paralexBackground : MonoBehaviour
{
    
    [SerializeField] private Vector2 paralexEffectMultiplier;
    // Start is called before the first frame update
  private Transform cameraTansform;
  private Vector3 lastCameraPosition;
  private float textureUnitSizeX;
  private float textureUnitSizeY;

  


  private void start()
  {
      cameraTansform = Camera.main.transform;
      lastCameraPosition = cameraTansform.position;
      Sprite sprite =  GetComponent<SpriteRenderer>().sprite;
      Texture2D texture = sprite.texture;
      textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
      textureUnitSizeY = texture.height / sprite.pixelsPerUnit;
  }


  private void LateUpdate()
  {
      Vector3 deltaMovement = cameraTansform.position - lastCameraPosition;
      transform.position += new Vector3( deltaMovement.x*paralexEffectMultiplier.x,deltaMovement.y*paralexEffectMultiplier.y);
      lastCameraPosition = cameraTansform.position;

      if (Mathf.Abs( cameraTansform.position.x - transform.position.x) >= textureUnitSizeX)
      {
          float offsetPositionX = (cameraTansform.position.x - transform.position.x) % textureUnitSizeX;
          transform.position = new Vector3(cameraTansform.position.x + offsetPositionX, transform.position.y);
      }

      if (Mathf.Abs( cameraTansform.position.y - transform.position.y) >= textureUnitSizeY)
      {
          float offsetPositionY = (cameraTansform.position.y - transform.position.y) % textureUnitSizeY;
          transform.position = new Vector3(transform.position.x, cameraTansform.position.y + offsetPositionY);
      }
  }
}
