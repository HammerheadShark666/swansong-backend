using Microsoft.Extensions.Caching.Memory;
using SwanSong.Data.UnitOfWork.Interfaces;
using System.Threading.Tasks;

namespace SwanSong.Data.Helper;
public class DataHelper
{
    public static async Task CompleteContextActionAsync(string cacheKey, IMemoryCache _memoryCache, IUnitOfWork _unitOfWork)
    {
        await _unitOfWork.CompleteAsync();

        if (cacheKey != null)
        {
            _memoryCache.Remove(cacheKey);
        }
    }

    public static void CompleteContextAction(string cacheKey, IMemoryCache _memoryCache, IUnitOfWork _unitOfWork)
    {
        _unitOfWork.Complete();

        if (cacheKey != null)
        {
            _memoryCache.Remove(cacheKey);
        }
    }
}
