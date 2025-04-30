using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Realtair.LocalDebugger.FormValues;

public class FormValuesAutoMapperProfile : Profile
{
    public FormValuesAutoMapperProfile()
    {
        CreateMap<FormValue, FormValueDto>();
        CreateMap<GetFormValueDto, FormValueDto>();
    }
}
