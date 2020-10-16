using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuervos : MonoBehaviour
{
    public static int _cCero = 0;
    public static int _cUno = 0;
    public static int _cDos = 0;
    public static int _cTres = 0;
    public static int _cCuatro = 0;

    internal static object GetObject()
    {
        throw new NotImplementedException();
    }

    public static int _cCinco = 0;

    private void Update()
    {
        if (_cCero >= 1)
        {
            transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(false);
        }

        if (_cUno >= 1)
        {
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(1).gameObject.SetActive(false);
        }

        if (_cDos >= 1)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }

        if (_cTres >= 1)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }

        if (_cCuatro >= 1)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }

        if (_cCinco >= 1)
        {
            transform.GetChild(2).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(2).gameObject.SetActive(false);
        }


    }

    public static void GetcCero()
    {
        _cCero++;
    }

    public static void GetcUno()
    {
        _cUno++;
    }

    public static void GetcDos()
    {
        _cDos++;
    }

    public static void GetcTres()
    {
        _cTres++;
    }
    public static void GetcCuatro()
    {
        _cCuatro++;
    }
    public static void GetcCinco()
    {
        _cCinco++;
    }
}
