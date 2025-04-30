using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtair.LocalDebugger.FormValues;

public class GetFormValueDto
{
    public int Presentation_Id { get; set; }
    public string StoredData { get; set; } = string.Empty;
}
