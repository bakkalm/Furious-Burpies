﻿using UnityEngine;

public class StickProperty : MonoBehaviour
{
    #region Fields & Properties
    [Header("Parameters")]
    [SerializeField]
    private bool isEnabled = true;
    public bool IsEnable { get { return this.isEnabled; } set { this.isEnabled = value; } }
    #endregion

    #region Methods
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == GameObjectsTags.Player)
        {
            if (this.isEnabled)
            {
                IStickBehaviour stickBehaviour = collision.gameObject.GetComponent<StickBehaviour>();
                stickBehaviour.Stick(collision.contacts[0].normal);
                Debug.Log("Stick Collision Collider !!!");
            }
        }
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if(this.isEnabled)
        {
            if(hit.gameObject.tag == GameObjectsTags.Player)
            {
                IStickBehaviour stickBehaviour = hit.gameObject.GetComponent<CustomCharacterController>();
                stickBehaviour.Stick(hit.normal);
                Debug.Log("Stick Collision Controller !!!");
            }
        }
    }
    #endregion
}
