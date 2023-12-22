using BlogApp.Core.Entities.Common;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.BrandDto
{
    public  class CreateBrandDto
    {
        public string Name { get; set; }
    }

    public class Validation : AbstractValidator<CreateBrandDto>
    {
        public Validation()
        {
            RuleFor(x => x.Name).NotEmpty()
                .WithMessage("Name should not be empty")
                .MinimumLength(3).WithMessage("Name should have at least 3 characters.")
                .MaximumLength(50).WithMessage("Name cannot exceed 50 characters.");

        }
    }
}
