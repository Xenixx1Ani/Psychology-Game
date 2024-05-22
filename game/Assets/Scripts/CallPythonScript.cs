using UnityEngine;
using System.Diagnostics;
using System;
public class CallPythonScript : MonoBehaviour
{
    public void CallPythonExecutable(int testIndex)
    {
        int testsTakenTillNow = GlobalVariables.testIndex;
        UnityEngine.Debug.Log("testIndex : " + testsTakenTillNow);
        UnityEngine.Debug.Log("test date: " + GlobalVariables.datesForQuizes[0]);
        int[] data = new int[10];
        string[] labels = new string[10];
        for(int i=0;i<=testsTakenTillNow;++i){
            labels[i] = GlobalVariables.datesForQuizes[i].Split(" ")[0];
            data[i] = GlobalVariables.testScores[i];
        }
        
        ProcessStartInfo startInfo = new ProcessStartInfo();
        startInfo.FileName = "plot_bar_chart"; // we will need to test this in built? also seperate 
        startInfo.Arguments = $"{string.Join(",", labels)} {string.Join(",", data)}";//idk what the labels should be but will plo bar

        startInfo.UseShellExecute = false;
        startInfo.RedirectStandardOutput = true;
        Process process = new Process();
        process.StartInfo = startInfo;
        process.Start();
        string output = process.StandardOutput.ReadToEnd(); 
        process.WaitForExit();//game continues till u close the graph thing...I can't really test this cause both unity script and python need to be run at once
        
    //save thing in bar_chart.png
    }
}
