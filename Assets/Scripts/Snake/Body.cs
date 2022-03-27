using System.Collections.Generic;
using UnityEngine;

public class Body
{
    private const int Gab = 50;
    
    private List<Vector3> _moveHistory = new List<Vector3>();
    private List<Segment> _bodySegments = new List<Segment>();

    private GameObject _bodyPartTemplate;

    public Body(GameObject bodyPartTemplate)
    {
        _bodyPartTemplate = bodyPartTemplate;
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
        GrowSnake();
    }

    public void GrowSnake()
    {
        GameObject bodyPart = GameObject.Instantiate(_bodyPartTemplate);
        Segment bodySegment = bodyPart.GetComponent<Segment>();
        _bodySegments.Add(bodySegment);
    }

    public void ScanMovePosition(Vector3 position)
    {
        _moveHistory.Insert(0,position);

        for (int i = 0; i < _bodySegments.Count; i++)
        {
            Vector3 point = _moveHistory[Mathf.Min(i * Gab, _moveHistory.Count - 1)];
            _bodySegments[i].HandleSegmentMove(point);
        }
    }

}