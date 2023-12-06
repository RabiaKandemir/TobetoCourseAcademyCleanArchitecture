using Application.Services.Repositories;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Categories.Commands.Create
{
    public class CreatedCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreatedCategoryResponse>
    {
        ICategoryRepository _categoryRepository;

        public CreatedCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<CreatedCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            Category category = new Category();
            category.Name = request.Name;
            category.Id = Guid.NewGuid();

            var createdCategory = await _categoryRepository.AddAsync(category);

            CreatedCategoryResponse createdCategoryResponse = new CreatedCategoryResponse();
            createdCategoryResponse.Id = createdCategory.Id;
            createdCategoryResponse.Name = createdCategory.Name;
            createdCategoryResponse.CreatedDate = createdCategory.CreatedDate;

            return createdCategoryResponse;

        }
    }
}
