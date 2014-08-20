﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Models;

namespace Models.Repositories
{
    public interface IMovieAlquiladaRepository
    {
        List<MovieAlquilada> GetMoviesAlquiladasByCustomer(int customerId);
    }
}
