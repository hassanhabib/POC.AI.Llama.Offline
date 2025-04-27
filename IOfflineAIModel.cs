namespace OfflineAI
{
    public interface IOfflineAIModel
    {
        string GenerateText(string prompt, int maxTokens = 100);
        Task<string> GenerateTextAsync(string prompt, int maxTokens = 100);
    }
}
