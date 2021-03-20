using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Conveyor : MonoBehaviour
{
    [SerializeField] private LevelData _levelData;

    [SerializeField] private Transform _conveyorStartPoint;
    [SerializeField] private Transform _startNewSegmentPoint;
    [SerializeField] private Transform _startChocolatePointLeft;
    [SerializeField] private Transform _startChocolatePointRight;
    [SerializeField] private GameObject[] shafts;
    

    private ObjectsFactory _factory;
    private GameObject _currentSegment = null;
    
    void Start()
    {
        _factory = new ObjectsFactory();
        StartSegment();
        StartCoroutine(StartChocolates());
    }

    private void StartSegment()
    {
        GameObject segment = _factory.GetConveyorSegment();
        segment.transform.position = _conveyorStartPoint.position;
        segment.transform.rotation = _conveyorStartPoint.rotation;
        segment.GetComponent<ConveyorSegment>().StartMove(_levelData.ConveyorSpeed);
        _currentSegment = segment;
    }

    private IEnumerator StartChocolates()
    {
        while (true)
        {
            yield return new WaitForSeconds(
                Random.Range(_levelData.ChcolateIntervals.IntervalStart,
                    _levelData.ChcolateIntervals.IntervalEnd));

            foreach (var chocolate in _levelData.ChocolateProbabilityes)
            {
                if (Random.Range(1, 100) < chocolate.Probability)
                {
                    GameObject newChocolate = _factory.GetChocolate(chocolate.ChocolateType);
                    newChocolate.transform.position = new Vector3(
                        Random.Range(_startChocolatePointLeft.position.x, _startChocolatePointRight.position.x),
                        _startChocolatePointLeft.position.y, _startChocolatePointLeft.position.z);
                }
            }
        }
    }

    public void Update()
    {
        if (_currentSegment != null && _currentSegment.transform.position.z > _startNewSegmentPoint.position.z)
            StartSegment();
    }

    public void StopConveyorWork()
    {
        StopAllCoroutines();
    }


}
