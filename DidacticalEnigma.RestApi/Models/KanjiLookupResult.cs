﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DidacticalEnigma.RestApi.Models
{
    public class KanjiLookupResult
    {
        [Required]
        public IReadOnlyCollection<string> Kanji { get; set; }

        [Required]
        public IReadOnlyCollection<string> PossibleRadicals { get; set; }

        [Required]
        public IReadOnlyDictionary<string, string> UsedRadicals { get; set; }
    }
}
