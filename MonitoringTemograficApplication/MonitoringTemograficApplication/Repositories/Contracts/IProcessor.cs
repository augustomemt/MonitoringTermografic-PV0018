
using MonitoringTemograficApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace MonitoringTemograficApplication.Repositories.Contracts
{
  public interface IProcessor
  {

    IPagedList<TB_EXT_LD_LOG> GetAllProcessors(int? page, string search);
    //IPagedList<TB_EXT_LD_LOG> GetAllProcessors(int? page, string search, string ordenation);

    IPagedList<Measurements> GetAllMeasurements(int? page, string search);

    IPagedList<Measurements> GetAllMeasurementsMissing(int? page, string search);

    Measurements EditMeasurement(int id);

    bool processorChange(Processor processor);


    }
}
