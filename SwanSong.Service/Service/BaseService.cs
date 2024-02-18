using Microsoft.Extensions.Caching.Memory;

namespace SwanSong.Service;

public class BaseService
{    
    public readonly IMemoryCache _memoryCache; 
 
    public BaseService(IMemoryCache memoryCache)
    {
        _memoryCache = memoryCache;
    }

    public void ClearCache(string cacheKey)
    {
        if (cacheKey != null)
        {
            _memoryCache.Remove(cacheKey);
        }
    }
}