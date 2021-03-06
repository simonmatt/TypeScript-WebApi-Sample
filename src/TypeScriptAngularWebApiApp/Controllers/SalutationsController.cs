﻿using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

using TypeScriptAngularWebApiApp.Models;

namespace TypeScriptAngularWebApiApp.Controllers
{
    /// <summary>
    /// This represents the controller entity for salutations.
    /// </summary>
    public class SalutationsController : ApiController
    {
        /// <summary>
        /// Gets the list of <see cref="Salutation" />s.
        /// </summary>
        /// <returns>
        /// Returns the list of <see cref="Salutation" />s.
        /// </returns>
        public virtual async Task<List<Salutation>> Get()
        {
            var salutations = new List<Salutation>();
            await Task.Run(() =>
                {
                    salutations = new List<Salutation>()
                                      {
                                          new Salutation("Mr", "Mr"),
                                          new Salutation("Mrs", "Mrs"),
                                          new Salutation("Ms", "Ms"),
                                          new Salutation("Mx", "Mx"),
                                      };
                });

            return salutations;
        }
    }
}