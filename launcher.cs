using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Define the path to the Go executable
        string goExecutablePath = "path_to_your_go_executable/hello";

        // Create a new process
        Process process = new Process();
        process.StartInfo.FileName = goExecutablePath;
        process.StartInfo.Arguments = ""; // Pass arguments if needed
        process.StartInfo.UseShellExecute = false;
        process.StartInfo.RedirectStandardOutput = true;
        process.StartInfo.RedirectStandardError = true;
        process.StartInfo.CreateNoWindow = true;

        // Start the process
        process.Start();

        // Read the output
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();

        // Wait for the process to exit
        process.WaitForExit();

        // Print the output and error (if any)
        Console.WriteLine("Output:");
        Console.WriteLine(output);

        if (!string.IsNullOrEmpty(error))
        {
            Console.WriteLine("Error:");
            Console.WriteLine(error);
        }
    }
}
