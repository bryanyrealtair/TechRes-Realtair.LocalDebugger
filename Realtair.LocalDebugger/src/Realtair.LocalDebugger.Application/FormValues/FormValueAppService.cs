using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Realtair.LocalDebugger.FormValues;

public class FormValueAppService : 
    CrudAppService<
        FormValue,
        FormValueDto,
        int,
        PagedAndSortedResultRequestDto>,
    IFormValueAppService
{
    public FormValueAppService(IRepository<FormValue, int> repository) : base(repository)
    {

    }
}
