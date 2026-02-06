using UnityEngine;
using ArabicSupport;

public class ArabicFixTester : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Script jalan... ✅"); // Test apakah scriptnya jalan

        string teksArab = "فَعِلْ  فَعِيْلْ  فَي عِلْ  فَا عِلْ";
        string hasilFix = ArabicFixer.Fix(teksArab, true, false);

        Debug.Log("Hasil ArabicFixer: " + hasilFix); // Inilah yang nanti kamu copy
    }
}