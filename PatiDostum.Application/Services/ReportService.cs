using PatiDostum.Core.Dto;
using PatiDostum.Core.IRepositories;
using PatiDostum.Infrastructure.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Application.Services;

public class ReportService : IReportService
{
    private readonly IReportRepository _reportRepository;
    public ReportService(IReportRepository reportRepository)
    {
        _reportRepository = reportRepository;
    }
    public List<CountAdByCity> GetAdByAdNumber()
    {
        var adCount=_reportRepository.GetAdByAdNumber();
        return adCount;
    }

    public List<GetAdByDate> GetAdByProvinceName(string provinceName)
    {
      return  _reportRepository.GetAdByProvinceName(provinceName);
    }

    public List<GetAdByDate> GetStartFinish(DateTime? start, DateTime? finish)
    {
      return  _reportRepository.GetStartFinish(start, finish);
    }
}

