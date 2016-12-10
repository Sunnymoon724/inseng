﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {

    //caching
    Transform trans;

    //variable
    Move move;

    void Awake() {
        Caching();
        InitMove();
    }

    void Caching() {
        trans = transform;
    }

    void InitMove() {
        move = new Move();
        move.SetMovableArea(new Vector2(-360, -640), new Vector2(360, 640));
    }

    public Vector2 GetPosition() {
        return trans.position;
    }

    public Transform Move(Vector2 dest) {
        return move.MoveTransformTo(trans, dest);
    }
}