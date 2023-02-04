using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIButton : MonoBehaviour
{
    [SerializeField] private GameObject targetObject;
    [SerializeField] private string targetMessage;
    public Color highlightColor = Color.cyan;

    public void OnMouseEnter()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = highlightColor;
        }
    }

    public void OnMouseExit()
    {
        SpriteRenderer sprite = GetComponent<SpriteRenderer>();
        if (sprite != null)
        {
            sprite.color = Color.white;
        }
    }

    public void OnMouseDown()
    {
        transform.localScale = new Vector3(2.6f, 2.6f, 2.6f);
    }

    public void OnMouseUp()
    {
        transform.localScale = new Vector3(2.5f, 2.5f, 2.5f);
        if (targetObject != null)
        {
            targetObject.SendMessage(targetMessage);
        }
    }
}
