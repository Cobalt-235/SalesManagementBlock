using System.Text;
using System.Text.Json;
using Microsoft.Extensions.Logging;
using Quanlybangame.BLL;

namespace Quanlybangame.UI;

internal sealed class NhatkyProvider : ILoggerProvider
{
    private readonly object khoa = new();
    public static string Thumuc => Path.Combine(CauhinhBLL.Thumuc, "logs");
    public static string Duongdan(DateTime ngay) => Path.Combine(Thumuc, $"game-{ngay:yyyy-MM-dd}.log");
    public ILogger CreateLogger(string categoryName) => new TepLogger(this, categoryName);
    public void Dispose() { }
    private void Ghi<TState>(string ten, LogLevel muc, TState state, Exception? e, Func<TState, Exception?, string> formatter)
    {
        try
        {
            var dulieu = state is IEnumerable<KeyValuePair<string, object?>> ds ? ds.Where(x => x.Key != "{OriginalFormat}").ToDictionary(x => x.Key, x => Convert.ToString(x.Value)) : [];
            string dong = JsonSerializer.Serialize(new { Thoigian = DateTimeOffset.Now.ToString("O"), Muc = muc.ToString(), Nguon = ten, Noidung = formatter(state, e), Dulieu = dulieu, Loi = e?.ToString() });
            lock (khoa) { Directory.CreateDirectory(Thumuc); File.AppendAllText(Duongdan(DateTime.Now), dong + Environment.NewLine, new UTF8Encoding(false)); }
        }
        catch (IOException) { System.Diagnostics.Debug.WriteLine("Không ghi được nhật ký ứng dụng."); }
        catch (UnauthorizedAccessException) { System.Diagnostics.Debug.WriteLine("Không có quyền ghi nhật ký ứng dụng."); }
    }
    private sealed class TepLogger(NhatkyProvider p, string ten) : ILogger
    {
        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;
        public bool IsEnabled(LogLevel logLevel) => logLevel >= LogLevel.Debug;
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        { if (IsEnabled(logLevel)) p.Ghi(ten, logLevel, state, exception, formatter); }
    }
}
