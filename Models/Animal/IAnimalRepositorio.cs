﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaoLendario.Models.Animal
{
    interface IAnimalRepositorio
    {
        IQueryable<Animal> Animais { get; }
    }
}
