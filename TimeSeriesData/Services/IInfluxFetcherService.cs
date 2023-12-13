
using Timeseriesdata.Models;


public interface IInfluxFetcherService
{
     public Task<List<InfluxDataModel>> GetDataAsync(string organization, string bucket, string measurement, DateTime startTime, DateTime? endTime);

}
