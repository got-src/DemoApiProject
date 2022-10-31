namespace DemoApiProject;

public interface IHttpClientEnvelope<T>
{
    int StatusCode { get; set; }
    IEnumerable<string> Messages { get; set; }
    T Data { get; set; }

    IHttpClientEnvelope<T> WithStatusCode(int statusCode);
    IHttpClientEnvelope<T> WithMessage(string message);
    IHttpClientEnvelope<T> WithData(T data);
}
public class HttpClientEnvelope<T> : IHttpClientEnvelope<T>
{
    public int StatusCode { get; set; }
    public IEnumerable<string> Messages { get; set; }
    public T Data { get; set; }
    public IHttpClientEnvelope<T> WithStatusCode(int statusCode)
    {
        StatusCode = statusCode;
        return this;
    }

    public IHttpClientEnvelope<T> WithMessage(string message)
    {
        if (Messages is null)
        {
            Messages = new List<string>();
        }
        var enumerable = Messages.Append(message);
        Messages = enumerable;
        return this;
    }

    public IHttpClientEnvelope<T> WithData(T data)
    {
        Data = data;
        return this;
    }
}