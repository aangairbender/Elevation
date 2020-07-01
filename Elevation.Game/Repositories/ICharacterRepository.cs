using Elevation.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Elevation.Game.Repositories
{
    public interface ICharacterRepository
    {
        Task Add(Character character);
    }
}
