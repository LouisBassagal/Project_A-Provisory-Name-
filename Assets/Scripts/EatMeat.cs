using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatMeat : MonoBehaviour
{
    public SpriteRenderer ActualSprite;
    private Vector3 NormalScaling = new Vector3(0.125f, 0.125f, 0f);
    private Color Purple = new Color(127, 0, 255);
    private Color Red = new Color(237, 0, 0);
    private Color Green = new Color(0, 128, 0);

    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject CollidedObject = collision.gameObject;
        if (CollidedObject.CompareTag("Meat"))
        {
            Vector3 ActualScaling = this.transform.localScale;
            ActualScaling += NormalScaling;
            this.transform.localScale = ActualScaling;
            SpriteRenderer ObjectRenderer = CollidedObject.GetComponent<SpriteRenderer>();
            ActualSprite.color = ObjectRenderer.color;
            Destroy(CollidedObject);
        }
    }
}
