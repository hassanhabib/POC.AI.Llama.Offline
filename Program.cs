using OfflineAI;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! ask me anything!");

            while(true)
            {
                string question = Console.ReadLine();

                var llama = new LlamaCppModel(
                    "models/tinyllama-1.1b-chat-v1.0.Q4_K_M.gguf", 
                    "models/llama-cli.exe");

                var output = llama.GenerateText(
                    question);

                Console.WriteLine(output);
            }
        }
    }
}
