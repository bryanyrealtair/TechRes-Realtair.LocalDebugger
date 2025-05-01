using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities;

namespace Realtair.LocalDebugger.FormValues;

public class FormValue : Entity<int>
{
    public int Id {  get; set; }
    public required string StoredData { get; set; }
    public DateTime Created { get; set; }
    public int Presentation_Id { get; set; }
}
