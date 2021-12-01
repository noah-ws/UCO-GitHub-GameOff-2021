using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Constants
{
    [SerializeField] public static readonly KeyCode INTERACTION_KEY = KeyCode.T;
    [SerializeField] public static readonly KeyCode JUMP_KEY = KeyCode.Space;
    public static readonly bool DEV_MODE = true;
    public static readonly string HORIZONTAL = "Horizontal";
    public static readonly string VERTICAL = "Vertical";
    public static readonly float GRAVITY = 9.8f;
    public static readonly Vector2 GRAVITY_DOWN = new Vector2(0, GRAVITY * -1 * 9);
    public static readonly Vector2 GRAVITY_LEFT = new Vector2(GRAVITY * -1 * 9, 0);
    public static readonly Vector2 GRAVITY_UP = new Vector2(0, GRAVITY * 9);
    public static readonly Vector2 GRAVITY_RIGHT = new Vector2(GRAVITY * 9, 0);
}