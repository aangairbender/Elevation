using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Elevation.Game.Systems.CharacterSystem.UseCases.CreateCharacter
{
    public class CreateCharacterRequest : IRequest<CreateCharacterResponse>
    {
        public string Name { get; set; }
    }
}
