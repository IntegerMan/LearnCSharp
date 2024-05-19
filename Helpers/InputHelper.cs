using Microsoft.DotNet.Interactive;

int GetNumber(string prompt = "Enter a number") {
    bool valid;
    int result;
    do
    {
        string input = Kernel.GetInputAsync("Pick a number.").Result;

        valid = int.TryParse(input, out result);
    } while (!valid);

    return result;
}