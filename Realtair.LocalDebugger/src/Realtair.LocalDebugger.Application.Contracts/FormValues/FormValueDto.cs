using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace Realtair.LocalDebugger.FormValues;

public class FormValueDto : EntityDto<int>
{
    public int Id { get; set; }
    public string StoredData { get; set; }
    public DateTime Created { get; set; }
    public int Presentation_Id { get; set; }
}
