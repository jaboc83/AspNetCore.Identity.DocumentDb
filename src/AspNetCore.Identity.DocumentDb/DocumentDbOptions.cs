﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;

namespace AspNetCore.Identity.DocumentDb
{
    public class DocumentDbOptions
    {
        /// <summary>
        /// Gets or sets the name of the Database that should be used in DocumentDb 
        /// </summary>
        public string Database { get; set; }

        /// <summary>
        /// Gets or sets the name of the DocumentCollection that should be used to store and query users in DocumentDB
        /// </summary>
        public string DocumentCollection { get; set; }

        /// <summary>
        /// Gets or sets a Function that gets passed a UserId and should return the according PartitionKey.
        /// Leave this NULL if automatic partitioning is not used in the configured DocumentCollection.
        /// </summary>
        public Func<string, string> PartitionKeyGenerator { get; set; }
    }
}
