using System;
using UnityEngine;
using Object = UnityEngine.Object;

public class ObjectsFactory
{
    private GameObject _conveyorSegment;

    private GameObject _brokeningPlatform;
    private GameObject _chocolate;
    private GameObject _trufelle;
    private GameObject _rafaello;
    private GameObject _shit;
    private GameObject _nails;
    private GameObject _glass;
    private GameObject _dirt;


    public GameObject GetConveyorSegment()
    {
        if (!_conveyorSegment)
            _conveyorSegment = Resources.Load<GameObject>(AssetPath.ConveyorSegment);

        return UnityEngine.Object.Instantiate(_conveyorSegment);
    }

    public GameObject GetChocolate(ChocolateType type)
    {
        GameObject chocolate;
        switch (type)
        {
            case ChocolateType.Chocolate:
                chocolate = GetChocolate();
                break;
            case ChocolateType.Truffele:
                chocolate = GetTruffele();
                break;
            case ChocolateType.Rafaello:
                chocolate = GetRafaello();
                break;
            case ChocolateType.Shit:
                chocolate = GetShit();
                break;
            case ChocolateType.Nails:
                chocolate = GetNails();
                break;
            case ChocolateType.Glass:
                chocolate = GetGlass();
                break;
            case ChocolateType.Dirt:
                chocolate = GetDirt();
                break;
            default:
                throw new ArgumentOutOfRangeException();
        }
        return UnityEngine.Object.Instantiate(chocolate);
    }

    private GameObject GetChocolate()
    {
        if (!_chocolate)
            _chocolate = Resources.Load<GameObject>(AssetPath.Chocolate);

        return _chocolate;
    }

    private GameObject GetTruffele()
    {
        if (!_trufelle)
            _trufelle = Resources.Load<GameObject>(AssetPath.Trufelle);

        return _trufelle;
    }

    private GameObject GetRafaello()
    {
        if (!_rafaello)
            _rafaello = Resources.Load<GameObject>(AssetPath.Rafaello);

        return _rafaello;
    }


    private GameObject GetTrufelle()
    {
        if (!_trufelle)
            _trufelle = Resources.Load<GameObject>(AssetPath.Trufelle);

        return _trufelle;
    }

    private GameObject GetShit()
    {
        if (!_shit)
            _shit = Resources.Load<GameObject>(AssetPath.Shit);

        return _shit;
    }

    private GameObject GetNails()
    {
        if (!_nails)
            _nails = Resources.Load<GameObject>(AssetPath.Nails);

        return _nails;
    }

    private GameObject GetGlass()
    {
        if (!_glass)
            _glass = Resources.Load<GameObject>(AssetPath.Glass);

        return _glass;
    }

    private GameObject GetDirt()
    {
        if (!_dirt)
        {
            _dirt = Resources.Load<GameObject>(AssetPath.Dirt);
        }
        return _dirt;
    }
}