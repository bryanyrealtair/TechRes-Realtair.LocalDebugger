﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realtair.LocalDebugger.FormValues;

public class CreateUpdateFormValueDto
{
    [Required]
    public int Id { get; set; }

    [Required]
    public string StoredData { get; set; } = string.Empty;

    [Required]
    public DateTime Created { get; set; } = DateTime.Now;

    [Required]
    public int Presentation_Id { get; set; }
}
