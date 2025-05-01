using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Realtair.LocalDebugger.FormValues;

public interface IFormValueAppService : 
    ICrudAppService<
        FormValueDto, 
        int,
        PagedAndSortedResultRequestDto,
        CreateUpdateFormValueDto>
{

}
