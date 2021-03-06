﻿using System;
using UnityEngine;

public interface IShoeInterface
{
    string Name { get; set; }
    GameObject ShoeType { get; set; }

    Tuple<Vector3, Vector3> GetFrontCoords(CapsuleCollider collider);
    Tuple<Vector3, Vector3> GetTopCoords(CapsuleCollider collider);
    Tuple<Vector3, Vector3> GetTopLeftCoords(CapsuleCollider collider);
    Tuple<Vector3, Vector3> GetTopRightCoords(CapsuleCollider collider);
    Quaternion ResolveShoeQuaternion(bool rotate);

}
