using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Calculations and Rounding
/// </summary>
public class ConvertTemperatures : MonoBehaviour
{
    /// <summary>
    /// Convert Temperatures
    /// </summary>
    void Start()
    {
        IntPrintMessage(0);
        IntPrintMessage(32);
        IntPrintMessage(212);
        FloatPrintMessage(0);
        DoublePrintMessage(0);
    }

    // Temperature convertions using INT
    static int IntConvertCelsius(int temperature)
    {
        return ((temperature - 32) / 9) * 5;
    }

    static int IntConvertFarenheit(int temperature)
    {
        return (temperature * 9) / 5 + 32;
    }

    void IntPrintMessage(int sourceFahrenheit)
    {
        int convertCelsius = IntConvertCelsius(sourceFahrenheit);
        int convertFahrenheit = IntConvertFarenheit(convertCelsius);
        print($"INT Source Fahrenheith value = {sourceFahrenheit}");
        print($"INT Converted to Celsius = {convertCelsius}");
        print($"INT Convert back to Fahrenheit = {convertFahrenheit}");
    }

    // Temperature convertions using FLOAT
    static float FloatConvertCelsius(float temperature)
    {
        return ((temperature - 32) / 9) * 5;
    }

    static float FloatConvertFarenheit(float temperature)
    {
        return (temperature * 9) / 5 + 32;
    }

    void FloatPrintMessage(float sourceFahrenheit)
    {
        float convertCelsius = FloatConvertCelsius(sourceFahrenheit);
        float convertFahrenheit = FloatConvertFarenheit(convertCelsius);
        print($"FLOAT Source Fahrenheith value = {sourceFahrenheit}");
        print($"FLOAT Converted to Celsius = {convertCelsius}");
        print($"FLOAT Convert back to Fahrenheit = {convertFahrenheit}");
    }

    // Temperature convertions using DOUBLE
    static double DoubleConvertCelsius(double temperature)
    {
        return ((temperature - 32) / 9) * 5;
    }

    static double DoubleConvertFarenheit(double temperature)
    {
        return (temperature * 9) / 5 + 32;
    }

    void DoublePrintMessage(double sourceFahrenheit)
    {
        double convertCelsius = DoubleConvertCelsius(sourceFahrenheit);
        double convertFahrenheit = DoubleConvertFarenheit(convertCelsius);
        print($"DOUBLE Source Fahrenheith value = {sourceFahrenheit}");
        print($"DOUBLE Converted to Celsius = {convertCelsius}");
        print($"DOUBLE Convert back to Fahrenheit = {convertFahrenheit}");
    }
}
