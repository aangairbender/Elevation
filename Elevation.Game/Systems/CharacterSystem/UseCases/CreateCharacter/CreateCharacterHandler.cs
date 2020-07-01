using Elevation.Domain.Entities;
using Elevation.Game.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Elevation.Game.Systems.CharacterSystem.UseCases.CreateCharacter
{
    public class CreateCharacterHandler : IRequestHandler<CreateCharacterRequest, CreateCharacterResponse>
    {
        private readonly ICharacterRepository _characterRepository;

        public CreateCharacterHandler(ICharacterRepository characterRepository)
        {
            _characterRepository = characterRepository;
        }

        public async Task<CreateCharacterResponse> Handle(CreateCharacterRequest request, CancellationToken cancellationToken)
        {
            var entity = new Character
            {
                Name = request.Name
            };
            await _characterRepository.Add(entity);
            return new CreateCharacterResponse { Character = entity };
        }
    }
}
