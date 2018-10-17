﻿using System;
using UnityEngine;

public class FrictionProperty : MonoBehaviour
{
    #region Fields & Properties
    [Header("Parameters")]
    [SerializeField]
    private Vector2 frictionCoef = new Vector2(0.5f, 0.5f);

    #endregion

    #region Methods
    #region Collisions
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == GameObjectsTags.Player)
        {
            IFrictionBehaviour frictionBehaviour = collision.gameObject.GetComponent<FrictionBehaviour>();
            frictionBehaviour.Friction(this.frictionCoef);
        }
    }
    #endregion
    #endregion
}
