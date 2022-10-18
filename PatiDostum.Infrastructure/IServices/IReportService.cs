using PatiDostum.Core.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatiDostum.Infrastructure.IServices;

public interface IReportService
{
    public List<GetAdByDate> GetStartFinish(DateTime? start, DateTime? finish);
    public List<GetAdByDate> GetAdByProvinceName(string provinceName);
    public List<CountAdByCity> GetAdByAdNumber();
}

